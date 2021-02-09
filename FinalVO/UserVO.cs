using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class UserVO
    {
        //사용자ID
        public string User_ID { get; set; }
        //사용자명
        public string User_Name { get; set; }
        //사용자 패스워드
        public string User_PW { get; set; }
        //거래처코드
        public string Customer_Code { get; set; }
        //사용자구분
        public string User_Type { get; set; }
        //기본화면코드
        public string Default_Screen_Code { get; set; }
        //기본공정코드
        public string Default_Process_Code { get; set; }
        //모니터링사용여부
        public string Monitoring_YN { get; set; }
        //사용여부
        public string Use_YN { get; set; }
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
