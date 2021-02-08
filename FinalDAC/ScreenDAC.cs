using FinalEnc;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDAC
{
    public class ScreenDAC
    {
        SqlConnection conn;
        public ScreenDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        public List<ScreenVO> SelectScreenInfo(string screen_Name)
        {
            string sQuery = @"select Screen_Code, Screen_Path,Type,  case when Use_YN='Y' then 1 else 0 end Use_YN, convert(char(19), Ins_Date, 21) Ins_Date , Ins_Emp, Up_Date, Up_Emp
                                from ScreenItem_Master where 1 = 1 ";

            //화면 이름 추가 할 것
            if (!string.IsNullOrEmpty(screen_Name))
                sQuery += " and UserGroup_Name Like @screen_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(screen_Name))
                    cmd.Parameters.AddWithValue("@screen_Name", "%" + screen_Name + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<ScreenVO> list = Helper.DataReaderMapToList<ScreenVO>(reader);
                return list;
            }
        }

        public bool UpdateScreenUseYN(ScreenVO vo)
        {
            string sQuery = @"update ScreenItem_Master set Use_YN = @Use_YN where Screen_Code = @Screen_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Screen_Code", vo.Screen_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
