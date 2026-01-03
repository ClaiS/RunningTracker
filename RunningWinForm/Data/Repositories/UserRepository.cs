using RunningWinForm.Models;
using RunningWinForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace RunningWinForm.Data.Repositories
{
    public class UserRepository
    {
        private readonly RunningContext _context;

        public UserRepository(RunningContext context)
        {
            _context = context;
        }

        public User GetUser(string username)
        {
            return _context.Users
                .Include("UserRoles.Role")
                .FirstOrDefault(u => u.Username == username);
        }

        public List<User> GetAll()
        {
            // Include bảng trung gian UserRoles, và từ đó Include tiếp Role
            return _context.Users
                           .Include("UserRoles.Role")
                           .OrderBy(u => u.UserID)
                           .ToList();
        }

        public User GetById(int id) => _context.Users.Find(id);

        // 2. Thêm
        public void Add(User user, int roleId)
        {
            // Bước A: Lưu User trước để DB sinh ra UserID
            _context.Users.Add(user);
            _context.SaveChanges(); // Lúc này user.UserID đã có giá trị

            // Bước B: Thêm vào bảng UserRole
            var userRole = new UserRole
            {
                UserID = user.UserID,
                RoleID = roleId
            };
            _context.UserRoles.Add(userRole);
            _context.SaveChanges();
        }

        // 3. Sửa
        public void Update(User user, int newRoleId)
        {
            // A. Cập nhật thông tin cơ bản
            var dbUser = _context.Users.Find(user.UserID);
            if (dbUser != null)
            {
                dbUser.FullName = user.FullName;
                dbUser.Email = user.Email;
                if (!string.IsNullOrEmpty(user.Password)) dbUser.Password = user.Password;
            }

            // B. Cập nhật Quyền (Xóa quyền cũ -> Thêm quyền mới)
            // Tìm các dòng trong UserRole của user này
            var oldRoles = _context.UserRoles.Where(ur => ur.UserID == user.UserID).ToList();

            // Xóa hết quyền cũ
            _context.UserRoles.RemoveRange(oldRoles);

            // Thêm quyền mới
            var newRole = new UserRole
            {
                UserID = user.UserID,
                RoleID = newRoleId
            };
            _context.UserRoles.Add(newRole);

            _context.SaveChanges();
        }

        // 4. Xóa
        public void Delete(int userId)
        {
            // Xóa ràng buộc trong UserRole
            var roles = _context.UserRoles.Where(ur => ur.UserID == userId);
            _context.UserRoles.RemoveRange(roles);

            // Xóa User
            var user = _context.Users.Find(userId);
            if (user != null) _context.Users.Remove(user);

            _context.SaveChanges();
        }

        // 5. Check trùng (quan trọng cho đăng ký)
        public bool IsUsernameExists(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        public bool IsEmailExists(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
    }
}

