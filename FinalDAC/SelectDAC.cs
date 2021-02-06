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
    public class SelectDAC
    {
        #region Connection Open
        SqlConnection conn;
        public SelectDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["team2"].ConnectionString);
            conn.Open();
        }
        #endregion

        //WorkOrderVO
        public List<WorkOrderVO> SelectWorkOrder(string dtpFrom, string dtpTo)
        {
            string sql = "select * from View_WorkOrder where 1=1 and Plan_Date between @dtpFrom and @dtpTo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }

        //GoodsInHistory
        public List<GoodsInHistoryVO> SelectGoodsInHistory(string workorderno)
        {
            string sql = "select * from View_Pallet";
            if (!string.IsNullOrEmpty(workorderno))
            {
                sql += " where Workorderno = @workorderno";
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(workorderno))
                {
                    cmd.Parameters.AddWithValue("@workorderno", workorderno);
                }
                
                SqlDataReader reader = cmd.ExecuteReader();
                List<GoodsInHistoryVO> list = Helper.DataReaderMapToList<GoodsInHistoryVO>(reader);

                conn.Close();
                return list;
            }
        }

        //ReceivingListVO
        public List<ReceivingListVO> SelectReceivingListVO(string dtpFrom, string dtpTo)
        {
            string sql = "select * from View_ReceivingList where In_Date between @dtpFrom and @dtpTo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);

                SqlDataReader reader = cmd.ExecuteReader();
                List<ReceivingListVO> list = Helper.DataReaderMapToList<ReceivingListVO>(reader);

                conn.Close();
                return list;
            }
        }

        //WorkHistory
        public List<WorkHistoryVO> SelectWorkHistory()
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

        //AttendanceManagement
        public List<AttendanceManagementVO> SelectAttendanceManagement()
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

        //UserGroup
        public List<UserVO> SelectUserMasterInfo(string usergroup_Name)
        {
            string sQuery = @"select User_ID, User_Name, User_PW, Customer_Code, User_Type, Default_Screen_Code, Default_Process_Code, Monitoring_YN, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp
                                from User_Master where 1=1 ";

            if (!string.IsNullOrEmpty(usergroup_Name))
                sQuery += " and UserGroup_Name Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(usergroup_Name))
                    cmd.Parameters.AddWithValue("@groupName", "%" + usergroup_Name + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserVO> list = Helper.DataReaderMapToList<UserVO>(reader);
                return list;
            }
        }

        //UserGroup
        public List<UserGroupVO> SelectUserGroup(string usergroup_Name)
        {
            string sQuery = @"select UserGroup_Code, UserGroup_Name, Admin, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp 
                              from UserGroup_Master where 1 = 1 ";

            if (!string.IsNullOrEmpty(usergroup_Name))
                sQuery += " and UserGroup_Name Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(usergroup_Name))
                    cmd.Parameters.AddWithValue("@groupName", "%" + usergroup_Name + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserGroupVO> list = Helper.DataReaderMapToList<UserGroupVO>(reader);
                return list;
            }
        }

        public List<GVStatusVO> SelectGVStatus()
        {
            string sql = "select * from View_GVStatus";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<GVStatusVO> list = Helper.DataReaderMapToList<GVStatusVO>(reader);

                conn.Close();
                return list;
            }
        }

        public List<GVHistoryVO> SelectGVHistory(string dtpFrom, string dtpTo)
        {
            string sql = "select * from View_GVHistory where Loading_Date between @dtpFrom and @dtpTo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);

                SqlDataReader reader = cmd.ExecuteReader();
                List<GVHistoryVO> list = Helper.DataReaderMapToList<GVHistoryVO>(reader);

                conn.Close();
                return list;
            }
        }
    }
}
