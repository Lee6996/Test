using Final.PRM_PRF.PopUp;
using FinalVO;
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
        List<InspecVo> list;

        public frm_QAM_SQC_004()
        {
            InitializeComponent();
        }

        private void frm_QAM_SQC_004_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvQAM_SQC);
            RefreshState();
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

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 200);
            CommonUtil.AddGridTextColumn(dgv, "생산일", "Prd_Date", 200);
            CommonUtil.AddGridTextColumn(dgv, "공정", "Process_name", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장", "Wc_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 200);

            CommonUtil.AddGridTextColumn(dgv, "측정항목", "Inspect_name", 175);
            CommonUtil.AddGridTextColumn(dgv, "USL", "USL", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgv, "SL", "SL", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
            CommonUtil.AddGridTextColumn(dgv, "LSL", "LSL", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
            
            CommonUtil.AddGridTextColumn(dgv, "측정일시", "Inspect_datetime", 200);
            CommonUtil.AddGridTextColumn(dgv, "상세품목코드", "Inspect_Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "측정순번", "Inspect_measure_seq", 200);
            CommonUtil.AddGridTextColumn(dgv, "측정값", "Inspect_val", 100, textAlign: DataGridViewContentAlignment.MiddleRight, headerAlign: DataGridViewContentAlignment.MiddleRight);
        }

        private void RefreshState()
        {
            list = new QAM_SQC_Service().GetInspecVoList(dtpFrom.Value.ToString(), dtpTo.Value.ToString(), txtProcess.Text, txtWorkCenter.Text);
            dgvQAM_SQC.DataSource = list;
        }


        #endregion

    }
}
