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
    public class Qualification : UpdatedEntity
    {


        [DisplayName("EmployeeId")]
        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]

        public Employee Employee { get; set; }

        [DisplayName("QualificationTypeId")]
        [Required]
        public int QualificationTypeId { get; set; }
        [ForeignKey("Id")]

        public QualificationType QualificationType { get; set; }

        [DisplayName("QualificationLevelId")]
        [Required]
        public int QualificationLevelId { get; set; }
        [ForeignKey("Id")]

        public QualificationLevel QualificationLevel { get; set; }

        [DisplayName("Qualification Name")]
        [Required]
        public string QualificationName     { get; set; }

        [DisplayName("Qualification Year")]
        [Required]
        public int QualificationYear { get; set; }

        [DisplayName("QualificationTypeId")]
        [Required]
        public string Institute { get; set; }


        [DisplayName("Grade")]
        [Required]
        public string Grade { get; set; }


    }
}
