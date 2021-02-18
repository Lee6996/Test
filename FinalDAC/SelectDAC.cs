using FinalVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Select 쿼리문을 모아놓은 DAC단
/// 개발자 : 전원
/// </summary>

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

        //List<InspecVo> - 민주
        public List<InspecVo> GetInspecVoList(string dtpFrom, string dtpTo, string processCode, string wcCode)
        {
            string sql = "select * from View_Inspect where 1=1 and Prd_Date between @dtpFrom and @dtpTo";
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
                List<InspecVo> list = Helper.DataReaderMapToList<InspecVo>(reader);

                conn.Close();
                return list;
            }
        }

        //List<ConditionVO> - 민주
        public List<ConditionVO> GetConditionVoList(string dtpFrom, string dtpTo, string processCode, string wcCode)
        {
            string sql = "select * from View_Condition where 1=1 and Prd_Date between @dtpFrom and @dtpTo";
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
                List<ConditionVO> list = Helper.DataReaderMapToList<ConditionVO>(reader);

                conn.Close();
                return list;
            }
        }

        //WorkOrderVO - 민주
        public List<WorkOrderVO> SelectWorkOrder(string dtpFrom = null, string dtpTo = null, string processCode = null, string wcCode = null)
        {
            string sql = "select * from View_WorkOrder where 1=1";
            if(!string.IsNullOrEmpty(dtpFrom) || !string.IsNullOrEmpty(dtpTo)) sql += " and Plan_Date between @dtpFrom and @dtpTo ";
            if (!string.IsNullOrEmpty(processCode)) sql += " AND Process_Code = @Process_Code";
            if (!string.IsNullOrEmpty(wcCode)) sql += " AND Wc_Code = @Wc_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(dtpFrom) || !string.IsNullOrEmpty(dtpTo))
                {
                    cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                    cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                } if (!string.IsNullOrEmpty(processCode))
                    cmd.Parameters.AddWithValue("@Process_Code", processCode);
                if (!string.IsNullOrEmpty(wcCode))
                    cmd.Parameters.AddWithValue("@Wc_Code", wcCode);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }

        //GoodsInHistory - 민주
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

        //ReceivingListVO - 민주
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

        //WorkHistory - 민주
        public List<WorkHistoryVO> SelectWorkHistory(string dtpFrom, string dtpTo, string Wc_Name)
        {
            string sql = "select * from View_WorkHistory where Work_Date between @dtpFrom and @dtpTo ";
            if (!string.IsNullOrEmpty(Wc_Name))
            {
                sql += " and Wc_Name = @Wc_Name";
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

        //AttendanceManagement - 민주
        public List<AttendanceManagementVO> SelectAttendanceManagement(string dtpFrom, string dtpTo, string user_Name)
        {
            string sql = "select * from View_AttendanceManagement where Work_Date between @dtpFrom and @dtpTo ";
            if (!string.IsNullOrEmpty(user_Name))
            {
                sql += " and user_Name = @user_Name";
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

        //User 유저 정보 - 경진
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
        //List<UserVO> - 경진
        public List<UserVO> SelectUserInfo(string user_Name)
        {
            string sQuery = @"select User_ID, User_Name, User_PW, Customer_Code, User_Type, Default_Screen_Code, Default_Process_Code, Monitoring_YN, Use_YN, convert(char(23), Ins_Date, 21) Ins_Date, Ins_Emp, convert(char(23), Up_Date, 21) Up_Date, Up_Emp
                                from User_Master where 1=1 ";

            if (!string.IsNullOrEmpty(user_Name))
                sQuery += " and User_Name Like @userName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(user_Name))
                    cmd.Parameters.AddWithValue("@userName", "%" + user_Name + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<UserVO> list = Helper.DataReaderMapToList<UserVO>(reader);
                return list;
            }
        }

        //UserGroup - 경진
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

        //GVHistory - 민주
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

        //GV - 민주
        public List<GVStatusVO> SelectGVStatus(string GVGroup_Code =null, string Item_Code = null)
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

        //ItemLevelInfo - 영규
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
        //GetAllItem - 영규
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
        //GetAllItemMaster - 영규
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
        //GetAllDef_Ma_Master - 영규
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

        //Process - 미사용
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

        //WorkCenter - 미사용
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

        //NOP - 민주
        public List<NOPVO> SelectNOP(string dtpFrom = null, string dtpTo = null, string WC_Code = null)
        {
            string sQuery = "select * from View_NOP where 1=1 ";

            if (!string.IsNullOrEmpty(dtpFrom) && !string.IsNullOrEmpty(dtpTo))
                sQuery += " and Nop_Date between @dtpFrom and @dtpTo";

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

        //MainPopUp용 Select 문 - 민주
        public List<T> SelectForPopup<T>(string type, string checkExist = null)
        {
            string sql;
            switch (type)
            {
                case "WC":
                    sql = "SELECT WC_Code,WC_Name FROM WorkCenter_Master"; break;
                case "Item":
                    sql = "SELECT Item_Code,Item_Name FROM Item_Master"; break;
                case "GV":
                    sql = "SELECT GV_Code,GV_Name FROM GV_Master";
                    if (!string.IsNullOrEmpty(checkExist))
                        sql += " where GV_Status = 'Rest'";
                    break;
                case "GVGroup":
                    sql = "SELECT GVGroup_Code,GVGroup_Name FROM GVGruop_Master"; break;
                case "User":
                    sql = "SELECT User_ID,User_Name FROM User_Master"; break;
                case "Process":
                    sql = "SELECT Process_Code, Process_Name FROM Process_Master"; break;
                case "Mold":
                    sql = "SELECT Mold_Code, Mold_Name FROM Mold_Master"; break;
                case "Nop_Ma":
                    sql = "SELECT Nop_Ma_Code, Nop_Ma_Name FROM Nop_Ma_Master"; break;
                case "Nop_Mi":
                    sql = "SELECT Nop_Mi_Code, Nop_Mi_Name FROM Nop_Mi_Master"; break;
                case "Def_Ma":
                    sql = "SELECT Def_Ma_Code, Def_Ma_Name FROM Def_Ma_Master"; break;
                case "Boxing_Grade":
                    sql = "SELECT Boxing_Grade_Code, Boxing_Grade_Name FROM BoxingGrade_Master"; break;
                default: sql = null; break;
                
            }
            if (sql != null)
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<T> list = Helper.DataReaderMapToList<T>(reader);

                    conn.Close();
                    return list;
                }
            else return null;
        }

        //List<WorkDayVO>  - 성재
        public List<WorkDayVO> SelectWorkDay(string Prd_Date_from, string Prd_Date_to, string Process_Code = null, string Wc_Code = null)
        {
            string sql = " SELECT * from View_WorkDay where Prd_Date >= @Prd_Date_from and Prd_Date<= @Prd_Date_to ";

            if (!string.IsNullOrEmpty(Process_Code))
                sql += " and Process_Code = @Process_Code";

            if (!string.IsNullOrEmpty(Wc_Code))
                sql += " and Wc_Code = @Wc_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Prd_Date_from", Prd_Date_from);
                cmd.Parameters.AddWithValue("@Prd_Date_to", Prd_Date_to);

                if (!string.IsNullOrEmpty(Process_Code))
                    cmd.Parameters.AddWithValue("@Process_Code", Process_Code);
                if (!string.IsNullOrEmpty(Wc_Code))
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkDayVO> list = Helper.DataReaderMapToList<WorkDayVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<WorkItemVO> - 성재
        public List<WorkItemVO> SelectWorkItem(string Prd_Date_from, string Prd_Date_to, string Wc_Code = null)
        {
            string sql = " SELECT * from View_WorkItem where Prd_Date between @Prd_Date_from and @Prd_Date_to ";

            if (!string.IsNullOrEmpty(Wc_Code))
                sql += " and Wc_Code = @Wc_Code ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@Prd_Date_from", Prd_Date_from);
                cmd.Parameters.AddWithValue("@Prd_Date_to", Prd_Date_to);

                if (!string.IsNullOrEmpty(Wc_Code))
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkItemVO> list = Helper.DataReaderMapToList<WorkItemVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<WorkBoxingVO> - 
        public List<WorkBoxingVO> SelectWorkBoxing(string Prd_Date_from, string Prd_Date_to, string Wc_Code = null)
        {
            string sql = " SELECT * from View_WorkBoxing where Prd_Date between @Prd_Date_from and @Prd_Date_to";


            if (!string.IsNullOrEmpty(Wc_Code))
                sql += " and Wc_Code = @Wc_Code ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@Prd_Date_from", Prd_Date_from);
                cmd.Parameters.AddWithValue("@Prd_Date_to", Prd_Date_to);

                if (!string.IsNullOrEmpty(Wc_Code))
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkBoxingVO> list = Helper.DataReaderMapToList<WorkBoxingVO>(reader);

                conn.Close();
                return list;
            }
        }
        // List<MoldVO> - 성재
        public List<MoldVO> SelectMold( )
        {
            string sql = " SELECT * from View_Mold_Master";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);

                conn.Close();
                return list;
            }
        }
        // List<WorkCenterVO> - 성재
        public List<WorkCenterVO> SelectWorkCenter()
        {
            string sql = " SELECT * from View_WorkCenter";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkCenterVO> list = Helper.DataReaderMapToList<WorkCenterVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<MoldVO> - 성재
        public List<MoldVO> SelectMolds(string Mold_Code = null, string Mold_Group = null)
        {
            string sql = " SELECT * from View_Mold_Master where Mold_Group = @Mold_Group and Mold_Code = @Mold_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Mold_Code", Mold_Code);
                cmd.Parameters.AddWithValue("@Mold_Group", Mold_Group);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<MoldVO> - 성재
        public List<MoldVO> SelectMoldCode(string Mold_Code=null, string Mold_Group = null)
        {
            string sql = " SELECT * from View_Mold_Master where 1=1 ";

            if (!string.IsNullOrEmpty(Mold_Code))
                sql += " and Mold_Code = @Mold_Code";
            if (!string.IsNullOrEmpty(Mold_Group))
                sql += " and Mold_Group = @Mold_Group";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(Mold_Code))
                    cmd.Parameters.AddWithValue("@Mold_Code", Mold_Code);
                if (!string.IsNullOrEmpty(Mold_Group))
                    cmd.Parameters.AddWithValue("@Mold_Group", Mold_Group);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<MoldVO> - 성재
        public List<MoldVO> SelectMoldGroup(string Mold_Code = null, string Mold_Group = null)
        {
            string sql = " SELECT * from View_Mold_Master where 1=1 ";

            if (!string.IsNullOrEmpty(Mold_Group))
                sql += " and Mold_Group = @Mold_Group";
            if (!string.IsNullOrEmpty(Mold_Code))
                sql += " and Mold_Code = @Mold_Code";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (!string.IsNullOrEmpty(Mold_Code))
                    cmd.Parameters.AddWithValue("@Mold_Code", Mold_Code);
                if (!string.IsNullOrEmpty(Mold_Group))
                    cmd.Parameters.AddWithValue("@Mold_Group", Mold_Group);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldVO> list = Helper.DataReaderMapToList<MoldVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<MoldGroupVO> - 성재
        public List<MoldGroupVO> GetMoldGroup()
        {
            string sql = " SELECT Mold_Group from Mold_Master";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldGroupVO> list = Helper.DataReaderMapToList<MoldGroupVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<MoldUseVO> - 성재
        public List<MoldUseVO> SelectMoldUse()
        {
            string sql = " SELECT * from View_MoldUse";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseVO> list = Helper.DataReaderMapToList<MoldUseVO>(reader);

                conn.Close();
                return list;
            }
        }

        //List<MoldUseVO> - 성재
        public List<MoldUseVO> SelectMoldUses(string dtpFrom, string dtpTo, string Item_Code = null, string Wc_Code = null)
        {
            string sql = " SELECT * from View_MoldUse where Prd_Date between @dtpFrom and @dtpTo";

            if (!string.IsNullOrEmpty(Item_Code))
                sql += " and Item_Code = @Item_Code";

            if (!string.IsNullOrEmpty(Wc_Code))
                sql += " and Wc_Code = @Wc_Code ";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                cmd.Parameters.AddWithValue("@Item_Code", Item_Code);
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseVO> list = Helper.DataReaderMapToList<MoldUseVO>(reader);

                conn.Close();
                return list;
            }
        }

        //List<MoldUseVO> - 성재
        public List<MoldUseVO> SelectMoldUseItem(string dtpFrom, string dtpTo, string Item_Code = null, string Wc_Code = null)
        {
            string sql = " SELECT * from View_MoldUse where Prd_Date between @dtpFrom and @dtpTo";

            if (!string.IsNullOrEmpty(Wc_Code))
                sql += " and Wc_Code = @Wc_Code";
            if (!string.IsNullOrEmpty(Item_Code))
                sql += " and Item_Code = @Item_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                if (!string.IsNullOrEmpty(Item_Code))
                    cmd.Parameters.AddWithValue("@Item_Code", Item_Code);
                if (!string.IsNullOrEmpty(Wc_Code))
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseVO> list = Helper.DataReaderMapToList<MoldUseVO>(reader);

                conn.Close();
                return list;
            }
        }
        //List<MoldUseVO> - 성재
        public List<MoldUseVO> SelectMoldUseWc(string dtpFrom, string dtpTo, string Item_Code = null, string Wc_Code = null)
        {
            string sql = " SELECT * from View_MoldUse where Prd_Date between @dtpFrom and @dtpTo";

            if (!string.IsNullOrEmpty(Wc_Code))
                sql += " and Wc_Code = @Wc_Code";
            if (!string.IsNullOrEmpty(Item_Code))
                sql += " and Item_Code = @Item_Code";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                if (!string.IsNullOrEmpty(Item_Code))
                    cmd.Parameters.AddWithValue("@Item_Code", Item_Code);
                if (!string.IsNullOrEmpty(Wc_Code))
                    cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<MoldUseVO> list = Helper.DataReaderMapToList<MoldUseVO>(reader);

                conn.Close();
                return list;
            }
        }
        //공지사항 전체 - SysNotice - 경진
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

        //List<LOTVO> - 민주
        public List<LOTVO> GetLotVOList(string YYYY)
        {
            string sQuery = " SELECT * from View_Lot where 1 = 1";

            if (!string.IsNullOrEmpty(YYYY))
                sQuery += " and YYYY = @YYYY";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(YYYY))
                    cmd.Parameters.AddWithValue("YYYY", YYYY); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<LOTVO> list = Helper.DataReaderMapToList<LOTVO>(reader);
                return list;
            }
        }
    }
}
