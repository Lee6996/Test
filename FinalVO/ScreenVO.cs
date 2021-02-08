using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class ScreenVO
    {
        //화면 코드
        public string Screen_Code { get; set; }
        //화면타입
        public string Type { get; set; }
        //화면경로
        public string Screen_Path { get; set; }
        //사용여부
        public int Use_YN { get; set; }
        //최초입력일자
        public string Ins_Date { get; set; }
        //최초입력자
        public string Ins_Emp { get; set; }
        //최종수정 일자
        public string Up_Date { get; set; }
        //최종수정자
        public string Up_Emp { get; set; }
    }
}
