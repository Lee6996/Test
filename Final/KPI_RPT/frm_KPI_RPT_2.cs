using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.KPI_RPT
{
    public partial class frm_KPI_RPT_2 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return txtPCodeText.Text; } set { txtPCodeText.Text = value; } }
        public string txtWNameText { get { return txtWCodeText.Text; } set { txtWCodeText.Text = value; } }
        public frm_KPI_RPT_2()
        {
            InitializeComponent();
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            frm_KPI_RPT_P process = new frm_KPI_RPT_P();
            if (process.ShowDialog() == DialogResult.OK)
            {
                this.txtPNameText = process.ResultCode;
                txtPCodeText.Text = txtPNameText;
            }
        }

        private void btn_WorkCenter_Click(object sender, EventArgs e)
        {
            frm_KPI_RPT_W workcenter = new frm_KPI_RPT_W();
            if (workcenter.ShowDialog() == DialogResult.OK)
            {
                this.txtWNameText = workcenter.ResultCode;
                txtWCodeText.Text = txtWNameText;
            }
        }

        private void frm_KPI_RPT_2_Load(object sender, EventArgs e)
        {
            DataLoad();
        }


        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_KPI_MONTH);

            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "공정", "Process_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "작업장", "Wc_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "품목", "Item_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "전월생산량", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "전월생산시간", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "당월생산량", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "당월생산시간", "", 120);

            GetData();
        }
        private void GetData()
        {
            WorkDayService service = new WorkDayService();

            List<WorkDayVO> list = service.SelectWorkDay();

            dgv_KPI_MONTH.DataSource = null;
            dgv_KPI_MONTH.DataSource = list;

        }
    }
}
