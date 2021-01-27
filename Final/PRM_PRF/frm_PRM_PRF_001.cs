using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// 실적조회
/// 21.01.26 홍민주
/// </summary>
namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_001 : KPI_RPT.KPI_RPT_MDIParent
    {
        public frm_PRM_PRF_001()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_001_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvPRM_PRF_001);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업지시번호", "Workorderno", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업지시일자", "Plan_Date", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업지시상태", "Wo_Status", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "품목코드", "Item_Code", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "작업장", "Wc_Name", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "투입수량", "In_Qty_Main", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "산출수량", "Out_Qty_Main", 150);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_001, "생산수량", "Prd_Qty", 150);
            new PRM_PRF_Service().DgvDataBind(dgvPRM_PRF_001);
        }
    }
}
