using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class WorkItemVO
    {
        public string Item_Type { get; set; }
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public decimal PrdQty_Per_Hour { get; set; }
        public int Prd_Qty { get; set; }
    }
    public class WorkBoxingVO
    {
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
        public string Prd_Date { get; set; }
        public int In_Qty { get; set; }
    }

}
