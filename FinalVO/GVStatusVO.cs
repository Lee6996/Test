using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class GVStatusVO
    {
        public string GV_Code { get; set; }
        public string GV_Name { get; set; }
        public string Workorderno { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string GV_Status { get; set; }
        public int GV_Qty { get; set; }
        public string Loading_date { get; set; }
        public string Loading_time { get; set; }
        public string Loading_Wc { get; set; }
        public string Unloading_date { get; set; }
        public string Unloading_time { get; set; }
        public string Unloading_Wc { get; set; }
        public string In_Time { get; set; }
        public string Center_Time { get; set; }
        public string Out_Time { get; set; }
        public string GVGroup_Code { get; set; }
    }
}
