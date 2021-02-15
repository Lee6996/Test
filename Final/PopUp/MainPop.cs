using FinalDAC;
using FinalVO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final.PRM_PRF.PopUp
{
    public partial class MainPop : Form
    {
        string type;
        string sCode;
        string sName;
        public string SCode { get => sCode; set => sCode = value; }
        public string SName { get => sName; set => sName = value; }

        public MainPop(string type)
        {
            InitializeComponent();
            this.Text = "찾기";
            this.type = type;
        }

        private void frm_PRM_PRF_MainPop_Load(object sender, EventArgs e)
        {
            switch(type)
            {
                case "WC":
                    lblType.Text = "작업장 목록";
                    SettingDGV(dgvMainPop, type);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<WC>(type);
                    break;

                case "Item":
                    lblType.Text = "품목 목록";
                    SettingDGV(dgvMainPop, type);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<Item>(type);
                    break;

                case "GV":
                    lblType.Text = "대차 목록";
                    SettingDGV(dgvMainPop, type);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<GV>(type);
                    break;
                case "GVGroup":
                    lblType.Text = "대차그룹 목록";
                    SettingDGV(dgvMainPop, type);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<GVGroup>(type);
                    break;
                case "User":
                    lblType.Text = "작업자 목록";
                    SettingDGV(dgvMainPop);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<User>(type);
                    break;
                case "Process":
                    lblType.Text = "공정 목록";
                    SettingDGV(dgvMainPop, type);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<Process>(type);
                    break;
                case "Mold":
                    lblType.Text = "금형 목록";
                    SettingDGV(dgvMainPop, type);
                    dgvMainPop.DataSource = new SelectDAC().SelectForPopup<Mold>(type);
                    break;

            }
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv, string type)
        {
            //WC, Item, GV
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "Code", $"{type}_Code", 150);
            CommonUtil.AddGridTextColumn(dgv, "Name", $"{type}_Name", 150);
        }
        private void SettingDGV(DataGridView dgv)
        {
            //User
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "Code", "User_ID", 150);
            CommonUtil.AddGridTextColumn(dgv, "Name", "User_Name", 150);
        }
        #endregion

        private void dgvMainPop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SCode = dgvMainPop[0, dgvMainPop.CurrentRow.Index].Value.ToString();
            SName = dgvMainPop[1, dgvMainPop.CurrentRow.Index].Value.ToString();
            this.Close();
        }

        private void MainPop_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(SCode == null || SName == null)
            {
                SCode = null; SName = null;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
