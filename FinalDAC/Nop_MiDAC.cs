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
    public class Nop_MiDAC
    {
        #region Connection Open
        static SqlConnection conn;
        public Nop_MiDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        #endregion
        
            public List<Nop_MiVO> GetAllNop_Mi_Master(string nop)
            {
                string sQuery = @"SELECT Nop_Mi_Code
      ,Nop_Mi_Name
      ,Nop_Ma_Code
      ,Use_YN
      ,Remark
      ,Ins_Date
      ,Ins_Emp
      ,Up_Date
      ,Up_Emp
  FROM Nop_Mi_Master where 1 = 1  ";

                if (!string.IsNullOrEmpty(nop))
                    sQuery += " and Nop_Mi_Code Like @Nop_Mi_Name ";

                using (SqlCommand cmd = new SqlCommand(sQuery, conn))
                {
                    if (!string.IsNullOrEmpty(nop))
                        cmd.Parameters.AddWithValue("@Nop_Mi_Name", "%" + nop + "%"); //포함하는 문자열

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Nop_MiVO> list = Helper.DataReaderMapToList<Nop_MiVO>(reader);
                    return list;
                }
            }
        
    }
}
