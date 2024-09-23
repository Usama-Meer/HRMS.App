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
    public  class DepartmentManager
    {
        [Required]
        [DisplayName("DepartmentId")]
        public string DepartmentId { get; set; }
        [ForeignKey("Id")]

        public virtual Department Department { get; set; }

        [Required]
        [DisplayName("ManagerId")]
        public int ManagerId { get; set; }



    }
}
