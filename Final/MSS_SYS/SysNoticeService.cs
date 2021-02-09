using FinalDAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MSS_SYS
{
    public class SysNoticeService 
    {
        SysNoticeDAC dac;
        public SysNoticeService()
        {
            dac = new SysNoticeDAC();
        }


        public void Dispose()
        {
            dac.Dispose();
        }
    }
}
