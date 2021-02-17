using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class WorkDayVO
    {
        //생산일자
        public string Prd_Date { get; set; }
        //근무인원
        public string  User_ID { get; set; }
        //공정
        public string  Process_Code { get; set; }
        //작업장
        public string Wc_Code { get; set; }
        //제품명
        public string Item_Name { get; set; }
        //실적
        public int? Prd_Qty { get; set; }
        //생산시간
        public string WorkTime { get; set; }
        //시간당생산량
        public decimal PrdQty_Per_Hour { get; set; }
        //비가동시간
        public int? Nop_Check_Time { get; set; }
    }
    public class WorkMonthVO
    {
        //공정
        public string Process_Code { get; set; }
        //작업장
        public string Wc_Code { get; set; }
        //제품명
        public string Item_Name { get; set; }
        //전월생산량
        public string Month_Prd_Qty { get; set; }
        //전월생산시간
        public string Month_WorkTime { get; set; }
        //당월생산량
        public string NMonth_Prd_Qty { get; set; }
        //당월시간
        public string NMonth_WorkTime { get; set; }
    }
}
