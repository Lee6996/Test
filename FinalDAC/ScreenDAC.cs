using FinalEnc;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
        public List<ScreenVO> SelectScreenInfo(string screen_Code)
        {
            string sQuery = @"select Screen_Code, Screen_Name, Screen_Path,Type,  case when Use_YN='Y' then 1 else 0 end Use_YN, convert(char(19), Ins_Date, 21) Ins_Date , Ins_Emp, convert(char(19), Up_Date, 21) Up_Date, Up_Emp
                                from ScreenItem_Master where 1 = 1 ";

            if (!string.IsNullOrEmpty(screen_Code))
                sQuery += " and Screen_Code Like @screen_Code ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(screen_Code))
                    cmd.Parameters.AddWithValue("@screen_Code", "%" + screen_Code + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<ScreenVO> list = Helper.DataReaderMapToList<ScreenVO>(reader);
                return list;
            }
        }

        public bool UpdateScreenUseYN(ScreenVO vo)
        {
            string sQuery = @"update ScreenItem_Master set Use_YN = @Use_YN, Up_Date = @Up_Date where Screen_Code = @Screen_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Screen_Code", vo.Screen_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");
                cmd.Parameters.AddWithValue("@Up_Date", Convert.ToDateTime(vo.Up_Date));

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }
        //화면 코드 바인딩
        public DataTable SelectScreenBinding()
        {
            DataTable dtScreen = new DataTable();
            string sql = "select Screen_Code, Screen_Name from ScreenItem_Master";
            using(SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dtScreen);
            }
            return dtScreen;
        }
    }
}
