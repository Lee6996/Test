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

        public bool InsertAllDef_Master(Def_MaVO def)
        {
            throw new NotImplementedException();
        }
    }
}

