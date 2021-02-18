using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Final.MDS_ODS
{
    public class ProcessService
    {
        
        public DataTable PRBinding()
        {
            return new ProcessDAC().PRBinding();
        }

        public List<ProcessVO> GetAll_ProcessMaster(string pr)
        {
            return new ProcessDAC().GetAll_ProcessMaster(pr);
        }

        public bool UpdateUseYN(ProcessVO vo)
        {
            return new ProcessDAC().UpdateUseYN(vo);
        }

        public bool InsertUpdatePR_MaVO(ProcessVO additem)
        {
            return new ProcessDAC().InsertUpdatePR_MaVO(additem);
        }
    }
}