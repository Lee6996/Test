using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class WorkOrderVO
    {
        public string Workorderno { get; set; }             
        public string Item_Code { get; set; }
        public string Wc_Code { get; set; }
        public int Plan_Qty { get; set; }
        public string Plan_Unit { get; set; }
        public string Plan_Date { get; set; }
        public string Prd_Date { get; set; }
        public string Wo_Status { get; set; }
        public int Wo_Order { get; set; }
        public string Plan_Starttime { get; set; }
        public string Plan_Endtime { get; set; }
        public string Prd_Starttime { get; set; }
        public string Prd_Endtime { get; set; }
        public int In_Qty_Main { get; set; }
        public int Out_Qty_Main { get; set; }
        public int Prd_Qty { get; set; }
        public string Prd_Unit { get; set; }
        public string Worker_CloseTime { get; set; }
        public string Manager_CloseTime { get; set; }
        public string Close_CancelTime { get; set; }
        public string Wo_Req_No { get; set; }
        public int Req_Seq { get; set; }
        public string Mat_LotNo { get; set; }
        public string Remark { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Name { get; set; }
        public string Process_Code { get; set; }
    }
}
