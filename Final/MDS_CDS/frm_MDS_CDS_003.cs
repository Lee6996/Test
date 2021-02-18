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
    public partial class frm_MDS_CDS_003 : Form
    {
        List<Nop_MaVO> Noplist; //불량 대분류
        Nop_MaService Nopservice = new Nop_MaService();
        public frm_MDS_CDS_003()
        {
            InitializeComponent();
        }

        private void frm_MDS_CDS_003_Load(object sender, EventArgs e)
        {
            ///gridview
            CommonUtil.SetInitGridView(dgvNop);
            CommonUtil.AddGridTextColumn(dgvNop, "비가동대분류코드", "Nop_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvNop, "비가동대분류 명", "Nop_Ma_Name", 210);
            CommonUtil.AddGridTextColumn(dgvNop, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvNop, "사용여부", "Use_YN", 210, visibility: false);



            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvNop.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvNop.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNop.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvNop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvUser.CellClick += dgvUser_CellClick;

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = Nopservice.NopBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Nop_Ma_Name"] = "전체";
            dr["Nop_Ma_Code"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbNop.DisplayMember = "Nop_Ma_Name";
            cbNop.ValueMember = "Nop_Ma_Code";
            cbNop.DataSource = dtName;


            GetAllNopMa("");

        }

        private void GetAllNopMa(string nop)
        {
            try
            {
                Noplist = Nopservice.GetAllNop_Ma_Master(nop);

                dgvNop.DataSource = Noplist;
                dgvNop.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbNop.Text == "전체")
            {
                GetAllNopMa("");
            }
            else
            {
                GetAllNopMa(cbNop.SelectedValue.ToString());
            }

        }

        private void cbNop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNop.SelectedIndex < 0) return;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtCode.Text))
                {
                    Nop_MaVO vo = new Nop_MaVO
                    {
                        Nop_Ma_Code = txtCode.Text,
                        Nop_Ma_Name = txtName.Text
                    };

                    if (Nopservice.InsertUpdateNop_MaVO(vo))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllNopMa("");
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
            RefreshControl();
        }

        private void RefreshControl()
        {
            txtCode.Text = txtName.Text = "";
            txtCode.Focus();
        }

        private void dgvNop_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvNop[0, dgvNop.CurrentRow.Index].Value.ToString();
            txtName.Text = dgvNop[1, dgvNop.CurrentRow.Index].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void dgvNop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell dgv = (DataGridViewCheckBoxCell)dgvNop.Rows[e.RowIndex].Cells[4];
                int useyn = (Convert.ToInt32(dgv.Value) == 1) ? 0 : 1;

                Nop_MaVO vo = new Nop_MaVO
                {
                    Nop_Ma_Code = dgvNop.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                Nop_MaService service = new Nop_MaService();
                service.UpdateUseYN(vo);
            }
        }


    }
}
