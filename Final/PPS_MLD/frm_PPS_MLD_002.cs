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
    public partial class frm_PPS_MLD_002 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public string txtPNameText { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string txtWNameText { get { return textBox6.Text; } set { textBox6.Text = value; } }

        public frm_PPS_MLD_002()
        {
            InitializeComponent();
        }

        private void frm_PPS_MLD_002_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_Mold);

            CommonUtil.AddGridTextColumn(dgv_Mold, "생산일자", "Prd_Date", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형코드", "Mold_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형명", "Mold_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "작업지시번호", "Workorderno", 140);
            CommonUtil.AddGridTextColumn(dgv_Mold, "품목코드", "Item_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "품목명", "Item_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "작업장코드", "Wc_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "작업장명", "Wc_Name", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형타수", "Mold_Shot_Cnt", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형생산량", "Mold_Prd_Qty", 120);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형사용시작시간", "Use_Starttime", 160);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형사용종료시간", "Use_Endtime", 160);
            CommonUtil.AddGridTextColumn(dgv_Mold, "금형사용시간", "Cum_Time", 120);
             GetData();
        }
        private void GetData()
        {
            MoldService service = new MoldService();

            List<MoldUseVO> list = service.SelectMoldUse();

            dgv_Mold.DataSource = null;
            dgv_Mold.DataSource = list;
        }
        private void ChangeGetData()
        {
            if (textBox1.Text == null)
            {
                MoldService service = new MoldService();

                List<MoldUseVO> list = service.SelectMoldUseWc(dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text, textBox6.Text);

                dgv_Mold.DataSource = null;
                dgv_Mold.DataSource = list;

            }
            if (textBox6.Text == null)
            {
                MoldService service = new MoldService();

                List<MoldUseVO> list = service.SelectMoldUseItem(dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text, textBox6.Text);

                dgv_Mold.DataSource = null;
                dgv_Mold.DataSource = list;
            }
            if (textBox1.Text != null && textBox6.Text != null)
            {
                MoldService service = new MoldService();

                List<MoldUseVO> list = service.SelectMoldUses(dateTimePicker1.Text, dateTimePicker2.Text, textBox1.Text, textBox6.Text);

                dgv_Mold.DataSource = null;
                dgv_Mold.DataSource = list;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            MoldService service = new MoldService();

            List<MoldUseVO> list = service.SelectMoldUses(dateTimePicker1.Text, dateTimePicker2.Text);

            dgv_Mold.DataSource = null;
            dgv_Mold.DataSource = list;
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Item")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = frm.SCode;
            }
        }

        private void btn_WorkCenter_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("WC")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = frm.SCode;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeGetData();
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ChangeGetData();
        }
    }
}
