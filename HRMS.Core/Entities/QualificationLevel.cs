using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Entities
{
    public class QualificationLevel:UpdatedEntity
    {


        [DisplayName("Qualification level Name")]

        public string QualificationLevelName { get; set; }






    }
}
