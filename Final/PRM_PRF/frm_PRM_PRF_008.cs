using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_008 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        public frm_PRM_PRF_008()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_008_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            RefreshState();
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            dgvPRM_PRF.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgv, "비가동일자", "Nop_Date", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장코드", "Wc_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장명", "Wc_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "비가동대분류", "Nop_Mi_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "비가동상세분류", "Nop_Ma_Name", 200);

            CommonUtil.AddGridTextColumn(dgv, "비가동발생시각", "Nop_Happentime", 200);
            CommonUtil.AddGridTextColumn(dgv, "비가동종료시간", "Nop_Canceltime", 200);
            CommonUtil.AddGridTextColumn(dgv, "비가동시간", "Nop_Time", 200);
            CommonUtil.AddGridTextColumn(dgv, "비고", "Remark", 200);
            CommonUtil.AddGridTextColumn(dgv, "발생유형", "Nop_Type", 200);
        }

        private void RefreshState()
        {
            dgvPRM_PRF.DataSource = new PRM_PRF_Service().GetNOPVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString());
        }

        #endregion


    }
}
