using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class AllocationStatus
    {
        public string MrCode { get; set; }
        public string Status { get; set; }
        public bool Active { get; set; }
        public string RequestCategoryType { get; set; }
    }
}
