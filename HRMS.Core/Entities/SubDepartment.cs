using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Core.Entities
{
    public  class SubDepartment:UpdatedEntity
    {




        [DisplayName("DepartmentId")]
        [Required]
        public int Departmentid { get; set; }
        [ForeignKey("Id")]
        public Department Department { get; set; }
        


        [DisplayName("Sub-Department Name")]
        [StringLength(50)]
        [Required]
        public string SubDepartmentName { get; set; }

        [DisplayName("Is Active")]
        [Required]
        public bool IsActive { get; set; }

       


    }
}
