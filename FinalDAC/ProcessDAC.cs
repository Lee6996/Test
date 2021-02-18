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
    public class ProcessDAC
    {
        SqlConnection conn;
        public ProcessDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }

        public List<ProcessVO> GetAll_ProcessMaster(string pr)
        {
            string sQuery = @"SELECT Process_code
      ,Process_name,
Process_Group,
Remark,
      case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp
  FROM Process_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(pr))
                sQuery += " and Process_code Like @Process_name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(pr))
                    cmd.Parameters.AddWithValue("@Process_name", "%" + pr + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(reader);
                return list;
            }
        }

        public bool InsertUpdatePR_MaVO(ProcessVO additem)
        {
            string sql = $@"IF NOT EXISTS(SELECT [Process_code] FROM [Process_Master] WHERE [Process_code]=@Process_code)
   BEGIN
		INSERT INTO [Process_Master] ([Process_code],[Process_name],[Process_Group],[Remark],[Use_YN],[Ins_Date],[Ins_Emp] )      
		VALUES(@Process_code,@Process_name,@Process_Group,@Remark,'Y',GETDATE(),'TEST')
		END
 ELSE
	 BEGIN
		UPDATE [Process_Master] SET [Process_name]=@Process_name, [Process_Group] = @Process_Group, [Remark] = @Remark, Up_Date =GETDATE(), Up_Emp = 'test' 
		where [Process_code]=@Process_code
		  END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Process_code", additem.Process_code);
                cmd.Parameters.AddWithValue("@Process_name", additem.Process_name);
                cmd.Parameters.AddWithValue("@Process_Group", additem.Process_Group);
                cmd.Parameters.AddWithValue("@Remark", additem.Remark);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateUseYN(ProcessVO vo)
        {
            string sQuery = @"update Process_Master set Use_YN = @Use_YN where Process_code = @Process_code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Process_code", vo.Process_code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public List<ProcessVO> GetAllProcess()
        {
            string sql = @"SELECT Process_code
      ,Process_name
      ,Process_Group
      ,Use_YN
      ,Remark
      ,Ins_Date
      ,Ins_Emp
      ,Up_Date
      ,Up_Emp
  FROM Process_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(reader);

                conn.Close();
                return list;
            }
        }

        public DataTable PRBinding()
        {
            DataTable dt = new DataTable();
            string sql = "select Process_Name, Process_Code from Process_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ProcessBindingName()
        {
            DataTable dt = new DataTable();
            string sql = "select Process_Code, Process_Name from Process_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }
    }
}
