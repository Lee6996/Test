using Final.LeeYounggyu.service;
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

namespace Final.LeeYounggyu
{
    public partial class MDS_CDS_002 : Form
    {
        List<Def_MaVO> Defmalist; //불량 대분류
        Def_MaService maservice = new Def_MaService();

        List<Def_MiVO> defmilist;//불량 상세
        Def_MiService miservice = new Def_MiService();
        public MDS_CDS_002()
        {
            InitializeComponent();
        }

        private void MDS_CDS_002_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvDefMaster);
            CommonUtil.AddGridTextColumn(dgvDefMaster, "불량현상대분류코드", "Def_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvDefMaster, "불량현상대분류 명", "Def_Ma_Name", 210);
            CommonUtil.AddGridTextColumn(dgvDefMaster, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvDefMaster, "사용여부", "Use_YN", 210);

            CommonUtil.SetInitGridView(dgvDefDetail);
            CommonUtil.AddGridTextColumn(dgvDefDetail,  "불량현상상세분류코드", "Def_Mi_Code", 210);
            CommonUtil.AddGridTextColumn(dgvDefDetail,  "불량현상상세분류 명", "Def_Mi_Name",210);
            CommonUtil.AddGridTextColumn(dgvDefDetail,  "비고", "Remark", 210);
            CommonUtil.AddGridTextColumn(dgvDefDetail, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvDefDetail, "사용여부", "Use_YN", 210);

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.White;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvDefDetail.Columns.Add(gridbtn);

            GetAllUserGroup();
        }

        private void GetAllUserGroup()
        {
            Defmalist = new List<Def_MaVO>();
            Defmalist = maservice.GetAllDef_Ma_Master();
            dgvDefMaster.DataSource = Defmalist;

            defmilist = new List<Def_MiVO>();
            defmilist = miservice.GetAllDef_Mi_Master();
            dgvDefDetail.DataSource = defmilist;
        }

        private void dgvDefMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDefDetail.DataSource = null;

            dgvDefDetail.DataSource = defmilist.FindAll(item => item.Def_Ma_Code == dgvDefMaster.SelectedRows[0].Cells[0].Value.ToString());
            lblDefM.Text = dgvDefMaster.SelectedRows[0].Cells[0].Value.ToString();
            txtDef_Micode.Text = "";
            txtDef_Miname.Text = "";
            txtRemark.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDef_Micode.Text) && !string.IsNullOrEmpty(txtDef_Miname.Text))
            {

                Def_MiVO additem = new Def_MiVO()
                {
                    Def_Mi_Code = txtDef_Micode.Text,
                    Def_Ma_Code = lblDefM.Text,
                    Def_Mi_Name = txtDef_Miname.Text,
                    Remark = txtRemark.Text,
                    Ins_Emp = UserStatic.User_Name

                };
                if (miservice.InsertUpdateDef_Mi_Master(additem))
                {
                    MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllUserGroup();                    
                }
                else
                {
                    MessageBox.Show("저장에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("필수 항목을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDefDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSave.Text.Equals("수정"))
            {

                txtDef_Micode.Text = dgvDefDetail.SelectedRows[0].Cells[0].Value.ToString();
                txtDef_Miname.Text = dgvDefDetail.SelectedRows[0].Cells[1].Value.ToString();
                txtRemark.Text = dgvDefDetail.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void dgvDefDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvDefDetail.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvDefDetail.SelectedRows[0].Cells[4].Value).ToString() == "Y") //사용안함
                    {
                        miservice.UsedDef_Mi_Master((dgvDefDetail.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        miservice.UsedDef_Mi_Master((dgvDefDetail.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllUserGroup();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDefMaster.Rows)
            {
                if (row.Cells[0].Value.ToString() == aBigTextBox_FindNameByCode1.txtCodeText)
                {
                    row.Selected = true;
                }
            }
            if (row.Cells[0].Value.ToString().Contains(lblGroup.Text))
            {
                row.Cells[0].Selected = true;
            }
        }
    }
}
