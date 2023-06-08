using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftms.domain
{
    internal class FtmsSticker
    {
        public int StickerId { get; set; }
        public int FileId { get; set; }
        public string QrFullText { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LoggedUser { get; set; }
        public bool Active { get; set; }
    }
}
