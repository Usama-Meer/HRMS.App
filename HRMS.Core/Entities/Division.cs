using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Core.Entities
{
    public class Division:DeletedEntity
    {

        [Required]
        [DisplayName("CompanyId")]
        [ForeignKey("id")]

        public virtual Company Company { get; set; }
        public string ContactName { get; set; }


        [Required]
        [DisplayName("Division Name")]
        [StringLength(100)]
        public string DivisionName { get; set; }

    }
}
