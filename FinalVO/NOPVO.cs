using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class NOPVO
    {
        //비가동 일자
        public string Nop_Date { get; set; }
        //작업장코드
        public string Wc_Code { get; set; }
        //작업장명
        public string Wc_Name { get; set; }
        //비가동대분류
        public string Nop_Mi_Name { get; set; }
        //비가동상세분류
        public string Nop_Ma_Name { get; set; }
        //비가동발생시각
        public string Nop_Happentime { get; set; }
        //비가동종료시간
        public string Nop_Canceltime { get; set; }
        //비가동시간
        public decimal Nop_Time { get; set; }
        //비고
        public string Remark { get; set; }
        //발생유형
        public string Nop_Type { get; set; }

        public string Nop_Seq { get; set; }
        public string Nop_Mi_Code { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }

    }
}
