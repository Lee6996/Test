using Final.PRM_PRF.PopUp;
using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PPS_SCH
{
    public partial class frm_PPS_SCH_002 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtWNameText { get { return textBox6.Text; } set { textBox6.Text = value; } }
        WorkOrderVO work;
        public frm_PPS_SCH_002()
        {
            InitializeComponent();
        }

        private void frm_PPS_SCH_002_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_Work);

            CommonUtil.AddGridTextColumn(dgv_Work, "작업지시상태 ", "Wo_Status", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "작업지시번호 ", "Workorderno", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "계획일자 ", "Plan_Date", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "계획수량 ", "Plan_Qty", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "계획수량단위 ", "Plan_Unit", 180);
            CommonUtil.AddGridTextColumn(dgv_Work, "품목코드 ", "Item_Code", 160);
            CommonUtil.AddGridTextColumn(dgv_Work, "작업장코드 ", "Wc_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "작업시작시간 ", "Prd_Starttime", 140);
            CommonUtil.AddGridTextColumn(dgv_Work, "작업종료시작 ", "Prd_Endtime", 160);
            CommonUtil.AddGridTextColumn(dgv_Work, "산출수량  ", "Out_Qty_Main", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "생산수량 ", "Prd_Qty", 120);
            CommonUtil.AddGridTextColumn(dgv_Work, "생산의뢰순번  ", "Wo_Req_No", 120);

            GetData();
        }
        private void GetData()
        {
            WorkOrderService service = new WorkOrderService();

            List<WorkOrderVO> listWork = service.listWork(dateTimePicker1.Text, dateTimePicker2.Text);

            dgv_Work.DataSource = null;
            dgv_Work.DataSource = listWork;


        }

        private void btn_WorkCenter_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("WC")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = frm.SCode;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();

            List<WorkOrderVO> listWork = service.listWork(dateTimePicker1.Text, dateTimePicker2.Text, textBox6.Text);

            dgv_Work.DataSource = null;
            dgv_Work.DataSource = listWork;

        }

        private void dgv_Work_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtWorkorder.Text = dgv_Work[1, dgv_Work.CurrentRow.Index].Value.ToString(); 
            txtItem.Text = dgv_Work[5, dgv_Work.CurrentRow.Index].Value.ToString(); 
            dtpPlanDate.Text = dgv_Work[2, dgv_Work.CurrentRow.Index].Value.ToString(); 
            nuPlanQty.Value = Convert.ToInt32(dgv_Work[3, dgv_Work.CurrentRow.Index].Value.ToString()) ;
            txtPlanUnit.Text = dgv_Work[4, dgv_Work.CurrentRow.Index].Value.ToString();

            work = new WorkOrderVO()
            {
                Workorderno = txtWorkorder.Text,
                Item_Code = txtItem.Text,
                Plan_Date = dtpPlanDate.Text,
                Plan_Qty = Convert.ToInt32(nuPlanQty.Value),
                Plan_Unit = txtPlanUnit.Text
            };


            panel10.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string Workorder = dgv_Work[1, dgv_Work.CurrentRow.Index].Value.ToString();

            WorkOrderService service = new WorkOrderService();

            bool bFlag = service.UpdateWorkorder(Workorder);

            GetData();
            panel10.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            string Status = "생산중";
            bool bFlag = service.UpdateWorkorder(work, Status);

            GetData();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();
            string Status = "작업지시마감";
            bool bFlag = service.UpdateWorkorder(work, Status);

            GetData();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
