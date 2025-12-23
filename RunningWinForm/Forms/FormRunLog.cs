using RunningWinForm.Data;
using RunningWinForm.Models;
using RunningWinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunningWinForm.Data.Repositories;

namespace RunningWinForm
{
    public partial class frmRunLog : Form
    {
        private readonly User _currentUser;
        private readonly bool _isAdminMode;
        private readonly RunSessionServices _runSessionServices;
        private List<RunSession> _runSessions;

        public frmRunLog(User currentUser, bool isAdmin = false)
        {
            var context = new RunningContext();
            var runRepo = new RunRepository(context);
            var userRepo = new UserRepository(context);
            _currentUser = currentUser;
            _isAdminMode = isAdmin;
            _runSessionServices = new RunSessionServices(runRepo, userRepo);
            InitializeComponent();
            LoadData();
            LoadPE();
            LoadThoiGianChay();
            LoadPaceTrungBinh();
            ClearInput();
        }

        private void frmRunLog_Load(object sender, EventArgs e)
        {
            // --- PHẦN UI (Giao diện) ---
            txtUserLoggedIn.Text = _currentUser.Username;

            if (_isAdminMode)
            {
                // Tựa đề cho admin
                txtUserLoggedIn.Enabled = true;
                this.Text = $"ADMIN MODE - {_currentUser.Username}";
            }
            else
            {
                txtUserLoggedIn.Enabled = false;
                this.Text = "Nhật ký chạy bộ";
            }

            LoadData();
        }

        private void ClearInput()
        {
            cmbBuoiChay.SelectedIndex = 0;
            dtpNgayChay.Value = DateTime.Today;
            cmbGioThoiGian.SelectedIndex = 0;
            cmbPhutThoiGian.SelectedIndex = 30;
            cmbGiayThoiGian.SelectedIndex = 0;
            cmbPhutPace.SelectedIndex = 5;
            cmbGiayPace.SelectedIndex = 30;
            cmbDiaHinh.SelectedIndex = 0;
            cmbCamNhanNguoiDung.SelectedIndex = 0;
            txtHRTrungBinh.Clear();
            txtQuangDuong.Clear();
            txtHRTrungBinh.Focus();
        }
        private void LoadPE()
        {
            for (int i = 1; i <= 10; i++)
                cmbCamNhanNguoiDung.Items.Add(i);
            cmbCamNhanNguoiDung.SelectedIndex = 0;
        }

        private void LoadThoiGianChay()
        {
            // Giờ: 00 → 24
            for (int i = 0; i <= 24; i++)
                cmbGioThoiGian.Items.Add(i.ToString("D2")); // "D2" → định dạng 2 chữ số: 0 → "00"

            // Phút: 00 → 59
            for (int i = 0; i <= 59; i++)
                cmbPhutThoiGian.Items.Add(i.ToString("D2"));

            // Giây: 00 → 59
            for (int i = 0; i <= 59; i++)
                cmbGiayThoiGian.Items.Add(i.ToString("D2"));

            // Thiết lập giá trị mặc định
            cmbGioThoiGian.SelectedIndex = 0;   
            cmbPhutThoiGian.SelectedIndex = 30; 
            cmbGiayThoiGian.SelectedIndex = 0;  
        }

        private void LoadPaceTrungBinh()
        {
            for (int i = 0; i <= 15; i++)
                cmbPhutPace.Items.Add(i.ToString("D2"));
            for (int i = 0; i <= 59; i++)
                cmbGiayPace.Items.Add(i.ToString("D2"));

            cmbPhutPace.SelectedIndex = 5; 
            cmbGiayPace.SelectedIndex = 30;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtHRTrungBinh.Text) || string.IsNullOrWhiteSpace(txtQuangDuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập nhịp tim trung bình!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtHRTrungBinh.Text, out int nhipTim))
                {
                    MessageBox.Show("Nhịp tim phải là số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtQuangDuong.Text, out decimal quangDuong))
                {
                    MessageBox.Show("Quãng đường phải là số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int durationSeconds =
                    int.Parse(cmbGioThoiGian.SelectedItem.ToString()) * 3600 +
                    int.Parse(cmbPhutThoiGian.SelectedItem.ToString()) * 60 +
                    int.Parse(cmbGiayThoiGian.SelectedItem.ToString());

                int paceSeconds =
                    int.Parse(cmbPhutPace.SelectedItem.ToString()) * 60 +
                    int.Parse(cmbGiayPace.SelectedItem.ToString());


                var session = new RunSession
                {
                    UserID = _currentUser.UserID,
                    RunType = cmbBuoiChay.SelectedItem.ToString(),
                    RunDate = dtpNgayChay.Value.Date,
                    Duration = durationSeconds,
                    Pace = paceSeconds,
                    Terrain = cmbDiaHinh.SelectedItem.ToString(),
                    RPE = int.Parse(cmbCamNhanNguoiDung.SelectedItem.ToString()),
                    AvgHR = nhipTim,
                    Distance = quangDuong
                };

                _runSessionServices.AddRunSession(session);
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void LoadData()
        {
            try
            {
                var topRunsResult = _runSessionServices.GetTopRuns(_currentUser, _isAdminMode);
                txtAllRuns.Text = topRunsResult.TotalRecords.ToString();
                _runSessions = topRunsResult.Data;
                ToGrid(_runSessions);

            }    
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToGrid(List<RunSession> runSessions)
        {
            dgvThongTinChayBo.Rows.Clear();
            foreach (var session in runSessions)
            {
                string ngay = session.RunDate.ToString("dd/MM/yyyy");
                string duration = TimeFormat.FormatDuration((int)session.Duration);
                string pace = TimeFormat.FormatPace((int)session.Pace);

                dgvThongTinChayBo.Rows.Add(
                    session.RunID,
                    session.RunType,
                    ngay,
                    session.Distance.ToString("F1"),
                    duration,
                    pace,
                    session.Terrain,
                    session.RPE.ToString(),
                    session.AvgHR.ToString()
                );
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThongTinChayBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedSession = dgvThongTinChayBo.Rows[e.RowIndex];
                cmbBuoiChay.Text = selectedSession.Cells["colBuoiChay"].Value.ToString();
                dtpNgayChay.Value = DateTime.ParseExact(selectedSession.Cells["colNgayChay"].Value.ToString(), "dd/MM/yyyy", null);
                txtQuangDuong.Text = selectedSession.Cells["colQuangDuong"].Value.ToString();
                cmbDiaHinh.SelectedItem = selectedSession.Cells["ColDiaHinh"].Value.ToString();
                cmbCamNhanNguoiDung.SelectedItem = selectedSession.Cells["ColCamNhanNguoiDung"].Value.ToString();
                txtHRTrungBinh.Text = selectedSession.Cells["ColHRTrungBinh"].Value.ToString();

                TimeFormat.RedoTime(selectedSession.Cells["ColThoiGian"].Value?.ToString(), cmbGioThoiGian, cmbPhutThoiGian, cmbGiayThoiGian);
                TimeFormat.RedoTime(selectedSession.Cells["ColPaceTB"].Value?.ToString(), null, cmbPhutPace, cmbGiayPace);
            }
        }
    }
}
