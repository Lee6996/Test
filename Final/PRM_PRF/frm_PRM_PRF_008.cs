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
/// 비가동등록
/// 작업장을 비가동 시키고 해제할 수 있고 조회 가능
/// </summary>
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (new PopUp.frm_PRM_PRF_008_PopUp().ShowDialog() == DialogResult.OK)
                RefreshState();
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridCheckBoxColumn(dgv);
            CommonUtil.AddGridTextColumn(dgv, "비가동일자", "Nop_Date", 150);
            CommonUtil.AddGridTextColumn(dgv, "작업장코드", "Wc_Code", 130);
            CommonUtil.AddGridTextColumn(dgv, "작업장명", "Wc_Name", 130);
            CommonUtil.AddGridTextColumn(dgv, "비가동대분류", "Nop_Mi_Name", 180);
            CommonUtil.AddGridTextColumn(dgv, "비가동상세분류", "Nop_Ma_Name", 150);

            CommonUtil.AddGridTextColumn(dgv, "비가동발생시각", "Nop_Happentime", 220);
            CommonUtil.AddGridTextColumn(dgv, "비가동종료시간", "Nop_Canceltime", 220);
            CommonUtil.AddGridTextColumn(dgv, "비가동시간", "Nop_Time", 120, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgv, "비고", "Remark", 200);
            CommonUtil.AddGridTextColumn(dgv, "발생유형", "Nop_Type", 150);
        }

        private void RefreshState()
        {
            dgvPRM_PRF.DataSource = new PRM_PRF_Service().GetNOPVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString(), txtWorkCenter.Text);
        }
        #endregion
    }
}
