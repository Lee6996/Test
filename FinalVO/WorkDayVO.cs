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
        string Prd_Date;
        //근무인원
        string User_ID;
        //공정
        string Process_Code;
        //작업장
        string Wc_Code;
        //제품명
        string Item_Name;
        //실적
        string Prd_Qty;
        //생산시간
        string WorkTime;
        //시간당생산량
        decimal PrdQty_Per_Hour;
        //비가동시간
        int Nop_Check_Time;
    }
    public class WorkMonthVO
    {
        //공정
        string Process_Code;
        //작업장
        string Wc_Code;
        //제품명
        string Item_Name;
        //전월생산량
        string Month_Prd_Qty;
        //전월생산시간
        string Month_WorkTime;
        //당월생산량
        string NMonth_Prd_Qty;
        //당월시간
        string NMonth_WorkTime;
    }
}
