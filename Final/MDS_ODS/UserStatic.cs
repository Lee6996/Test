using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.MDS_SDS
{
    public static class UserStatic
    {
        //사용자ID
        public static string User_ID { get; set; }
        //사용자명
        public static string User_Name { get; set; }
        //사용자 패스워드
        public static string User_PW { get; set; }
        //거래처코드
        public static string Customer_Code { get; set; }
        //사용자구분
        public static  string User_Type { get; set; }
        //기본화면코드
        public static string Default_Screen_Code { get; set; }
        //기본공정코드
        public static string Default_Process_Code { get; set; }
        //모니터링사용여부
        public static string Monitoring_YN { get; set; }
        //사용여부
        public static string Use_YN { get; set; }
        //최초입력일자
        public static DateTime Ins_Date { get; set; }
        //최초입력자
        public static string Ins_Emp { get; set; }
        //최종수정 일자
        public static DateTime Up_Date { get; set; }
        //최종수정자
        public static string Up_Emp { get; set; }
    }
}

