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
    public class Experience:BaseEntity
    {
        [Required]
        [DisplayName("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]
        public virtual Employee Employee { get; set; }
    
        [Required]
        [DisplayName("Company Name")]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [Required]
        [DisplayName("Designation")]
        [StringLength(50)]
        public string Designation {  get; set; }

        [Required]
        [DisplayName("Date-From")]
        public DateTime DateFrom { get; set; }

        [Required]
        [DisplayName("Date-To")]
        public DateTime DateTo { get; set; }

        [Required]
        [DisplayName("Reason For Leaving")]
        public string ReasonForLeaving { get; set; }



    }
}
