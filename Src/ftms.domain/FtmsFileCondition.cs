using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class FtmsFileCondition
    {
        public string MrCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int Positions { get; set; }
    }
}
