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
    public class WorkCenter_MasterDAC
    {
        SqlConnection conn;
        public WorkCenter_MasterDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }

        public List<WorkCenter_Master2VO> WorkCenterSelect(string code)
        {
            string sQuery = @"SELECT Wc_Code
      ,Wc_Name
      ,Wc_Group
      ,Process_Code
      ,Wo_Status
      ,CONVERT(char(10), Last_Cnt_Time, 23) Last_Cnt_Time
      ,Prd_Req_Type
      ,Pallet_YN
      ,Item_Code
      ,Prd_Unit
      ,Mold_Setup_YN   ,Remark   
    ,case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23) Up_Date, Up_Emp
                                        FROM WorkCenter_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(code))
                sQuery += " and Wc_Code Like @Wc_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(code))
                    cmd.Parameters.AddWithValue("@Wc_Name", "%" + code + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenter_Master2VO> list = Helper.DataReaderMapToList<WorkCenter_Master2VO>(reader);
                return list;
            }
        }

        public bool InsertUpdateWC_Ma2VO(WorkCenterVO additem)
        {
            string sql = $@"IF NOT EXISTS(SELECT Wc_Code FROM WorkCenter_Master WHERE Wc_Code=@Wc_Code)
   BEGIN
		INSERT INTO [dbo].[WorkCenter_Master]
           ([Wc_Code],[Wc_Name],[Wc_Group] ,[Process_Code],[Auto_Wo_YN] ,[Auto_Start_YN],[ERP_IF_YN],[Wo_Status] ,[Nop_Auto_YN],[Nop_Check_Time]
            ,[Last_Cnt_Time],[Prd_Req_Type],[Pallet_YN] ,[Item_Code],[Prd_Unit],[Mold_Setup_YN]
           ,[In_Qty_Auto_YN] ,[Use_YN],[Remark],[Ins_Date],[Ins_Emp])
     VALUES
           (@Wc_Code ,@Wc_Name ,@Wc_Group ,@Process_Code ,'Y' ,'Y' ,'N' ,'Working' ,'N' ,0 ,GETDATE() ,'Type' ,'Y' ,'Cap0010' ,'Wo' ,'Y' ,'Y' ,'Y' ,@Remark ,GETDATE() ,'LYG')
		END
 ELSE
	 BEGIN
		UPDATE [dbo].[WorkCenter_Master]
   SET
      [Wc_Name] = @Wc_Name
      ,[Wc_Group] = @Wc_Group
      ,[Process_Code] = @Process_Code    
      ,[Remark] = @Remark      
      ,[Up_Date] = getdate()
      ,[Up_Emp] = 'LYG'
 WHERE Wc_Code = @Wc_Code
		  END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Wc_Code", additem.Wc_Code);
                cmd.Parameters.AddWithValue("@Wc_Name", additem.Wc_Name);
                cmd.Parameters.AddWithValue("@Wc_Group", additem.Wc_Group);
                cmd.Parameters.AddWithValue("@Process_Code", additem.Process_Code);
                cmd.Parameters.AddWithValue("@Remark", additem.Remark);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateUseYN(WorkCenter_Master2VO vo)
        {
            string sQuery = @"update WorkCenter_Master set Use_YN = @Use_YN where Wc_Code = @Wc_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Wc_Code", vo.Wc_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public List<WorkCenterVO> GetAllWorkCenter()
        {
            string sql = @"SELECT Wc_Code
      ,Wc_Name
      ,Wc_Group
      ,Process_Code
      ,Auto_Wo_YN
      ,Auto_Start_YN
      ,ERP_IF_YN
      ,Wo_Status
      ,Nop_Auto_YN
      ,Nop_Check_Time
      ,Last_Cnt_Time
      ,Prd_Req_Type
      ,Pallet_YN
      ,Item_Code
      ,Prd_Unit
      ,Mold_Setup_YN
      ,In_Qty_Auto_YN
      ,Use_YN
      ,Remark
      ,Ins_Date
      ,Ins_Emp
      ,Up_Date
      ,Up_Emp
  FROM WorkCenter_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenterVO> list = Helper.DataReaderMapToList<WorkCenterVO>(reader);

                conn.Close();
                return list;
            }
        }

        public DataTable WorkCenterBinding()
        {
            DataTable dt = new DataTable();
            string sql = "select Wc_Code, WC_Name from WorkCenter_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }
    }
}
