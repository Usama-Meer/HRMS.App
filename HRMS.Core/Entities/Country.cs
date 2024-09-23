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
    public class Country:DeletedEntity
    {

        [Required]
        [DisplayName("Country Code")]
        [StringLength(5)]
        public string Code { get; set; }


        [Required]
        [DisplayName("CountryName")]
        [StringLength(100)]
        public string CountryName { get; set; }


    }
}
