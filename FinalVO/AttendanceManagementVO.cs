using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class AttendanceManagementVO
    {
        public string Workorderno { get; set; }
        public string Wc_Code { get; set; }
        public string Wc_Name { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Work_StartTime { get; set; }
        public string Work_EndTime { get; set; }
        public int Prd_Qty { get; set; }
        public string User_Name { get; set; }
    }
}
