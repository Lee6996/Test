using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_SDS.service
{
    public class WorkCenter_MasterService
    {       
        public DataTable WorkCenterBinding()
        {
            return new WorkCenter_MasterDAC().WorkCenterBinding();
        }

        public List<WorkCenterVO> WorkCenterSelect(string code)
        {
            return new WorkCenter_MasterDAC().WorkCenterSelect(code);
        }

        public List<WorkCenterVO> GetAllWorkCenter()
        {
            return new WorkCenter_MasterDAC().GetAllWorkCenter();
        }
    }
}
