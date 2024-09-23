using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class Location
    {


        [Required]
        [DisplayName("Code")]
        [StringLength(50)]
        public string Code { get; set; }

        [DisplayName("CompanyId")]
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("Id")]

        public virtual Company Company { get; set; }


        [Required]
        [DisplayName("Location Name")]
        [StringLength(100)]
        public string LocationName  { get; set; }

        [DisplayName("Address")]
        [StringLength(255)]
        public string Address { get; set; }

        [DisplayName("City Id")]
        public int CityId { get; set; }
        [ForeignKey("Id")]

        public virtual City City { get; set; }

        [DisplayName("Zip Code")]
        [StringLength(20)]
        public string ZipCode { get; set; }



        [DisplayName("CountryId")]
        public int CountryId { get; set; }
        [ForeignKey("Id")]

        public virtual Country Country { get; set; }


        [DisplayName("Phone Number")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [DisplayName("Email")]
        [StringLength(255)]
        public string Email { get; set; }

        [DisplayName("Is Active")]
        [Required]
        public bool IsActive { get; set; }
    }
}
