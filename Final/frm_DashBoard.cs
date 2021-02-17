using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final
{
    public partial class frm_DashBoard : Form
    {
        public frm_DashBoard()
        {
            InitializeComponent();
        }

        private void ChartLoad()
        {
            List<WorkOrderVO> listWork = new WorkOrderService().listWork(DateTime.Now.AddDays(-7).ToString(), DateTime.Now.ToString());
            chartDate.Series.Clear();
            chartDate.Series.Add("생산량");
            chartDate.Series["생산량"].ChartType = SeriesChartType.Column;
            chartDate.Series["생산량"].IsValueShownAsLabel = true;
            int i = 0;
            foreach (var item in listWork)
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

        private void frm_DashBoard_Load(object sender, EventArgs e)
        {
            ChartLoad();
            SetDGV(dgv1, 1);
            SetDGV(dgv2, 2);
            SetDGV(dgv3, 3);
            BindDGV(dgv1, 1);
            BindDGV(dgv2, 2);
            BindDGV(dgv3, 3);
        }

        private void SetDGV(DataGridView dgv, int no)
        {
            switch (no)
            {
                case 1:
                    CommonUtil.SetInitGridView(dgv);
                    CommonUtil.AddGridTextColumn(dgv, "대차코드", "GV_Code", 135);
                    CommonUtil.AddGridTextColumn(dgv, "대차명", "GV_Name", 135);
                    CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 150);
                    CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 150);
                    CommonUtil.AddGridTextColumn(dgv, "대차상태", "GV_Status", 140);
                    CommonUtil.AddGridTextColumn(dgv, "로딩일자", "Loading_date", 144);
                    break;
                case 2:
                    CommonUtil.SetInitGridView(dgv);
                    CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 140);
                    CommonUtil.AddGridTextColumn(dgv, "작업지시일자", "Plan_Date", 144);
                    CommonUtil.AddGridTextColumn(dgv, "작업지시상태", "Wo_Status", 132);
                    CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 150);
                    CommonUtil.AddGridTextColumn(dgv, "공정명", "Process_name", 125);
                    CommonUtil.AddGridTextColumn(dgv, "작업장", "Wc_Name", 135);
                    break;
                case 3:
                    CommonUtil.SetInitGridView(dgv);

                    CommonUtil.AddGridTextColumn(dgv, "화면코드", "Screen_Code", 200);
                    CommonUtil.AddGridTextColumn(dgv, "화면명", "Screen_Name", 200);
                    CommonUtil.AddGridTextColumn(dgv, "화면경로", "Screen_Path", 230);
                    CommonUtil.AddGridTextColumn(dgv, "수정일자", "Up_Date", 178);
                    break;
            }
        }
        private void BindDGV(DataGridView dgv, int no)
        {
            switch (no)
            {
                case 1:
                    dgv.DataSource = new DashBoardService().GetDashBoardGV();
                    break;
                case 2:
                    dgv.DataSource = new DashBoardService().GetDashBoardWorkOrder();
                    break;
                case 3:
                    dgv.DataSource = new DashBoardService().GetScreenVOList();
                    break;
            }
        }
    }
}
