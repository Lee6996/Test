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
    public class ItemInfoDAC
    {
        SqlConnection conn;
        public ItemInfoDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        public bool UpdateItemInfo(ItemInfoVO item)
        {
            string sql = $@"update Item_Level_Master
              set Level_Name = @Level_Name

              Item_lvl1 = @Item_lv1

              Item_lvl2 = @Item_lv2

              Item_lvl3 = @Item_lv3

              Item_lvl4 = @Item_lv4

              Item_lvl5 = @Item_lv5

              Box_Qty = @Box_Qty

              Pcs_Qty = @Pcs_Qty

              Mat_Qty = @Mat_Qty

              Ins_Emp = @Ins_Emp

              where Level_Code = @Level_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Level_Code", item.Level_Code);
                cmd.Parameters.AddWithValue("@Level_Name", item.Level_Name);
                cmd.Parameters.AddWithValue("@Item_lvl1", item.Item_lvl1);
                cmd.Parameters.AddWithValue("@Item_lvl2", item.Item_lvl2);
                cmd.Parameters.AddWithValue("@Item_lvl3", item.Item_lvl3);
                cmd.Parameters.AddWithValue("@Item_lvl4", item.Item_lvl4);
                cmd.Parameters.AddWithValue("@Item_lvl5", item.Item_lvl5);
                cmd.Parameters.AddWithValue("@Box_Qty", item.Box_Qty);
                cmd.Parameters.AddWithValue("@Pcs_Qty", item.Pcs_Qty);
                cmd.Parameters.AddWithValue("@Mat_Qty", item.Mat_Qty);
                cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }
        
        public bool InsertAllitem_Master(Item_MasterVO item)
        {
            string sql = $@"INSERT INTO Item_Master
                                 (Item_Code  ,Item_Name    ,Item_Type  ,Item_Spec    ,Item_Unit ,Level_1    , Level_2    ,Level_3 ,Level_4    ,Level_5                      
                                ,Item_Stock   ,PrdQty_Per_Hour  ,PrdQTy_Per_Batch    ,Cavity   ,Line_Per_Qty    ,Shot_Per_Qty  ,Dry_GV_Qty   ,Ins_Date   ,Ins_Emp
                                 )
                          VALUES
                                (@Item_Code  , @Item_Name    , @Item_Type  , @Item_Spec    , @Item_Unit , @Level_1    ,@ Level_2    ,@Level_3 , @Level_4    , @Level_5                      
                                 ,@Item_Stock   , @PrdQty_Per_Hour  , @PrdQTy_Per_Batch    , @Cavity   , @Line_Per_Qty    , @Shot_Per_Qty  , @Dry_GV_Qty   , convert(char(10), GetDATE(), 23) , @Ins_Emp ),";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
               cmd.Parameters.AddWithValue("@Item_Code", item.Item_Code);
               cmd.Parameters.AddWithValue("@Item_Name", item.Item_Name);          
               cmd.Parameters.AddWithValue("@Item_Type", item.Item_Type);
               cmd.Parameters.AddWithValue("@Item_Spec", item.Item_Spec);
               cmd.Parameters.AddWithValue("@Item_Unit", item.Item_Unit);
               cmd.Parameters.AddWithValue("@Level_1", item.Level_1);
               cmd.Parameters.AddWithValue("@Level_2", item.Level_2);
               cmd.Parameters.AddWithValue("@Level_3", item.Level_3);
               cmd.Parameters.AddWithValue("@Level_4", item.Level_4);
               cmd.Parameters.AddWithValue("@Level_5", item.Level_5);
               cmd.Parameters.AddWithValue("@Item_Stock", item.Item_Stock);
               cmd.Parameters.AddWithValue("@PrdQty_Per_Hour", item.PrdQty_Per_Hour);
               cmd.Parameters.AddWithValue("@PrdQTy_Per_Batch", item.PrdQTy_Per_Batch);
               cmd.Parameters.AddWithValue("@Cavity", item.Cavity);
               cmd.Parameters.AddWithValue("@Line_Per_Qty", item.Line_Per_Qty);
               cmd.Parameters.AddWithValue("@Shot_Per_Qty", item.Shot_Per_Qty);
               cmd.Parameters.AddWithValue("@Dry_GV_Qty", item.Dry_GV_Qty);              
               //cmd.Parameters.AddWithValue("@Ins_Date", item.Ins_Date);
                cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else 
                    return false;
            }
        }

        public bool UpdateItemInfo(Item_MasterVO upitem)
        {
            string sql = $@"UPDATE Item_Master
   SET 
      Item_Name = @Item_Name,
      Item_Type = @Item_Type,            
      Cavity = @Cavity, 
      Line_Per_Qty = @Line_Per_Qty,
      Shot_Per_Qty = @Shot_Per_Qty,    
      Ins_Date = @Ins_Date,
      Ins_Emp = @Ins_Emp,       
 WHERE Item_Code = @Item_Code,";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Item_Code", upitem.Item_Code);
                cmd.Parameters.AddWithValue("@Item_Name", upitem.Item_Name);               
                cmd.Parameters.AddWithValue("@Item_Type", upitem.Item_Type);       
                cmd.Parameters.AddWithValue("@Cavity", upitem.Cavity);
                cmd.Parameters.AddWithValue("@Line_Per_Qty", upitem.Line_Per_Qty);
                cmd.Parameters.AddWithValue("@Shot_Per_Qty", upitem.Shot_Per_Qty);               
                cmd.Parameters.AddWithValue("@Ins_Date", upitem.Ins_Date);
                cmd.Parameters.AddWithValue("@Ins_Emp", upitem.Ins_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public bool Use_YNItem_Level_Master(string groupcode, string used)
        {
            string sql = " update Item_Level_Master set Use_YN = @Use_YN where Level_Code = @Level_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Level_Code", groupcode);
                cmd.Parameters.AddWithValue("@Use_YN", used);

                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }       
    }
}

