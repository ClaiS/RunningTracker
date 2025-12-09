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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = "Chương trình quản lý chạy bộ";
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

            frmRunLog runLogForm = new frmRunLog();
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
    }
}
