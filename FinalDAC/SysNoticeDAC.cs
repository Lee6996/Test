using FinalVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
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
        //공지사항 추가
        public bool InsertSysNotice(SysNoticeVO vo)
        {
            string sQuery = @"insert into Sys_Notice (Title, Notice_Date, Notice_End, Description , Notice_Rtf,Use_YN, Ins_Emp, Up_Date, Up_Emp)
                                values(@title, @noticeDate, @noticeEnd, @description, @noticeRtf, 'Y', 'test', getdate(), 'test') ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@title", vo.Title);
                cmd.Parameters.AddWithValue("@noticeDate", vo.Notice_Date);
                cmd.Parameters.AddWithValue("@noticeEnd", vo.Notice_End);
                cmd.Parameters.AddWithValue("@description", vo.Description);
                cmd.Parameters.AddWithValue("@noticeRtf", vo.Notice_Rtf);
                //cmd.Parameters.AddWithValue("@Ins_Emp", LoginInfoVO.User_ID);
                //cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }
        //공지사항 수정
        public bool UpdateSysNotice(SysNoticeVO vo)
        {
            string sQuery = @"update Sys_Notice set Notice_Date = @noticeDate , Notice_End = @noticeEnd, Title = @title, Description =  @description, Up_Date= getdate() where Seq = @seq";

            using(SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@noticeDate", vo.Notice_Date);
                cmd.Parameters.AddWithValue("@noticeEnd", vo.Notice_End);
                cmd.Parameters.AddWithValue("@title", vo.Title);
                cmd.Parameters.AddWithValue("@description", vo.Description);
                cmd.Parameters.AddWithValue("@seq", vo.Seq);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();
                if (iResult <= 0) return false;
                else
                    return true;
            }
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
