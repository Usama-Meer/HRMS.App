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
    public class Company : UpdatedEntity
    {




        [DisplayName("CompanyName")]
        [Required(ErrorMessage = "Enter Company Name")]
        public string CompanyName { get; set; }

        
        public int IndustryId { get; set; }
        [ForeignKey("Id")]

        public virtual Industry Industry { get; set; }

        [DisplayName("Company Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Enter CompanyCode")] 
       public string Code { get; set; }


        [DisplayName("Company Description")]
        [StringLength(255)]
        [Required(ErrorMessage ="Enter Company Description")]
        public string Description { get; set; }

        [DisplayName("Address")]
        [StringLength(255)]
        public string Address { get; set; }

        [DisplayName("Country Id")]
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("Id")]

        public virtual Country Country { get; set; }

        [DisplayName("City Id")]
        [Required]
        public int CityId { get; set; }
        [ForeignKey("Id")]

        public virtual City City {get;set;}

        [DisplayName("Zip Code")]
        [StringLength(20)]
        public string ZipCode { get; set; }

        [DisplayName("Phone Number")]
        [StringLength(15)]
        public string PhoneNumber { get; set; }


        [DisplayName("Secondary Phone Number")]
        [StringLength(15)]
        public string SecondayPhoneNumber { get; set; }

        [DisplayName("Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [DisplayName("Website")]
        [StringLength(100)]
        public string Website { get; set; }

        [DisplayName("Company Logo")]
        
        public byte CompanyLogo { get; set; }





    }
}
