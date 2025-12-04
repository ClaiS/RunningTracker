using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Models
{
    internal class TrainingPlan
    {
        [Key]
        public int PlanID { get; set; }

        [Required, StringLength(20)]
        public String PlanType { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal TargetDistance { get; set; } // km

        [Required]
        public decimal TargetPace { get; set; }

        // FK
        public int UserID { get; set; }

        // navigation property
        public virtual User User { get; set; } // gọi đến bảng User
    }
}
