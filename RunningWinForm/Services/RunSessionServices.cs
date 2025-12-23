using RunningWinForm.Data;
using RunningWinForm.Data.Repositories;
using RunningWinForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningWinForm.Services
{
    public class RunSessionServices
    {
        private readonly RunRepository _runRepository;
        private readonly UserRepository _userRepository;
        private RunningContext _context = new RunningContext();

        public RunSessionServices(RunRepository runRepository, UserRepository userRepository)
        {
            _runRepository = runRepository;
            _userRepository = userRepository;
        }

        public int LayTongSoBuoiChay()
        {
            return _context.RunSessions.Count();
        }

        public int LaySoBuoiChayTheoDieuKien(string Username)
        {
            return _context.RunSessions.Count(r => r.User.Username.Contains(Username));
        }

        public void AddRunSession(RunSession session)
        {

            // Kiểm tra ngày chạy không vượt quá hôm nay
            if (session.RunDate.Date > DateTime.Now)
            {
                throw new ArgumentException("Ngày chạy không được lớn hơn ngày hiện tại!");
            }

            if (session.AvgHR < 40 || session.AvgHR > 220)
            {
                throw new ArgumentException("Nhịp tim không hợp lý (phải từ 40 đến 220).");
            }

            if (session.Distance <= 0)
            {
                throw new ArgumentException("Quãng đường chạy phải lớn hơn 0.");
            }
            _runRepository.Add(session);
        }

        public (List<RunSession> Data, int TotalRecords) GetAllRuns(int userId)
        {
            return _runRepository.GetByUser(userId);
        }

        public (List<RunSession> Data, int TotalRecords) GetTopRuns(User currentUser, bool isAdmin)
        {
            int? userIdParam = isAdmin ? (int?)null : currentUser.UserID;

            return _runRepository.GetByUser(userIdParam, 50);
        }

        public (List<RunSession> Data, int TotalRecords) SearchRunsByUsername(string username)
        {
            var user = _userRepository.GetUser(username) ?? throw new Exception("Không tìm thấy người dùng này!");

            return _runRepository.GetByUser(user.UserID);
        }
    }
}
