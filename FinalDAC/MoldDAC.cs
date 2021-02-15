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
    public class MoldDAC
    {
        SqlConnection conn;
        public MoldDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString));
            conn.Open();
        }
        public bool UpdateMold(MoldVO vo)
        {
            string sql = "update Mold_Master set Mold_Name = @Mold_Name, Mold_Group = @Mold_Group, Guar_Shot_Cnt = @Guar_Shot_Cnt, Remark= @Remark, Use_YN = @Use_YN where Mold_Code = @Mold_Code";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Mold_Name", vo.Mold_Name);
                cmd.Parameters.AddWithValue("@Mold_Group", vo.Mold_Group);
                cmd.Parameters.AddWithValue("@Guar_Shot_Cnt", vo.Guar_Shot_Cnt);
                cmd.Parameters.AddWithValue("@Remark", vo.Remark);
                cmd.Parameters.AddWithValue("@Use_YN", vo.Use_YN);
                cmd.Parameters.AddWithValue("@Mold_Code", vo.Mold_Code);
                cmd.Parameters.AddWithValue("@Up_Emp", LoginInfoVO.User_ID);

                int iResult = cmd.ExecuteNonQuery();
                Debug.WriteLine(iResult.ToString());
                conn.Close();

                if (iResult <= 0) return false;
                else return true;
            }
        }
        public bool InsertMold(MoldVO vo)
        {
            string iQuery = @"insert into Mold_Master (Mold_Code, Mold_Name, Mold_Group, Guar_Shot_Cnt, Purchase_Amt, In_Date, Remark, Use_YN, Ins_Date, Ins_Emp, Up_Date, Up_Emp)
                             values (@Mold_Code, @Mold_Name, @Mold_Group, @Guar_Shot_Cnt, @Purchase_Amt, GetDate(), @Remark, @Use_YN, GetDate(), @Ins_Emp, GETDATE(), @Up_Emp)";
            using (SqlCommand cmd = new SqlCommand(iQuery, conn))
            {
                cmd.Parameters.AddWithValue("Mold_Code", vo.Mold_Code);
                cmd.Parameters.AddWithValue("Mold_Name", vo.Mold_Name);
                cmd.Parameters.AddWithValue("Mold_Group", vo.Mold_Group);
                cmd.Parameters.AddWithValue("Guar_Shot_Cnt", vo.Guar_Shot_Cnt);
                cmd.Parameters.AddWithValue("Purchase_Amt", vo.Purchase_Amt);
                cmd.Parameters.AddWithValue("Remark", vo.Remark);
                cmd.Parameters.AddWithValue("Use_YN", vo.Use_YN);
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
    }
}
