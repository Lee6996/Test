using Final.MDS_SDS.service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.MDS_SDS
{
    public partial class frm_MDS_CDS_001 : Form
    {
        List<Def_MaVO> Defmalist; //불량 대분류
        Def_MaService Defservice = new Def_MaService();
        public frm_MDS_CDS_001()
        {
            InitializeComponent();
        }

        private void MDS_CDS_001_Load(object sender, EventArgs e)
        {
            ///gridview
            CommonUtil.SetInitGridView(dgvDef);
            CommonUtil.AddGridTextColumn(dgvDef, "불량현상대분류코드", "Def_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvDef, "불량현상대분류 명", "Def_Ma_Name", 210);
            CommonUtil.AddGridTextColumn(dgvDef, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvDef, "사용여부", "Use_YN", 210);



            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.White;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvDef.Columns.Add(gridbtn);
            GetAllDefMa();
            ///
            ControlSetting();
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
            Dictionary<string, string> cbblist = Defmalist.ToDictionary(item => item.Def_Ma_Code, item => item.Def_Ma_Name);
            cbGroup.DisplayMember = "Value";
            cbGroup.ValueMember = "Key";
            cbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbGroup.SelectedValue.ToString();
            ///
        }

        private void GetAllDefMa()
        {
            Defmalist = new List<Def_MaVO>();
            Defmalist = Defservice.GetAllDef_Ma_Master();
            dgvDef.DataSource = Defmalist;
        }

        private void dgvDef_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvDef.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvDef.SelectedRows[0].Cells[3].Value).ToString() == "Y") //사용안함
                    {
                        Defservice.GetUpdateDef_Ma_Master((dgvDef.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        Defservice.GetUpdateDef_Ma_Master((dgvDef.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllDefMa();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDef.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblGroup.Text))
                {
                    row.Cells[0].Selected = true;
                }
            }
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.Text = cbGroup.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    Def_MaVO additem = new Def_MaVO()
                    {
                        Def_Ma_Code = txtCode.Text,
                        Def_Ma_Name = txtName.Text,
                        Ins_Emp = UserStatic.User_Name
                    };

                    //if (Defservice.InsertUpdateDef_MaVO(additem))
                    //{
                    //    MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    GetAllDefMa();
                    //    ControlSetting();                        

                    //}
                    //else
                    //{
                    //    MessageBox.Show("저장실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                }
                else
                {
                    MessageBox.Show("필수항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "db", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSave.Text.Equals("수정"))
            {
                var taget = Defmalist.Find(item => item.Def_Ma_Code == dgvDef.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = taget.Def_Ma_Name.ToString();
                txtCode.Text = taget.Def_Ma_Code.ToString();
            }
        }
    }
}
