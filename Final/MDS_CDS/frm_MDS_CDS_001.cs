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
            if (cbGroup.Text == "전체")
            {
                GetAllDefMa("");
            }
            else
            {
                GetAllDefMa(cbGroup.SelectedValue.ToString());
            }           
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroup.SelectedIndex < 0) return;
        }
        
        private void RefreshControl()
        {
            txtName.Text = txtCode.Text = "";
            txtName.Focus();
        }

        private void dgvDef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         txtCode.Text =   dgvDef[0, dgvDef.CurrentRow.Index].Value.ToString();
         txtName.Text =   dgvDef[1, dgvDef.CurrentRow.Index].Value.ToString();
         }
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void dgvDef_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
               

                DataGridViewCheckBoxCell dgv = (DataGridViewCheckBoxCell)dgvDef.Rows[e.RowIndex].Cells[4];
                int useyn = (Convert.ToInt32(dgv.Value) == 1) ? 0 : 1;

                Def_MaVO vo = new Def_MaVO
                {
                    Def_Ma_Code = dgvDef.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                Def_MaService service = new Def_MaService();
                service.UpdateUseYN(vo);
            }
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtCode.Text))
                {
                    Def_MaVO additem = new Def_MaVO()
                    {
                        Def_Ma_Code = txtCode.Text,
                        Def_Ma_Name = txtName.Text,
                       // Ins_Emp = UserInfo.User_Name
                    };

                    if (Defservice.InsertUpdateDef_MaVO(additem))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllDefMa("");  
                    }
                    else
                    {
                        MessageBox.Show("저장실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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


    }
}
