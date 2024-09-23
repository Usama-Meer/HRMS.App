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
    public class Gender:DeletedEntity
    {
        [DisplayName("Gender")]
        [Required]
        [StringLength(50)]
        public string GenderName { get; set; }

    }
}
