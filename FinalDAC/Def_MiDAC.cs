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
    public class Def_MiDAC
    {
        #region Connection Open
        static SqlConnection conn;
        public Def_MiDAC()
        {
            conn = new SqlConnection(new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["team2"].ConnectionString));
            conn.Open();
        }
        #endregion

        public List<Def_MiVO> GetAllDef_Mi_Master(string def)
        {
            
                string sQuery = @"SELECT
       Def_Mi_Code
      ,Def_Ma_Code
      ,Def_Mi_Name
      ,Use_YN
      ,Remark
      ,Ins_Date
      ,Ins_Emp
      ,Up_Date
      ,Up_Emp
  FROM Def_Mi_Master where 1 = 1  ";

                if (!string.IsNullOrEmpty(def))
                    sQuery += " and Def_Mi_Code Like @Def_Mi_Name ";

                using (SqlCommand cmd = new SqlCommand(sQuery, conn))
                {
                    if (!string.IsNullOrEmpty(def))
                        cmd.Parameters.AddWithValue("@Def_Mi_Name", "%" + def + "%"); //포함하는 문자열

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Def_MiVO> list = Helper.DataReaderMapToList<Def_MiVO>(reader);
                    return list;
                }
            }

        public bool UpdateDef_Ma(Def_MiVO additem)
        {
            string sql = $@"UPDATE Def_Mi_Master
   SET 
      Def_Ma_Code = @Def_Ma_Code
      ,Def_Mi_Name = @Def_Mi_Name 
      ,Remark = @Remark           
      ,Up_Date = convert(char(10), GetDATE(), 23)
	   ,Up_Emp = 'test1' 
 WHERE Def_Mi_Code = @Def_Mi_Code";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Def_Mi_Code", additem.Def_Mi_Code);
                cmd.Parameters.AddWithValue("@Def_Mi_Name", additem.Def_Mi_Name);
                cmd.Parameters.AddWithValue("@Def_Ma_Code", additem.Def_Ma_Code);
                cmd.Parameters.AddWithValue("@Remark", additem.Remark);
                //cmd.Parameters.AddWithValue("@Up_Emp", vo.Up_Emp);


                if (cmd.ExecuteNonQuery() > 0) return true;
                else return false;
            }
        }

        public bool InsertDef_Mi(Def_MiVO vo)
        {
            string sQuery = @"select count(*) 
                              from Def_Mi_Master where 1 = 1 and Def_Mi_Code = @Def_Mi_Code and Def_Mi_Name = @Def_Mi_Name ";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Def_Mi_Code", vo.Def_Mi_Code);
                cmd.Parameters.AddWithValue("@Def_Mi_Name", vo.Def_Mi_Name);

                int iCnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (iCnt > 0)
                    return false;
                else
                {
                    sQuery = @"INSERT INTO Def_Mi_Master
           (Def_Mi_Code
           ,Def_Ma_Code
           ,Def_Mi_Name
          
           ,Remark
 ,Use_YN
           ,Ins_Date
           ,Ins_Emp
           ,Up_Date
           ,Up_Emp)
     VALUES
           (@Def_Mi_Code
           ,@Def_Ma_Code
           ,@Def_Mi_Name
           ,@Remark
           ,'Y'  , getdate(),'test', getdate(), 'test')";// test수정필요.
                    cmd.Parameters.AddWithValue("@Def_Ma_Code", vo.Def_Ma_Code);
                    cmd.Parameters.AddWithValue("@Remark", vo.Remark);



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
    }
}
