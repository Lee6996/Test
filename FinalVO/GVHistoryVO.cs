using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class GVHistoryVO
    {
        public int Hist_Seq { get; set; }
        public string GV_Code { get; set; }
        public string Workorderno { get; set; }
        public string Loading_Date { get; set; }
        public string Loading_Datetime { get; set; }
        public int Loading_Qty { get; set; }
        public string Loading_Wc { get; set; }
        public string In_Time { get; set; }
        public string Center_Time { get; set; }
        public string Out_Time { get; set; }
        public int Unloading_Qty { get; set; }
        public string Unloading_Date { get; set; }
        public string Unloading_Datetime { get; set; }
        public string Unloading_wc { get; set; }
        public string Target_GV { get; set; }
        public string Clear_Date { get; set; }
        public string Clear_Datetime { get; set; }
        public int Clear_Qty { get; set; }
        public string Clear_Cause { get; set; }
        public string Clear_wc { get; set; }
        public string Clear_Item { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string GV_Name { get; set; }
    }
}
