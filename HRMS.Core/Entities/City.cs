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
    public class City:DeletedEntity
    {
        [Required]
        [DisplayName("StateId")]
        public int StateId { get; set; }
        [ForeignKey("Id")]

        public virtual State State { get; set; }

        [Required]
        [DisplayName("City Name")]
        [StringLength(100)]
        public string CityName { get; set; }

    }
}
