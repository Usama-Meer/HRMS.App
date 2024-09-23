using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Core.Common
{
    public class UpdatedEntity:ActionEntity
    {
        public DateTime UpdateAt { get; set; }
        public int UpdatedById { get; set; }
        public string UpdatedByName { get; set; }


    }
}
