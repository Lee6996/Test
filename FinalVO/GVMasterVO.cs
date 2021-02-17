using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class GVMasterVO
    {
        public string GV_Code { get; set; }        // 대차코드
        public string GV_Name { get; set; }       // 대차명
        public string GVGroup_Code { get; set; }       // 대차그룹코드
       
        public string GV_Status { get; set; } //대차상태       

        public int Use_YN { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }
}
