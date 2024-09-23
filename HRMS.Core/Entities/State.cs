using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Core.Common;

namespace HRMS.Core.Entities
{
    public class State:UpdatedEntity
    {



        [DisplayName("CountryId")]
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("Id")]
        public virtual Country Country { get; set; }

        [DisplayName("State Name")]
        [StringLength(100)]
        [Required]
        public string StateName { get; set; }


    }
}
