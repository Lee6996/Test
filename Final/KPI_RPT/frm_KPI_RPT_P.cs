using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.KPI_RPT
{
    public partial class frm_KPI_RPT_P : Form
    {
        public string ResultCode { get; set; }
        public frm_KPI_RPT_P()
        {
            InitializeComponent();
        }
        private void frm_KPI_RPT_P_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_Process);

            CommonUtil.AddGridTextColumn(dgv_Process, "공정코드", "Process_code", 240);
            CommonUtil.AddGridTextColumn(dgv_Process, "공정이름", "Process_name", 240);

            GetData();
        }
        private void GetData()
        {
            ProcessService service = new ProcessService();

            List<ProcessVO> list = service.SelectProcess();

            dgv_Process.DataSource = null;
            dgv_Process.DataSource = list;

        }

        private void dgv_Process_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ResultCode = dgv_Process[0, dgv_Process.CurrentRow.Index].Value.ToString();
            this.Close();
        }
    }
}
