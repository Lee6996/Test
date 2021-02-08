using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_003 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        public frm_PRM_PRF_003()
        {
            InitializeComponent();
        }

        private void dgvPRM_PRF_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_PRM_PRF_003_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            RefreshState();
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        #region Mymethod

        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            dgv.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgv, "입고일자", "In_Date", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업지시상태", "Wo_Status", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "팔렛트번호", "Pallet_No", 200);
            CommonUtil.AddGridTextColumn(dgv, "입고수량", "In_Qty", 200);
            CommonUtil.AddGridTextColumn(dgv, "마감시간", "Closed_Time", 200);
        }

        private void RefreshState()
        {
            dgvPRM_PRF.DataSource = new PRM_PRF_Service().GetSelectReceivingListVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString());
        }
        #endregion
    }
}
