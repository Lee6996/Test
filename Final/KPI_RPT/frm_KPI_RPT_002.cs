﻿using Final.PRM_PRF.PopUp;
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
    public partial class frm_KPI_RPT_002 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return txtPCodeText.Text; } set { txtPCodeText.Text = value; } }
        public string txtWNameText { get { return txtWCodeText.Text; } set { txtWCodeText.Text = value; } }
        public frm_KPI_RPT_002()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_2_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void btn_Process_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("WC")
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
            MainPop frm = new MainPop("Process")
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

            List<WorkDayVO> list = service.SelectWorkDay(dateTimePicker1.Text);

            dgv_KPI_MONTH.DataSource = null;
            dgv_KPI_MONTH.DataSource = list;

        }
    }
}
