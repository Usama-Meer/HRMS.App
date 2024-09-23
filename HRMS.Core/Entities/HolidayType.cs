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
    public class HolidayType:DeletedEntity
    {
        [Required]
        [DisplayName("Holiday Type Name")]
        [StringLength(100)]
        public string HolidayTypeName { get; set; }


    }
}
