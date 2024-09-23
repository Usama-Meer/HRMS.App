using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public  class SubDepartmentManager:UpdatedEntity
    {



        
        [DisplayName("ManagerId")]
        [Required]
        public int ManagerId { get; set; }
        [ForeignKey("Id")]

        public SubDepartment SubDepartment { get; set; }


        


    }
}
