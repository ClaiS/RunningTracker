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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningWinForm
{
    public partial class frmRoleManager : Form
    {
        private readonly RoleServices _roleService;
        private int _selectedRoleId = -1;
        public frmRoleManager()
        {
            InitializeComponent();
            var context = new RunningContext();
            var roleRepo = new RoleRepository(context);
            _roleService = new RoleServices(roleRepo);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                _roleService.AddRole(txtRoleName.Text);
                MessageBox.Show("Thêm thành công!");
                LoadDataToGrid(); // Load lại lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedRoleId == -1) return;

            try
            {
                _roleService.UpdateRole(_selectedRoleId, txtRoleName.Text);
                MessageBox.Show("Cập nhật thành công!");
                LoadDataToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedRoleId == -1) return;

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa vai trò này?",
                                          "Xác nhận",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _roleService.DeleteRole(_selectedRoleId);
                    MessageBox.Show("Xóa thành công!");
                    LoadDataToGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }   

        private void LoadDataToGrid()
        {
            try
            {
                dgvRoleManager.Rows.Clear();
                var roles = _roleService.GetAllRoles();
                foreach (var r in roles)
                {
                    dgvRoleManager.Rows.Add(r.RoleID, r.RoleName);
                }

                // Sau khi load xong, reset form về trạng thái ban đầu
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách quyền: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            txtRoleName.Text = "";
            _selectedRoleId = -1;
            btnThem.Enabled = true; // Bật lại nút thêm
            btnSua.Enabled = false; // Tắt nút sửa/xóa vì chưa chọn dòng nào
            btnXoa.Enabled = false;
        }

        private void dgvRoleManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvRoleManager.Rows.Count)
            {
                DataGridViewRow row = dgvRoleManager.Rows[e.RowIndex];

                // Kiểm tra xem dòng đó có dữ liệu không (tránh click dòng trắng cuối cùng)
                if (row.Cells[0].Value == null) return;

                // 1. Lấy ID lưu vào biến tạm
                _selectedRoleId = int.Parse(row.Cells[0].Value.ToString());

                // 2. Đẩy tên lên TextBox để sửa
                txtRoleName.Text = row.Cells[1].Value.ToString();

                // 3. Điều khiển trạng thái nút
                btnThem.Enabled = false; // Đang chọn sửa thì khóa nút thêm
                btnSua.Enabled = true;   // Mở nút sửa
                btnXoa.Enabled = true;   // Mở nút xóa
            }
        }

        private void frmRoleManager_Load(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void frmRoleManager_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
