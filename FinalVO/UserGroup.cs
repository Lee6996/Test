using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    /// <summary>
    /// UserGroup VO
    /// 2021_01_26 염경진
    /// </summary>
    public class UserGroup
    {
        //사용자 그룹 코드
        public string UserGroup_Code { get; set; }
        //사용자 그룹명
        public string UserGroup_Name { get; set; }
        //관리자권한 여부
        public char Admin { get; set; }
        //사용여부
        public char Use_YN { get; set; }
        //최초입력일자
        public DateTime Ins_Date { get; set; }
        //최초입력자
        public string Ins_Emp { get; set; }
        //최종수정 일자
        public DateTime Up_Date { get; set; }
        //최종수정자
        public string Up_Emp { get; set; }
    }
}
