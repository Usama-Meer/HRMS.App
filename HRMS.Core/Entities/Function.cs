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
    public class Function:CreatedEntity
    {
        [DisplayName("QualificationTypeId")]
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("Id")]

        public Company Company { get; set; }


        [DisplayName("Fucntion Name")]
        [Required]
        [StringLength(100)]
        public string FunctionName { get; set; }
    }
}
