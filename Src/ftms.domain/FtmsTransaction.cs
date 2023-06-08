using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class FtmsTransaction
    {
        public int TransactionId { get; set; }
        public int FileId { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime TransactionDate { get; set; }
        public string FileCondition { get; set; }
        public int NumberPage { get; set; }
        public string LoggedUser { get; set; }
        public string PcName { get; set; }
        public string TrackingRemark { get; set; }
    }
}
