using Final.PRM_PRF.PopUp;
using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PPS_MLD
{
    public partial class frm_PPS_MLD_001 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtMNameText { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public frm_PPS_MLD_001()
        {
            InitializeComponent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Mold")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.SCode;
            }
        }

        private void frm_PPS_MLD_001_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_Mold);

            CommonUtil.AddGridTextColumn(dgv_Mold, "금형코드", "Mold_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형명", "Mold_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형그룹", "Mold_Group", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형상태", "Mold_Status", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형누적타수", "Cum_Shot_Cnt", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형누적생산량", "Cum_Prd_Qty", 140);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형누적사용시간", "Cum_Time", 160);
            CommonUtil.AddGridTextColumn(dgv_Mold, "보장타수", "Guar_Shot_Cnt", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "구입금액", "Purchase_Amt", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "입고일자", "In_Date", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "최종장착일시", "Last_Setup_Time", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "비고", "Remark", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "사용유무", "Use_YN", 120);
            MoldGroupComboT();
            GetData();
            MoldGroupCombo();
        }
        private void GetData()
        {
            MoldService service = new MoldService();

            List<MoldVO> list = service.SelectMold();

            dgv_Mold.DataSource = null;
            dgv_Mold.DataSource = list;

            panel10.Enabled = false;
            btnMoldUpdate.Visible = true;
            btnMoldInsert.Visible = true;
        }
        private void ChangeGetData()
        {
            if (cbMoldGroupT.Text == null)
            {
                MoldService service = new MoldService();

                List<MoldVO> list = service.SelectMoldCode(textBox1.Text, cbMoldGroupT.Text);

                dgv_Mold.DataSource = null;
                dgv_Mold.DataSource = list;

                panel10.Enabled = false;
                btnMoldUpdate.Visible = true;
                btnMoldInsert.Visible = true;
            }
            if (textBox1.Text == null)
            {
                MoldService service = new MoldService();

                List<MoldVO> list = service.SelectMoldGroup(textBox1.Text, cbMoldGroupT.Text);

                dgv_Mold.DataSource = null;
                dgv_Mold.DataSource = list;

                panel10.Enabled = false;
                btnMoldUpdate.Visible = true;
                btnMoldInsert.Visible = true;
            }
            if(textBox1.Text != null && cbMoldGroupT.Text != null)
            {
                MoldService service = new MoldService();

                List<MoldVO> list = service.SelectMolds(textBox1.Text, cbMoldGroupT.Text);

                dgv_Mold.DataSource = null;
                dgv_Mold.DataSource = list;

                panel10.Enabled = false;
                btnMoldUpdate.Visible = true;
                btnMoldInsert.Visible = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeGetData();
        }
        private void cbMoldGroupT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeGetData();

        }
        private void btnNewMold_Click(object sender, EventArgs e)
        { 
            txtMoldCode.Clear();
            txtMoldName.Clear();
            txtMoldGuarCnt.Clear();
            txtMoldAmt.Clear();
            txtMoldRemark.Clear();
            MoldGroupCombo();
            btnMoldInsert.Visible = true;
            panel10.Enabled = true;
            txtMoldGuarCnt.Enabled = true;
            btnMoldUpdate.Visible = false;

        }
        private void dgv_Mold_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMoldCode.Text = dgv_Mold[0, dgv_Mold.CurrentRow.Index].Value.ToString();
            txtMoldName.Text = dgv_Mold[1, dgv_Mold.CurrentRow.Index].Value.ToString();
            cbMoldGroupB.Text = dgv_Mold[2, dgv_Mold.CurrentRow.Index].Value.ToString();
            txtMoldGuarCnt.Text = dgv_Mold[7, dgv_Mold.CurrentRow.Index].Value.ToString();
            txtMoldAmt.Text = dgv_Mold[8, dgv_Mold.CurrentRow.Index].Value.ToString();
            dtpInDate.Text = dgv_Mold[9, dgv_Mold.CurrentRow.Index].Value.ToString();
            dtpLastSetup.Text = dgv_Mold[10, dgv_Mold.CurrentRow.Index].Value.ToString();
            txtMoldRemark.Text = dgv_Mold[11, dgv_Mold.CurrentRow.Index].Value.ToString();
            cbMoldUse.Text = dgv_Mold[12, dgv_Mold.CurrentRow.Index].Value.ToString();

            panel10.Enabled = true;
            txtMoldGuarCnt.Enabled = false;
            btnMoldInsert.Visible = false;
            btnMoldUpdate.Visible = true;
        }
        private void MoldGroupCombo()
        {
            MoldService service = new MoldService();
            List<MoldGroupVO> List = service.GetMoldGroup();
            CommonUtil.ComboBindingMold(cbMoldGroupB, List, "", true, "선택");
        }
        private void MoldGroupComboT()
        {
            MoldService service = new MoldService();
            List<MoldGroupVO> List = service.GetMoldGroup();
            CommonUtil.ComboBindingMold(cbMoldGroupT, List, "", true, "선택");
        }
            private void btnMoldInsert_Click(object sender, EventArgs e)
        {
            MoldVO mold = new MoldVO
            {
                Mold_Code = txtMoldCode.Text,
                Mold_Name = txtMoldName.Text,
                Mold_Group = cbMoldGroupB.Text,
                Guar_Shot_Cnt = Convert.ToInt32(txtMoldGuarCnt.Text),
                Purchase_Amt = Convert.ToInt32(txtMoldAmt.Text),
                In_Date = dtpInDate.Text,
                Remark = txtMoldRemark.Text,
                Use_YN = cbMoldUse.Text
            };
            MoldService service = new MoldService();
            bool bFlag = service.InsertMold(mold);
            MessageBox.Show("추가가 완료되었습니다.");
            clearControl();
        }

        private void btnMoldUpdate_Click(object sender, EventArgs e)
        {
            MoldVO mold = new MoldVO
            {
                Mold_Code = txtMoldCode.Text,
                Mold_Name = txtMoldName.Text,
                Mold_Group = cbMoldGroupB.Text,
                Purchase_Amt = Convert.ToInt32(txtMoldAmt.Text),
                Remark = txtMoldRemark.Text,
                Use_YN = cbMoldUse.Text
            };
            MoldService service = new MoldService();
            bool bFlag = service.UpdateMold(mold);
            MessageBox.Show("수정이 완료되었습니다.");
            clearControl();
        }
        private void clearControl()
        {
            txtMoldCode.Clear();
            txtMoldName.Clear();
            txtMoldGuarCnt.Clear();
            txtMoldAmt.Clear();
            txtMoldRemark.Clear();
            MoldGroupCombo();
            panel10.Enabled = false;
            btnMoldUpdate.Visible = true;
            btnMoldInsert.Visible = true;

        }
    }
}
