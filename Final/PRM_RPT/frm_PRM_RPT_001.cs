using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Final.PRM_RPT
{
    public partial class frm_PRM_RPT_001 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public frm_PRM_RPT_001()
        {
            InitializeComponent();
        }

        private void frm_PRM_RPT_001_Activated(object sender, EventArgs e)
        {

        }
        private void ReportBinding()
        {
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            string strConn = new FinalEnc.AESEnc().AESDecrypt256(ConfigurationManager.ConnectionStrings["Team2"].ConnectionString);


            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                
                SqlDataAdapter da = new SqlDataAdapter("select * from View_GVReport where Unloading_date like '" + date + "'", conn);
                da.Fill(dt);
            }
            
            XtraReport1 rpt = new XtraReport1();

            rpt.DataSource = dt;

            documentViewer1.DocumentSource = rpt;
            documentViewer1.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.SubmitParameters, new object[] { true });
            documentViewer1.InitiateDocumentCreation();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ReportBinding();
        }
    }
}
