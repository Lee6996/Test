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
        public List<WorkOrderVO> SelectWorkOrder()
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

        //GoodsInHistory
        public List<GoodsInHistoryVO> SelectGoodsInHistory()
        {
            string sql = "select * from View_Pallet";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<GoodsInHistoryVO> list = Helper.DataReaderMapToList<GoodsInHistoryVO>(reader);

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


        //ItemLevelInfo
        public List<ItemInfoVO> SelectItemLevel()
        {
            string sql = "SELECT Level_Code, Level_Name, Item_lvl1, Item_lvl2, Item_lvl3, Item_lvl4, Item_lvl5, Box_Qty, Pcs_Qty, Mat_Qty, Use_YN   FROM Item_Level_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemInfoVO> list = Helper.DataReaderMapToList<ItemInfoVO>(reader);

                conn.Close();
                return list;
            }
        }
    }
}
