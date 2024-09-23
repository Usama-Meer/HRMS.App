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
    public class RolePermission:UpdatedEntity
    {



        [DisplayName("RoleId")]
        [Required]

        public int RoleId { get; set; }
        [ForeignKey("Id")]

        public virtual Role Role { get; set; }

        [DisplayName("ApplicationPageId")]
        [Required]
        public int ApplicationPageId { get; set; }
        [ForeignKey("Id")]

        public virtual ApplicationPage ApplicationPage { get; set; }

        [DisplayName("ApplicationPageAcionId")]
        [Required]
        public int ApplicationPageActionId { get; set; }

        [ForeignKey("Id")]

        public virtual ApplicationPageAction ApplicationPageAction { get; set; }



    }
}
