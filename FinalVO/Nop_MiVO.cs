﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
     public  class Nop_MiVO
    {
        public string Nop_Mi_Code { get; set; }        // 비가동상세분류코드
        public string Nop_Mi_Name { get; set; }       // 비가동상세분류명
        public string Nop_Ma_Code { get; set; }       // 비가동대분류코드
        public string Remark { get; set; }                // 비고
        public string Use_YN { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }
}
