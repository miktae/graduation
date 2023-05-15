using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conn_PLC
{
    public class ReadFromPLC
    {
        // ĐỌC DB1
        public bool Start { get; set; }
        public bool Stop { get; set; }
        public bool Capture { get; set; }
        public short Qty_Total { get; set; }
        public short Qty_OK { get; set; }
        public short Qty_NG { get; set; }
        public short Sys_Cycle { get; set; }
    }
}
