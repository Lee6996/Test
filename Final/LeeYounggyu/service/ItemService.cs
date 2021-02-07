using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.LeeYounggyu.service
{
    public class ItemService
    {
        public List<ItemInfoVO> SelectItemLevel()
        {
            return new SelectDAC().SelectItemLevel();
        }
    }
}
