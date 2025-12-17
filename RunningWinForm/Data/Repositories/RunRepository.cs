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

        public List<RunSession> GetByUser(int userId)    
        {
            return _context.RunSessions
                .Where(s => s.UserID == userId)
                .Include(r => r.User)
                .OrderByDescending(r => r.RunDate)
                .ToList();
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
