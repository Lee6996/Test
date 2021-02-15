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
        public bool Use_YNItem_Level_Master(string groupcode, string used)
        {
            string sql = " update Def_Ma_Master set Use_YN = @Use_YN where Def_Ma_Code = @Def_Ma_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Def_Ma_Code", groupcode);
                cmd.Parameters.AddWithValue("@Use_YN", used);

                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public List<Def_MaVO> GetAllDef_Ma_Master(string def)
        {
            string sQuery = @"SELECT Def_Ma_Code
      ,Def_Ma_Name
      ,Use_YN
      ,Ins_Date
      ,Ins_Emp
      ,Up_Date
      ,Up_Emp
  FROM Def_Ma_Master where 1 = 1  ";

            if (!string.IsNullOrEmpty(def))
                sQuery += " and Def_Ma_Code Like @Def_Ma_Name ";

            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                if (!string.IsNullOrEmpty(def))
                    cmd.Parameters.AddWithValue("@Def_Ma_Name", "%" + def + "%"); //포함하는 문자열

                SqlDataReader reader = cmd.ExecuteReader();
                List<Def_MaVO> list = Helper.DataReaderMapToList<Def_MaVO>(reader);
                return list;
            }
        }

        public bool UpdateDef_Ma(Def_MaVO vo)
        {
            string sql = $@"UPDATE Def_Ma_Master
   SET    
       Def_Ma_Name = @Def_Ma_Name     
      ,Up_Date = convert(char(10), GetDATE(), 23)
	   ,Up_Emp = 'test1' 
 WHERE Def_Ma_Code = @Def_Ma_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Def_Ma_Code", vo.Def_Ma_Code);
                cmd.Parameters.AddWithValue("@Def_Ma_Name", vo.Def_Ma_Name);                
                //cmd.Parameters.AddWithValue("@Up_Emp", vo.Up_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public bool InsertDef_Ma(Def_MaVO vo)
        {
            string sQuery = @"select count(*) 
                              from Def_Ma_Master where 1 = 1 and Def_Ma_Code = @Def_Ma_Code and Def_Ma_Name = @Def_Ma_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Def_Ma_Code", vo.Def_Ma_Code);
                cmd.Parameters.AddWithValue("@Def_Ma_Name", vo.Def_Ma_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"INSERT INTO Def_Ma_Master
           (Def_Ma_Code
           ,Def_Ma_Name
           ,Use_YN
           ,Ins_Date
           ,Ins_Emp
           ,Up_Date
           ,Up_Emp)
     VALUES
           (@Def_Ma_Code
           ,@Def_Ma_Name
           ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.



                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Ins_Date);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Ins_Emp);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Up_Date);
                    //cmd.Parameters.AddWithValue("@Ins_Emp", additem.Up_Emp);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public DataTable DefBinding()
        {
                DataTable dt = new DataTable();
                string sql = "select Def_Ma_Name, Def_Ma_Code from Def_Ma_Master";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }

                return dt;            
        }

        public bool InsertAllDef_Master(Def_MaVO def)
        {
            string sql = $@"INSERT INTO Def_Ma_Master (Def_Ma_Code, Def_Ma_Name, Ins_Emp) values(@Def_Ma_Code, @Def_Ma_Name, @Ins_Emp)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Def_Ma_Code", def.Def_Ma_Code);
                cmd.Parameters.AddWithValue("@Def_Ma_Name", def.Def_Ma_Name);
                cmd.Parameters.AddWithValue("@Ins_Emp", def.Ins_Emp);


                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
        }      
    }
}

