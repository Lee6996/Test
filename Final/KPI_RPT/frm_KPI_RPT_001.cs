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
    public partial class frm_KPI_RPT_001 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return txtPCodeText.Text; } set { txtPCodeText.Text = value; } }
        public string txtWNameText { get { return txtWCodeText.Text; } set { txtWCodeText.Text = value; } }

        public frm_KPI_RPT_001()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_001_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_KPI_DAY);

            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "생산일자", "Prd_Date", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "근무인원", "User_ID", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "공정", "Process_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "작업장", "Wc_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "제품명", "Item_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "실적", "Prd_Qty", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "생산시간", "WorkTime", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "시간당생산량", "PrdQty_Per_Hour", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "비가동시간", "Nop_Check_Time", 120);

           // GetData();
        }
        private void GetData()
        {
            WorkDayService service = new WorkDayService();

            List<WorkDayVO> list = service.SelectWorkDay(dateTimePicker1.Text, dateTimePicker2.Text, txtPCodeText.Text, txtWCodeText.Text);

            dgv_KPI_DAY.DataSource = null;
            dgv_KPI_DAY.DataSource = list;

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

        private void txtWCodeText_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtPCodeText_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
