using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace HRMS.Core.Entities
{
    public  class Group:DeletedEntity
    {
        [DisplayName("CompanyId")]
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("Id")]

        public virtual Company Company { get; set; }

        [DisplayName("Group Name")]
        [Required]
        [StringLength(50)]
        public string GroupName { get; set; }






    }
}
