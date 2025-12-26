using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunningWinForm.Models;

namespace RunningWinForm.Data.Repositories
{
    public class RunRepository
    {
        private readonly RunningContext _context;

        public RunRepository(RunningContext context)
        {
            _context = context;
        }

        public void Add(RunSession session)
        {
            _context.RunSessions.Add(session);
            _context.SaveChanges();
        }

        public (List<RunSession> Data, int TotalRecords) GetByUser(int? userId = null, int? topCount = null)
        {
            // 1. Khởi tạo Query
            var query = _context.RunSessions
                                .Include(r => r.User)
                                .AsQueryable();

            // 2. Nếu có UserID thì lọc, nếu null (Admin) thì bỏ qua bước này -> lấy hết
            if (userId.HasValue)
            {
                query = query.Where(s => s.UserID == userId.Value);
            }

            int TotalRecords = query.Count();

            // 3. Luôn luôn sắp xếp mới nhất lên đầu
            query = query.OrderByDescending(r => r.RunDate);

            // 4. Nếu có giới hạn số lượng (ví dụ 50 dòng) thì Take
            if (topCount.HasValue)
            {
                query = query.Take(topCount.Value);
            }

            var countList = query.ToList();

            // 5. Chạy lệnh lấy dữ liệu
            return (countList, TotalRecords);
        }

        public void Delete(int sessionId)
        {
            var session = _context.RunSessions.Find(sessionId);
            if (session != null)
            {
                _context.RunSessions.Remove(session);
                _context.SaveChanges();
            }
        }

        public List<RunSession> GetRunsByFilter(int userId, int year, int? month = null, int? week = null)
        {
            // 1. Lọc cơ bản theo User và Năm
            var query = _context.RunSessions.AsQueryable()
                .Where(r => r.UserID == userId && r.RunDate.Year == year);

            // 2. Nếu chọn Tháng -> Lọc thêm tháng
            if (month.HasValue)
            {
                query = query.Where(r => r.RunDate.Month == month.Value);
            }

            // 3. Lấy dữ liệu về RAM để xử lý lọc Tuần (Vì LINQ to SQL xử lý tuần hơi phức tạp)
            var result = query.ToList();

            // 4. Nếu chọn Tuần -> Lọc tiếp trên RAM
            if (week.HasValue)
            {
                // Sử dụng hàm GetIsoWeek (bạn cần viết hàm này hoặc dùng Calendar)
                // Cách đơn giản nhất:
                System.Globalization.Calendar cal = System.Globalization.CultureInfo.CurrentCulture.Calendar;
                result = result.Where(r => cal.GetWeekOfYear(r.RunDate,
                    System.Globalization.CalendarWeekRule.FirstFourDayWeek,
                    DayOfWeek.Monday) == week.Value).ToList();
            }

            return result; // Trả về danh sách các buổi chạy thô
        }

        public List<int> GetAvailableYears(int userId)
        {
            return _context.RunSessions
                .Where(r => r.UserID == userId)
                .Select(r => r.RunDate.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToList();
        }
    }
}
