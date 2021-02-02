using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    // 가스사용량이력VO
    public class GasUseVO
    {
        public int Seq { get; set; }
        // 이력순번
        public string Std_Date { get; set; }
        // 기준일자
        public string Wc_Code { get; set; }
        // 작업장코드
        public int Gas_Val { get; set; }
        // 가스계랑치
        public int Dorm_Gas { get; set; }
        // 기숙사가스사용량
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
