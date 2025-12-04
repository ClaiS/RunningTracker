namespace RunningWinForm
{
    partial class FormRunLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuoiChay = new System.Windows.Forms.ComboBox();
            this.lblBuoiChay = new System.Windows.Forms.Label();
            this.lblNgayChay = new System.Windows.Forms.Label();
            this.lblQuangDuong = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblDiaHinh = new System.Windows.Forms.Label();
            this.lblCamNhanNguoiDung = new System.Windows.Forms.Label();
            this.lblHRTrungBinh = new System.Windows.Forms.Label();
            this.cmbCamNhanNguoiDung = new System.Windows.Forms.ComboBox();
            this.cmbDiaHinh = new System.Windows.Forms.ComboBox();
            this.dgvThongTinChayBo = new System.Windows.Forms.DataGridView();
            this.colBuoiChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaceTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCamNhanNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHRTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtHRTrungBinh = new System.Windows.Forms.TextBox();
            this.dtpNgayChay = new System.Windows.Forms.DateTimePicker();
            this.cmbGioThoiGian = new System.Windows.Forms.ComboBox();
            this.cmbPhutThoiGian = new System.Windows.Forms.ComboBox();
            this.cmbGiayThoiGian = new System.Windows.Forms.ComboBox();
            this.cmbGiayPace = new System.Windows.Forms.ComboBox();
            this.cmbPhutPace = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChayBo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin quản lý chạy bộ";
            // 
            // cmbBuoiChay
            // 
            this.cmbBuoiChay.FormattingEnabled = true;
            this.cmbBuoiChay.Location = new System.Drawing.Point(326, 154);
            this.cmbBuoiChay.Name = "cmbBuoiChay";
            this.cmbBuoiChay.Size = new System.Drawing.Size(243, 39);
            this.cmbBuoiChay.TabIndex = 1;
            // 
            // lblBuoiChay
            // 
            this.lblBuoiChay.AutoSize = true;
            this.lblBuoiChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuoiChay.Location = new System.Drawing.Point(23, 154);
            this.lblBuoiChay.Name = "lblBuoiChay";
            this.lblBuoiChay.Size = new System.Drawing.Size(142, 31);
            this.lblBuoiChay.TabIndex = 2;
            this.lblBuoiChay.Text = "Buổi chạy";
            // 
            // lblNgayChay
            // 
            this.lblNgayChay.AutoSize = true;
            this.lblNgayChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayChay.Location = new System.Drawing.Point(23, 252);
            this.lblNgayChay.Name = "lblNgayChay";
            this.lblNgayChay.Size = new System.Drawing.Size(152, 31);
            this.lblNgayChay.TabIndex = 3;
            this.lblNgayChay.Text = "Ngày chạy";
            // 
            // lblQuangDuong
            // 
            this.lblQuangDuong.AutoSize = true;
            this.lblQuangDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuangDuong.Location = new System.Drawing.Point(23, 452);
            this.lblQuangDuong.Name = "lblQuangDuong";
            this.lblQuangDuong.Size = new System.Drawing.Size(218, 31);
            this.lblQuangDuong.TabIndex = 5;
            this.lblQuangDuong.Text = "Pace trung bình";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(23, 347);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(234, 31);
            this.lblThoiGian.TabIndex = 7;
            this.lblThoiGian.Text = "Thòi gian (h:m:s)";
            // 
            // lblDiaHinh
            // 
            this.lblDiaHinh.AutoSize = true;
            this.lblDiaHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaHinh.Location = new System.Drawing.Point(23, 558);
            this.lblDiaHinh.Name = "lblDiaHinh";
            this.lblDiaHinh.Size = new System.Drawing.Size(121, 31);
            this.lblDiaHinh.TabIndex = 9;
            this.lblDiaHinh.Text = "Địa hình";
            // 
            // lblCamNhanNguoiDung
            // 
            this.lblCamNhanNguoiDung.AutoSize = true;
            this.lblCamNhanNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamNhanNguoiDung.Location = new System.Drawing.Point(23, 666);
            this.lblCamNhanNguoiDung.Name = "lblCamNhanNguoiDung";
            this.lblCamNhanNguoiDung.Size = new System.Drawing.Size(297, 31);
            this.lblCamNhanNguoiDung.TabIndex = 11;
            this.lblCamNhanNguoiDung.Text = "Cảm nhận người dùng";
            // 
            // lblHRTrungBinh
            // 
            this.lblHRTrungBinh.AutoSize = true;
            this.lblHRTrungBinh.BackColor = System.Drawing.SystemColors.Control;
            this.lblHRTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRTrungBinh.Location = new System.Drawing.Point(23, 773);
            this.lblHRTrungBinh.Name = "lblHRTrungBinh";
            this.lblHRTrungBinh.Size = new System.Drawing.Size(259, 31);
            this.lblHRTrungBinh.TabIndex = 13;
            this.lblHRTrungBinh.Text = "Nhịp tim trung bình";
            // 
            // cmbCamNhanNguoiDung
            // 
            this.cmbCamNhanNguoiDung.FormattingEnabled = true;
            this.cmbCamNhanNguoiDung.Location = new System.Drawing.Point(326, 666);
            this.cmbCamNhanNguoiDung.Name = "cmbCamNhanNguoiDung";
            this.cmbCamNhanNguoiDung.Size = new System.Drawing.Size(243, 39);
            this.cmbCamNhanNguoiDung.TabIndex = 15;
            // 
            // cmbDiaHinh
            // 
            this.cmbDiaHinh.FormattingEnabled = true;
            this.cmbDiaHinh.Location = new System.Drawing.Point(326, 558);
            this.cmbDiaHinh.Name = "cmbDiaHinh";
            this.cmbDiaHinh.Size = new System.Drawing.Size(243, 39);
            this.cmbDiaHinh.TabIndex = 16;
            // 
            // dgvThongTinChayBo
            // 
            this.dgvThongTinChayBo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChayBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChayBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBuoiChay,
            this.ColNgayChay,
            this.ColThoiGian,
            this.ColPaceTB,
            this.ColDiaHinh,
            this.ColCamNhanNguoiDung,
            this.ColHRTrungBinh});
            this.dgvThongTinChayBo.Location = new System.Drawing.Point(624, 154);
            this.dgvThongTinChayBo.Name = "dgvThongTinChayBo";
            this.dgvThongTinChayBo.RowHeadersWidth = 82;
            this.dgvThongTinChayBo.RowTemplate.Height = 33;
            this.dgvThongTinChayBo.Size = new System.Drawing.Size(1603, 650);
            this.dgvThongTinChayBo.TabIndex = 17;
            // 
            // colBuoiChay
            // 
            this.colBuoiChay.HeaderText = "Buổi chạy";
            this.colBuoiChay.MinimumWidth = 10;
            this.colBuoiChay.Name = "colBuoiChay";
            // 
            // ColNgayChay
            // 
            this.ColNgayChay.HeaderText = "Ngày chạy";
            this.ColNgayChay.MinimumWidth = 10;
            this.ColNgayChay.Name = "ColNgayChay";
            // 
            // ColThoiGian
            // 
            this.ColThoiGian.HeaderText = "Thòi gian";
            this.ColThoiGian.MinimumWidth = 10;
            this.ColThoiGian.Name = "ColThoiGian";
            // 
            // ColPaceTB
            // 
            this.ColPaceTB.HeaderText = "Pace trung bình";
            this.ColPaceTB.MinimumWidth = 10;
            this.ColPaceTB.Name = "ColPaceTB";
            // 
            // ColDiaHinh
            // 
            this.ColDiaHinh.HeaderText = "Địa hình";
            this.ColDiaHinh.MinimumWidth = 10;
            this.ColDiaHinh.Name = "ColDiaHinh";
            // 
            // ColCamNhanNguoiDung
            // 
            this.ColCamNhanNguoiDung.HeaderText = "Cảm nhận người dùng";
            this.ColCamNhanNguoiDung.MinimumWidth = 10;
            this.ColCamNhanNguoiDung.Name = "ColCamNhanNguoiDung";
            // 
            // ColHRTrungBinh
            // 
            this.ColHRTrungBinh.HeaderText = "HR trung bình";
            this.ColHRTrungBinh.MinimumWidth = 10;
            this.ColHRTrungBinh.Name = "ColHRTrungBinh";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(299, 888);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 67);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(799, 888);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(157, 67);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1294, 888);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(162, 67);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1788, 888);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 67);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // txtHRTrungBinh
            // 
            this.txtHRTrungBinh.Location = new System.Drawing.Point(326, 773);
            this.txtHRTrungBinh.Name = "txtHRTrungBinh";
            this.txtHRTrungBinh.Size = new System.Drawing.Size(243, 38);
            this.txtHRTrungBinh.TabIndex = 22;
            // 
            // dtpNgayChay
            // 
            this.dtpNgayChay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChay.Location = new System.Drawing.Point(326, 252);
            this.dtpNgayChay.Name = "dtpNgayChay";
            this.dtpNgayChay.Size = new System.Drawing.Size(243, 38);
            this.dtpNgayChay.TabIndex = 23;
            // 
            // cmbGioThoiGian
            // 
            this.cmbGioThoiGian.FormattingEnabled = true;
            this.cmbGioThoiGian.Location = new System.Drawing.Point(326, 347);
            this.cmbGioThoiGian.Name = "cmbGioThoiGian";
            this.cmbGioThoiGian.Size = new System.Drawing.Size(69, 39);
            this.cmbGioThoiGian.TabIndex = 24;
            // 
            // cmbPhutThoiGian
            // 
            this.cmbPhutThoiGian.FormattingEnabled = true;
            this.cmbPhutThoiGian.Location = new System.Drawing.Point(411, 347);
            this.cmbPhutThoiGian.Name = "cmbPhutThoiGian";
            this.cmbPhutThoiGian.Size = new System.Drawing.Size(69, 39);
            this.cmbPhutThoiGian.TabIndex = 25;
            // 
            // cmbGiayThoiGian
            // 
            this.cmbGiayThoiGian.FormattingEnabled = true;
            this.cmbGiayThoiGian.Location = new System.Drawing.Point(500, 347);
            this.cmbGiayThoiGian.Name = "cmbGiayThoiGian";
            this.cmbGiayThoiGian.Size = new System.Drawing.Size(69, 39);
            this.cmbGiayThoiGian.TabIndex = 26;
            // 
            // cmbGiayPace
            // 
            this.cmbGiayPace.FormattingEnabled = true;
            this.cmbGiayPace.Location = new System.Drawing.Point(455, 452);
            this.cmbGiayPace.Name = "cmbGiayPace";
            this.cmbGiayPace.Size = new System.Drawing.Size(69, 39);
            this.cmbGiayPace.TabIndex = 28;
            // 
            // cmbPhutPace
            // 
            this.cmbPhutPace.FormattingEnabled = true;
            this.cmbPhutPace.Location = new System.Drawing.Point(366, 452);
            this.cmbPhutPace.Name = "cmbPhutPace";
            this.cmbPhutPace.Size = new System.Drawing.Size(69, 39);
            this.cmbPhutPace.TabIndex = 27;
            // 
            // FormRunLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2274, 1011);
            this.Controls.Add(this.cmbGiayPace);
            this.Controls.Add(this.cmbPhutPace);
            this.Controls.Add(this.cmbGiayThoiGian);
            this.Controls.Add(this.cmbPhutThoiGian);
            this.Controls.Add(this.cmbGioThoiGian);
            this.Controls.Add(this.dtpNgayChay);
            this.Controls.Add(this.txtHRTrungBinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvThongTinChayBo);
            this.Controls.Add(this.cmbDiaHinh);
            this.Controls.Add(this.cmbCamNhanNguoiDung);
            this.Controls.Add(this.lblHRTrungBinh);
            this.Controls.Add(this.lblCamNhanNguoiDung);
            this.Controls.Add(this.lblDiaHinh);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblQuangDuong);
            this.Controls.Add(this.lblNgayChay);
            this.Controls.Add(this.lblBuoiChay);
            this.Controls.Add(this.cmbBuoiChay);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRunLog";
            this.Text = "FormRunLog";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChayBo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuoiChay;
        private System.Windows.Forms.Label lblBuoiChay;
        private System.Windows.Forms.Label lblNgayChay;
        private System.Windows.Forms.Label lblQuangDuong;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblDiaHinh;
        private System.Windows.Forms.Label lblCamNhanNguoiDung;
        private System.Windows.Forms.Label lblHRTrungBinh;
        private System.Windows.Forms.ComboBox cmbCamNhanNguoiDung;
        private System.Windows.Forms.ComboBox cmbDiaHinh;
        private System.Windows.Forms.DataGridView dgvThongTinChayBo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtHRTrungBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuoiChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaceTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCamNhanNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHRTrungBinh;
        private System.Windows.Forms.DateTimePicker dtpNgayChay;
        private System.Windows.Forms.ComboBox cmbGioThoiGian;
        private System.Windows.Forms.ComboBox cmbPhutThoiGian;
        private System.Windows.Forms.ComboBox cmbGiayThoiGian;
        private System.Windows.Forms.ComboBox cmbGiayPace;
        private System.Windows.Forms.ComboBox cmbPhutPace;
    }
}