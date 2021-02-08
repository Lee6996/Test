using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class SysNoticeVO
    {
        //공지순번
        public int Seq { get; set; }
        //공지시작일자
        public string Notice_Date { get; set; }
        //공지종료일자
        public string Notice_End { get; set; }
        //공지제목
        public string Title { get; set; }
        //공지내역
        public string Description { get; set; }
        //공지참조
        public string Notice_Rtf { get; set; }
        //이메일참조
        public string Email_Recipients { get; set;  }
        //이메일 송부유형
        public string Email_Send_Code { get; set; }
        //사용여부
        public string Use_YN { get; set; }
        //비고
        public string Remark { get; set; }
        //최초입력일자
        public string Ins_Date { get; set; }
        //최초입력자
        public string Ins_Emp { get; set; }
        //최종수정일자
        public string Up_Date { get; set; }
        //최종수정자
        public string Up_Emp { get; set; }
    }
}
