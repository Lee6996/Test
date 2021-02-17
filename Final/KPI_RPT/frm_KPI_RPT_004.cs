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

namespace Final.KPI_RPT
{
    public partial class frm_KPI_RPT_004 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return txtPCodeText.Text; } set { txtPCodeText.Text = value; } }
        public string txtWNameText { get { return txtWCodeText.Text; } set { txtWCodeText.Text = value; } }
        public frm_KPI_RPT_004()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_4_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Process")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtPCodeText.Text = frm.SCode;
            }
        }
        private void btn_WorkCenter_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("WC")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtWCodeText.Text = frm.SCode;

            }
        }

        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_KPI_BOXING);

            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "품목코드", "Item_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "품목명", "Item_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "포장일자", "Prd_Date", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "일일포장량", "In_Qty", 120);

            GetData();
        }
        private void GetData()
        {
            WorkDayService service = new WorkDayService();

            List<WorkBoxingVO> list = service.SelectWorkBoxing(dateTimePicker1.Text, dateTimePicker2.Text, txtWCodeText.Text);

            dgv_KPI_BOXING.DataSource = null;
            dgv_KPI_BOXING.DataSource = list;

        }

    }
}
