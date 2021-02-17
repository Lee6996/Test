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
    public partial class frm_KPI_RPT_003 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return txtPCodeText.Text; } set { txtPCodeText.Text = value; } }
        public string txtWNameText { get { return txtWCodeText.Text; } set { txtWCodeText.Text = value; } }
        public frm_KPI_RPT_003()
        {
            InitializeComponent();
        }


        private void frm_KPI_RPT_3_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-7);
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
            CommonUtil.SetInitGridView(dgv_KPI_MONTH);

            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "품목군", "Item_Type", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "품목구분", "Item_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "품목명", "Item_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "목표생산량", "PrdQty_Per_Hour", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_MONTH, "생산수량", "Prd_Qty", 120);

            GetData();
        }
        private void GetData()
        {
            WorkDayService service = new WorkDayService();

            List<WorkItemVO> list = service.SelectWorkItem(dateTimePicker1.Text, dateTimePicker2.Text, txtWCodeText.Text);

            dgv_KPI_MONTH.DataSource = null;
            dgv_KPI_MONTH.DataSource = list;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
