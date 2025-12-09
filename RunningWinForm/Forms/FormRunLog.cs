using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningWinForm
{
    public partial class frmRunLog : Form
    {
        public frmRunLog()
        {
            InitializeComponent();
            //System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("en-GB");
            this.Text = "Thông tin quản lý chạy bộ";
            LoadBuoiChay();
            LoadPE();
            LoadDiaHinh();
            LoadThoiGianChay();
            LoadPaceTrungBinh();
            ClearInput();
        }

        private void ClearInput()
        {
            dtpNgayChay.Value = DateTime.Today;
            cmbBuoiChay.SelectedIndex = 0;
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

        private void LoadBuoiChay()
        {
            cmbBuoiChay.Items.AddRange(new string[] { "Easy", "Tempo", "Interval", "Long" });
            cmbBuoiChay.SelectedIndex = 0;
        }

        private void LoadPE()
        {
            for (int i = 1; i <= 10; i++)
                cmbCamNhanNguoiDung.Items.Add(i);
            cmbCamNhanNguoiDung.SelectedIndex = 0;
        }

        private void LoadDiaHinh()
        {
            cmbDiaHinh.Items.AddRange(new string[] { "Bằng phẳng", "Đường núi", "Đường dốc" });
            cmbDiaHinh.SelectedIndex = 0;
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

            string buoiChay = cmbBuoiChay.SelectedItem?.ToString() ?? "";
            DateTime ngayChay = dtpNgayChay.Value;
            // 3. Định dạng ngày theo dd/MM/yyyy
            string ngayHienThi = ngayChay.ToString("dd/MM/yyyy");

            // Thời gian chạy: hh:mm:ss
            string gio = cmbGioThoiGian.SelectedItem?.ToString() ?? "00";
            string phut = cmbPhutThoiGian.SelectedItem?.ToString() ?? "00";
            string giay = cmbGiayThoiGian.SelectedItem?.ToString() ?? "00";
            string thoiGianChay = $"{gio}:{phut}:{giay}";

            // Pace: mm:ss
            string phutPace = cmbPhutPace.SelectedItem?.ToString() ?? "00";
            string giayPace = cmbGiayPace.SelectedItem?.ToString() ?? "00";
            string pace = $"{phutPace}:{giayPace}";

            string diaHinh = cmbDiaHinh.SelectedItem?.ToString() ?? "";
            string camNhan = cmbCamNhanNguoiDung.SelectedItem?.ToString() ?? "";
            string nhipTimTrungBinh = txtHRTrungBinh.Text.Trim();
            string quangDuong = txtQuangDuong.Text.Trim();



            // 4. Thêm vào DataGridView
            dgvThongTinChayBo.Rows.Add(
                buoiChay,
                ngayHienThi,
                quangDuong,
                thoiGianChay,
                pace,
                diaHinh,
                camNhan,
                nhipTimTrungBinh.ToString()
            );

            MessageBox.Show("Thêm buổi chạy thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
