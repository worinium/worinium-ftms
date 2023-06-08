using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    public class FtmsFile
    {
        public int FileId { get; set; }
        public string FileNumber { get; set; }
        public string OwnerName { get; set; }
        public bool CofoExist { get; set; }
        public bool RofoExist { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? AppDate { get; set; }
        public string Remark { get; set; }
        public string RegisterNumber { get; set; }
        public DateTime? RofoDate { get; set; }
        public DateTime? CommencementDate { get; set; }
        public string FileAlias { get; set; }
        public string LgaCode { get; set; }
        public string RackNumber { get; set; }
        public int CurrentTransaction { get; set; }

        public FtmsFile()
        {
            CurrentTransaction = 0;
        }
    }
}
