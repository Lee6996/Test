using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    public class WorkCenterService
    {
        SelectDAC dac;
        public WorkCenterService()
        {
            dac = new SelectDAC();
        }
        public List<WorkCenterVO> SelectWorkCenter()
        {
            return dac.SelectWorkCenter();
        }
    }
}
