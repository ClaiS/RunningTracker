using RunningWinForm.Data;
using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using RunningWinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Data.Entity;

namespace RunningWinForm
{
    public partial class frmLogin : Form
    {
        private readonly AccountServices _accountServices;

        public frmLogin(AccountServices accountServices)
        {
            _accountServices = accountServices;
            InitializeComponent();
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        public User LoggedInUser { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;



            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _accountServices.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else
            {
                LoggedInUser = user;
                MessageBox.Show($"Chào mừng {LoggedInUser.FullName}!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
            {
                // Khi tick vào: Hiện chữ bình thường
                // '\0' là ký tự null, nghĩa là không dùng ký tự thay thế nào cả
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // Khi bỏ tick: Hiện lại dấu sao
                txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
            }
        }
    }
}
