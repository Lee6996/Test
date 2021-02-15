using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVO
{
    public class Nop_MaVO
    {
        /// <summary>
        /// 비가동대분류코드
        /// </summary>
        public string Nop_Ma_Code { get; set; }      // 비가동대분류코드
        /// <summary>
        /// 비가동대분류명
        /// </summary>
        public string Nop_Ma_Name { get; set; }     // 비가동대분류명
        /// <summary>
        /// 사용유무
        /// </summary>
        public int Use_YN { get; set; }
        public string Ins_Date { get; set; }
        public string Ins_Emp { get; set; }
        public string Up_Date { get; set; }
        public string Up_Emp { get; set; }
    }
}
