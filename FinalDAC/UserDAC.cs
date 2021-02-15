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
    public class UserDAC
    {
        SqlConnection conn;

        public UserDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }

        public void SetLoginInfoVO(string User_ID)
        {
            string sQuery = "SELECT User_Name FROM User_Master where 1=1 and User_ID = @User_ID";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@User_ID", User_ID);

                LoginInfoVO.User_ID = User_ID;
                LoginInfoVO.User_Name = cmd.ExecuteScalar().ToString();
            }
        }

        public bool CheckLoginAble(string User_ID, string User_PW)
        {
            string sQuery = "SELECT COUNT(*) FROM User_Master where 1=1 and User_ID = @User_ID and User_PW = @User_PW";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@User_ID", User_ID);
                cmd.Parameters.AddWithValue("@User_PW", User_PW);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    SetLoginInfoVO(User_ID);
                    return true;
                }
                else return false;
            }
        }
    }
}
