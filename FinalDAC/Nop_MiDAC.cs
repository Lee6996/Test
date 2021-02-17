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

        public bool InsertNop_Mi(Nop_MiVO additem)
        {
            string sQuery = @"select count(*) 
                              from Nop_Mi_Master where 1 = 1 and Nop_Mi_Code = @Nop_Mi_Code and Nop_Mi_Name = @Nop_Mi_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", additem.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Name", additem.Nop_Mi_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"INSERT INTO Nop_Mi_Master
           (Nop_Mi_Code
           ,Nop_Mi_Name
           ,Nop_Ma_Code
           
           ,Remark
,Use_YN
           ,Ins_Date
           ,Ins_Emp
           ,Up_Date
           ,Up_Emp)
     VALUES
           (@Nop_Mi_Code
           ,@Nop_Mi_Name
           ,@Nop_Ma_Code           
           ,@Remark          
           ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.
                    cmd.Parameters.AddWithValue("@Nop_Ma_Code", additem.Nop_Ma_Code);
                    cmd.Parameters.AddWithValue("@Remark", additem.Remark);
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

        public bool UpdateUseYN(Nop_MiVO vo)
        {
            string sQuery = @"update Nop_Mi_Master set Use_YN = @Use_YN where Nop_Mi_Code = @Nop_Mi_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", vo.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool InsertUpdateNop_MiVO(Nop_MiVO additem)
        {
            string sql = $@"IF NOT EXISTS(SELECT [Nop_Mi_Code] FROM [Nop_Mi_Master] WHERE [Nop_Mi_Code]=@Nop_Mi_Code)
   BEGIN
		INSERT INTO [Nop_Mi_Master] ([Nop_Mi_Code],[Nop_Mi_Name],[Nop_Ma_Code],[Remark],[Use_YN],[Ins_Date],[Ins_Emp] )      
		VALUES(@Nop_Mi_Code,@Nop_Mi_Name,@Nop_Ma_Code,@Remark,'Y',GETDATE(),'TEST')
		END
 ELSE
	 BEGIN
		UPDATE [Nop_Mi_Master] SET [Nop_Mi_Name]=@Nop_Mi_Name, [Remark] = @Remark, Up_Date =GETDATE(), Up_Emp = 'test' 
		where [Nop_Mi_Code]=@Nop_Mi_Code
		  END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", additem.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Name", additem.Nop_Mi_Name);
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", additem.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Remark", additem.Remark);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateNop_Mi(Nop_MiVO additem)
        {
            string sql = $@"UPDATE Nop_Mi_Master
   SET 
      Nop_Ma_Code = @Nop_Ma_Code
      ,Nop_Mi_Name = @Nop_Mi_Name 
      ,Remark = @Remark           
      ,Up_Date = convert(char(10), GetDATE(), 23)
	   ,Up_Emp = 'test1' 
 WHERE Nop_Mi_Code = @Nop_Mi_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nop_Mi_Code", additem.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("@Nop_Mi_Name", additem.Nop_Mi_Name);
                cmd.Parameters.AddWithValue("@Nop_Ma_Code", additem.Nop_Ma_Code);
                cmd.Parameters.AddWithValue("@Remark", additem.Remark);
                //cmd.Parameters.AddWithValue("@Up_Emp", vo.Up_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }
        #endregion

        public List<Nop_MiVO> GetAllNop_Mi_Master(string nop)
            {
                string sQuery = @"SELECT Nop_Mi_Code
      ,Nop_Mi_Name
      ,Nop_Ma_Code
       ,Remark,
     case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp
  FROM Nop_Mi_Master where 1 = 1  ";

                if (!string.IsNullOrEmpty(nop))
                    sQuery += " and Nop_Ma_Code Like @Nop_Mi_Name ";

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
