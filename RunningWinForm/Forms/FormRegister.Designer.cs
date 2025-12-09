namespace RunningWinForm
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.txtComfirmPass = new System.Windows.Forms.TextBox();
            this.lblComfirmPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(158, 134);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(203, 31);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(188, 244);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(133, 31);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(426, 134);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 38);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(426, 244);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 38);
            this.txtPassword.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(267, 449);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(295, 57);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Xác nhận đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.Location = new System.Drawing.Point(239, 26);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(356, 46);
            this.lblRegisterTitle.TabIndex = 0;
            this.lblRegisterTitle.Text = "Đăng ký tài khoản";
            // 
            // txtComfirmPass
            // 
            this.txtComfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComfirmPass.Location = new System.Drawing.Point(426, 350);
            this.txtComfirmPass.Name = "txtComfirmPass";
            this.txtComfirmPass.Size = new System.Drawing.Size(250, 38);
            this.txtComfirmPass.TabIndex = 8;
            // 
            // lblComfirmPass
            // 
            this.lblComfirmPass.AutoSize = true;
            this.lblComfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComfirmPass.Location = new System.Drawing.Point(140, 357);
            this.lblComfirmPass.Name = "lblComfirmPass";
            this.lblComfirmPass.Size = new System.Drawing.Size(239, 31);
            this.lblComfirmPass.TabIndex = 7;
            this.lblComfirmPass.Text = "Nhập lại mật khẩu:";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 568);
            this.Controls.Add(this.txtComfirmPass);
            this.Controls.Add(this.lblComfirmPass);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRegisterTitle);
            this.Name = "frmRegister";
            this.Text = "Chương trình quản lý chạy bộ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.TextBox txtComfirmPass;
        private System.Windows.Forms.Label lblComfirmPass;
    }
}