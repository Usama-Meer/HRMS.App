using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Common
{
    public class CreatedEntity:BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }   
        public string CreatedByName { get; set; }= null!;
    }

}
