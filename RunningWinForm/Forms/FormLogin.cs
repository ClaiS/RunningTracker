using RunningWinForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunningWinForm.Data.Repositories;
using System.Windows.Media.Media3D;
using RunningWinForm.Models;

namespace RunningWinForm
{
    public partial class frmLogin : Form
    {
        private readonly UserRepository _userRepository;

        public frmLogin(UserRepository userRepository)
        {
            _userRepository = userRepository;
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

            var user = _userRepository.GetUserAndPassword(username, password);

            if(user == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else
            {
                LoggedInUser = user;
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
