using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Models
{
    public class YearlySummary
    {
        [Key]
        public int SummaryID { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public decimal TotalDistance { get; set; } // km

        [Required]
        public decimal TotalTrainingLoad { get; set; }

        [Required]
        public int TotalRuns { get; set; }

        [StringLength(20)]
        public string DominantRunType { get; set; }

        //FK
        public int UserID { get; set; }

        //navigation property
        public virtual User User { get; set; } // gọi đến bảng User
    }
}
