using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_001 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public frm_PRM_PRF_001()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_001_Load(object sender, EventArgs e)
        {

            CommonUtil.SetInitGridView(dgvPRM_PRF_001);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업지시번호", "CommonCode", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업지시일자", "CommonCode", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업지시상태", "name", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "품목코드", "safestock", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "품목명", "stock", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업장", "safestock", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "투입수량", "stock", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "산출수량", "safestock", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "생산수량", "stock", 150);
        }
    }
}
