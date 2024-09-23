using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class LeaveBalances: UpdatedEntity
    {
        [DisplayName("LeaveBalanceId")]
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


        [Required]
        [DisplayName("Leave Year")]
        public int LeaveYear { get; set; }

        [Required]
        [DisplayName("Balance")]
        public decimal Balance { get; set; }






    }
}
