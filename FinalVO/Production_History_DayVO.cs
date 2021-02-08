using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    // 시간대일별실적VO
    public class Production_History_DayVO
    {
        // 작업지시번호
        public string Workorderno { get; set; }
        // 생산일자
        public string Prd_Date { get; set; }
        // 시작시간대
        public int Start_hour { get; set; }
        // 투입수량
        public int Un_Qty_Main { get; set; }
        // 산출수량
        public int Out_Qty_Main { get; set; }
        // 생산수량
        public int Prd_Qty { get; set; }
        // 생산수량단위
        public string Prd_Unit { get; set; }
        // 최초입력일자
        public string Ins_Date { get; set; }
        // 최초입력자
        public string Ins_Emp { get; set; }
        // 최종수정일자
        public string Up_Date { get; set; }
        // 최종수정자
        public string Up_Emp { get; set; }
        
    }
}
