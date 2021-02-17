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
using System.Windows.Forms.DataVisualization.Charting;

namespace Final.PPS_SCH
{
    public partial class frm_PPS_SCH_003 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        List<WorkOrderVO> listWork;
        public frm_PPS_SCH_003()
        {
            InitializeComponent();
        }

        private void frm_PPS_SCH_003_Load(object sender, EventArgs e)
        {
            chartDate.Titles.Add("일별 생산 현황");
            chartDate.Legends.Clear();
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
            ChartLoad();
        }
        private void GetData()
        {
            WorkOrderService service = new WorkOrderService();

            listWork = service.listWork(dateTimePicker1.Text, dateTimePicker2.Text);

            dgv_Work.DataSource = null;
            dgv_Work.DataSource = listWork;
        }
        private void ChartLoad()
        {
            WorkOrderService service = new WorkOrderService();

            List<WorkChartVO> chartWorks = service.ChartWork(dateTimePicker1.Text, dateTimePicker2.Text);

            chartDate.Series.Clear();
            chartDate.Series.Add("생산량");
            chartDate.Series["생산량"].ChartType = SeriesChartType.Column;
            chartDate.Series["생산량"].IsValueShownAsLabel = true;
            int i = 0;
            foreach (var item in chartWorks)
            {
                if (i < 16)
                {
                    chartDate.Series["생산량"].Points.AddXY(item.Prd_Date.ToString().Substring(0, 10), item.Prd_Qty);
                    i++;
                }
                else
                    return;
            }
            chartDate.ChartAreas[0].AxisX.MajorGrid.Enabled = false;// 그래프선 보이기 안보이기
        }

        private void button22_Click(object sender, EventArgs e)
        {
            GetData();
            ChartLoad();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();

            listWork = service.listWork(dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text);

            dgv_Work.DataSource = null;
            dgv_Work.DataSource = listWork;

            ChartLoad();
        }

        private void cbWorkStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkOrderService service = new WorkOrderService();

            listWork = service.listWork(dateTimePicker1.Text, dateTimePicker2.Text, cbWorkStatus.Text ,textBox1.Text);

            dgv_Work.DataSource = null;
            dgv_Work.DataSource = listWork;

            ChartLoad();
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
    }
}