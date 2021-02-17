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
    public class BoxingGrade_Detail_MasterDAC
    {
        #region Connection Open
        static SqlConnection conn;
        public BoxingGrade_Detail_MasterDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        #endregion
        public List<BoxingGrade_Detail_MasterVO> GetAllBox_Detail_Master(string box)
        {
            string sQuery = @"  SELECT [Grade_Detail_Code]
          ,[Grade_Detail_Name]
          ,[Boxing_Grade_Code]
          ,case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp
      FROM [dbo].[BoxingGrade_Detail_Master] where 1 = 1  ";

            if (!string.IsNullOrEmpty(box))
                sQuery += " and Boxing_Grade_Code Like @Grade_Detail_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(box))
                    cmd.Parameters.AddWithValue("@Grade_Detail_Name", "%" + box + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<BoxingGrade_Detail_MasterVO> list = Helper.DataReaderMapToList<BoxingGrade_Detail_MasterVO>(reader);
                return list;
            }
        }

        public bool InsertUpdateBox_DetailVO(BoxingGrade_Detail_MasterVO additem)
        {
            string sql = $@"IF NOT EXISTS(SELECT [Grade_Detail_Code] FROM [BoxingGrade_Detail_Master] WHERE [Grade_Detail_Code]=@Grade_Detail_Code)
   BEGIN
		INSERT INTO [BoxingGrade_Detail_Master] ([Grade_Detail_Code],[Grade_Detail_Name],[Boxing_Grade_Code],[Use_YN],[Ins_Date],[Ins_Emp] )      
		VALUES(@Grade_Detail_Code,@Grade_Detail_Name,@Boxing_Grade_Code,'Y',GETDATE(),'TEST')
		END
 ELSE
	 BEGIN
		UPDATE [BoxingGrade_Detail_Master] SET [Grade_Detail_Name]=@Grade_Detail_Name, Up_Date =GETDATE(), Up_Emp = 'test' 
		where [Grade_Detail_Code]=@Grade_Detail_Code
		  END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Grade_Detail_Code", additem.Grade_Detail_Code);
                cmd.Parameters.AddWithValue("@Grade_Detail_Name", additem.Grade_Detail_Name);
                cmd.Parameters.AddWithValue("@Boxing_Grade_Code", additem.Boxing_Grade_Code);                

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public List<BoxingGrade_Detail_MasterVO> GetAllBoxMa(string box)
        {
            string sQuery = @"SELECT [Boxing_Grade_Code]
      ,[Boxing_Grade_Name]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]
  FROM [dbo].[BoxingGrade_Master] where 1 = 1  ";

            if (!string.IsNullOrEmpty(box))
                sQuery += " and Boxing_Grade_Code Like @Boxing_Grade_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(box))
                    cmd.Parameters.AddWithValue("@Boxing_Grade_Name", "%" + box + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<BoxingGrade_Detail_MasterVO> list = Helper.DataReaderMapToList<BoxingGrade_Detail_MasterVO>(reader);
                return list;
            }
        }

        public bool UpdateBox_Detail(BoxingGrade_Detail_MasterVO additem)
        {
            string sql = $@"UPDATE BoxingGrade_Detail_Master
   SET 
      Boxing_Grade_Code = @Boxing_Grade_Code
      ,Grade_Detail_Name = @Grade_Detail_Name 
               
      ,Up_Date = convert(char(10), GetDATE(), 23)
	   ,Up_Emp = 'test1' 
 WHERE Grade_Detail_Code = @Grade_Detail_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Grade_Detail_Code", additem.Grade_Detail_Code);
                cmd.Parameters.AddWithValue("@Grade_Detail_Name", additem.Grade_Detail_Name);
                cmd.Parameters.AddWithValue("@Boxing_Grade_Code", additem.Boxing_Grade_Code);
                
                //cmd.Parameters.AddWithValue("@Up_Emp", vo.Up_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public bool InsertBox_Detail(BoxingGrade_Detail_MasterVO additem)
        {
            string sQuery = @"select count(*) 
                              from BoxingGrade_Detail_Master where 1 = 1 and Grade_Detail_Code = @Grade_Detail_Code and Grade_Detail_Name = @Grade_Detail_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Grade_Detail_Code", additem.Grade_Detail_Code);
                cmd.Parameters.AddWithValue("@Grade_Detail_Name", additem.Grade_Detail_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"[dbo].[BoxingGrade_Detail_Master]
           ([Grade_Detail_Code]
           ,[Grade_Detail_Name]
           ,[Boxing_Grade_Code]
           ,[Use_YN]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (@Grade_Detail_Code
           ,@Grade_Detail_Name
           ,@Boxing_Grade_Code 
           ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.
                    cmd.Parameters.AddWithValue("@Boxing_Grade_Code", additem.Boxing_Grade_Code);
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
    }
}
