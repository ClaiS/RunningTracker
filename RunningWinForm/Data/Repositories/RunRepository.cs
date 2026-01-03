using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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

        public RunSession GetById(int runId)
        {
            return _context.RunSessions.FirstOrDefault(x => x.RunID == runId);
        }

        public void Add(RunSession session)
        {
            _context.RunSessions.Add(session);
            _context.SaveChanges();
        }

        public void Update(RunSession runSession)
        {
            // Đánh dấu đối tượng này đã bị thay đổi
            _context.RunSessions.AddOrUpdate(runSession);
            _context.SaveChanges();
        }

        // Lấy dữ liệu cho tìm kiếm

        public (List<RunSession> Data, int TotalRecords) GetRuns(
            int? userId = null,       // Nếu null là Admin xem hết, có value là xem của User đó
            DateTime? fromDate = null, // Tìm kiếm: Từ ngày
            DateTime? toDate = null,   // Tìm kiếm: Đến ngày
            string sessionType = null, // Tìm kiếm: Loại bài (Easy, Long...)
            int? topCount = null       // Mặc định: Lấy 30 hoặc 50 dòng
        )
        {
            // 1. Khởi tạo Query & Join bảng User
            var query = _context.RunSessions
                                .Include(r => r.User)
                                .AsQueryable();

            // 2. PHÂN QUYỀN: Lọc theo UserID (Nếu có)
            if (userId.HasValue)
            {
                query = query.Where(s => s.UserID == userId.Value);
            }

            // 3. TÌM KIẾM: Lọc theo khoảng thời gian (Nếu có truyền vào)
            if (fromDate.HasValue && toDate.HasValue)
            {
                // Tính toán khoảng thời gian bao trùm
                var startDate = fromDate.Value.Date; // 00:00:00 của ngày bắt đầu
                var endDate = toDate.Value.Date.AddDays(1).AddTicks(-1); // 23:59:59 của ngày kết thúc

                // So sánh trực tiếp
                query = query.Where(s => s.RunDate >= startDate && s.RunDate <= endDate);
            }

            // 4. TÌM KIẾM: Lọc theo loại bài tập (Nếu có và khác "Tất cả")
            if (!string.IsNullOrEmpty(sessionType) && sessionType != "Tất cả")
            {
                query = query.Where(s => s.RunType == sessionType);
            }

            // 5. Tính tổng số bản ghi (Dựa trên các điều kiện lọc ở trên)
            // Lưu ý: Nếu tìm kiếm, đây là số kết quả tìm thấy. Nếu mặc định, đây là tổng số bài.
            int TotalRecords = query.Count();

            // 6. Luôn sắp xếp mới nhất lên đầu
            query = query.OrderByDescending(r => r.RunDate);

            // 7. Giới hạn số lượng (Dùng cho màn hình mặc định để load nhanh)
            if (topCount.HasValue)
            {
                query = query.Take(topCount.Value);
            }

            // 8. Chạy lệnh lấy dữ liệu
            return (query.ToList(), TotalRecords);
        }

        //public (List<RunSession> Data, int TotalRecords) GetByUser(int? userId = null, int? topCount = null)
        //{
        //    // 1. Khởi tạo Query
        //    var query = _context.RunSessions
        //                        .Include(r => r.User)
        //                        .AsQueryable();

        //    // 2. Nếu có UserID thì lọc, nếu null (Admin) thì bỏ qua bước này -> lấy hết
        //    if (userId.HasValue)
        //    {
        //        query = query.Where(s => s.UserID == userId.Value);
        //    }

        //    int TotalRecords = query.Count();

        //    // 3. Luôn luôn sắp xếp mới nhất lên đầu
        //    query = query.OrderByDescending(r => r.RunDate);

        //    // 4. Nếu có giới hạn số lượng (ví dụ 50 dòng) thì Take
        //    if (topCount.HasValue)
        //    {
        //        query = query.Take(topCount.Value);
        //    }

        //    var countList = query.ToList();

        //    // 5. Chạy lệnh lấy dữ liệu
        //    return (countList, TotalRecords);
        //}

        public void Delete(int sessionId)
        {
            var session = _context.RunSessions.Find(sessionId);
            if (session != null)
            {
                _context.RunSessions.Remove(session);
                _context.SaveChanges();
            }
        }

        public List<RunSession> FindSessions(int userId, bool isAdmin, DateTime fromDate, DateTime toDate, string runType)
        {
            var query = _context.RunSessions.AsQueryable();

            // 1. PHÂN QUYỀN (Data Security)
            if (!isAdmin)
            {
                // User thường: CHỈ được thấy bài của chính mình
                query = query.Where(r => r.UserID == userId);
            }
            // Admin: Không lọc UserId -> thấy hết

            // 2. LỌC THEO THỜI GIAN (Search Criteria)
            // Dùng .Date để so sánh chính xác ngày, bỏ qua giờ phút
            query = query.Where(r => r.RunDate >= fromDate.Date && r.RunDate <= toDate.Date);

            // 3. LỌC THEO LOẠI BÀI
            if (!string.IsNullOrEmpty(runType) && runType != "Tất cả")
            {
                query = query.Where(r => r.RunType == runType);
            }

            // 4. SẮP XẾP (Mới nhất lên đầu)
            query = query.OrderByDescending(r => r.RunDate);

            return query.ToList();
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
