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

        public DataTable ItemLevelBinding()
        {
            return new ItemInfoDAC().ItemLevelBinding();
        }

        public List<ItemInfoVO> ItemLevelGroupSelect(string groupName)
        {
            return new ItemInfoDAC().ItemLevelGroupSelect(groupName);
        }

        public bool InsertItemLevel(ItemInfoVO additem)
        {
            return new ItemInfoDAC().InsertItemLevel(additem);
        }

        public bool UpdateItemLevel(ItemInfoVO vo)
        {
            return new ItemInfoDAC().UpdateItemLevel(vo);
        }

        public DataTable ItemMasterBindingName()
        {
            return new ItemInfoDAC().ItemMasterBindingName();
        }
        public DataTable ItemMasterBindingType()
        {
            return new ItemInfoDAC().ItemMasterBindingType();
        }
        //string groupName
        public List<Item_MasterVO> ItemMasterSelect(string groupName)
        {
            return new ItemInfoDAC().ItemMasterSelect(groupName);
        }

        public bool InsertItemMaster(Item_MasterVO additem)
        {
            return new ItemInfoDAC().InsertItemMaster(additem);
        }

        public bool UpdateUSEYN(Item_MasterVO vo)
        {
            return new ItemInfoDAC().UpdateUSEYN(vo);
        }

        public bool InsertUpdateItemInfo(ItemInfoVO additem)
        {
            return new ItemInfoDAC().InsertUpdateItemInfo(additem);
        }
    }
}
