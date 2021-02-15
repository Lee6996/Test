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
    public class Condition_SpecDAC
    {
        SqlConnection conn;
        public Condition_SpecDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }

        public bool InsertCondition(ConditionSpecVO condition)
        {
            string sQuery = @"select count(*) 
                              from Condition_Spec_Master where 1 = 1 and Condition_Code = @Condition_Code and Condition_Name = @Condition_Name  ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Condition_Code", condition.Condition_Code);
                cmd.Parameters.AddWithValue("@Condition_Name", condition.Condition_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"INSERT INTO Condition_Spec_Master
           (Item_Code
           ,Wc_Code
           ,Condition_Code
           ,Condition_Name
           ,SL
           ,USL
           ,LSL
           ,Condition_Unit
           ,Condition_Group
           ,Remark
           ,Ins_Date
           ,Ins_Emp
           ,Up_Date
           ,Up_Emp)
     VALUES
           (@Item_Code
           ,@Wc_Code 
           ,@Condition_Code
           ,@Condition_Name
           ,@SL 
           ,@USL 
           ,@LSL
           ,@Condition_Unit
           ,@Condition_Group
           ,@Remark  , getdate(),'test', getdate(), 'test' ) ";


                    cmd.Parameters.AddWithValue("@Item_Code", condition.Item_Code);
                    cmd.Parameters.AddWithValue("@Wc_Code", condition.Wc_Code);
                    cmd.Parameters.AddWithValue("@Condition_Code", condition.Condition_Code);
                    cmd.Parameters.AddWithValue("@Condition_Name", condition.Condition_Name);
                    cmd.Parameters.AddWithValue("@USL", condition.USL);
                    cmd.Parameters.AddWithValue("@SL", condition.SL);
                    cmd.Parameters.AddWithValue("@LSL", condition.LSL);
                    cmd.Parameters.AddWithValue("@Condition_Unit", condition.Condition_Unit);
                    cmd.Parameters.AddWithValue("@Condition_Group", condition.Condition_Group);
                    cmd.Parameters.AddWithValue("@Remark", condition.Remark);

                    //cmd.Parameters.AddWithValue("@Ins_Date", additem.Ins_Date);
                    //cmd.Parameters.AddWithValue("@Up_Date", item.Up_Date);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Ins_Emp);
                    // cmd.Parameters.AddWithValue("@Up_Emp", additem.Up_Emp);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public List<ConditionSpecVO> ConditionSelect(string code)
        {
            string sQuery = @"SELECT Item_Code
      ,Wc_Code
      ,Condition_Code
      ,Condition_Name
      ,SL
      ,USL
      ,LSL
      ,Condition_Unit
      ,Condition_Group
      ,Remark
   , CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23) Up_Date, Up_Emp
                                        FROM Condition_Spec_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(code))
                sQuery += " and Condition_Name Like @Condition_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(code))
                    cmd.Parameters.AddWithValue("@Condition_Name", "%" + code + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<ConditionSpecVO> list = Helper.DataReaderMapToList<ConditionSpecVO>(reader);
                return list;
            }
        }
    }
}
