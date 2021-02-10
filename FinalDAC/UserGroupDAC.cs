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
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        public List<UserGroupVO> SelectUserGroupInfo(string usergoup_Code)
        {
            string sQuery = @"select UserGroup_Code, UserGroup_Name, Admin, case when Use_YN='Y' then 1 else 0 end Use_YN, convert(char(23), Ins_Date, 21) Ins_Date , Ins_Emp, convert(char(23), Up_Date, 21) Up_Date, Up_Emp
                                from UserGroup_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(usergoup_Code))
                sQuery += " and UserGroup_Code Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(usergoup_Code))
                    cmd.Parameters.AddWithValue("@groupName", "%" + usergoup_Code + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupVO> list = Helper.DataReaderMapToList<UserGroupVO>(reader);
                return list;
            }
        }
        //같은 내용 있는지 검색
        public List<UserGroupVO> SelectUserGroupInfo(string usergroup_code, string usergroup_Name)
        {
            string sQuery = @"select UserGroup_Code, UserGroup_Name, Admin, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp 
                              from UserGroup_Master where 1 = 1 and UserGroup_Name = @groupCode and UserGroup_Name = @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@groupCode", usergroup_code);
                cmd.Parameters.AddWithValue("@groupName", usergroup_Name);

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupVO> list = Helper.DataReaderMapToList<UserGroupVO>(reader);
                return list;
            }
        }
        //나중에 로그인 기능 추가시에 최종수정자(Up_Emp)를 아이디로 해줘야 함
        public bool InsertUserGroup( UserGroupVO vo)
        {
            string sQuery = @"select count(*) 
                              from UserGroup_Master where 1 = 1 and UserGroup_Code = @groupCode and UserGroup_Name = @groupName ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@groupCode", vo.UserGroup_Code);
                cmd.Parameters.AddWithValue("@groupName", vo.UserGroup_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"insert into UserGroup_Master (UserGroup_Code, UserGroup_Name, Admin, Use_YN, Ins_Date, Ins_Emp,Up_Date, Up_Emp)
                                values(@groupCode, @groupName, 'Y', 'Y', getdate(), 'test' ,sysdatetime(), 'test') ";
                    cmd.CommandText = sQuery;

                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
        }

        public bool UpdateUserGroup(UserGroupVO vo)
        {
            string sQuery = @"update UserGroup_Master set Use_YN = @Use_YN where UserGroup_Code = @UserGroup_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@UserGroup_Code", vo.UserGroup_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }
        public DataTable SelectUserGroupNameBinding()
        {
            
            DataTable dt = new DataTable();
                string sql = "select UserGroup_Name, UserGroup_Code from UserGroup_Master";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            
            return dt;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
