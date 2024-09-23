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
    public class QualificationType:UpdatedEntity
    {


        [DisplayName("Qualification Type Name")]
        [Required]
        public string QualificationTypeName { get; set; }

        


    }
}
