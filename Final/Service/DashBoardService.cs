using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Service
{
    class DashBoardService
    {
        public List<GVStatusVO> GetDashBoardGV()
        {

            return new SelectDAC().SelectGVStatus();
        }

        internal List<WorkOrderVO> GetDashBoardWorkOrder()
        {
            return new SelectDAC().SelectWorkOrder();
        }

        public List<ScreenVO> GetScreenVOList()
        {
            return new ScreenDAC().SelectScreenInfo();
        }
    }
}
