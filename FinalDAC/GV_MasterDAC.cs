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
    public class GV_MasterDAC
    {
        #region Connection Open
        static SqlConnection conn;       

        public GV_MasterDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        #endregion

        public List<GVMasterVO> GetAllGV_Master(string gv)
        {
            string sQuery = @"SELECT [GV_Code]
      ,[GV_Name]
      ,[GVGroup_Code]
      ,[GV_Status]
      ,case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp
  FROM [dbo].[GV_Master]  where 1 = 1 ";

            if (!string.IsNullOrEmpty(gv))
                sQuery += " and GV_Code Like @GV_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(gv))
                    cmd.Parameters.AddWithValue("@GV_Name", "%" + gv + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<GVMasterVO> list = Helper.DataReaderMapToList<GVMasterVO>(reader);
                return list;
            }
        }

        public bool InsertUpdateGV_Ma(GVMasterVO vo)
        {
            string sql = $@"IF NOT EXISTS(SELECT [GV_Code] FROM [GV_Master] WHERE [GV_Code]=@GV_Code)
   BEGIN
		INSERT INTO [GV_Master] ([GV_Code],[GV_Name], [GVGroup_Code], [GV_Status] ,[Use_YN],[Ins_Date],[Ins_Emp] )      
		VALUES(@GV_Code, @GV_Name, @GVGroup_Code, @GV_Status, 'Y',GETDATE(),'TEST')
		END
 ELSE
	 BEGIN
		UPDATE [GV_Master] SET [GV_Name]=@GV_Name, [GVGroup_Code] = @GVGroup_Code, [GV_Status] = @GV_Status, Up_Date =GETDATE(), Up_Emp = 'test' 
		where [GV_Code]=@GV_Code
		  END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@GV_Code", vo.GV_Code);
                cmd.Parameters.AddWithValue("@GV_Name", vo.GV_Name);
                cmd.Parameters.AddWithValue("@GVGroup_Code", vo.GVGroup_Code);
                cmd.Parameters.AddWithValue("@GV_Status", vo.GV_Status);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateUseYN(GVMasterVO vo)
        {
            string sQuery = @"update GV_Master set Use_YN = @Use_YN where GV_Code = @GV_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@GV_Code", vo.GV_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateGV_Master(GVMasterVO vo)
        {
            string sql = $@"UPDATE GV_Master
   SET 
      GVGroup_Code = @GVGroup_Code
      ,GV_Name = @GV_Name 
               
      ,Up_Date = convert(char(10), GetDATE(), 23)
	   ,Up_Emp = 'test1' 
 WHERE GV_Code = @GV_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@GV_Code", vo.GV_Code);
                cmd.Parameters.AddWithValue("@GV_Name", vo.GV_Name);
                cmd.Parameters.AddWithValue("@GVGroup_Code", vo.GVGroup_Code);

                //cmd.Parameters.AddWithValue("@Up_Emp", vo.Up_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public DataTable GVBinding()
        {
            DataTable dt = new DataTable();
            string sql = "select GV_Name, GV_Code from GV_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }
        public bool InsertGV_Master(GVMasterVO vo)
        {
            string sQuery = @"select count(*) 
                              from GV_Master where 1 = 1 and GV_Code = @GV_Code and GV_Name = @GV_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Grade_Detail_Code", vo.GV_Code);
                cmd.Parameters.AddWithValue("@Grade_Detail_Name", vo.GV_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"[dbo].[GV_Master]
           ([GV_Code]
           ,[GV_Name]
           ,[GVGroup_Code]
           ,[Use_YN]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (@GV_Code
           ,@GV_Name
           ,@GVGroup_Code 
           ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.
                    cmd.Parameters.AddWithValue("@GVGroup_Code", vo.GVGroup_Code);
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
