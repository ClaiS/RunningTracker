using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using RunningWinForm.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services
{
    public class AccountServices
    {
        private readonly UserRepository _userRepository;

        public AccountServices(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(string username, string password)
        {
            User user = _userRepository.GetUser(username);

            // Xử lý kết quả

            if(user == null)
            {
                return null;
            }

            if (PasswordHelper.VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }
    }
}
