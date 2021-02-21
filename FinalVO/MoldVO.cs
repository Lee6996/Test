using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class MoldVO
    {
        // 금형코드
        public string Mold_Code { get; set; }
        // 금형명
        public string Mold_Name { get; set; }
        // 금형그룹
        public string Mold_Group { get; set; }
        // 금형상태
        public string Mold_Status { get; set; }
        // 금형누적타수
        public int Cum_Shot_Cnt { get; set; }
        // 금형누적생산량
        public int Cum_Prd_Qty { get; set; }
        // 금형누적사용시간
        public decimal Cum_Time { get; set; }
        // 보장타수
        public int Guar_Shot_Cnt { get; set; }
        // 구앱금액
        public int Purchase_Amt { get; set; }
        // 입고일자
        public string In_Date { get; set; }
        // 최종장착일시
        public string Last_Setup_Time { get; set; }
        // 장착작업장코드
        public string Wc_Code { get; set; }
        // 비고
        public string Remark { get; set; }
        // 사용여부
        public string Use_YN { get; set; }
        // 최초입력일자
        public string Ins_Date { get; set; }
        // 최초입력자
        public string Ins_Emp { get; set; }
        // 최종수정일자
        public string Up_Date { get; set; }
        // 최종수정자
        public string Up_Emp { get; set; }

    }
    public class MoldGroupVO
    {
        public string Mold_Group { get; set; }
    }
    public class MoldUseVO
    {

        // 생산일자
        public string Prd_Date { get; set; }
        // 금형코드
        public string Mold_Code { get; set; }
        // 금형명
        public string Mold_Name { get; set; }
        // 작업지시번호
        public string Workorderno { get; set; }
        // 품목코드
        public string Item_Code { get; set; }
        // 품목명
        public string Item_Name { get; set; }
        // 작업장코드
        public string Wc_Code { get; set; }
        // 작업장명
        public string Wc_Name { get; set; }
        // 금형타수
        public int Mold_Shot_Cnt { get; set; }
        // 금형생산량
        public int Mold_Prd_Qty { get; set; }
        // 금형사용시작시간
        public string Use_Starttime { get; set; }
        // 금형사용종료시간
        public string Use_Endtime { get; set; }
        // 금형사용시간
        public decimal Cum_Time { get; set; }


    }

}
