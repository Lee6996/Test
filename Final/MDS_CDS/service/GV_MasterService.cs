using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_CDS.service
{
    public class GV_MasterService
    {
        public DataTable GVBinding()
        {
            return new GV_MasterDAC().GVBinding();
        }

        public List<GVMasterVO> GetAllGV_Master(string gv)
        {
            return new GV_MasterDAC().GetAllGV_Master(gv);
        }

        public bool InsertGV_Master(GVMasterVO vo)
        {
            return new GV_MasterDAC().InsertGV_Master(vo);
        }

        public bool UpdateGV_Master(GVMasterVO vo)
        {
            return new GV_MasterDAC().UpdateGV_Master(vo);
        }

        public bool UpdateUseYN(GVMasterVO vo)
        {
            return new GV_MasterDAC().UpdateUseYN(vo);
        }

        public bool InsertUpdateGV_Ma(GVMasterVO vo)
        {
            return new GV_MasterDAC().InsertUpdateGV_Ma(vo);
        }
    }
}
