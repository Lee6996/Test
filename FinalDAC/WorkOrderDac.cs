using FinalVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDAC
{
    public class WorkOrderDac
    {

         SqlConnection conn;
        public WorkOrderDac()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        //public bool UpdateMold(MoldVO vo)
        //{
        //    string sql = "update Mold_Master set Mold_Name = @Mold_Name, Mold_Group = @Mold_Group, Guar_Shot_Cnt = @Guar_Shot_Cnt, Remark= @Remark, Use_YN = @Use_YN where Mold_Code = @Mold_Code";

        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@Mold_Name", vo.Mold_Name);
        //        cmd.Parameters.AddWithValue("@Mold_Group", vo.Mold_Group);
        //        cmd.Parameters.AddWithValue("@Guar_Shot_Cnt", vo.Guar_Shot_Cnt);
        //        cmd.Parameters.AddWithValue("@Remark", vo.Remark);
        //        cmd.Parameters.AddWithValue("@Use_YN", vo.Use_YN);
        //        cmd.Parameters.AddWithValue("@Mold_Code", vo.Mold_Code);
        //        cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

        //        int iResult = cmd.ExecuteNonQuery();
        //        Debug.WriteLine(iResult.ToString());
        //        conn.Close();

        //        if (iResult <= 0) return false;
        //        else return true;
        //    }
        //}
        public bool InsertWorkOrder(WorkOrderVO vo)
        {
            string iQuery = @"insert into WorkOrder (Req_Seq, Wo_Req_No, Item_Code, Wc_Code, Plan_Date, Plan_Qty, Plan_Unit, Remark, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
                             values (@Req_Seq, @Wo_Req_No, @Item_Code, @Wc_Code, @Plan_Date, @Plan_Qty, @Plan_Unit, @Remark, GetDate(), @Ins_Emp, GETDATE(), @Up_Emp)";
            using (SqlCommand cmd = new SqlCommand(iQuery, conn))
            {
                cmd.Parameters.AddWithValue("Req_Seq", vo.Req_Seq);
                cmd.Parameters.AddWithValue("Wo_Req_No", vo.Wo_Req_No);
                cmd.Parameters.AddWithValue("Item_Code", vo.Item_Code);
                cmd.Parameters.AddWithValue("Wc_Code", vo.Wc_Code);
                cmd.Parameters.AddWithValue("Plan_Date", vo.Plan_Date);
                cmd.Parameters.AddWithValue("Plan_Qty", vo.Plan_Qty);
                cmd.Parameters.AddWithValue("Plan_Unit", vo.Plan_Unit);
                cmd.Parameters.AddWithValue("Remark", vo.Remark);
                cmd.Parameters.AddWithValue("Ins_Emp", LoginInfoVO.User_ID);
                cmd.Parameters.AddWithValue("Up_Emp", LoginInfoVO.User_ID);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();

                if (iResult <= 0) return false;
                else return true;
            }
        }
        public List<WorkOrderVO> listWork(string dtpFrom, string dtpTo)
        {
            string sql = " SELECT * from View_WorkOrder where Prd_Date between @dtpFrom and @dtpTo";

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
        public List<WorkOrderVO> listWork(string dtpFrom, string dtpTo, string Wc_Code)
        {
            string sql = " SELECT * from View_WorkOrder where Prd_Date between @dtpFrom and @dtpTo and Wc_Code = @Wc_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }
        public List<WorkOrderVO> listWork(string dtpFrom, string dtpTo, string Wc_Code=null, string Status)
        {
            string sql = " SELECT * from View_WorkOrder where Prd_Date between @dtpFrom and @dtpTo and Status = @Status";

            if (!string.IsNullOrEmpty(Wc_Code)) sql += " and Wc_Code = @Wc_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);
                cmd.Parameters.AddWithValue("@Wc_Code", Wc_Code);
                cmd.Parameters.AddWithValue("@Status", Status);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }
        public List<WorkReqVO> listReq(string dtpFrom, string dtpTo)
        {
            string sql = " SELECT * from View_Wo_Req where Prd_Plan_Date between @dtpFrom and @dtpTo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dtpFrom", dtpFrom);
                cmd.Parameters.AddWithValue("@dtpTo", dtpTo);

                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkReqVO> list = Helper.DataReaderMapToList<WorkReqVO>(reader);

                conn.Close();
                return list;
            }
        }
        public bool UpdateWorkorder(WorkOrderVO vo, string Status)
        {
            string sql = "update Mold_Master set Item_Code = @Item_Code, Plan_Date = @Plan_Date, Plan_Qty = @Plan_Qty, Plan_Unit= @Plan_Unit, Up_Date = Getdate(), Up_Emp=@Up_Emp, Req_Status = '작업지시마감' where Workorderno = @Workorderno";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Workorderno", vo.Workorderno);
                cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                cmd.Parameters.AddWithValue("@Plan_Date", vo.Plan_Date);
                cmd.Parameters.AddWithValue("@Plan_Qty", vo.Plan_Qty);
                cmd.Parameters.AddWithValue("@Plan_Unit", vo.Plan_Unit);
                cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();

                if (iResult <= 0) return false;
                else return true;
            }
        }
        public bool UpdateWorkorder(string Workorderno)
        {
            string sql = "update Mold_Master set Workorderno = @Workorderno, Up_Date = GetDate(), Up_Emp = @Up_Emp";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Workorderno", Workorderno);

                cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();

                if (iResult <= 0) return false;
                else return true;
            }
        }
    }
}

