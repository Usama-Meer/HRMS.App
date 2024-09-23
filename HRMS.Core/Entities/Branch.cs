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
    public  class Branch:DeletedEntity
    {

        [Required]
        [DisplayName("CompanyId")]
        public string CompanyId { get; set; }
        [ForeignKey("Id")]

        public virtual Company Company { get; set; }
        
        [Required]
        [DisplayName("Branch Name")]
        [StringLength(100)]
        public string BranchName { get; set; }

        [Required]
        [DisplayName("Branch Code")]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }


        [Required]
        [DisplayName("CityId")]
        public int CityId { get; set; }

        public virtual City City { get; set; }

        [Required]
        [DisplayName("StateId")]
        public int StateId { get; set; }

        public virtual State State { get; set; }



        [DisplayName("Zip Code")]
        [StringLength(10)]
        public string ZipCode { get; set; }



        [DisplayName("CountryId")]
        public int CountryId { get; set; }
        [ForeignKey("Id")]

        public virtual Country Country { get; set; }

        [Required]
        [DisplayName("PhoneNumber")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }


        [Required]
        [DisplayName("Email")]
        [StringLength(255)]
        public string Email { get; set; }
        
        [Required]
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }

        [Required]
        [DisplayName("Branch Manager Id")]
        public int BranchManagerId { get; set; }




    }
}
