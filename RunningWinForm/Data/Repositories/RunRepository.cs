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

        public List<RunSession> GetByUser(int? userId = null, int? topCount = null)
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

            // 3. Luôn luôn sắp xếp mới nhất lên đầu
            query = query.OrderByDescending(r => r.RunDate);

            // 4. Nếu có giới hạn số lượng (ví dụ 50 dòng) thì Take
            if (topCount.HasValue)
            {
                query = query.Take(topCount.Value);
            }

            // 5. Chạy lệnh lấy dữ liệu
            return query.ToList();
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
    }
}
