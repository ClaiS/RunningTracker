using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Services
{
    internal class AccountServices
    {
        private readonly UserRepository _userRepository;

        public AccountServices(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(string username, string password)
        {
            // Kiểm tra Input
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            
            User user = _userRepository.GetUserAndPassword(username, password);

            // Xử lý kết quả
            
            if(user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
