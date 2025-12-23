using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services
{
    public class UserServices
    {
        private readonly UserRepository _userRepo;

        public UserServices(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public List<User> GetAllUsers() => _userRepo.GetAll();

        // LOGIC THÊM USER
        public void AddUser(User user, string confirmPass, int roleId)
        {
            // Validate dữ liệu
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
                throw new Exception("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");

            if (user.Password != confirmPass)
                throw new Exception("Mật khẩu nhập lại không khớp!");

            if (_userRepo.IsUsernameExists(user.Username))
                throw new Exception("Tên đăng nhập đã tồn tại!");

            if (!string.IsNullOrEmpty(user.Email) && _userRepo.IsEmailExists(user.Email))
                throw new Exception("Email này đã được sử dụng!");

            if (user.Password != confirmPass)
                throw new Exception("Mật khẩu nhập lại không khớp!");

            // --- BĂM MẬT KHẨU TẠI ĐÂY ---
            // Thay thế mật khẩu thô bằng mật khẩu đã mã hóa
            user.Password = PasswordHelper.HashPassword(user.Password);

            _userRepo.Add(user, roleId);
        }

        // LOGIC SỬA USER
        public void UpdateUser(User user, string confirmPass, int roleId)
        {
            var existingUser = _userRepo.GetById(user.UserID);
            if (existingUser == null) throw new Exception("Người dùng không tồn tại!");

            if (user.Password != confirmPass)
                throw new Exception("Mật khẩu nhập lại không khớp!");

            // Check trùng email (nếu email thay đổi)
            if (existingUser.Email != user.Email && _userRepo.IsEmailExists(user.Email))
                throw new Exception("Email này đã được sử dụng!");

            // Chỉ cập nhật mật khẩu nếu người dùng có nhập mới
            if (!string.IsNullOrWhiteSpace(user.Password))
            {
                if (user.Password != confirmPass)
                    throw new Exception("Mật khẩu nhập lại không khớp!");

                // --- BĂM MẬT KHẨU MỚI ---
                user.Password = PasswordHelper.HashPassword(user.Password);
            }
            else
            {
                // Nếu user để trống mật khẩu -> Repo sẽ tự hiểu là không update cột này
                // (Dựa vào logic Repo ở bước trước: if (!string.IsNullOrEmpty...))
                user.Password = null;
            }

            _userRepo.Update(user, roleId);
        }

        public void DeleteUser(int id)
        {
            _userRepo.Delete(id);
        }
    }
}
