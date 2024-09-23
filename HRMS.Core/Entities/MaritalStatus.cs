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
    public class MaritalStatus : UpdatedEntity
    {


        [Required]
        [DisplayName("Marital Status Name")]
        [StringLength(100)]
        public string MaritalStatusName {get;set;}




    }
}
