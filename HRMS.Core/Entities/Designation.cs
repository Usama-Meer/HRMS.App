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
    public class Designation:DeletedEntity
    {

        [Required]
        [DisplayName("Designation Name")]
        [StringLength(100)]
        public string DesignationName { get; set; }



    }
}
