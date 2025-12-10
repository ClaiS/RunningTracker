using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Data.Repositories
{
    public class UserRepository
    {
        private readonly RunningContext _context;

        public UserRepository(RunningContext context)
        {
            _context = context;
        }

        public User GetUserAndPassword(string username, string password)
        {
            return _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
