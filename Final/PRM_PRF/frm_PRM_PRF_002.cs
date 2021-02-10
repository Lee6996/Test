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
    public partial class frm_PRM_PRF_002 : MDI_Parent.frm_MDIParent_2Grid
    {
        List<WorkOrderVO> Wlist;
        List<GoodsInHistoryVO> Glist;
        string workorderno, palletno;

        public frm_PRM_PRF_002()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_002_Load(object sender, EventArgs e)
        {
            SetDgv_1(dgvPRM_PRF_1);
            SetDgv_2(dgvPRM_PRF_2);

            RefreshState();
            
        }
        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void dgvPRM_PRF_1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            workorderno = Wlist[e.RowIndex].Workorderno;
            
            RefreshState_2();
        }

        private void dgvPRM_PRF_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            palletno = Glist[e.RowIndex].Pallet_No;
            //gVO = Glist.Find(palletno => palletno.Pallet_No == dgvPRM_PRF_2[0,dgvPRM_PRF_2.CurrentRow.Index].Value.ToString());
        }

        private void btnWoEnd_Click(object sender, EventArgs e)
        {
            if (new PRM_PRF_Service().Update002_WO(workorderno))
            {

            }
        }

        private void btnPalletEnd_Click(object sender, EventArgs e)
        {
            if (new PRM_PRF_Service().Update002_Pallet(palletno))
            {

            }
        }

        #region MyMethod

        #region DGV1
        private void SetDgv_1(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            //dgv.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgv, "생산일자", "Prd_Date", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업지시번호", "Workorderno", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업지시상태", "Wo_Status", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "작업장", "Wc_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "투입수량", "In_Qty_Main", 200);
            CommonUtil.AddGridTextColumn(dgv, "산출수량", "Out_Qty_Main", 200);
            CommonUtil.AddGridTextColumn(dgv, "생산수량", "Prd_Qty", 200);
        }

        private void RefreshState()
        {
            Wlist = new PRM_PRF_Service().GetWorkOrderVOList(dtpFrom.Value.ToString(), dtpTo.Value.ToString());
            dgvPRM_PRF_1.DataSource = Wlist;
            dgvPRM_PRF_2.DataSource = null;
        }


        #endregion

        #region DGV2
        private void SetDgv_2(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            //dgv.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgv, "팔렛트번호", "Pallet_No", 200);
            CommonUtil.AddGridTextColumn(dgv, "등급코드", "Grade_Detail_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "등급명", "Grade_Detail_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "포장등급코드", "Boxing_Grade_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "포장등급명", "Boxing_Grade_Name", 200);
            CommonUtil.AddGridTextColumn(dgv, "생산수량", "In_Qty", 200);
        }

        private void RefreshState_2()
        {
            Glist = new PRM_PRF_Service().GetGoodsInHistoryVOList(workorderno);
            dgvPRM_PRF_2.DataSource = Glist;
        }

        #endregion
        #endregion


        //private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        //{
        //    if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
        //    {
        //        dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        //    }
        //}
    }
}
