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
    public class Nop_MaDAC
    {
        #region Connection Open
        static SqlConnection conn;
        public Nop_MaDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        #endregion

        public List<Nop_MaVO> GetAllNop_Ma_Master(string nop)
        {
            string sQuery = @"SELECT Nop_Ma_Code
      ,Nop_Ma_Name
     ,case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp  
   FROM Nop_Ma_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(nop))
                sQuery += " and Nop_Ma_Code Like @Nop_Ma_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(nop))
                    cmd.Parameters.AddWithValue("@Nop_Ma_Name", "%" + nop + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<Nop_MaVO> list = Helper.DataReaderMapToList<Nop_MaVO>(reader);
                return list;
            }
        }

        public bool UpdateUseYN(Nop_MaVO vo)
        {
            string sQuery = @"update Nop_Ma_Master set Use_YN = @Use_YN where Nop_Ma_Code = @Nop_Ma_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", vo.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool InsertUpdateNop_MaVO(Nop_MaVO vo)
        {
            string sql = $@"IF NOT EXISTS(SELECT [Nop_Ma_Code] FROM [Nop_Ma_Master] WHERE [Nop_Ma_Code]=@Nop_Ma_Code)
   BEGIN
		INSERT INTO [Nop_Ma_Master] ([Nop_Ma_Code],[Nop_Ma_Name],[Use_YN],[Ins_Date],[Ins_Emp] )      
		VALUES(@Nop_Ma_Code,@Nop_Ma_Name,'Y',GETDATE(),'TEST')
		END
 ELSE
	 BEGIN
		UPDATE [Nop_Ma_Master] SET [Nop_Ma_Name]=@Nop_Ma_Name,Up_Date =GETDATE(), Up_Emp = 'test' 
		where [Nop_Ma_Code]=@Nop_Ma_Code
		  END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", vo.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", vo.Nop_Ma_Name);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateNop_Ma(Nop_MaVO vo)
        {         
                string sql = $@"UPDATE Nop_Ma_Master
   SET    
       Nop_Ma_Name = @Nop_Ma_Name     
      ,Up_Date = convert(char(10), GetDATE(), 23)
	   ,Up_Emp = 'test1' 
 WHERE Nop_Ma_Code = @Nop_Ma_Code";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nop_Ma_Code", vo.Nop_Ma_Code);
                    cmd.Parameters.AddWithValue("@Nop_Ma_Name", vo.Nop_Ma_Name);
                    //cmd.Parameters.AddWithValue("@Up_Emp", vo.Up_Emp);


                    if (cmd.ExecuteNonQuery() > 0) return true;
                    else return false;
                }       
        }

        public bool InsertNop_Ma(Nop_MaVO vo)
        {
            string sQuery = @"select count(*) 
                              from Nop_Ma_Master where 1 = 1 and Nop_Ma_Code = @Nop_Ma_Code and Nop_Ma_Name = @Nop_Ma_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", vo.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Ma_Name", vo.Nop_Ma_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"INSERT INTO Nop_Ma_Master
           (Nop_Ma_Code
           ,Nop_Ma_Name
           ,Use_YN
           ,Ins_Date
           ,Ins_Emp
           ,Up_Date
           ,Up_Emp)
     VALUES
           (@Nop_Ma_Code
           ,@Nop_Ma_Name
           ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.



                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Ins_Date);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Ins_Emp);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Up_Date);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Up_Emp);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
       
        public DataTable NopBinding()
            {
                DataTable dt = new DataTable();
                string sql = "select Nop_Ma_Name, Nop_Ma_Code from Nop_Ma_Master";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }

                return dt;
            }
        
    }
}
