using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    public class WorkDayService
    {
        SelectDAC dac;
        public List<WorkDayVO> SelectWorkDay()
        {
            return dac.SelectWorkDay();
        }
    }


}
