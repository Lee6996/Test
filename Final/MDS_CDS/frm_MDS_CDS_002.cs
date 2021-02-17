using Final.MDS_CDS.service;
using Final.PRM_PRF.PopUp;
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

namespace Final.MDS_CDS
{
    public partial class frm_MDS_CDS_002 : Form
    {
        public string txtCodeText { get; set; }
        public string txtNameText { get; set; }

        List<Def_MaVO> Defmalist; //불량 대분류
        Def_MaService maservice = new Def_MaService();

        List<Def_MiVO> Defmilist;//불량 상세
        Def_MiService miservice = new Def_MiService();
        public frm_MDS_CDS_002()
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
            CommonUtil.AddGridTextColumn(dgvDefDetail, "사용여부", "Use_YN", 210,visibility: false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvDefDetail.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvDefDetail.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDefDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvDefDetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDefMaster.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDefMaster.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvDefMaster.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            txtCode.Text = txtCodeText;
            txtName.Text = txtNameText;
            GetAllData("");
        }

        private void GetAllData(string def)
        {         
            try
            {
                Defmalist = maservice.GetAllDef_Ma_Master(def);
                dgvDefMaster.DataSource = Defmalist;
                dgvDefMaster.ClearSelection();

                Defmilist = miservice.GetAllDef_Mi_Master(def);
                dgvDefDetail.DataSource = Defmilist;
                dgvDefDetail.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvDefMaster_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            var taget = Defmalist.Find(item => item.Def_Ma_Code == dgvDefDetail.SelectedRows[0].Cells[0].Value.ToString());
            txtDef_Macode.Text = taget.Def_Ma_Name.ToString();            
            txtDef_Micode.Text = taget.Def_Ma_Name.ToString();
            txtDef_Miname.Text = taget.Def_Ma_Code.ToString();

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Def_MiVO additem = new Def_MiVO
                {
                    Def_Mi_Code = txtDef_Micode.Text,
                    Def_Ma_Code = lblDefM.Text,
                    Def_Mi_Name = txtDef_Miname.Text,
                    Remark = txtRemark.Text, 
                 };

                Def_MiService service = new Def_MiService();
                bool bFlag = service.InsertDef_Mi(additem);

                if (bFlag)
                {
                    MessageBox.Show("저장되었습니다..");
                    GetAllData("");
                }
                else
                    MessageBox.Show("이미 등록된 그룹코드이거나 그룹명입니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            RefreshControl();
        }
        private void RefreshControl()
        {
            txtDef_Macode.Text = txtDef_Maname.Text = txtDef_Micode.Text = txtDef_Miname.Text = "";
            txtCode.Focus();       

        }     
        public void Search()
        {
            txtCode.Text = txtCodeText;
            txtName.Text = txtNameText;
        }


private void dgvDefDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var taget = Defmilist.Find(item => item.Def_Ma_Code == dgvDefDetail.SelectedRows[0].Cells[0].Value.ToString());
            txtName.Text = taget.Def_Mi_Name.ToString();
            txtCode.Text = taget.Def_Mi_Code.ToString();
        }
      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllData(txtName.Text);           
        }

        private void btndotdotdot_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Def_Ma")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCode.Text = frm.SCode;
                txtName.Text = frm.SName;
                //여기에 dgv 초기화 코딩
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Def_MiVO additem = new Def_MiVO
                {
                    Def_Mi_Code = txtDef_Micode.Text,
                    Def_Ma_Code = lblDefM.Text,
                    Def_Mi_Name = txtDef_Miname.Text,
                    Remark = txtRemark.Text,
                };

                Def_MiService service = new Def_MiService();
                bool bFlag = service.UpdateDef_Mi(additem);

                if (bFlag)
                {
                    MessageBox.Show("수정되었습니다..");
                    GetAllData("");
                }
                else
                    MessageBox.Show("이미 등록된 그룹코드이거나 그룹명입니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            RefreshControl();
        }
    }
}
