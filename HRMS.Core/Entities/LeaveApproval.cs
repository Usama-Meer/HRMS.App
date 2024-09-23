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
    public class LeaveApproval:DeletedEntity
    {
        [DisplayName("LeaveApprovalId")]
        public int Id { get; set; }

        [Required]
        [DisplayName("LeaveRequestId")]
        public int LeaveRequestId { get; set; }
        [ForeignKey("Id")]

        [Required]
        [DisplayName("ApproverId")]
        public int ApproverId { get; set; }

        [Required]
        [DisplayName("ApprovalDate")]
        public DateTime ApproverDate { get; set; }


        public LeaveRequest LeaveRequest { get; set; }

        [DisplayName("Status")]
        [StringLength(50)]
        public string Status { get; set; }


        [DisplayName("Comments")]
        [StringLength(255)]
        public string Comments {  get; set; }

    }
}
