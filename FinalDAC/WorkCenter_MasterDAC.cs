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

        public List<WorkCenterVO> WorkCenterSelect(string code)
        {
            string sQuery = @"SELECT Wc_Code
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
      ,Remark   
    ,case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23) Up_Date, Up_Emp
                                        FROM WorkCenter_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(code))
                sQuery += " and Wc_Name Like @Wc_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(code))
                    cmd.Parameters.AddWithValue("@Wc_Name", "%" + code + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenterVO> list = Helper.DataReaderMapToList<WorkCenterVO>(reader);
                return list;
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
