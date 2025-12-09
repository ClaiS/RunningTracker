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

namespace RunningWinForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text;

            //if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Vui lòng nhập đủ thông tin!");
            //    return;
            //}

            //using (var context = new RunningContext())
            //{
            //    var user = context.Users
            //        .FirstOrDefault(u => u.Username == username && u.Password == password);

            //    if (user != null)
            //    {
            //        // Lưu thông tin người dùng đang đăng nhập
            //        Global.CurrentUser = user;
            //        this.DialogResult = DialogResult.OK;
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            //    }
            //}
        }
    }
}
