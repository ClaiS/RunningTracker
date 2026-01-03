namespace RunningWinForm
{
    partial class frmRunLog
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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuoiChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuangDuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtQuangDuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMainInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblSearchRunType = new System.Windows.Forms.Label();
            this.cmbRunType = new System.Windows.Forms.ComboBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.txtUserLoggedIn = new System.Windows.Forms.TextBox();
            this.lblUserLoggedIn = new System.Windows.Forms.Label();
            this.txtAllRuns = new System.Windows.Forms.TextBox();
            this.lblAllRuns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChayBo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin quản lý chạy bộ";
            // 
            // cmbBuoiChay
            // 
            this.cmbBuoiChay.FormattingEnabled = true;
            this.cmbBuoiChay.Items.AddRange(new object[] {
            "Easy",
            "Tempo",
            "Interval",
            "Long"});
            this.cmbBuoiChay.Location = new System.Drawing.Point(332, 376);
            this.cmbBuoiChay.Name = "cmbBuoiChay";
            this.cmbBuoiChay.Size = new System.Drawing.Size(243, 39);
            this.cmbBuoiChay.TabIndex = 1;
            // 
            // lblBuoiChay
            // 
            this.lblBuoiChay.AutoSize = true;
            this.lblBuoiChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuoiChay.Location = new System.Drawing.Point(29, 376);
            this.lblBuoiChay.Name = "lblBuoiChay";
            this.lblBuoiChay.Size = new System.Drawing.Size(142, 31);
            this.lblBuoiChay.TabIndex = 2;
            this.lblBuoiChay.Text = "Buổi chạy";
            // 
            // lblNgayChay
            // 
            this.lblNgayChay.AutoSize = true;
            this.lblNgayChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayChay.Location = new System.Drawing.Point(29, 474);
            this.lblNgayChay.Name = "lblNgayChay";
            this.lblNgayChay.Size = new System.Drawing.Size(152, 31);
            this.lblNgayChay.TabIndex = 3;
            this.lblNgayChay.Text = "Ngày chạy";
            // 
            // lblQuangDuong
            // 
            this.lblQuangDuong.AutoSize = true;
            this.lblQuangDuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuangDuong.Location = new System.Drawing.Point(29, 766);
            this.lblQuangDuong.Name = "lblQuangDuong";
            this.lblQuangDuong.Size = new System.Drawing.Size(218, 31);
            this.lblQuangDuong.TabIndex = 5;
            this.lblQuangDuong.Text = "Pace trung bình";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(29, 661);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(234, 31);
            this.lblThoiGian.TabIndex = 7;
            this.lblThoiGian.Text = "Thòi gian (h:m:s)";
            // 
            // lblDiaHinh
            // 
            this.lblDiaHinh.AutoSize = true;
            this.lblDiaHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaHinh.Location = new System.Drawing.Point(29, 872);
            this.lblDiaHinh.Name = "lblDiaHinh";
            this.lblDiaHinh.Size = new System.Drawing.Size(121, 31);
            this.lblDiaHinh.TabIndex = 9;
            this.lblDiaHinh.Text = "Địa hình";
            // 
            // lblCamNhanNguoiDung
            // 
            this.lblCamNhanNguoiDung.AutoSize = true;
            this.lblCamNhanNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamNhanNguoiDung.Location = new System.Drawing.Point(29, 980);
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
            this.lblHRTrungBinh.Location = new System.Drawing.Point(29, 1087);
            this.lblHRTrungBinh.Name = "lblHRTrungBinh";
            this.lblHRTrungBinh.Size = new System.Drawing.Size(259, 31);
            this.lblHRTrungBinh.TabIndex = 13;
            this.lblHRTrungBinh.Text = "Nhịp tim trung bình";
            // 
            // cmbCamNhanNguoiDung
            // 
            this.cmbCamNhanNguoiDung.FormattingEnabled = true;
            this.cmbCamNhanNguoiDung.Location = new System.Drawing.Point(332, 980);
            this.cmbCamNhanNguoiDung.Name = "cmbCamNhanNguoiDung";
            this.cmbCamNhanNguoiDung.Size = new System.Drawing.Size(243, 39);
            this.cmbCamNhanNguoiDung.TabIndex = 15;
            // 
            // cmbDiaHinh
            // 
            this.cmbDiaHinh.FormattingEnabled = true;
            this.cmbDiaHinh.Items.AddRange(new object[] {
            "Bằng phẳng",
            "Dốc",
            "Gồ gề"});
            this.cmbDiaHinh.Location = new System.Drawing.Point(332, 872);
            this.cmbDiaHinh.Name = "cmbDiaHinh";
            this.cmbDiaHinh.Size = new System.Drawing.Size(243, 39);
            this.cmbDiaHinh.TabIndex = 16;
            // 
            // dgvThongTinChayBo
            // 
            this.dgvThongTinChayBo.AllowUserToAddRows = false;
            this.dgvThongTinChayBo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChayBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChayBo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colBuoiChay,
            this.ColNgayChay,
            this.colQuangDuong,
            this.ColThoiGian,
            this.ColPaceTB,
            this.ColDiaHinh,
            this.ColCamNhanNguoiDung,
            this.ColHRTrungBinh});
            this.dgvThongTinChayBo.Location = new System.Drawing.Point(633, 364);
            this.dgvThongTinChayBo.Name = "dgvThongTinChayBo";
            this.dgvThongTinChayBo.RowHeadersWidth = 82;
            this.dgvThongTinChayBo.RowTemplate.Height = 33;
            this.dgvThongTinChayBo.Size = new System.Drawing.Size(1603, 765);
            this.dgvThongTinChayBo.TabIndex = 17;
            this.dgvThongTinChayBo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinChayBo_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 10;
            this.colID.Name = "colID";
            this.colID.Visible = false;
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
            // colQuangDuong
            // 
            this.colQuangDuong.HeaderText = "Quãng đường";
            this.colQuangDuong.MinimumWidth = 10;
            this.colQuangDuong.Name = "colQuangDuong";
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
            this.btnThem.Location = new System.Drawing.Point(295, 1250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 67);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(795, 1250);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(157, 67);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1292, 1250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(162, 67);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1788, 1250);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 67);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtHRTrungBinh
            // 
            this.txtHRTrungBinh.Location = new System.Drawing.Point(332, 1087);
            this.txtHRTrungBinh.Name = "txtHRTrungBinh";
            this.txtHRTrungBinh.Size = new System.Drawing.Size(243, 38);
            this.txtHRTrungBinh.TabIndex = 22;
            // 
            // dtpNgayChay
            // 
            this.dtpNgayChay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayChay.Location = new System.Drawing.Point(332, 474);
            this.dtpNgayChay.Name = "dtpNgayChay";
            this.dtpNgayChay.Size = new System.Drawing.Size(243, 38);
            this.dtpNgayChay.TabIndex = 23;
            // 
            // cmbGioThoiGian
            // 
            this.cmbGioThoiGian.FormattingEnabled = true;
            this.cmbGioThoiGian.Location = new System.Drawing.Point(332, 661);
            this.cmbGioThoiGian.Name = "cmbGioThoiGian";
            this.cmbGioThoiGian.Size = new System.Drawing.Size(69, 39);
            this.cmbGioThoiGian.TabIndex = 24;
            // 
            // cmbPhutThoiGian
            // 
            this.cmbPhutThoiGian.FormattingEnabled = true;
            this.cmbPhutThoiGian.Location = new System.Drawing.Point(417, 661);
            this.cmbPhutThoiGian.Name = "cmbPhutThoiGian";
            this.cmbPhutThoiGian.Size = new System.Drawing.Size(69, 39);
            this.cmbPhutThoiGian.TabIndex = 25;
            // 
            // cmbGiayThoiGian
            // 
            this.cmbGiayThoiGian.FormattingEnabled = true;
            this.cmbGiayThoiGian.Location = new System.Drawing.Point(506, 661);
            this.cmbGiayThoiGian.Name = "cmbGiayThoiGian";
            this.cmbGiayThoiGian.Size = new System.Drawing.Size(69, 39);
            this.cmbGiayThoiGian.TabIndex = 26;
            // 
            // cmbGiayPace
            // 
            this.cmbGiayPace.FormattingEnabled = true;
            this.cmbGiayPace.Location = new System.Drawing.Point(461, 766);
            this.cmbGiayPace.Name = "cmbGiayPace";
            this.cmbGiayPace.Size = new System.Drawing.Size(69, 39);
            this.cmbGiayPace.TabIndex = 28;
            // 
            // cmbPhutPace
            // 
            this.cmbPhutPace.FormattingEnabled = true;
            this.cmbPhutPace.Location = new System.Drawing.Point(372, 766);
            this.cmbPhutPace.Name = "cmbPhutPace";
            this.cmbPhutPace.Size = new System.Drawing.Size(69, 39);
            this.cmbPhutPace.TabIndex = 27;
            // 
            // txtQuangDuong
            // 
            this.txtQuangDuong.Location = new System.Drawing.Point(332, 564);
            this.txtQuangDuong.Name = "txtQuangDuong";
            this.txtQuangDuong.Size = new System.Drawing.Size(243, 38);
            this.txtQuangDuong.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quãng đường (km)";
            // 
            // grpMainInfo
            // 
            this.grpMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMainInfo.Location = new System.Drawing.Point(18, 289);
            this.grpMainInfo.Name = "grpMainInfo";
            this.grpMainInfo.Size = new System.Drawing.Size(578, 872);
            this.grpMainInfo.TabIndex = 31;
            this.grpMainInfo.TabStop = false;
            this.grpMainInfo.Text = "Thông tin chính";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.lblSearchRunType);
            this.groupBox1.Controls.Add(this.cmbRunType);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.lblDateTo);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.lblDateFrom);
            this.groupBox1.Controls.Add(this.txtUserLoggedIn);
            this.groupBox1.Controls.Add(this.lblUserLoggedIn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(777, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1459, 192);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nâng cao";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1196, 32);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(240, 135);
            this.btnTimKiem.TabIndex = 39;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblSearchRunType
            // 
            this.lblSearchRunType.AutoSize = true;
            this.lblSearchRunType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRunType.Location = new System.Drawing.Point(916, 47);
            this.lblSearchRunType.Name = "lblSearchRunType";
            this.lblSearchRunType.Size = new System.Drawing.Size(166, 37);
            this.lblSearchRunType.TabIndex = 38;
            this.lblSearchRunType.Text = "Buổi chạy";
            // 
            // cmbRunType
            // 
            this.cmbRunType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRunType.FormattingEnabled = true;
            this.cmbRunType.Items.AddRange(new object[] {
            "Easy",
            "Tempo",
            "Interval",
            "Long"});
            this.cmbRunType.Location = new System.Drawing.Point(884, 118);
            this.cmbRunType.Name = "cmbRunType";
            this.cmbRunType.Size = new System.Drawing.Size(243, 45);
            this.cmbRunType.TabIndex = 37;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(524, 120);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(243, 44);
            this.dtpToDate.TabIndex = 36;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(357, 126);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(161, 37);
            this.lblDateTo.TabIndex = 35;
            this.lblDateTo.Text = "Đến ngày";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(524, 41);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(243, 44);
            this.dtpFromDate.TabIndex = 34;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(368, 47);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(140, 37);
            this.lblDateFrom.TabIndex = 33;
            this.lblDateFrom.Text = "Từ ngày";
            // 
            // txtUserLoggedIn
            // 
            this.txtUserLoggedIn.Enabled = false;
            this.txtUserLoggedIn.Location = new System.Drawing.Point(49, 120);
            this.txtUserLoggedIn.Name = "txtUserLoggedIn";
            this.txtUserLoggedIn.Size = new System.Drawing.Size(260, 47);
            this.txtUserLoggedIn.TabIndex = 32;
            // 
            // lblUserLoggedIn
            // 
            this.lblUserLoggedIn.AutoSize = true;
            this.lblUserLoggedIn.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserLoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLoggedIn.Location = new System.Drawing.Point(77, 64);
            this.lblUserLoggedIn.Name = "lblUserLoggedIn";
            this.lblUserLoggedIn.Size = new System.Drawing.Size(213, 37);
            this.lblUserLoggedIn.TabIndex = 31;
            this.lblUserLoggedIn.Text = "Người dùng: ";
            // 
            // txtAllRuns
            // 
            this.txtAllRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllRuns.Location = new System.Drawing.Point(2012, 299);
            this.txtAllRuns.Name = "txtAllRuns";
            this.txtAllRuns.Size = new System.Drawing.Size(224, 44);
            this.txtAllRuns.TabIndex = 34;
            // 
            // lblAllRuns
            // 
            this.lblAllRuns.AutoSize = true;
            this.lblAllRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllRuns.Location = new System.Drawing.Point(1735, 302);
            this.lblAllRuns.Name = "lblAllRuns";
            this.lblAllRuns.Size = new System.Drawing.Size(271, 37);
            this.lblAllRuns.TabIndex = 33;
            this.lblAllRuns.Text = "Tổng buổi chạy: ";
            // 
            // frmRunLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(2274, 1379);
            this.Controls.Add(this.txtAllRuns);
            this.Controls.Add(this.lblAllRuns);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtQuangDuong);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.grpMainInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRunLog";
            this.Text = "Thông tin quản lý chạy bộ";
            this.Load += new System.EventHandler(this.frmRunLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChayBo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpNgayChay;
        private System.Windows.Forms.ComboBox cmbGioThoiGian;
        private System.Windows.Forms.ComboBox cmbPhutThoiGian;
        private System.Windows.Forms.ComboBox cmbGiayThoiGian;
        private System.Windows.Forms.ComboBox cmbGiayPace;
        private System.Windows.Forms.ComboBox cmbPhutPace;
        private System.Windows.Forms.TextBox txtQuangDuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuoiChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuangDuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaceTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCamNhanNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHRTrungBinh;
        private System.Windows.Forms.GroupBox grpMainInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUserLoggedIn;
        private System.Windows.Forms.Label lblUserLoggedIn;
        private System.Windows.Forms.Label lblSearchRunType;
        private System.Windows.Forms.ComboBox cmbRunType;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TextBox txtAllRuns;
        private System.Windows.Forms.Label lblAllRuns;
        private System.Windows.Forms.Button btnTimKiem;
    }
}