using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_SDS.service
{
    public class Condition_Spec_MasterService
    {
        public List<ConditionSpecVO> ConditionSelect(string code)
        {
            return new Condition_SpecDAC().ConditionSelect(code);
        }

        public bool InsertCondition(ConditionSpecVO condition)
        {
            return new Condition_SpecDAC().InsertCondition(condition);
        }      
    }
}
