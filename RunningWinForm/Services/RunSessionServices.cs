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

        public List<RunSession> Search(User currentUser, DateTime from, DateTime to, string type)
        {
            // Logic nghiệp vụ: Xác định xem user này có phải Admin không?
            bool isAdmin = (currentUser.UserID == 1); // Hoặc logic kiểm tra quyền của bạn

            // Gọi xuống Repository để lấy dữ liệu thô
            return _runRepository.FindSessions(currentUser.UserID, isAdmin, from, to, type);
        }

        public void UpdateRun(RunSession newRun)
        {
            // Bước 1: Tìm bài cũ trong DB
            var existingRun = _runRepository.GetById(newRun.RunID);
            if (existingRun == null) throw new Exception("Không tìm thấy bài chạy này!");


            // Bước 3: Cập nhật dữ liệu mới vào entity
            existingRun.RunDate = newRun.RunDate;
            existingRun.RunType = newRun.RunType;
            existingRun.Distance = newRun.Distance;
            existingRun.Duration = newRun.Duration ;       // TimeSpan
            existingRun.Pace = newRun.Pace; // double
            existingRun.Terrain = newRun.Terrain;
            existingRun.AvgHR = newRun.AvgHR;
            existingRun.RPE = newRun.RPE;


            // Bước 4: Gọi Repo lưu
            _runRepository.Update(existingRun);
        }

        public void DeleteRun(int runId)
        {
            // Kiểm tra tồn tại trước khi xóa (để an toàn)
            var runEntity = _runRepository.GetById(runId);
            if (runEntity == null) throw new Exception("Dữ liệu không tồn tại hoặc đã bị xóa!");

            _runRepository.Delete(runId);
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
            return _runRepository.GetRuns(userId);
        }

        public (List<RunSession> Data, int TotalRecords) GetDefaultRuns(User currentUser, bool isAdmin)
        {
            // Nếu Admin -> userId = null (xem hết). Nếu User -> xem của chính mình.
            int? userIdParam = isAdmin ? (int?)null : currentUser.UserID;

            // Gọi Repo: Không truyền ngày/loại, nhưng giới hạn Top 30
            return _runRepository.GetRuns(
                userId: userIdParam,
                fromDate: null,
                toDate: null,
                sessionType: null,
                topCount: 30 // Giới hạn 30 dòng cho nhẹ
            );
        }

        public (List<RunSession> Data, int TotalRecords) SearchRuns(User currentUser, bool isAdmin, DateTime from, DateTime to, string type)
        {
            int? userIdParam = isAdmin ? (int?)null : currentUser.UserID;

            // Gọi Repo: Truyền đầy đủ tham số tìm kiếm, KHÔNG giới hạn số lượng (topCount = null)
            return _runRepository.GetRuns(
                userId: userIdParam,
                fromDate: from,
                toDate: to,
                sessionType: type,
                topCount: null // Tìm kiếm thì muốn xem hết kết quả
            );
        }

        public (List<RunSession> Data, int TotalRecords) SearchRunsByUsername(string username)
        {
            var user = _userRepository.GetUser(username) ?? throw new Exception("Không tìm thấy người dùng này!");

            return _runRepository.GetRuns(user.UserID);
        }
    }
}
