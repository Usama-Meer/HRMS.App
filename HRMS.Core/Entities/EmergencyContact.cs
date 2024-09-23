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
    public class EmergencyContact:BaseEntity
    {
        [Required]
        [DisplayName("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]
        public virtual Employee Employee { get; set; }


        [Required]
        [DisplayName("Contact Name")]
        [StringLength(50)]
        public string ContactName { get; set; }


        [Required]
        [DisplayName("RelationshipTypeId")]
        public int RelationshipTypeId { get; set; }
        [ForeignKey("Id")]
        public virtual RelationShipType RelationShipType { get; set; }


        [Required]
        [DisplayName("Phone Number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }


        
        [DisplayName("Email")]
        [StringLength(50)]
        public string Email { get; set; }
        
        [DisplayName("Address")]
        [StringLength(50)]
        public string Address { get; set; }


    }
}
