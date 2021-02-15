using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_SDS.service
{
    public class SpecService
    {
        public List<ItemSpecVO> ItemSpecSelect(string code)
        {
            return new ItemSpecDAC().ItemSpecSelect(code);
        }

        public bool InsertSpec(ItemSpecVO additem)
        {
            return new ItemSpecDAC().InsertSpec(additem);
        }
    }
}
