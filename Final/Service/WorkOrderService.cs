using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    class WorkOrderService
    {
        WorkOrderDac dac;
        public WorkOrderService()
        {
            dac = new WorkOrderDac();
        }
        public bool InsertWorkOrder(WorkOrderVO work)
        {
            return dac.InsertWorkOrder(work);
        }        
        public List<WorkOrderVO> listWork(string dtpFrom, string dtpTo)
        {
            return dac.listWork(dtpFrom,dtpTo);
        }
        public List<WorkOrderVO> listWork(string dtpFrom, string dtpTo, string Wcode)
        {
            return dac.listWork(dtpFrom, dtpTo, Wcode);
        }
        public List<WorkReqVO> listReq(string dtpFrom, string dtpTo)
        {
            return dac.listReq(dtpFrom,dtpTo);
        }
        public bool UpdateWorkorder(WorkOrderVO vo, string Status)
        {
            return dac.UpdateWorkorder(vo, Status);
        }
        public bool UpdateWorkorder(string Workorder)
        {
            return dac.UpdateWorkorder(Workorder);
        }
    }
}

