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
    public partial class frmUserManager : Form
    {
        private readonly RoleServices _roleService;
        private readonly UserServices _userService;
        private int _selectedUserId = -1;
        public frmUserManager()
        {
            InitializeComponent();
            var context = new RunningContext();

            var userRepo = new UserRepository(context);
            _userService = new UserServices(userRepo);

            var roleRepo = new RoleRepository(context);
            _roleService = new RoleServices(roleRepo);
        }

        private void LoadUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                dgvUserManager.Rows.Clear();

                foreach (var u in users)
                {
                    int index = dgvUserManager.Rows.Add();
                    dgvUserManager.Rows[index].Cells[0].Value = u.UserID;
                    dgvUserManager.Rows[index].Cells[1].Value = u.Username;
                    dgvUserManager.Rows[index].Cells[2].Value = u.Email;

                    // XỬ LÝ HIỂN THỊ ROLE N-N
                    // Lấy role đầu tiên tìm thấy trong bảng UserRoles để hiển thị (hoặc nối chuỗi nếu muốn hiện hết)
                    var firstRole = u.UserRoles.FirstOrDefault()?.Role;
                    dgvUserManager.Rows[index].Tag = new
                    {
                        UserObj = u,
                        RoleID = firstRole?.RoleID ?? 0 // Nếu không có role thì là 0
                    };
                }
                //ResetForm();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load user: " + ex.Message); }
        }

        private void ResetForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComfirmPassword.Text = "";
            txtHoTen.Text = "";
            txtMail.Text = "";

            // Mặc định chọn quyền đầu tiên hoặc bỏ chọn
            if (lstRole.Items.Count > 0) lstRole.SelectedIndex = 0;

            _selectedUserId = -1;
            txtUsername.Enabled = true; // Cho phép nhập username khi thêm mới
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void LoadRoles()
        {
            try
            {
                var roles = _roleService.GetAllRoles();

                // Cấu hình ListBox
                lstRole.DataSource = roles;
                lstRole.DisplayMember = "RoleName"; // Hiển thị tên
                lstRole.ValueMember = "RoleID";     // Giá trị ngầm là ID
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load quyền: " + ex.Message); }
        }

        private void frmUserManager_Load(object sender, EventArgs e)
        {
            LoadRoles();
            LoadUsers();
        }

        private void dgvUserManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy object User được lưu trong Tag (hoặc query lại DB cũng được)
            // Ở đây tôi ép kiểu từ Tag cho nhanh vì lúc LoadUsers đã gán vào
            dynamic tagData = dgvUserManager.Rows[e.RowIndex].Tag;
            User u = tagData.UserObj;
            int roleId = tagData.RoleID;

            if (u != null)
            {
                _selectedUserId = u.UserID;
                txtUsername.Text = u.Username;
                txtHoTen.Text = u.FullName;
                txtMail.Text = u.Email;

                // Không hiển thị mật khẩu cũ vì lý do bảo mật
                txtPassword.Text = "";
                txtComfirmPassword.Text = "";

                // Chọn đúng quyền trong ListBox
                lstRole.SelectedValue = roleId;

                // Khóa username không cho sửa
                txtUsername.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRoleId = (int)lstRole.SelectedValue;

                var newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text, // Service sẽ check confirm pass
                    FullName = txtHoTen.Text.Trim(),
                    Email = txtMail.Text.Trim()
                };

                _userService.AddUser(newUser, txtComfirmPassword.Text, selectedRoleId);

                LoadUsers();

                MessageBox.Show("Thêm người dùng thành công!");
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int selectedRoleId = (int)lstRole.SelectedValue;

            try
            {
                var updateUser = new User
                {
                    UserID = _selectedUserId,
                    FullName = txtHoTen.Text.Trim(),
                    Email = txtMail.Text.Trim(),
                    Password = txtPassword.Text, // Nếu để trống nghĩa là không đổi pass
                };

                _userService.UpdateUser(updateUser, txtComfirmPassword.Text, selectedRoleId);

                MessageBox.Show("Cập nhật thành công!");
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == -1) return;

            if (MessageBox.Show("Xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _userService.DeleteUser(_selectedUserId);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa: " + ex.Message);
                }
            }
        }
    }
}
