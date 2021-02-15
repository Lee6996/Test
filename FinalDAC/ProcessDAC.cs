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
