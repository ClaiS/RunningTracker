namespace RunningWinForm
{
    partial class frmSearch
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
            this.lblThongKe = new System.Windows.Forms.Label();
            this.lblBuoiChay = new System.Windows.Forms.Label();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuoiChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayChay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuangDuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaceTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCamNhanNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHRTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAllRuns = new System.Windows.Forms.Label();
            this.txtAllRuns = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(731, 27);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(259, 63);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "Thống kê";
            // 
            // lblBuoiChay
            // 
            this.lblBuoiChay.AutoSize = true;
            this.lblBuoiChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuoiChay.Location = new System.Drawing.Point(18, 202);
            this.lblBuoiChay.Name = "lblBuoiChay";
            this.lblBuoiChay.Size = new System.Drawing.Size(353, 39);
            this.lblBuoiChay.TabIndex = 2;
            this.lblBuoiChay.Text = "Nhập tên người dùng";
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colBuoiChay,
            this.ColNgayChay,
            this.colQuangDuong,
            this.ColThoiGian,
            this.ColPaceTB,
            this.ColDiaHinh,
            this.ColCamNhanNguoiDung,
            this.ColHRTrungBinh});
            this.dgvKetQua.Enabled = false;
            this.dgvKetQua.Location = new System.Drawing.Point(25, 304);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 82;
            this.dgvKetQua.RowTemplate.Height = 33;
            this.dgvKetQua.Size = new System.Drawing.Size(1603, 581);
            this.dgvKetQua.TabIndex = 17;
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
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1471, 928);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 67);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(425, 205);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 38);
            this.txtSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(834, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 67);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAllRuns
            // 
            this.lblAllRuns.AutoSize = true;
            this.lblAllRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllRuns.Location = new System.Drawing.Point(18, 943);
            this.lblAllRuns.Name = "lblAllRuns";
            this.lblAllRuns.Size = new System.Drawing.Size(271, 37);
            this.lblAllRuns.TabIndex = 24;
            this.lblAllRuns.Text = "Tổng buổi chạy: ";
            // 
            // txtAllRuns
            // 
            this.txtAllRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllRuns.Location = new System.Drawing.Point(295, 940);
            this.txtAllRuns.Name = "txtAllRuns";
            this.txtAllRuns.Size = new System.Drawing.Size(224, 44);
            this.txtAllRuns.TabIndex = 25;
            // 
            // frmSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1674, 1029);
            this.Controls.Add(this.txtAllRuns);
            this.Controls.Add(this.lblAllRuns);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.lblBuoiChay);
            this.Controls.Add(this.lblThongKe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearch";
            this.Text = "Tìm kiếm người dùng";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.Label lblBuoiChay;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuoiChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayChay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuangDuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaceTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCamNhanNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHRTrungBinh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAllRuns;
        private System.Windows.Forms.TextBox txtAllRuns;
    }
}