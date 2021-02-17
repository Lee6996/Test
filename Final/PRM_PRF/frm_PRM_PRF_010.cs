using Final.PRM_PRF.PopUp;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// 근태현황분석
/// 근무자의 근태를 상세하게 확인하고 조회가능
/// </summary>
namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_010 : Final.MDI_Parent.frm_MDIParent_2Grid
    {
        string user_Name;
        public frm_PRM_PRF_010()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("User")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUser_ID.Text = frm.SCode;
                txtUser_Name.Text = frm.SName;
                RefreshState();
            }
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void frm_PRM_PRF_010_Load(object sender, EventArgs e)
        {
            SetDgv_1(dgvPRM_PRF_1);
            SetDgv_2(dgvPRM_PRF_2);
            RefreshState();
        }

        private void dgvPRM_PRF_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user_Name = dgvPRM_PRF_1["user_Name", dgvPRM_PRF_1.CurrentRow.Index].Value.ToString();
            RefreshState_2(user_Name);
        }

        #region MyMethod

        #region DGV1
        private void SetDgv_1(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
        }
        private void RefreshState()
        {
            dgvPRM_PRF_1.DataSource = new PRM_PRF_Service().SelectWorkHistoryPivot(dtpFrom.Value.ToString(), dtpTo.Value.ToString(), txtUser_ID.Text);
            dgvPRM_PRF_2.DataSource = null;
        }


        #endregion

        #region DGV2
        private void SetDgv_2(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장코드", "Wc_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장명", "Wc_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업시작일시", "Work_StartTime", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업종료일시", "Work_EndTime", 200);
            CommonUtil.AddGridTextColumn(dgv, "생산수량", "Prd_Qty", 200);
            CommonUtil.AddGridTextColumn(dgv, "할당작업자", "User_Name", 200);
        }

        private void RefreshState_2(string user_Name)
        {
            dgvPRM_PRF_2.DataSource = new PRM_PRF_Service().GetAttendanceManagementVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString(), user_Name);
        }

        #endregion

        #endregion


    }
}
