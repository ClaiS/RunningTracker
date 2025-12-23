using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services
{
    public class RoleServices
    {
        private readonly RoleRepository _roleRepository;

        public RoleServices(RoleRepository roleRepo)
        {
            _roleRepository = roleRepo;
        }

        /// <summary>
        ///     Lấy toàn bộ danh sách Role dựa trên Repository của Role, sử dụng hàm GetAll()
        /// </summary>
        public List<Role> GetAllRoles()
        {
            return _roleRepository.GetAll();
        }

        /// <summary>
        ///     Thêm Role mới, dựa tren Repository của Role, sử dụng hàm Add()
        /// </summary>
        /// <param name="roleName">Tên Role</param>
        /// <exception cref="Exception"> Tên đã tồn tại hoặc để trống</exception>
        public void AddRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new Exception("Tên vai trò không được để trống!");

            if (_roleRepository.IsNameExists(roleName))
                throw new Exception("Tên vai trò này đã tồn tại!");

            var role = new Role { RoleName = roleName.Trim() };
            _roleRepository.Add(role);
        }

        /// <summary>
        ///     Chỉnh sửa Role, dựa tren Repository của Role, sử dụng hàm Update()
        /// </summary>
        /// <param name="roleID">ID của Role cần chỉnh sửa</param>
        /// <param name="newName">Tên Role mới</param>
        /// <exception cref="Exception"> Tên đã tồn tại hoặc để trống</exception>
        public void UpdateRole(int roleId, string newName)
        {
            var role = _roleRepository.GetById(roleId) ?? throw new Exception("Không tìm thấy vai trò cần sửa!");
            if (string.IsNullOrWhiteSpace(newName))
                throw new Exception("Tên mới không được để trống!");

            // Kiểm tra trùng tên (Nếu tên mới khác tên cũ mà lại trùng trong DB)
            if (role.RoleName != newName && _roleRepository.IsNameExists(newName))
                throw new Exception("Tên vai trò này đã tồn tại!");

            // Cập nhật
            role.RoleName = newName.Trim();
            _roleRepository.Update(role);
        }

        /// <summary>
        ///     Xóa Role, dựa tren Repository của Role, sử dụng hàm Update()
        /// </summary>
        /// <param name="roleID">ID của Role xóa</param>
        /// <exception cref="Exception">Admin và User Role không thể xóa, không tồn tại hoặc có tồn tại người dùng đang sử dụng vai trò này</exception>
        public void DeleteRole(int roleId)
        {
            var role = _roleRepository.GetById(roleId) ?? throw new Exception("Vai trò không tồn tại!");

            // Chặn xóa các role hệ thống quan trọng
            if (role.RoleName == "Admin" || role.RoleName == "User")
                throw new Exception("Không thể xóa vai trò hệ thống (Admin/User)!");

            // TODO: Kiểm tra xem có User nào đang dùng Role này không (Nếu có thì chặn xóa)
            // if (role.Users.Count > 0) throw new Exception("Role này đang có người dùng!");

            _roleRepository.Delete(roleId);
        }
    }
}
