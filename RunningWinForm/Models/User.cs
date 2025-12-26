using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(256)]
        public string Password { get; set; }

        //navigation property
        public virtual ICollection<RunSession> RunSessions { get; set; }

        public virtual ICollection<TrainingPlan> TrainingPlans { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        
    }
}
