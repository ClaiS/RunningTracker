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

            var runLogForm = new frmRunLog(_currentUser);
            runLogForm.MdiParent = this;
            runLogForm.Show();
        }

        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuHeThongDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
