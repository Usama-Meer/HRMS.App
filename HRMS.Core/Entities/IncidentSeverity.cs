using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Core.Common;

namespace HRMS.Core.Entities
{
    public class IncidentSeverity:DeletedEntity
    {


        [Required]
        [DisplayName("Severity")]
        [StringLength(50)]
        public string Severity { get; set; }

        
    }
}
