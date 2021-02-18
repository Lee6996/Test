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

        public List<WorkCenter_Master2VO> WorkCenterSelect(string code)
        {
            return new WorkCenter_MasterDAC().WorkCenterSelect(code);
        }

        public List<WorkCenterVO> GetAllWorkCenter()
        {
            return new WorkCenter_MasterDAC().GetAllWorkCenter();
        }

        public bool UpdateUseYN(WorkCenter_Master2VO vo)
        {
            return new WorkCenter_MasterDAC().UpdateUseYN(vo);
        }

        public bool InsertUpdateWC_Ma2VO(WorkCenterVO additem)
        {
            return new WorkCenter_MasterDAC().InsertUpdateWC_Ma2VO(additem);
        }
    }
}
