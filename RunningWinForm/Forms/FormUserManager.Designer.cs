namespace RunningWinForm
{
    partial class frmUserManager
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.txtComfirmPassword = new System.Windows.Forms.TextBox();
            this.lblComfirmPass = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lstRole = new System.Windows.Forms.ListBox();
            this.dgvUserManager = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(158, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(217, 31);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(188, 216);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(142, 31);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(426, 112);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 38);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(426, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 38);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.Location = new System.Drawing.Point(446, 20);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(557, 46);
            this.lblRegisterTitle.TabIndex = 0;
            this.lblRegisterTitle.Text = "Màn hình quản lý người dùng";
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComfirmPassword.Location = new System.Drawing.Point(426, 322);
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.Size = new System.Drawing.Size(250, 38);
            this.txtComfirmPassword.TabIndex = 8;
            this.txtComfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblComfirmPass
            // 
            this.lblComfirmPass.AutoSize = true;
            this.lblComfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmPass.Location = new System.Drawing.Point(140, 329);
            this.lblComfirmPass.Name = "lblComfirmPass";
            this.lblComfirmPass.Size = new System.Drawing.Size(257, 31);
            this.lblComfirmPass.TabIndex = 7;
            this.lblComfirmPass.Text = "Nhập lại mật khẩu:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(1048, 216);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(250, 38);
            this.txtMail.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(1048, 112);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 38);
            this.txtHoTen.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(870, 219);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(95, 31);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Email:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(870, 115);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(109, 31);
            this.lblHoTen.TabIndex = 9;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(146, 855);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 57);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(140, 439);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(99, 31);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Quyền";
            // 
            // lstRole
            // 
            this.lstRole.FormattingEnabled = true;
            this.lstRole.ItemHeight = 25;
            this.lstRole.Location = new System.Drawing.Point(278, 439);
            this.lstRole.Name = "lstRole";
            this.lstRole.Size = new System.Drawing.Size(250, 354);
            this.lstRole.TabIndex = 15;
            // 
            // dgvUserManager
            // 
            this.dgvUserManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colUsername,
            this.colMail});
            this.dgvUserManager.Location = new System.Drawing.Point(579, 439);
            this.dgvUserManager.Name = "dgvUserManager";
            this.dgvUserManager.RowHeadersWidth = 82;
            this.dgvUserManager.RowTemplate.Height = 33;
            this.dgvUserManager.Size = new System.Drawing.Size(816, 354);
            this.dgvUserManager.TabIndex = 16;
            this.dgvUserManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserManager_CellClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 10;
            this.colID.Name = "colID";
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tên đăng nhập";
            this.colUsername.MinimumWidth = 10;
            this.colUsername.Name = "colUsername";
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Email";
            this.colMail.MinimumWidth = 10;
            this.colMail.Name = "colMail";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(615, 855);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(175, 57);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1097, 855);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 57);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 938);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvUserManager);
            this.Controls.Add(this.lstRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtComfirmPassword);
            this.Controls.Add(this.lblComfirmPass);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRegisterTitle);
            this.Name = "frmUserManager";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmUserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.TextBox txtComfirmPassword;
        private System.Windows.Forms.Label lblComfirmPass;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ListBox lstRole;
        private System.Windows.Forms.DataGridView dgvUserManager;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
    }
}