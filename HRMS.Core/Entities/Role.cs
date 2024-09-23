using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class Role:UpdatedEntity
    {



        [DisplayName("Role Name")]
        [StringLength(50)]
        [Required]
        public string RoleName { get; set; }

        [DisplayName("Role Description")]
        [StringLength(255)]
        [Required]
        public string Description { get; set; }

        [DisplayName("Company Id")]
        [Required]
        public int CompanyId {  get; set; }
        [ForeignKey("Id")]

        public virtual Company Company { get; set; }

        [DisplayName("Is Active")]
        [Required]
        public bool IsActive { get; set; }



    }
}
