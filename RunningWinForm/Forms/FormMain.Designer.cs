namespace RunningWinForm
{
    partial class frmMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyChayBo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLy,
            this.mnuBaoCao});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1589, 40);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThongDangXuat,
            this.mnuHeThongThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(135, 36);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuHeThongDangXuat
            // 
            this.mnuHeThongDangXuat.Name = "mnuHeThongDangXuat";
            this.mnuHeThongDangXuat.Size = new System.Drawing.Size(256, 44);
            this.mnuHeThongDangXuat.Text = "Đăng xuất";
            this.mnuHeThongDangXuat.Click += new System.EventHandler(this.mnuHeThongDangXuat_Click);
            // 
            // mnuHeThongThoat
            // 
            this.mnuHeThongThoat.Name = "mnuHeThongThoat";
            this.mnuHeThongThoat.Size = new System.Drawing.Size(256, 44);
            this.mnuHeThongThoat.Text = "Thoát";
            this.mnuHeThongThoat.Click += new System.EventHandler(this.mnuHeThongThoat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyChayBo});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(117, 36);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuQuanLyChayBo
            // 
            this.mnuQuanLyChayBo.Name = "mnuQuanLyChayBo";
            this.mnuQuanLyChayBo.Size = new System.Drawing.Size(321, 44);
            this.mnuQuanLyChayBo.Text = "Quản lý chạy bộ";
            this.mnuQuanLyChayBo.Click += new System.EventHandler(this.mnuQuanLyChayBo_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCaoThongKe});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(118, 36);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBaoCaoThongKe
            // 
            this.mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            this.mnuBaoCaoThongKe.Size = new System.Drawing.Size(298, 44);
            this.mnuBaoCaoThongKe.Text = "Xem thống kê";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1589, 910);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Quản lý chạy bộ";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyChayBo;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoThongKe;
    }
}

