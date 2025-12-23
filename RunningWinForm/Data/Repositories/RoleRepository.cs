using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Data.Repositories
{
    public class RoleRepository
    {
        private readonly RunningContext _context;

        public RoleRepository(RunningContext context)
        {
            _context = context;
        }

        /// <summary>
        ///     Lấy toàn bộ danh sách Role
        /// </summary>
        /// <returns>Trả về danh sách các Role theo RoleID</returns>
        public List<Role> GetAll()
        {
            // Trả về danh sách Role, sắp xếp theo ID cho đẹp
            return _context.Roles.OrderBy(r => r.RoleID).ToList();
        }

        /// <summary>
        ///     Tìm kiếm Role theo ID
        /// </summary>
        /// <returns>Nếu tồn tại, trả về chính nó. Nếu không thì trả về Null</returns>
        public Role GetById(int id)
        {
            return _context.Roles.Find(id);
        }

        /// <summary>
        ///     Thêm Role mới vào Db
        /// </summary>
        public void Add(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        /// <summary>
        ///     Thay đổi thông tin của một Role
        /// </summary>
        public void Update(Role role)
        {
            //var roleOld = _context.Roles.Find(role.RoleID); 
            //if(roleOld != null)
            //{
            //    roleOld.RoleName = role.RoleName;
            //    _context.SaveChanges();
            //}
            //_context.Entry(role).State = System.Data.Entity.EntityState.Modified;

            _context.Roles.AddOrUpdate(role);
            _context.SaveChanges();
        }

        /// <summary>
        ///     Xóa Role theo ID
        /// </summary>
        public void Delete(int id)
        {
            var role = _context.Roles.Find(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }

        /// <summary>
        ///     Kiểm tra xem tên Role có tồn tại chưa
        /// </summary>
        public bool IsNameExists(string name)
        {
            return _context.Roles.Any(r => r.RoleName == name);
        }
    }
}
