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

    public class ItemSpecDAC
    {
        SqlConnection conn;
        public ItemSpecDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }

        public bool InsertSpec(ItemSpecVO additem)
        {
            string sQuery = @"select count(*) 
                              from Inspect_Spec_Master where 1 = 1 and Inspect_code = @Inspect_code and Inspect_name = @Inspect_name  ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Inspect_code", additem.Inspect_code);
                cmd.Parameters.AddWithValue("@Inspect_name", additem.Inspect_name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"INSERT INTO Inspect_Spec_Master
           (Item_Code
           ,Process_code
           ,Inspect_code
           ,Inspect_name
           ,USL
           ,SL
           ,LSL
           ,Sample_size
           ,Inspect_Unit
           ,Use_YN
           ,Remark
           ,Ins_Date
           ,Ins_Emp
           ,Up_Date
           ,Up_Emp)
     VALUES
           (@Item_Code
           ,@Process_code
           ,@Inspect_code
           ,@Inspect_name
           ,@USL
           ,@SL
           ,@LSL
           ,@Sample_size
           ,@Inspect_Unit
           ,'Y'  , getdate(),'test', getdate(), 'test' ) ";


                    cmd.Parameters.AddWithValue("@Item_Code", additem.Item_Code);
                    cmd.Parameters.AddWithValue("@Process_code", additem.Process_code);
                    cmd.Parameters.AddWithValue("@Inspect_code", additem.Inspect_code);
                    cmd.Parameters.AddWithValue("@Inspect_name", additem.Inspect_name);
                    cmd.Parameters.AddWithValue("@USL", additem.USL);
                    cmd.Parameters.AddWithValue("@SL", additem.SL);
                    cmd.Parameters.AddWithValue("@LSL", additem.LSL);
                    cmd.Parameters.AddWithValue("@Sample_size", additem.Sample_size);
                    cmd.Parameters.AddWithValue("@Inspect_Unit", additem.Inspect_Unit);
                                        
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

        public List<ItemSpecVO> ItemSpecSelect(string data)
        {
            string sQuery = @"SELECT Item_Code
      ,Process_code
      ,Inspect_code
      ,Inspect_name
      ,USL
      ,SL
      ,LSL
      ,Sample_size
      ,Inspect_Unit    
      ,Remark   
    ,case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23) Up_Date, Up_Emp
                                        FROM Inspect_Spec_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(data))
                sQuery += " and Inspect_code Like @Inspect_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(data))
                    cmd.Parameters.AddWithValue("@Inspect_Name", "%" + data + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemSpecVO> list = Helper.DataReaderMapToList<ItemSpecVO>(reader);
                return list;
            }
        }
    }
}
