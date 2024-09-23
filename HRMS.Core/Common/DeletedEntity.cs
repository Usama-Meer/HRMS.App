using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Common
{
    public class DeletedEntity:UpdatedEntity
    {
        public DateTime DeletedAt { get; set; }
        public int DeletedById { get; set; }
        public string DetetedByName { get; set; }=null!;
    }
}
