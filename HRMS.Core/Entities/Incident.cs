using HRMS.Core.Common;
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
    public  class Incident:DeletedEntity
    {

        [Required]
        [DisplayName("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("Id")]

        public Employee Employee { get; set; }

        [Required]
        [DisplayName("Incident Date")]

        public DateTime IncidentDate { get; set; }

        [Required]
        [DisplayName("Reported Date")]

        public DateTime ReportedTime { get; set; }

        [Required]
        [DisplayName("Incident Description")]
        [StringLength(255)]
        public string IncidentDescription { get; set; }

        [Required]
        [DisplayName("IncidentTypeId")]
        public int IncidentTypeId { get; set; }
        [ForeignKey("Id")]

        public IncidentType IncidentType { get; set; }

        [Required]
        [DisplayName("Severity")]
        [StringLength(50)]
        public string Severity { get; set; }


        [Required]
        [DisplayName("Severity")]
        [StringLength(50)]
        public string Severity { get; set; }

        [Required]
        [DisplayName("Status")]
        [StringLength(50)]
        public string Status { get; set; }






    }
}
