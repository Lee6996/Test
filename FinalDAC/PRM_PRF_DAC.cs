using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalVO;

namespace FinalDAC
{
    public class PRM_PRF_DAC
    {
        SqlConnection conn;

        #region Connection Open
        public PRM_PRF_DAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        #endregion

        #region
        #endregion

        #region 001

        public bool Update_001(WorkOrderVO vo)
        {
            string sql = "update WorkOrder set Prd_Qty = @Prd_Qty, Up_Date = GETDATE(), Up_Emp = @Up_Emp where Workorderno = @Workorderno";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Workorderno", vo.Workorderno);
                cmd.Parameters.AddWithValue("@Prd_Qty", vo.Prd_Qty);
                cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID); 

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();
                if (iResult <= 0) return false;
                else return true;
            }
        }


        #endregion

        #region 002
        public bool UpdateWorkorderStatus(string workorderno)
        {
            string sql = "update WorkOrder set Wo_Status = 'End', Plan_Endtime = GETDATE(), Manager_CloseTime = GETDATE(),  Up_Date = GETDATE(), Up_Emp = @Up_Emp where Workorderno = @Workorderno";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Workorderno", workorderno);
                cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();
                if (iResult <= 0) return false;
                else return true;
            }
        }

        public bool UpdatePalletStatus(string palletno)
        {
            string sql = "update Goods_In_History set Colsed_YN = 'Y', Closed_Time = GETDATE(),  Up_Date = GETDATE(), Up_Emp = @Up_Emp where Pallet_No = @Pallet_No";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Pallet_No", palletno);
                cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();
                if (iResult <= 0) return false;
                else return true;
            }
        }

        #endregion

        #region 003

        #endregion

        #region 004
        #endregion

        #region 005
        #endregion

        #region 006
        #endregion

        #region 007
        #endregion

        #region 008
        public void InsertNop_History(NOPVO vo)
        {
            string iQuery = @"insert into Nop_History
                            (Nop_Date, Nop_Happentime, Nop_Canceltime, Wc_Code, Nop_Mi_Code, Nop_Type, Nop_Time, Remark, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
                             values
                            (GETDATE(), GETDATE(), null, @Wc_Code, @Nop_Mi_Code, @Nop_Type, @Nop_Time, @Remark, GETDATE(), @Ins_Emp, GETDATE(), @Up_Emp)";
            using (SqlCommand cmd = new SqlCommand(iQuery, conn))
            {
                cmd.Parameters.AddWithValue("Wc_Code", vo.Wc_Code);
                cmd.Parameters.AddWithValue("Nop_Mi_Code", vo.Nop_Mi_Code);
                cmd.Parameters.AddWithValue("Nop_Type", vo.Nop_Type);
                cmd.Parameters.AddWithValue("Nop_Time", vo.Nop_Time); 
                cmd.Parameters.AddWithValue("Remark", vo.Remark); 
                cmd.Parameters.AddWithValue("Ins_Emp", LoginInfoVO.User_ID);
                cmd.Parameters.AddWithValue("Up_Emp", LoginInfoVO.User_ID);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
            }
        }
        #endregion

        #region 009
        public List<WorkOrderVO> Select_009()
        {
            string sql = "select * from View_WorkHistory";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }
        #endregion

        #region 010
        public DataTable SelectWorkHistoryPivot(string Start_Date, string End_Date)
        {
            using (SqlCommand cmd = new SqlCommand("sp_WorkHistory_Pivot", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Start_Date", Start_Date);
                cmd.Parameters.AddWithValue("@End_Date", End_Date);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        #endregion
    }
}
