using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class FtmsSetting
    {
        public string MrCode { get; set; }
        public string Value { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
    }
}
