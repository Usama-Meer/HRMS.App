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
    public class Holidays:DeletedEntity
    {
        [Required]
        [DisplayName("Holiday Name")]
        [StringLength(100)]
        public string HolidayName { get; set; }

        [Required]
        [DisplayName("Holiday Description")]
       
        public string Description { get; set; }

        [Required]
        [DisplayName("Holiday Date")]
        
        public DateTime HolidayDate { get; set; }

        [Required]
        [DisplayName("isGazetted")]

        public bool isGazetted { get; set; }



        
    }
}
