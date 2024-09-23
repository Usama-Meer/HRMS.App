using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public  class NextOfKin:UpdatedEntity
    {

        public int Id {  get; set; }

        [DisplayName("NextOfKin Name")]
        [Required]
        [StringLength(100)]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]

        public Employee Employee { get; set; }

        [DisplayName("RelationshipTypeId")]
        [Required]

        public int RelationshipTypeId { get; set; }
        [ForeignKey("Id")]

        public RelationShipType RelationShipType { get; set; }


        [DisplayName("Date Of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Cnic Number")]
        [Required]
        [StringLength(50)]
        public string CnicNo    { get; set; }


    }
}
