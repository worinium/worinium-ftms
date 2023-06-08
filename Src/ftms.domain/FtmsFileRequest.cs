using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class FtmsFileRequest
    {
        public int RequestId { get; set; }
        public string RequestorName { get; set; }
        public string RequestPurpose { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestorPcName { get; set; }
        public string RequestorLoggedUser { get; set; }
    }
}
