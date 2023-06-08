using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class FtmsCensus
    {
        public int CensusId { get; set; }
        public DateTime CensusDate { get; set; }
        public string LocationCode { get; set; }
        public int FileId { get; set; }
        public string LoggedUser { get; set; }
        public string PcName { get; set; }
    }
}
