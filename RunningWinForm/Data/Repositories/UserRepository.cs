using RunningWinForm.Models;
using RunningWinForm.Services;
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

        public User GetUser(string username)
        {
            return _context.Users
                .FirstOrDefault(u => u.Username == username);
        }
    }
}
