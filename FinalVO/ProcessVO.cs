using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    // 공정정보 VO
    public class ProcessVO
    {
        public string Process_code { get; set; }
        // 공정코드
        public string Process_name { get; set; }
        // 공정명
        public string Process_Group { get; set; }
        // 공정그룹
        public string UseYN { get; set; }
        // 사용여부
        public string Remark { get; set; }
        // 비고
        public string Ins_Date { get; set; }
        // 최초입력일자
        public string Ins_Emp { get; set; }
        // 최초입력자
        public string Up_Date { get; set; }
        // 최종수정일자
        public string Up_Emp { get; set; }
        // 최종수정자
    }
}
