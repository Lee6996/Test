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
        public List<ReceivingListVO> SelectReceivingListVO(string dtpFrom, string dtpTo, string itemCode = null)
        {
            string sql = "select * from View_ReceivingList where In_Date between @dtpFrom and @dtpTo";
            if (!string.IsNullOrEmpty(itemCode))
            {
                sql += " and Item_Code = @Item_Code";
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                if (!string.IsNullOrEmpty(itemCode))
                {
                    cmd.Parameters.AddWithValue("@Item_Code", itemCode);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                List<ReceivingListVO> list = Helper.DataReaderMapToList<ReceivingListVO>(reader);

                conn.Close();
                return list;
            }
        }

        //WorkHistory
        public List<WorkHistoryVO> SelectWorkHistory(string dtpFrom, string dtpTo, string Wc_Name)
        {
            string sql = "select * from View_WorkHistory where Work_Date between @dtpFrom and @dtpTo ";
            if (!string.IsNullOrEmpty(Wc_Name))
            {
                sql += " where Wc_Name = @Wc_Name";
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                if (!string.IsNullOrEmpty(Wc_Name))
                {
                    cmd.Parameters.AddWithValue("@Wc_Name", Wc_Name);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkHistoryVO> list = Helper.DataReaderMapToList<WorkHistoryVO>(reader);

                conn.Close();
                return list;
            }
        }

        //AttendanceManagement
        public List<AttendanceManagementVO> SelectAttendanceManagement(string dtpFrom, string dtpTo, string user_Name)
        {
            string sql = "select * from View_AttendanceManagement where Work_Date between @dtpFrom and @dtpTo ";
            if (!string.IsNullOrEmpty(user_Name))
            {
                sql += " where user_Name = @user_Name";
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(user_Name))
                {
                    cmd.Parameters.AddWithValue("@user_Name", user_Name);
                }
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
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
        public List<GVHistoryVO> SelectGVHistory(string dtpFrom, string dtpTo, string GV_Code, string Item_Code)
        {
            string sQuery = "select * from View_GVHistory where Loading_date between @dtpFrom and @dtpTo";
            if (!string.IsNullOrEmpty(GV_Code))
                sQuery += " and GV_Code = @GV_Code ";
            if (!string.IsNullOrEmpty(Item_Code))
                sQuery += " and Item_Code Like @Item_Code ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                if (!string.IsNullOrEmpty(GV_Code))
                    cmd.Parameters.AddWithValue("@GV_Code", GV_Code);
                if (!string.IsNullOrEmpty(Item_Code))
                    cmd.Parameters.AddWithValue("@Item_Code", Item_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<GVHistoryVO> list = Helper.DataReaderMapToList<GVHistoryVO>(reader);

                conn.Close();
                return list;
            }
        }

        //GV
        public List<GVStatusVO> SelectGVStatus(string GVGroup_Code, string Item_Code)
        {
            string sQuery = "select * from View_GVStatus where 1=1 ";

            if (!string.IsNullOrEmpty(GVGroup_Code))
                sQuery += " and GVGroup_Code Like @GVGroup_Code ";
            if (!string.IsNullOrEmpty(Item_Code))
                sQuery += " and Item_Code Like @Item_Code ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(GVGroup_Code))
                    cmd.Parameters.AddWithValue("@GVGroup_Code", GVGroup_Code);
                if (!string.IsNullOrEmpty(Item_Code))
                    cmd.Parameters.AddWithValue("@Item_Code", Item_Code);

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
        //GetAllItemMaster
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
        //GetAllDef_Ma_Master
        public static List<Def_MaVO> GetAllDef_Ma_Master()
        {
            List<Def_MaVO> defMa = null;
            string sql = @"SELECT Def_Ma_Code
                                         ,Def_Ma_Name
                                         ,Use_YN
                                         ,Ins_Date
                                         ,Ins_Emp
                                         ,Up_Date
                                         ,Up_Emp
                                     FROM Def_Ma_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                SqlDataReader reader = cmd.ExecuteReader();
                List<Def_MaVO> list = Helper.DataReaderMapToList<Def_MaVO>(reader);

                conn.Close();
                return defMa;
            }
        }

        //Process
        public List<ProcessVO> SelectProcess(string Prd_Date)
        {
            string sql = " SELECT * from View_Process_Master where Prd_Date = @Prd_Date";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProcessVO> list = Helper.DataReaderMapToList<ProcessVO>(reader);

                conn.Close();
                return list;
            }
        }

        //WorkCenter
        public List<WorkCenterVO> SelectWorkCenter(string Prd_Date)
        {
            string sql = " SELECT * from View_WorkCenter_Master where Prd_Date = @Prd_Date";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenterVO> list = Helper.DataReaderMapToList<WorkCenterVO>(reader);

                conn.Close();
                return list;
            }
        }

        //NOP
        public List<NOPVO> SelectNOP(string dtpFrom = null, string dtpTo = null, string WC_Code = null)
        {
            string sQuery = "select * from View_NOP";

            if (!string.IsNullOrEmpty(dtpFrom) && !string.IsNullOrEmpty(dtpTo))
                sQuery += " where Nop_Date between @dtpFrom and @dtpTo";

            if (!string.IsNullOrEmpty(WC_Code))
                sQuery += " and WC_Code Like @WC_Code ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(dtpFrom) && !string.IsNullOrEmpty(dtpTo))
                {
                    cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                    cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                }

                if (!string.IsNullOrEmpty(WC_Code))
                    cmd.Parameters.AddWithValue("@WC_Code", WC_Code);

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
            switch (type)
            {
                case "WC":
                    sql = "SELECT WC_Code,WC_Name FROM WorkCenter_Master"; break;
                case "Item":
                    sql = "SELECT Item_Code,Item_Name FROM Item_Master"; break;
                case "GV":
                    sql = "SELECT GV_Code,GV_Name FROM GV_Master"; break;
                case "GVGroup":
                    sql = "SELECT GVGroup_Code,GVGroup_Name FROM GVGruop_Master"; break;
                case "User":
                    sql = "SELECT User_ID,User_Name FROM User_Master"; break;
                case "Process":
                    sql = "SELECT Process_Code, Process_Name FROM Process_Master"; break;
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
        public List<WorkDayVO> SelectWorkDay(string Prd_Date)
        {
            string sql = " SELECT * from View_WorkDay where Prd_Date = @Prd_Date";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@Prd_Date", Prd_Date);
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkDayVO> list = Helper.DataReaderMapToList<WorkDayVO>(reader);

                conn.Close();
                return list;
            }
        }
        public List<WorkItemVO> SelectWorkItem(string Prd_Date)
        {
            string sql = " SELECT * from View_WorkItem where Prd_Date = @Prd_Date";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@Prd_Date", Prd_Date);
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkItemVO> list = Helper.DataReaderMapToList<WorkItemVO>(reader);

                conn.Close();
                return list;
            }
        }
        public List<WorkBoxingVO> SelectWorkBoxing(string Prd_Date)
        {
            string sql = " SELECT * from View_WorkBoxing where Prd_Date = @Prd_Date";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@Prd_Date", Prd_Date);
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkBoxingVO> list = Helper.DataReaderMapToList<WorkBoxingVO>(reader);

                conn.Close();
                return list;
            }
        }

        //공지사항 전체 - SysNotice
        public List<SysNoticeVO> SelectAllNoticeInfo(string sysnotice)
        {
            
            string sQuery = @"select Seq, convert(char(10), Notice_Date, 23) Notice_Date, convert(char(10), Notice_End, 23) Notice_End, Title, Description, Notice_Rtf, Email_Recipients, Email_Send_Code, 
                              case when Use_YN='Y' then 1 else 0 end Use_YN, Remark, convert(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, convert(char(10), Up_Date, 23) Up_Date, Up_Emp
                              from Sys_Notice where 1 = 1 ";

            if (sysnotice == "만료")
                sQuery += " and Notice_End < convert(char(10), getdate(),23) ";
            if(sysnotice =="진행")
                sQuery += " and Notice_Date <= convert(char(10), getdate(),23) and Notice_End >= convert(char(10), getdate(),23) ";
            if (sysnotice == "예정")
                sQuery += " and Notice_Date > convert(char(10), getdate(),23)";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                //if (!string.IsNullOrEmpty(sysnotice))
                //    cmd.Parameters.AddWithValue("@groupName", "%" + sysnotice + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<SysNoticeVO> list = Helper.DataReaderMapToList<SysNoticeVO>(reader);
                return list;
            }
        }
    }
}
