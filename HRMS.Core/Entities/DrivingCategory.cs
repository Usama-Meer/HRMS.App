using HRMS.Core.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HRMS.Core.Entities
{
    public class DrivingCategory:DeletedEntity
    {

        [Required]
        [DisplayName("Driving Category Name")]
        [StringLength(50)]
        public string DrivingCategoryName { get; set; }


        [DisplayName("Description")]
        [StringLength(255)]
        public string Description { get; set; }


    }
}