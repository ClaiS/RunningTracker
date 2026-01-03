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
        private int _selectedRunId = 0;


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
                // Gọi Service hàm Default
                var result = _runSessionServices.GetDefaultRuns(_currentUser, _isAdminMode);
                txtAllRuns.Text = result.TotalRecords.ToString();
                _runSessions = result.Data;
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
            if (_selectedRunId == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            int.TryParse(cmbGioThoiGian.Text, out int gio);
            int.TryParse(cmbPhutThoiGian.Text, out int phut);
            int.TryParse(cmbGiayThoiGian.Text, out int giay);

            int durationSeconds = gio * 3600 + phut * 60 + giay;

            // 2. Xử lý Pace
            int.TryParse(cmbPhutPace.Text, out int phutPace);
            int.TryParse(cmbGiayPace.Text, out int giayPace);

            int paceSeconds = phutPace * 60 + giayPace;

            int.TryParse(txtHRTrungBinh.Text, out int avgHR);

            int rpe = 0;
            int.TryParse(cmbCamNhanNguoiDung.Text, out rpe);

            try
            {
                // Bước 1: Gom dữ liệu từ các ô nhập liệu vào DTO
                var dto = new RunSession
                {
                    RunID = _selectedRunId, // Quan trọng: ID để Service biết sửa dòng nào
                    RunType = cmbBuoiChay.Text,
                    RunDate = dtpNgayChay.Value.Date,
                    Duration = durationSeconds,
                    Pace = paceSeconds,
                    Terrain = cmbDiaHinh.Text,
                    RPE = rpe,
                    AvgHR = avgHR,
                    Distance = decimal.Parse(txtQuangDuong.Text)
                };

                // Bước 2: Gọi Service thực hiện Update
                _runSessionServices.UpdateRun(dto);

                MessageBox.Show("Cập nhật thành công!");

                // Bước 3: Refresh lại Grid để thấy dữ liệu mới
                ClearInput(); // Xóa trắng các ô nhập
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật: {ex.Message}");
            }
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
                int.TryParse(selectedSession.Cells["colID"].Value.ToString(), out _selectedRunId);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Validate ngày
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo");
                return;
            }

            try
            {
                // Lấy tham số từ UI
                DateTime from = dtpFromDate.Value;
                DateTime to = dtpToDate.Value;
                string type = cmbRunType.SelectedItem?.ToString() ?? "Tất cả";

                // Gọi Service hàm Search
                var result = _runSessionServices.SearchRuns(_currentUser, _isAdminMode, from, to, type);

                // Cập nhật UI
                txtAllRuns.Text = result.TotalRecords.ToString(); // Số kết quả tìm thấy
                ToGrid(result.Data);

                // Thông báo
                if (result.TotalRecords == 0)
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedRunId == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn chắc chắn muốn xóa buổi chạy này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Gọi Service xóa theo ID
                    _runSessionServices.DeleteRun(_selectedRunId);

                    MessageBox.Show("Đã xóa xong!");

                    // Refresh lại Grid
                    ClearInput();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa: {ex.Message}");
                }
            }
        }
    }
}
