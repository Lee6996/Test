using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    // 근무이력VO
    public class WorkHistoryVO
    {
        // 이력순번
        public int Work_Seq { get; set; }
        // 근무일자
        public string Work_Date { get; set; }
        // 공정코드
        public string Process_Code { get; set; }
        // 사용자ID
        public string User_ID { get; set; }
        // 근무시작시간
        public string Work_StartTime { get; set; }
        // 근무종료시간
        public string Work_EndTime { get; set; }
        // 근무시간
        public string Work_Time { get; set; }
        // 휴무구분
        public string Work_Type { get; set; }
        // 비고
        public string Remark { get; set; }
        // 최초입력일자
        public string Ins_Date { get; set; }
        // 최초입력자
        public string Ins_Emp { get; set; }
        // 최종수정일자
        public string Up_Date { get; set; }
        // 최종수정자
        public string Up_Emp { get; set; }
        
        public string User_Name { get; set; }
        public string Wc_Name { get; set; }
    }
}
