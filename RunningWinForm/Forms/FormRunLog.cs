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

namespace RunningWinForm
{
    public partial class frmRunLog : Form
    {
        private readonly User _currentUser;
        private List<RunSession> _runSessions;

        public frmRunLog(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            LoadData();
            LoadPE();
            LoadThoiGianChay();
            LoadPaceTrungBinh();
            ClearInput();
        }
        public frmRunLog()
        {
            InitializeComponent();
            //System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("en-GB");
            LoadPE();
            LoadThoiGianChay();
            LoadPaceTrungBinh();
            ClearInput();
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
            // Kiểm tra dữ liệu nhập phải đầy đủ

            if (string.IsNullOrWhiteSpace(txtHRTrungBinh.Text))
            {
                MessageBox.Show("Vui lòng nhập nhịp tim trung bình!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHRTrungBinh.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQuangDuong.Text))
            {
                MessageBox.Show("Vui lòng nhập quãng đường đã chạy!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHRTrungBinh.Focus();
                return;
            }

            if (!int.TryParse(txtHRTrungBinh.Text, out int nhipTim) || nhipTim < 40 || nhipTim > 220)
            {
                MessageBox.Show("Nhịp tim phải là số từ 40 đến 220!", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHRTrungBinh.Focus();
                return;
            }

            // Kiểm tra ngày chạy không vượt quá hôm nay
            if (dtpNgayChay.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày chạy không được lớn hơn ngày hiện tại!", "Lỗi ngày",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Distance = decimal.Parse(txtQuangDuong.Text)
            };

            try
            {
                using (var context = new RunningContext())
                {
                    context.RunSessions.Add(session);
                    context.SaveChanges();
                }
                LoadData();

                MessageBox.Show("Thêm buổi chạy thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            using (var context = new RunningContext()) 
            {                 
                _runSessions = context.RunSessions
                    .Where(s => s.UserID == _currentUser.UserID)
                    .Include(r => r.User)
                    .ToList();
            }
            ToGrid(_runSessions);     
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
