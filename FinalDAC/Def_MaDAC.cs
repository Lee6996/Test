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
    public class Def_MaDAC
    {
        #region Connection Open
        static SqlConnection conn;
        public Def_MaDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        #endregion
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
    }
}

