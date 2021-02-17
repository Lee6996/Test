using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.QAM_SQC
{
    public partial class frm_QAM_SQC_004 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        public frm_QAM_SQC_004()
        {
            InitializeComponent();
        }

        private void frm_QAM_SQC_004_Load(object sender, EventArgs e)
        {

        }

        #region
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "생산년도", "YYYY", 336);
            CommonUtil.AddGridTextColumn(dgv, "레벨코드", "Level_Code", 336);
            CommonUtil.AddGridTextColumn(dgv, "레벨명", "Level_Name", 336);
            CommonUtil.AddGridTextColumn(dgv, "차수", "Prd_Order", 336);
            CommonUtil.AddGridTextColumn(dgv, "원자재LOT번호", "Mat_LotNo", 336);
        }

        private void RefreshState()
        {
            dgvQAM_SQC.DataSource = new QAM_SQC_Service().GetLotVOList(YYYY);
        }
        #endregion
    }
}
