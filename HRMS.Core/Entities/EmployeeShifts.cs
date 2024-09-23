using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Core.Entities
{
    public class EmployeeShifts:DeletedEntity
    {
        [Required]
        [DisplayName("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]
        public Employee Employee { get; set; }


        [Required]
        [DisplayName("ShiftId")]
        public int ShiftId { get; set; }
        [ForeignKey("Id")]
        public Shifts Shifts { get; set; }


        [Required]
        [DisplayName("Start-Date")]
        
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("End-Date")]
        public DateTime EndDate { get; set; }

    }
}
