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

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    SetLoginInfoVO(User_ID);
                    return true;
                }
                else return false;
            }
        }

        //사용자명 콤보박스 바인딩
        public DataTable SelectUserNameBinding()
        {

            DataTable dt = new DataTable();
            string sql = "select User_ID, User_Name from User_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }
        //기본공정 이름 콤보박스 바인딩
        public DataTable SelectDefaultProcessCodeBinding()
        {

            DataTable dt = new DataTable();
            string sql = @"select Default_Process_Code, Process_name
                           from User_Master inner join Process_Master on User_Master.Default_Process_Code = Process_Master.Process_code";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }
        //사용자등록
        public bool InsertUser(UserVO vo)
        {
            string sQuery = @"select count(*) 
                              from User_Master where 1 = 1 and User_ID = @userID and User_Name = @userName and User_PW = @userPwd and Default_Process_Code = @userProcessCode ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@userID", vo.User_ID);
                cmd.Parameters.AddWithValue("@userName", vo.User_Name);
                cmd.Parameters.AddWithValue("@userPwd", vo.User_PW);
                cmd.Parameters.AddWithValue("@userProcessCode", vo.Default_Process_Code);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"insert into User_Master (User_ID, User_Name, User_PW, Customer_Code, User_Type , Default_Screen_Code , Default_Process_Code, Monitoring_YN, Use_YN, Ins_Date, Ins_Emp,Up_Date, Up_Emp)
                                                 values(@userID, @userName, @userPwd, '1', '1', '1', @userProcessCode, 'Y', 'Y', getdate(), 'YGJ' ,sysdatetime(), 'YGJ') ";
                    cmd.CommandText = sQuery;

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
        }
    }
}
