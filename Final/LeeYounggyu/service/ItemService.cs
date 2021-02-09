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
             

        public bool UpdateItemInfo(ItemInfoVO item)
        {
            return new ItemInfoDAC().UpdateItemInfo(item);
        }


        public bool Use_YNItem_Level_Master(string groupcode, string used)
        {
            return new ItemInfoDAC().Use_YNItem_Level_Master(groupcode, used);
        }

        public List<Item_MasterVO> GetAllItem_Master()
        {
            return new SelectDAC().GetAllItem_Master();
        }

        public bool UpdateAllItem_Master(Item_MasterVO upitem)
        {
            return new ItemInfoDAC().UpdateItemInfo(upitem);
        }

        public List<ItemInfoVO> GetAllItem_Level_Master()
        {
            return SelectDAC.GetAllItem_Level_Master();
        }

        public bool InsertAllItem_Master(Item_MasterVO item)
        {
            return new ItemInfoDAC().InsertAllitem_Master(item);
        }
    }
}
