using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace HRMS.Core.Entities
{
    public class LeaveRequest
    {
        [Key]
        [DisplayName("LeaveRequestId")]
        public int Id { get; set; }

        [Required]
        [DisplayName("EmployeeId")]
        public int Employeed { get; set; }
        [ForeignKey("Id")]

        public Employee Employee { get; set; }


        [Required]
        [DisplayName("LeaveTypeId")]
        public int LeaveTypeId { get; set; }
        [ForeignKey("Id")]

        public LeaveType LeaveType { get; set; }


        [DisplayName("Start-Time")]
        [Required]
        public DateTime StartTime { get; set; }

        [DisplayName("End-Time")]
        [Required]
        public DateTime EndTime { get; set; }

        [DisplayName("Number Of Days")]
        [Required]
        public int NumberOfDays { get; set; }


        [DisplayName("Reason")]
        [Required]
        public string Reason { get; set; }

        [DisplayName("Status")]
        [Required]
        [StringLength(100)]
        public string Status  { get; set; }


        
    }
}
