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
    }
}
