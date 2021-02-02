﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.KPI_RPT
{
    public partial class frm_KPI_RPT_1 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public frm_KPI_RPT_1()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_1_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_KPI_DAY);

            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "생산일자", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "근무인원", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "공정", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "작업장", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "제품명", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "실적", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "생산시간", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "시간당생산량", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "가스사용량", "", 120);
            CommonUtil.AddGridTextColumn(dgv_KPI_DAY, "비가동시간", "", 120);
        }
    }
}
