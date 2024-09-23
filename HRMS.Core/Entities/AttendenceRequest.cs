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
    public class AttendenceRequest:DeletedEntity
    {
        [Required]
        [DisplayName("Request Date")]
        public DateTime RequestDate { get; set; }

        [Required]
        [DisplayName("Correction Date")]
        public DateTime CorrectionDate { get; set; }

        [Required]
        [DisplayName("check In Time")]
        public DateTime CheckInTime { get; set; }

        [Required]
        [DisplayName("Check Out Time")]
        public DateTime CheckOutTime { get; set; }
        
        [Required]
        [DisplayName("Request Check In Time")]
        public DateTime RequestCheckInTime { get; set; }

        [Required]
        [DisplayName("Request Check Out Time")]
        public DateTime RequestCheckOutTime { get; set; }


        [Required]
        [DisplayName("Reason")]
        [StringLength(255)]
        public string Reason { get; set; }


        [Required]
        [DisplayName("Status")]
        [StringLength(100)]
        public string Status { get; set; }



    }
}
