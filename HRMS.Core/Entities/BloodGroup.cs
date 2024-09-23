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
    public class BloodGroup:DeletedEntity
    {
        [Required]
        [DisplayName("Blood Group Name ")]
        [StringLength(50)]
        public string BloodGroupName { get; set; }


        [Required]
        [DisplayName("Description")]
        [StringLength(255)]
        public string Description { get; set; }


    }
}
