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
/// 대차 이력 조회
/// 사용한 대차의 이력을 확인하고 조회 가능
/// </summary>
namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_006 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        public frm_PRM_PRF_006()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_006_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            RefreshState();
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("GV")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtGVCode.Text = frm.SCode;
                txtGVDetail.Text = frm.SName;
                RefreshState();
            }
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Item")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtItemCode.Text = frm.SCode;
                txtItemDetail.Text = frm.SName;
                RefreshState();
            }
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            dgvPRM_PRF.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgv, "대차코드", "GV_Code", 150);
            CommonUtil.AddGridTextColumn(dgv, "대차명", "GV_Name", 150);
            CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 150);
            CommonUtil.AddGridTextColumn(dgv, "품목코드", "Item_Code", 150);
            CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 150);

            CommonUtil.AddGridTextColumn(dgv, "로딩일자", "Loading_date", 150);
            CommonUtil.AddGridTextColumn(dgv, "로딩수량", "Loading_Qty", 150);
            CommonUtil.AddGridTextColumn(dgv, "로딩시간", "Loading_Datetime", 150);
            CommonUtil.AddGridTextColumn(dgv, "로딩작업장", "Loading_Wc", 150);
            CommonUtil.AddGridTextColumn(dgv, "요입시간", "In_Time", 150);
            CommonUtil.AddGridTextColumn(dgv, "중간시간", "Center_Time", 150);
            CommonUtil.AddGridTextColumn(dgv, "요출시간", "Out_Time", 150);

            CommonUtil.AddGridTextColumn(dgv, "언로딩일자", "Unloading_Date", 150);
            CommonUtil.AddGridTextColumn(dgv, "언로딩수량", "Unloading_Qty", 150);
            CommonUtil.AddGridTextColumn(dgv, "언로딩시간", "Unloading_Datetime", 150);
            CommonUtil.AddGridTextColumn(dgv, "언로딩작업장", "Unloading_wc", 150);

            CommonUtil.AddGridTextColumn(dgv, "대상대차", "Target_GV", 150);
            CommonUtil.AddGridTextColumn(dgv, "대차비우기일자", "Clear_Date", 150);
            CommonUtil.AddGridTextColumn(dgv, "대차비우기일시", "Clear_Datetime", 150);
            CommonUtil.AddGridTextColumn(dgv, "대차비우기수량", "Clear_Qty", 150);
            CommonUtil.AddGridTextColumn(dgv, "대차비우기원인", "Clear_Cause", 150);
            CommonUtil.AddGridTextColumn(dgv, "대상작업장", "Clear_wc", 150);
            CommonUtil.AddGridTextColumn(dgv, "대상작업장품목", "Clear_Item", 150);
        }

        private void RefreshState()
        {
            dgvPRM_PRF.DataSource = new PRM_PRF_Service().GetGVHistoryVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString(),txtGVCode.Text, txtItemCode.Text);
        }
        #endregion
    }
}
