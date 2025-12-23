using RunningWinForm.Data;
using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using RunningWinForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningWinForm
{
    public partial class frmSearch : Form
    {
        private readonly User _currentUser;
        private List<RunSession> _runSessions;
        private readonly RunSessionServices _runSessionServices;

        public frmSearch(User currentUser)
        {
            _currentUser = currentUser;
            var context = new RunningContext();
            var runRepo = new RunRepository(context);
            var userRepo = new UserRepository(context);
            _currentUser = currentUser;
            _runSessionServices = new RunSessionServices(runRepo, userRepo);
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập tên người cần tìm.");
                return;
            }

            if (_currentUser.Username == keyword)
            {
                DialogResult result = MessageBox.Show(
                    "Đây là tài khoản của chính bạn!\n\n" +
                    "- Bạn chỉ có thể XEM ở đây.\n" +
                    "- Nếu muốn Thêm/Sửa/Xóa, hãy vào mục 'Quản lý chạy bộ'.\n\n" +
                    "Bạn có muốn tiếp tục xem không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                // Nếu user chọn No thì dừng lại, không tìm kiếm nữa
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            try
            {
                var allRunsByUser = _runSessionServices.SearchRunsByUsername(keyword);
                txtAllRuns.Text = allRunsByUser.TotalRecords.ToString();
                _runSessions = allRunsByUser.Data;
                if (_runSessions.Count == 0)
                {
                    MessageBox.Show("Người dùng này chưa có buổi chạy nào.");
                    dgvKetQua.Rows.Clear();
                }
                else
                {
                    ToGrid(_runSessions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToGrid(List<RunSession> runSessions)
        {
            dgvKetQua.Rows.Clear();
            foreach (var session in runSessions)
            {
                string ngay = session.RunDate.ToString("dd/MM/yyyy");
                string duration = TimeFormat.FormatDuration((int)session.Duration);
                string pace = TimeFormat.FormatPace((int)session.Pace);

                dgvKetQua.Rows.Add(
                    session.RunID,
                    session.RunType,
                    ngay,
                    session.Distance.ToString("F1"),
                    duration,
                    pace,
                    session.Terrain,
                    session.RPE.ToString(),
                    session.AvgHR.ToString()
                );
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            
        }
    }
}
