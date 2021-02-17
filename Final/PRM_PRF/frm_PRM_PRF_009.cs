using Final.PRM_PRF.PopUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// 근태정보조회
/// 근무자의 모든 근태 정보를 확인하고 조회가능
/// </summary>
namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_009 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        public frm_PRM_PRF_009()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_09_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            RefreshState();
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void btnWorkCenter_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("WC")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtWorkCenter.Text = frm.SCode;
                txtWorkCenterDetail.Text = frm.SName;
                RefreshState();
            }
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "근무일", "Work_Date", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장", "Wc_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업자", "User_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "근무시작시간", "Work_StartTime", 200);
            CommonUtil.AddGridTextColumn(dgv, "근무종료시간", "Work_EndTime", 200);
            CommonUtil.AddGridTextColumn(dgv, "근무시간", "Work_Time", 200);
        }

        private void RefreshState()
        {
            dgvPRM_PRF.DataSource = new PRM_PRF_Service().GetWorkHistoryVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString(), txtWorkCenterDetail.Text);
        }



        #endregion

        
    }
}
