using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Core.Common;

namespace HRMS.Core.Entities
{
    public  class LeaveType:UpdatedEntity
    {

        [DisplayName("CompanyId")]
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("Id")]

        public virtual Company Company { get; set; }

        [Required]
        [DisplayName("LeaveTypeName")]
        [StringLength(50)]
        public string LeaveTypeName { get; set; }
        
        [Required]
        [DisplayName("Max-Day-Per-Year")]
        
        public int MaxDaysPerYear { get; set; }

        [Required]
        [DisplayName("Is Active")]
        
        public bool IsActive { get; set; }




    }
}
