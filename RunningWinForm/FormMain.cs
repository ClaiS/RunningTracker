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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Chương trình quản lý chạy bộ";
        }

        private void mnuQuanLyChayBo_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormRunLog)
                {
                    child.Activate();
                    return;
                }
            }

            FormRunLog runLogForm = new FormRunLog();
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
