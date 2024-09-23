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
    public class HolidayBranch:CreatedEntity
    {
        [DisplayName("HolidayId")]
        [Required]
        public int HolidayId { get; set; }
        [ForeignKey("Id")]

        public virtual Holidays Holidays { get; set; }

        [DisplayName("BranchId")]
        [Required]
        public int BranchId { get; set; }
        [ForeignKey("Id")]

        public virtual Branch Branch { get; set; }

    }
}
