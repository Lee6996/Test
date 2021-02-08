using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.KPI_RPT
{
    public partial class frm_KPI_RPT_4 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return txtPCodeText.Text; } set { txtPCodeText.Text = value; } }
        public string txtWNameText { get { return txtWCodeText.Text; } set { txtWCodeText.Text = value; } }
        public frm_KPI_RPT_4()
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

        private void frm_KPI_RPT_4_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_KPI_BOXING);

            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "품목코드", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "품목명", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "누계포장량", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_BOXING, "전일포장량", "", 120);
        }
    }
}
