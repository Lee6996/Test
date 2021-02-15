using Final.MDS_CDS.service;
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
            CommonUtil.AddGridTextColumn(dgvDef, "사용여부", "Use_YN", 210, visibility: false);



            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvDef.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvDef.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDef.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvDef.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvUser.CellClick += dgvUser_CellClick;

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = Defservice.DefBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Def_Ma_Name"] = "전체";
            dr["Def_Ma_Code"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbGroup.DisplayMember = "Def_Ma_Name";
            cbGroup.ValueMember = "Def_Ma_Code";
            cbGroup.DataSource = dtName;

            //DataLoad("");
            GetAllDefMa("");
            ///
            
        }
   
       

        private void GetAllDefMa(string def)        
        {     
            try
            {                
                Defmalist = Defservice.GetAllDef_Ma_Master(def);

                dgvDef.DataSource = Defmalist;
                dgvDef.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllDefMa(cbGroup.SelectedValue.ToString());
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroup.SelectedIndex < 0) return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length < 1)
            {
                MessageBox.Show("불량현상코드를 입력해주세요");
                return;
            }
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show("불량현상명을 입력해주세요");
                return;
            }

            try
            {
                Def_MaVO vo = new Def_MaVO
                {
                    Def_Ma_Code = txtCode.Text,
                    Def_Ma_Name = txtName.Text
                };

                Def_MaService service = new Def_MaService();
                bool bFlag = service.InsertDef_Ma(vo);

                if (bFlag)
                {
                    MessageBox.Show("저장되었습니다..");
                    GetAllDefMa("");
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
            txtCode.Text = txtName.Text = "";
            txtCode.Focus();
        }

        private void dgvDef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {           
                var taget = Defmalist.Find(item => item.Def_Ma_Code == dgvDef.SelectedRows[0].Cells[0].Value.ToString());
                txtName.Text = taget.Def_Ma_Name.ToString();
                txtCode.Text = taget.Def_Ma_Code.ToString();            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length < 1)
            {
                MessageBox.Show("불량현상코드를 입력해주세요");
                return;
            }
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show("불량현상명을 입력해주세요");
                return;
            }

            try
            {
                Def_MaVO vo = new Def_MaVO
                {
                    Def_Ma_Code = txtCode.Text,
                    Def_Ma_Name = txtName.Text
                };

                Def_MaService service = new Def_MaService();
                bool bFlag = service.UpdateDef_Ma(vo);

                if (bFlag)
                {
                    MessageBox.Show("수정되었습니다..");
                    GetAllDefMa("");
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }
    }
}
