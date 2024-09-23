using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class EmployeeGrade:DeletedEntity
    {
        [Required]
        [DisplayName("EmployeeGrade")]
        [StringLength(10)]
        public string EmployeeGradeName { get; set; }
    }
}
