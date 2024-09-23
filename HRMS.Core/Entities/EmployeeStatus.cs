using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class EmployeeStatus:DeletedEntity
    {

        [Required]
        [DisplayName("Employee Status")]
        [StringLength(100)]
        public string EmployeeStatusName { get; set; }


    }
}
