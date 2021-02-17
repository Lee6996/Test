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
    public partial class frm_MDS_CDS_006 : Form
    {
        List<GVMasterVO> GVlist; //대차
        GV_MasterService GVservice = new GV_MasterService();
        public frm_MDS_CDS_006()
        {
            InitializeComponent();
        }

        private void frm_MDS_CDS_006_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvGV);
            CommonUtil.AddGridTextColumn(dgvGV, "대차코드", "GV_Code", 210);
            CommonUtil.AddGridTextColumn(dgvGV, "대차명", "GV_Name", 210);
            CommonUtil.AddGridTextColumn(dgvGV, "대차그룹코드", "GVGroup_Code", 210);
            CommonUtil.AddGridTextColumn(dgvGV, "대차상태", "GV_Status", 210);
            CommonUtil.AddGridTextColumn(dgvGV, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvGV, "사용여부", "Use_YN", 210, visibility: false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvGV.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvGV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvGV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvUser.CellClick += dgvUser_CellClick;

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = GVservice.GVBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["GV_Name"] = "전체";
            dr["GV_Code"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cboGVName.DisplayMember = "GV_Name";
            cboGVName.ValueMember = "GV_Code";
            cboGVName.DataSource = dtName;


            GetAllGVMa("");
        }
        private void GetAllGVMa(string gv)
        {
            try
            {
                GVlist = GVservice.GetAllGV_Master(gv);

                dgvGV.DataSource = GVlist;
                dgvGV.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboGVName.Text == "전체")
            {
                GetAllGVMa("");
            }
            else
            {
                GetAllGVMa(cboGVName.SelectedValue.ToString());
            }
        }

        private void cboGVName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGVName.SelectedIndex < 0) return;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void RefreshControl()
        {
            txtCode.Text = txtName.Text = "";
            txtCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtCode.Text))
                {

                    string targetBoxing = "";
                    foreach (Control ctrl in gboGV.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            RadioButton rdo = (RadioButton)ctrl;
                            if (rdo.Checked)
                            {
                                targetBoxing = rdo.Tag.ToString();
                                break;
                            }
                        }
                    }
                    GVMasterVO vo = new GVMasterVO
                    {
                        GV_Code = txtCode.Text,
                        GV_Name = txtName.Text,
                        GVGroup_Code = targetBoxing,
                        GV_Status = cbStatus.SelectedItem.ToString()
                    };

                    if (GVservice.InsertUpdateGV_Ma(vo))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAllGVMa("");
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

        private void dgvGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var taget = GVlist.Find(item => item.GV_Code == dgvGV.SelectedRows[0].Cells[0].Value.ToString());
            txtName.Text = taget.GV_Name.ToString();
            txtCode.Text = taget.GV_Code.ToString();

            if (taget.GVGroup_Code.Equals("사출작업대차"))
            {
                rdo1.Checked = true;
            }
            else if (taget.GVGroup_Code.Equals("건조작업대차"))
            {
                rdo2.Checked = true;
            }
            else if (taget.GVGroup_Code.Equals("성형작업대차"))
            {
                rdo3.Checked = true;
            }
            else if (taget.GVGroup_Code.Equals("포장작업대차"))
            {
                rdo4.Checked = true;
            }

            txtCode.Text = dgvGV[0, dgvGV.CurrentRow.Index].Value.ToString();
            txtName.Text = dgvGV[1, dgvGV.CurrentRow.Index].Value.ToString();
        }

        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell dgv = (DataGridViewCheckBoxCell)dgvGV.Rows[e.RowIndex].Cells[6];
                int useyn = (Convert.ToInt32(dgv.Value) == 1) ? 0 : 1;

                GVMasterVO vo = new GVMasterVO
                {
                    GV_Code = dgvGV.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                GV_MasterService service = new GV_MasterService();
                service.UpdateUseYN(vo);
            }
        }
    }
}
