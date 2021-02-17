using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class BoxingGrade_Detail_MasterVO
    {
        public string Grade_Detail_Code { get; set; }        // 포장등급상세코드
        public string Grade_Detail_Name { get; set; }       // 포장등급상세명
        public string Boxing_Grade_Code { get; set; }       // 포장등급
        public int Use_YN { get; set; }                       // 사용여부
        public string Ins_Date { get; set; }                 // 최초입력일자
        public string Ins_Emp { get; set; }                      // 최초입력자
        public string Up_Date { get; set; }                 // 최종수정일자
        public string Up_Emp { get; set; }                      // 최종수정자
    }
}
