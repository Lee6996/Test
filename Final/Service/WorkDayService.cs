using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    class WorkDayService
    {
        SelectDAC dac;
        public WorkDayService()
        {
            dac = new SelectDAC();
        }
        public List<WorkDayVO> SelectWorkDay(string Prd_Date_from, string Prd_Date_to, string Pcode, string Wcode)
        {
            return dac.SelectWorkDay(Prd_Date_from, Prd_Date_to, Pcode, Wcode);
        }
        public List<WorkItemVO> SelectWorkItem(string Prd_Date_from, string Prd_Date_to,string Wcode)
        {
            return dac.SelectWorkItem(Prd_Date_from, Prd_Date_to, Wcode);
        }

        public List<WorkBoxingVO> SelectWorkBoxing(string Prd_Date_from, string Prd_Date_to, string Wcode)
        {
            return dac.SelectWorkBoxing(Prd_Date_from, Prd_Date_to, Wcode);
        }
    }


}
