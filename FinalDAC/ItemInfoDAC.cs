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
              set (Level_Name = @Level_Name,

              Item_lvl1 = @Item_lv1,

              Item_lvl2 = @Item_lv2,

              Item_lvl3 = @Item_lv3,

              Item_lvl4 = @Item_lv4,

              Item_lvl5 = @Item_lv5,

              Box_Qty = @Box_Qty,

              Pcs_Qty = @Pcs_Qty,
              Mat_Qty = @Mat_Qty,
              Up_Date = CONVERT(char(10), Up_Date, 23), Up_Emp = 'test1'
              where Level_Code = @Level_Code";


            //Ins_Emp = @Ins_Emp
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
                //cmd.Parameters.AddWithValue("@Ins_Emp", item.Ins_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public DataTable ItemMasterBindingName()
        {
            DataTable dt = new DataTable();
            string sql = "select Item_Code, Item_Name from Item_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        public bool UpdateUSEYN(Item_MasterVO vo)
        {
            string sQuery = @"update Item_Master set Use_YN = @Use_YN where Item_Code = @Item_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Item_Code", vo.Item_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool UpdateMaster(Item_MasterVO additem)
        {
            string sql = $@"UPDATE Item_Master

                                         SET
                                            Item_Name = @Item_Name,
                                            Cavity = @Cavity,
                                            Line_Per_Qty = @Line_Per_Qty,
                                            Shot_Per_Qty = @Shot_Per_Qty,
                                            Up_Date = convert(char(10), GetDATE(), 23),
                                            Up_Emp = 'LYG'

                                         WHERE Item_Code = @Item_Code";



            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Item_Code", additem.Item_Code);
                cmd.Parameters.AddWithValue("@Item_Name", additem.Item_Name);
                cmd.Parameters.AddWithValue("@Cavity", additem.Cavity);
                cmd.Parameters.AddWithValue("@Line_Per_Qty", additem.Line_Per_Qty);
                cmd.Parameters.AddWithValue("@Shot_Per_Qty", additem.Shot_Per_Qty);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool InsertUpdateItemInfo(ItemInfoVO additem)
        {
            string sql = $@"IF NOT EXISTS(SELECT [Level_Code] FROM [Item_Level_Master] WHERE [Level_Code]=@Level_Code)
   BEGIN
		INSERT INTO [Item_Level_Master]([Level_Code],[Level_Name],[Item_lvl1],[Item_lvl2],[Item_lvl3],[Item_lvl4],[Item_lvl5],[Box_Qty],[Pcs_Qty],[Mat_Qty],[Use_YN],[Ins_Date],[Ins_Emp] )      
		VALUES(@Level_Code,@Level_Name,@Item_lvl1,@Item_lvl2,@Item_lvl3,@Item_lvl4,@Item_lvl5,@Box_Qty,@Pcs_Qty,@Mat_Qty,'Y',GETDATE(),'TEST')
		END
 ELSE
	 BEGIN
		UPDATE [Item_Level_Master] SET [Level_Name]=@Level_Name,[Item_lvl1]=@Item_lvl1,[Item_lvl2]=@Item_lvl2,[Item_lvl3]=@Item_lvl3,[Item_lvl4]=@Item_lvl4,[Item_lvl5]=@Item_lvl5,[Box_Qty]=@Box_Qty,[Pcs_Qty]=@Pcs_Qty,[Mat_Qty]=@Mat_Qty,Up_Date =GETDATE(), Up_Emp = 'test' 
		where [Level_Code]=@Level_Code
		  END";


            //Ins_Emp = @Ins_Emp
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Level_Code", additem.Level_Code);
                cmd.Parameters.AddWithValue("@Level_Name", additem.Level_Name);
                cmd.Parameters.AddWithValue("@Item_lvl1", additem.Item_lvl1);
                cmd.Parameters.AddWithValue("@Item_lvl2", additem.Item_lvl2);
                cmd.Parameters.AddWithValue("@Item_lvl3", additem.Item_lvl3);
                cmd.Parameters.AddWithValue("@Item_lvl4", additem.Item_lvl4);
                cmd.Parameters.AddWithValue("@Item_lvl5", additem.Item_lvl5);
                cmd.Parameters.AddWithValue("@Box_Qty", additem.Box_Qty);
                cmd.Parameters.AddWithValue("@Pcs_Qty", additem.Pcs_Qty);
                cmd.Parameters.AddWithValue("@Mat_Qty", additem.Mat_Qty);



                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool InsertItemMaster(Item_MasterVO additem)
        {
            string sql = $@"INSERT INTO Item_Master
       (Item_Code ,Item_Name ,Item_Type ,Item_Spec,Item_Unit ,Level_1, Level_2, Level_3 ,Level_4 ,Level_5 ,Item_Stock,PrdQty_Per_Hour,PrdQTy_Per_Batch ,Cavity ,Line_Per_Qty ,Shot_Per_Qty ,Dry_GV_Qty , Use_YN, Ins_Date ,Ins_Emp, Up_Date, Up_Emp)
VALUES
      (@Item_Code, @Item_Name , @Item_Type, @Item_Spec , @Item_Unit , @Level_1 , @Level_2, @Level_3 , @Level_4, @Level_5 , @Item_Stock , @PrdQty_Per_Hour , @PrdQTy_Per_Batch , @Cavity , @Line_Per_Qty ,@Shot_Per_Qty ,@Dry_GV_Qty, 'Y' ,convert(char(10), GetDATE(), 23) , 'test', convert(char(10), GetDATE(), 23), 'test' )";



            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Item_Name", additem.Item_Name);
                cmd.Parameters.AddWithValue("@Item_Code", additem.Item_Code);
                cmd.Parameters.AddWithValue("@Item_Type", additem.Item_Type);
                cmd.Parameters.AddWithValue("@Item_Spec", additem.Item_Spec);
                cmd.Parameters.AddWithValue("@Item_Unit", additem.Item_Unit);
                cmd.Parameters.AddWithValue("@Level_1", additem.Level_1);
                cmd.Parameters.AddWithValue("@Level_2", additem.Level_2);
                cmd.Parameters.AddWithValue("@Level_3", additem.Level_3);
                cmd.Parameters.AddWithValue("@Level_4", additem.Level_4);
                cmd.Parameters.AddWithValue("@Level_5", additem.Level_5);
                cmd.Parameters.AddWithValue("@Item_Stock", additem.Item_Stock);
                cmd.Parameters.AddWithValue("@PrdQty_Per_Hour", additem.PrdQty_Per_Hour);
                cmd.Parameters.AddWithValue("@PrdQTy_Per_Batch", additem.PrdQTy_Per_Batch);
                cmd.Parameters.AddWithValue("@Cavity", additem.Cavity);
                cmd.Parameters.AddWithValue("@Line_Per_Qty", additem.Line_Per_Qty);
                cmd.Parameters.AddWithValue("@Shot_Per_Qty", additem.Shot_Per_Qty);
                cmd.Parameters.AddWithValue("@Dry_GV_Qty", additem.Dry_GV_Qty);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }



        public List<Item_MasterVO> ItemMasterSelect(string groupName)
        {
            string sQuery = @"SELECT
                                               [Item_Code]
                                              ,[Item_Name]
                                              ,[Item_Type]
                                              ,[Item_Spec]
                                              ,[Item_Unit]
                                              ,[Level_1]
                                              ,[Level_2]
                                              ,[Level_3]
                                              ,[Level_4]
                                              ,[Level_5]
                                              ,[LotSize]
                                              ,[Lead_Time]
                                              ,[Item_Stock]
                                              ,[PrdQty_Per_Hour]
                                              ,[PrdQTy_Per_Batch]
                                              ,[Cavity]
                                              ,[Line_Per_Qty]
                                              ,[Shot_Per_Qty]
                                              ,[Dry_GV_Qty]
                                              ,[Remark]
                                                , case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp
                                                 from [TEAM2].[dbo].[Item_Master] where 1 = 1  ";


            if (!string.IsNullOrEmpty(groupName))
                sQuery += " and Item_Code Like @groupName ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(groupName))
                    cmd.Parameters.AddWithValue("@groupName", "%" + groupName + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<Item_MasterVO> list = Helper.DataReaderMapToList<Item_MasterVO>(reader);
                return list;
            }
        }


        public DataTable ItemMasterBindingType()
        {
            DataTable dt = new DataTable();
            string sql = "select Item_Code, Item_Type from Item_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        public bool UpdateItemLevel(ItemInfoVO vo)
        {
            string sQuery = @"update Item_Level_Master set Use_YN = @Use_YN where Level_Code = @Level_Code";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Level_Code", vo.Level_Code);
                cmd.Parameters.AddWithValue("@Use_YN", (vo.Use_YN == 1) ? "Y" : "N");

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool InsertItemLevel(ItemInfoVO additem)
        {
            string sQuery = @"select count(*) 
                              from Item_Level_Master where 1 = 1 and Level_Code = @Level_Code and Level_Name = @Level_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Level_Code", additem.Level_Code);
                cmd.Parameters.AddWithValue("@Level_Name", additem.Level_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"insert into
		Item_Level_Master
                  (Level_Code
                  ,Level_Name
                  ,Item_lvl1
                  ,Item_lvl2
                  ,Item_lvl3
                  ,Item_lvl4
                  ,Item_lvl5
                  ,Box_Qty
                  ,Pcs_Qty
                  ,Mat_Qty
                  ,Use_YN
                  ,Ins_Date
                  ,Ins_Emp
                  ,Up_Date
                  ,Up_Emp)
            VALUES
                  (@Level_Code ,@Level_Name, @Item_lvl1 ,@Item_lvl2 ,@Item_lvl3 ,@Item_lvl4 ,@Item_lvl5, @Box_Qty , @Pcs_Qty , @Mat_Qty ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.


                    cmd.Parameters.AddWithValue("@Item_lvl1", additem.Item_lvl1);
                    cmd.Parameters.AddWithValue("@Item_lvl2", additem.Item_lvl2);
                    cmd.Parameters.AddWithValue("@Item_lvl3", additem.Item_lvl3);
                    cmd.Parameters.AddWithValue("@Item_lvl4", additem.Item_lvl4);
                    cmd.Parameters.AddWithValue("@Item_lvl5", additem.Item_lvl5);
                    cmd.Parameters.AddWithValue("@Box_Qty", additem.Box_Qty);
                    cmd.Parameters.AddWithValue("@Pcs_Qty", additem.Pcs_Qty);
                    cmd.Parameters.AddWithValue("@Mat_Qty", additem.Mat_Qty);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Ins_Emp);


                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public List<ItemInfoVO> ItemLevelGroupSelect(string groupName)
        {
            string sQuery = @"select Level_Code
                                              ,Level_Name
                                              ,Item_lvl1
                                              ,Item_lvl2
                                              ,Item_lvl3
                                              ,Item_lvl4
                                              ,Item_lvl5
                                              ,Box_Qty
                                              ,Pcs_Qty
                                              ,Mat_Qty,
                                            case when Use_YN='Y' then 1 else 0 end Use_YN, CONVERT(char(10), Ins_Date, 23) Ins_Date, Ins_Emp, CONVERT(char(10), Up_Date, 23)  Up_Date, Up_Emp
                                        from Item_Level_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(groupName))
                sQuery += " and Level_Code Like @Level_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(groupName))
                    cmd.Parameters.AddWithValue("@Level_Name", "%" + groupName + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<ItemInfoVO> list = Helper.DataReaderMapToList<ItemInfoVO>(reader);
                return list;
            }
        }

        public DataTable ItemLevelBinding()
        {
            DataTable dt = new DataTable();
            string sql = "select Level_Code, Level_Name from Item_Level_Master";
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }

            return dt;
        }

        public bool InsertAllitem_Master(Item_MasterVO item) //수정필요
        {
            string sql = $@"INSERT INTO Item_Master
                                 (Item_Code  ,Item_Name    ,Item_Type  ,Item_Spec    ,Item_Unit ,Level_1    , Level_2    ,Level_3 ,Level_4    ,Level_5                      
                                ,Item_Stock   ,PrdQty_Per_Hour  ,PrdQTy_Per_Batch    ,Cavity   ,Line_Per_Qty    ,Shot_Per_Qty  ,Dry_GV_Qty   ,Ins_Date   ,Ins_Emp, Up_Date, Up_Emp
                                 )
                          VALUES
                                (@Item_Code  , @Item_Name    , @Item_Type  , @Item_Spec    , @Item_Unit , @Level_1    ,@ Level_2    ,@Level_3 , @Level_4    , @Level_5                      
                                 ,@Item_Stock   , @PrdQty_Per_Hour  , @PrdQTy_Per_Batch    , @Cavity   , @Line_Per_Qty    , @Shot_Per_Qty  , @Dry_GV_Qty   , convert(char(10), GetDATE(), 23) Ins_Date , 'test' , convert(char(10), GetDATE(), 23) Ins_Date ) Up_Date, 'test'";
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
	                                        Cavity = @Cavity, 
	                                        Line_Per_Qty = @Line_Per_Qty,
	                                        Shot_Per_Qty = @Shot_Per_Qty,    
	                                        Up_Date = convert(char(10), GetDATE(), 23),
	                                        Up_Emp = 'test1'     
	                                     WHERE Item_Code = @Item_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Item_Code", upitem.Item_Code);
                cmd.Parameters.AddWithValue("@Cavity", upitem.Cavity);
                cmd.Parameters.AddWithValue("@Line_Per_Qty", upitem.Line_Per_Qty);
                cmd.Parameters.AddWithValue("@Shot_Per_Qty", upitem.Shot_Per_Qty);
                //cmd.Parameters.AddWithValue("@Up_Emp", upitem.Up_Emp);


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

