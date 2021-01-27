using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalVO;

namespace FinalDAC
{
    public class PRM_PRF_DAC
    {
        SqlConnection conn;

        public PRM_PRF_DAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["team2"].ConnectionString);
            conn.Open();
        }

        public List<WorkOrderVO> Select_001()
        {
            string sQuery = "select * from view_workorder";
            using (SqlCommand cmd = new SqlCommand(sQuery, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<WorkOrderVO> list = Helper.DataReaderMapToList<WorkOrderVO>(reader);

                conn.Close();
                return list;
            }
        }
    }
}
