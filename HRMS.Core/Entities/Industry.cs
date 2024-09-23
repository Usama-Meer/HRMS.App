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
    public class Industry:DeletedEntity
    {

        [DisplayName("IndustryId")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Industry Name")]
        public string IndustryName { get; set; }

    }
}
