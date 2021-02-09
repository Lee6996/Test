using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class User
    {
        public string User_ID { get; set; }
        public string User_Name { get; set; }
    }

    public class WC
    {
        public string WC_Code {get; set;}
        public string WC_Name { get; set; }
    }

    public class Item
    {
        public string Item_Code { get; set; }
        public string Item_Name { get; set; }
    }

    public class GV
    {
        public string GV_Code { get; set; }
        public string GV_Name { get; set; }
    }

    public class GVGroup
    {
        public string GVGroup_Code { get; set; }
        public string GVGroup_Name { get; set; }
    }

    public class Process
    {
        public string Process_Code { get; set; }
        public string Process_Name { get; set; }
    }
}
