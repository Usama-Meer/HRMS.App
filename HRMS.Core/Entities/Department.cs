using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace HRMS.Core.Entities
{
    public class Department:DeletedEntity
    {
        [Required]
        [DisplayName("CompanyId")]
        public string CompanyId { get; set; }
        [ForeignKey("Id")]

        public virtual Company Company { get; set; }

        [Required]
        [DisplayName("Department Name")]
        [StringLength(50)]
        public string DepartmentName { get; set; }


        [Required]
        [DisplayName("Is Active ")]
        public bool IsActive {  get; set; }


    }
}
