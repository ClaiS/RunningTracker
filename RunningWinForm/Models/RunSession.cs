using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Models
{
    public class RunSession
    {
        [Key]
        public int RunID { get; set; }

        [Required]
        public String RunType { get; set; }

        [Required]
        public DateTime RunDate { get; set; }

        [Required]
        public decimal Distance { get; set; } // km

        [Required]
        public decimal Duration { get; set; } // minutes

        [Required]
        public int RPE { get; set; } // Rate of Perceived Exertion

        public String Terrain { get; set; }

        [Required]
        public int AvgHR { get; set; }

        //FK
        public int UserID { get; set; }

        //navigation property

        public virtual User User { get; set; } // gọi đến bảng User
    }
}
