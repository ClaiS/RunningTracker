using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningWinForm.Models
{
    public class Role
    {
        [Required]
        public int RoleID { get; set; }

        [Required, StringLength(20)]
        public string RoleName { get; set; }

        //navigation property
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
