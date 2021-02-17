using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.QAM_SQC
{
    class QAM_SQC_Service
    {
        internal List<LOTVO> GetLotVOList(string YYYY)
        {
            return new SelectDAC().GetLotVOList(YYYY);
        }

        internal List<InspecVo> GetInspecVoList(string dtpFrom, string dtpTo, string processCode, string wcCode)
        {
            return new SelectDAC().GetInspecVoList(dtpFrom, dtpTo, processCode, wcCode);
        }
        internal List<ConditionVO> GetConditionVOVoList(string dtpFrom, string dtpTo, string processCode, string wcCode)
        {
            return new SelectDAC().GetConditionVoList(dtpFrom, dtpTo, processCode, wcCode);
        }
    }
}
