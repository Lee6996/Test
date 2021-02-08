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
    public partial class frm_KPI_RPT_W : Form
    {
        public string ResultCode { get; set; }
        public frm_KPI_RPT_W()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_W_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_WorkCenter);

            CommonUtil.AddGridTextColumn(dgv_WorkCenter, "작업장코드", "Wc_Code", 240);
            CommonUtil.AddGridTextColumn(dgv_WorkCenter, "작업장이름", "Wc_Name", 240);

            GetData();
        }
        private void GetData()
        {
            WorkCenterService service = new WorkCenterService();

            List<WorkCenterVO> list = service.SelectWorkCenter();

            dgv_WorkCenter.DataSource = null;
            dgv_WorkCenter.DataSource = list;

        }

        private void dgv_WorkCenter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ResultCode = dgv_WorkCenter[0, dgv_WorkCenter.CurrentRow.Index].Value.ToString();
            this.Close();
        }
    }
}
