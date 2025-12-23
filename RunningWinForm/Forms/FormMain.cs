    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunningWinForm.Models;

namespace RunningWinForm
{
    public partial class frmMain : Form
    {
        private readonly User _currentUser;
        public bool IsLogout { get; private set; } = false;
        public frmMain()
        {
            InitializeComponent();
            this.Text = "Chương trình quản lý chạy bộ";
        }

        public frmMain(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bool isAdmin = IsAdmin();
            mnuRoleManager.Enabled = isAdmin;
            mnuUserManager.Enabled = isAdmin;

            if (_currentUser != null)
            {
                // Hiển thị lời chào lên StatusStrip
                toolStripHello.Text = $"Xin chào {_currentUser.FullName}";
            }
        }

        private bool IsAdmin()
        {
            if(_currentUser == null || _currentUser.UserRoles == null)
            {
                return false;
            }

            return _currentUser.UserRoles.Any(ur => ur.RoleID == 1);
        }

        private void mnuQuanLyChayBo_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmRunLog)
                {
                    child.Activate();
                    return;
                }
            }

            bool isAdmin = IsAdmin();

            var runLogForm = new frmRunLog(_currentUser, isAdmin);
            runLogForm.MdiParent = this;
            runLogForm.Show();
        }


        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuHeThongDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đăng xuất không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                IsLogout = true;

                // Đóng form Main lại
                // Khi form đóng, code sẽ chạy tiếp ở Program.cs
                this.Close();
            }
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmSearch)
                {
                    child.Activate();
                    return;
                }
            }

            var searchForm = new frmSearch(_currentUser);
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void mnuRoleManager_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmRoleManager)
                {
                    child.Activate();
                    return;
                }
            }

            var searchForm = new frmRoleManager();
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void mnuUserManager_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmUserManager)
                {
                    child.Activate();
                    return;
                }
            }

            var searchForm = new frmUserManager();
            searchForm.MdiParent = this;
            searchForm.Show();
        }
    }
}
