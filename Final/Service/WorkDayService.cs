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
        public List<WorkDayVO> SelectWorkDay(string Prd_Date)
        {
            return dac.SelectWorkDay(Prd_Date);
        }
        public List<WorkItemVO> SelectWorkItem(string Prd_Date)
        {
            return dac.SelectWorkItem(Prd_Date);
        }

        public List<WorkBoxingVO> SelectWorkBoxing(string Prd_Date)
        {
            return dac.SelectWorkBoxing(Prd_Date);
        }
    }


}
