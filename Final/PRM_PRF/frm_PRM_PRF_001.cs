using Final.PRM_PRF.PopUp;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_001 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        WorkOrderVO vo;
        List<WorkOrderVO> list; 

        public frm_PRM_PRF_001()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_001_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            RefreshState();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(vo != null)
            {
                PopUp.frm_PRM_PRF_001_PopUp frm = new PopUp.frm_PRM_PRF_001_PopUp(vo);
                frm.ShowDialog();
                RefreshState();
            }
            else
            {
                AutoClosingMessageBox.Show("수정하실 내용을 선택 후 버튼을 눌러주세요.", "3초후 종료...", 3000);
            }

        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void dgvPRM_PRF_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                vo = list[e.RowIndex];
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Process")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtProcess.Text = frm.SCode;
                txtProcessDetail.Text = frm.SName;
                RefreshState();
            }
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
            CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 250);
            CommonUtil.AddGridTextColumn(dgv, "작업지시일자", "Plan_Date", 230);
            CommonUtil.AddGridTextColumn(dgv, "작업지시상태", "Wo_Status", 150);
            CommonUtil.AddGridTextColumn(dgv, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "공정명", "Process_name", 175);
            CommonUtil.AddGridTextColumn(dgv, "작업장", "Wc_Name", 175);
            CommonUtil.AddGridTextColumn(dgv, "투입수량", "In_Qty_Main", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgv, "산출수량", "Out_Qty_Main", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgv, "생산수량", "Prd_Qty", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
        }

        private void RefreshState()
        {
            list = new PRM_PRF_Service().GetWorkOrderVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString(), txtProcess.Text, txtWorkCenter.Text);
            dgvPRM_PRF.DataSource = list;
        }


        #endregion
    }
}