using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using FinalVO;

namespace FinalDAC
{
    public class UserGroupDAC : IDisposable
    {
        SqlConnection conn;

        public UserGroupDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString);
            conn.Open();
        }
        public List<UserGroupVO> SelectUserGroupInfo(string usergoup_Name)
        {
            string sQuery = @"select UserGroup_Code, UserGroup_Name, Admin, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp 
                              from UserGroup_Master where 1 = 1 ";

            if (!string.IsNullOrEmpty(usergoup_Name))
                sQuery += " and UserGroup_Name Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(usergoup_Name))
                    cmd.Parameters.AddWithValue("@groupName", "%" + usergoup_Name + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupVO> list = Helper.DataReaderMapToList<UserGroupVO>(reader);
                return list;
            }
        }
        //public List<UserGroupVO> InsertUserGroup()

        public void Dispose()
        {
            conn.Close();
        }
    }
}
