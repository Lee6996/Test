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

        #region 001
        public List<WorkOrderVO> Select_001()
        {
            string sql = "select * from View_WorkOrder";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }

        public bool Update_001(WorkOrderVO vo)
        {
            string sql = "update WorkOrder set Prd_Qty = @Prd_Qty where Workorderno = @Workorderno";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Workorderno", vo.Workorderno);
                cmd.Parameters.AddWithValue("@Prd_Qty", vo.Prd_Qty);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();
                if (iResult <= 0) return false;
                else return true;
            }
        }
        #endregion

        #region 002

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
        #endregion

        #region 009
        public List<WorkHistoryVO> Select_009()
        {
            string sql = "select * from View_WorkHistory";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkHistoryVO> list = Helper.DataReaderMapToList<WorkHistoryVO>(reader);

                conn.Close();
                return list;
            }
        }
        #endregion

        #region 010
        public DataTable Select_010_1(string Start_Date, string End_Date)
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

        public List<AttendanceManagementVO> Select_010_2()
        {
            string sql = "select * from View_AttendanceManagement";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<AttendanceManagementVO> list = Helper.DataReaderMapToList<AttendanceManagementVO>(reader);

                conn.Close();
                return list;
            }
        }
        #endregion
    }
}
