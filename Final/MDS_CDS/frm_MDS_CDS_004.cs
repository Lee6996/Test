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
    public partial class frm_MDS_CDS_004 : Form
    {
        public string txtCodeText { get; set; }
        public string txtNameText { get; set; }

        List<Nop_MaVO> NopMalist; //비가동 대분류
        Nop_MaService MApservice = new Nop_MaService();


        List<Nop_MiVO> NopMilist; //비가동 상세분류
        Nop_MiService MIservice = new Nop_MiService();
        public frm_MDS_CDS_004()
        {
            InitializeComponent();
        }

        private void frm_MDS_CDS_004_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvNopMa);
            CommonUtil.AddGridTextColumn(dgvNopMa, "비가동대분류코드", "Nop_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvNopMa, "비가동대분류 명", "Nop_Ma_Name", 210);
            CommonUtil.AddGridTextColumn(dgvNopMa, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvNopMa, "사용여부", "Use_YN", 210, visibility: false);

            CommonUtil.SetInitGridView(dgvNopMi);
            CommonUtil.AddGridTextColumn(dgvNopMi, "비가동대분류코드", "Nop_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvNopMi, "비가동상세코드", "Nop_Mi_Code", 210);
            CommonUtil.AddGridTextColumn(dgvNopMi, "비가동상세 명", "Nop_Mi_Name", 210);
            CommonUtil.AddGridTextColumn(dgvNopMi, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvNopMi, "비고", "Remark", 210);
            CommonUtil.AddGridTextColumn(dgvNopMi, "사용여부", "Use_YN", 210, visibility: false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvNopMi.Columns.Add(col);

            dgvNopMa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNopMa.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvNopMa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNopMi.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNopMi.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvNopMi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetAllData("");
        }
        private void GetAllData(string nop)
        {
            try
            {
                NopMalist = MApservice.GetAllNop_Ma_Master(nop);
                dgvNopMa.DataSource = NopMalist;
                dgvNopMa.ClearSelection();

                NopMilist = MIservice.GetAllNop_Mi_Master(nop);
                dgvNopMi.DataSource = NopMilist;
                dgvNopMi.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }
        private void RefreshControl()
        {
            txtNopMaCode.Text = txtNopMiCode.Text = txtNopMiName.Text = txtRemark.Text = "";
            txtCode.Focus();
        }

        private void btndotdotdot_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Nop_Ma")
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllData(txtName.Text);
        }

        private void dgvNopMi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var taget = NopMilist.Find(item => item.Nop_Ma_Code == dgvNopMi.SelectedRows[0].Cells[0].Value.ToString());
            txtName.Text = taget.Nop_Mi_Name.ToString();
            txtCode.Text = taget.Nop_Mi_Code.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Nop_MiVO additem = new Nop_MiVO
                {
                    Nop_Mi_Code = txtNopMiCode.Text,
                    Nop_Ma_Code = txtNopMaCode.Text,
                    Nop_Mi_Name = txtNopMiName.Text,
                    Remark = txtRemark.Text,
                };

                Nop_MiService service = new Nop_MiService();
                bool bFlag = service.InsertNop_Mi(additem);

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
        public void Search()
        {
            txtCode.Text = txtCodeText;
            txtName.Text = txtNameText;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Nop_MiVO additem = new Nop_MiVO
                {
                    Nop_Mi_Code = txtNopMiCode.Text,
                    Nop_Ma_Code = txtNopMaCode.Text,
                    Nop_Mi_Name = txtNopMiName.Text,
                    Remark = txtRemark.Text,
                };

                Nop_MiService service = new Nop_MiService();
                bool bFlag = service.UpdateNop_Mi(additem);

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
