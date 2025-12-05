using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Models
{
    internal class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

        [Required, StringLength(20)]
        public string Role { get; set; } // "Admin" hoặc "User"

        //navigation property
        public virtual ICollection<RunSession> RunSessions { get; set; }

        public virtual ICollection<TrainingPlan> TrainingPlans { get; set; }

        public virtual ICollection<MonthlySummary> MonthlySummaries { get; set; }

        public virtual ICollection<YearlySummary> YearlySummaries { get; set; }

        public virtual ICollection<WeeklySummary> WeeklySummaries { get; set; }
    }
}
