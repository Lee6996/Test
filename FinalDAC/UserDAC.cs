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
    public class UserDAC : IDisposable
    {
        SqlConnection conn;

        public UserDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString);
            conn.Open();
        }
        public List<UserVO> SelectUserGroupInfo(string usergoup_Name)
        {
            string sQuery = @"select User_ID, User_Name, User_PW, Customer_Code, User_Type, Default_Screen_Code, Default_Process_Code, Monitoring_YN, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp
                                from User_Master where 1=1 ";

            if (!string.IsNullOrEmpty(usergoup_Name))
                sQuery += " and UserGroup_Name Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(usergoup_Name))
                    cmd.Parameters.AddWithValue("@groupName", "%" + usergoup_Name + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserVO> list = Helper.DataReaderMapToList<UserVO>(reader);
                return list;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
