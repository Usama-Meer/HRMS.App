using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public  class Shifts:UpdatedEntity
    {
        

        [DisplayName("Shift Name")]
        [StringLength(50)]
        [Required]
        public string ShiftName { get; set; }

        [DisplayName("Start-Time")]
        [Required]
        public DateTime StartTime { get; set; }

        [DisplayName("End-Time")]
        [Required]
        public DateTime EndTime { get; set; }



    }
}
