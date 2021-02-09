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
       static SqlConnection conn;
        public SelectDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        #endregion

        //WorkOrderVO
        public List<WorkOrderVO> SelectWorkOrder(string dtpFrom, string dtpTo, string processCode, string wcCode)
        {
            string sql = "select * from View_WorkOrder where 1=1 and Plan_Date between @dtpFrom and @dtpTo";
            if (!string.IsNullOrEmpty(processCode)) sql += " AND Process_Code = @Process_Code";
            if (!string.IsNullOrEmpty(wcCode)) sql += " AND Wc_Code = @Wc_Code";
            
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                if (!string.IsNullOrEmpty(processCode))
                    cmd.Parameters.AddWithValue("@Process_Code", processCode);
                if (!string.IsNullOrEmpty(wcCode))
                    cmd.Parameters.AddWithValue("@Wc_Code", wcCode);

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

        //GVHistory
        public List<GVHistoryVO> SelectGVHistory(string dtpFrom, string dtpTo)
        {
            string sql = "select * from View_ReceivingList where Loading_date between @dtpFrom and @dtpTo";
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

        //GV
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
        //GetAllItem
        public static List<ItemInfoVO> GetAllItem_Level_Master()
        {
            List<ItemInfoVO> ItemGroup = null;
            string sql = @"SELECT Level_Code
                                      , Level_Name
                                      , Item_lvl1
                                      , Item_lvl2
                                      , Item_lvl3
                                      , Item_lvl4
                                      , Item_lvl5
                                      , Box_Qty
                                      , Pcs_Qty
                                      , Mat_Qty
                                      , Use_YN
                                      , Ins_Date
                                      , Ins_Emp
                                      , Up_Date
                                      , Up_Emp
                                  FROM Item_Level_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemInfoVO> list = Helper.DataReaderMapToList<ItemInfoVO>(reader);

                conn.Close();
                return ItemGroup;
            }
        }

        public List<Item_MasterVO> GetAllItem_Master()
        {
            string sql = @"SELECT Item_Code
                                            , Item_Name
                                            , Item_Type
                                            , Item_Spec
                                            , Item_Unit
                                            , Level_1
                                            , Level_2
                                            , Level_3
                                            , Level_4
                                            , Level_5
                                            , Item_Stock
                                            , Lead_Time
                                            , LotSize
                                            , PrdQty_Per_Hour
                                            , PrdQTy_Per_Batch
                                            , Cavity
                                            , Line_Per_Qty
                                            , Shot_Per_Qty
                                            , Dry_GV_Qty
                                            , Heat_GV_Qty
                                            , Remark
                                            , Use_YN


                                            FROM Item_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Item_MasterVO> list = Helper.DataReaderMapToList<Item_MasterVO>(reader);

                conn.Close();
                return list;
            }

        }


        //Process
        public List<ProcessVO> SelectProcess()
        {
            string sql = " SELECT * from Process_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(reader);

                conn.Close();
                return list;
            }
        }

        //WorkCenter
        public List<WorkCenterVO> SelectWorkCenter()
        {
            string sql = " SELECT * from WorkCenter_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenterVO> list = Helper.DataReaderMapToList<WorkCenterVO>(reader);

                conn.Close();
                return list;
            }
        }

        //NOP
        public List<NOPVO> SelectNOP(string dtpFrom, string dtpTo)
        {
            string sql = "select * from View_NOP where Nop_Date between @dtpFrom and @dtpTo";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);

                SqlDataReader reader = cmd.ExecuteReader();
                List<NOPVO> list = Helper.DataReaderMapToList<NOPVO>(reader);

                conn.Close();
                return list;
            }
        }

        //WC,ITEM,GV,User Code,Name Select
        public List<T> SelectForPopup<T>(string type)
        {
            string sql;
            switch(type)
            {
                case "WC":
                    sql = "SELECT WC_Code,WC_Name FROM WorkCenter_Master"; break;
                case "Item":
                    sql = "SELECT Item_Code,Item_Name FROM Item_Master"; break;
                case "GV":
                    sql = "SELECT WC_Code,WC_Name FROM GV_Master"; break;
                case "User":
                    sql = "SELECT User_ID,User_Name FROM User_Master";break;
                case "Process":
                    sql = "SELECT Process_ID, Process_Name FROM Process_Master"; break;
                default: sql = null; break;
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<T> list = Helper.DataReaderMapToList<T>(reader);

                conn.Close();
                return list;
            }
        }
    }
}
