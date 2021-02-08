using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    public class ProcessService
    {
        SelectDAC dac;
        public List<ProcessVO> SelectProcess()
        {
            return dac.SelectProcess();
        }
    }
}
