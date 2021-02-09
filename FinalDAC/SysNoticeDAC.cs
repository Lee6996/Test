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
    public class SysNoticeDAC : IDisposable
    {
        SqlConnection conn;
        public SysNoticeDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        public List<SysNoticeVO> SelectUserGroupInfo(string usergoup_Code)
        {
            //애매한 부분 
            string sQuery = @"select Seq,convert(char(19), Notice_Date, 21) Notice_Date, convert(char(19), Notice_End, 21) Notice_End, Title, Description, Notice_Rtf, Email_Recipients, Email_Send_Code, 
                              case when Use_YN='Y' then 1 else 0 end Use_YN, Remark, convert(char(19), Ins_Date, 21) Ins_Date, Ins_Emp, convert(char(19), Up_Date, 21) Up_Date, Up_Emp
                              from Sys_Notice where 1 = 1 and Notice_Date between '2021-02-08' and '2021-02-08' and Notice_End between '2021-02-08 ";

            if (!string.IsNullOrEmpty(usergoup_Code))
                sQuery += " and UserGroup_Name Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(usergoup_Code))
                    cmd.Parameters.AddWithValue("@groupName", "%" + usergoup_Code + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<SysNoticeVO> list = Helper.DataReaderMapToList<SysNoticeVO>(reader);
                return list;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
