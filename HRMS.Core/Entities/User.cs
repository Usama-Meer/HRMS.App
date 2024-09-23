using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class User:UpdatedEntity
    {



        [DisplayName("Username")]
        [StringLength(50)]
        [Required]
        public string Username { get; set; }

        [DisplayName("Password")]
        [StringLength(255)]
        [Required]
        public string Password { get; set; }

        [DisplayName("Is Login")]
        public bool isLogin { get; set; }

        [DisplayName("Last Login Date")]
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }


        [DisplayName("Is Active")]
        [Required]
        public bool IsActive { get; set; }


        [DisplayName("Employee Id")]
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]
        
        public virtual Employee Employee { get; set; }


        [DisplayName("Role Id")]
        [Required]
        public int RoleId { get; set; }
        [ForeignKey("Id")]

        public virtual Role Role { get; set; }

        [DisplayName("Session Id")]
        public int SessionId {  get; set; }


    }
}
