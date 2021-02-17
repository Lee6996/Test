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
        }
    }
}
