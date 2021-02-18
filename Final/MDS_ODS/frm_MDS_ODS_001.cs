using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.MDS_ODS
{
    public partial class frm_MDS_ODS_001 : Form
    {
        List<ProcessVO> processlist;
        ProcessService processservice = new ProcessService();
        public frm_MDS_ODS_001()
        {
            InitializeComponent();
        }

        private void frm_MDS_ODS_001_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvProcess);
            CommonUtil.AddGridTextColumn(dgvProcess, "공정코드", "Process_code", 210);
            CommonUtil.AddGridTextColumn(dgvProcess, "공정명", "Process_name", 210);
            CommonUtil.AddGridTextColumn(dgvProcess, "공정그룹", "Process_Group", 210);
            CommonUtil.AddGridTextColumn(dgvProcess, "비고 명", "Remark", 210);
            CommonUtil.AddGridTextColumn(dgvProcess, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvProcess, "사용여부", "Use_YN", 210, visibility: false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvProcess.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvProcess.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProcess.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvProcess.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvUser.CellClick += dgvUser_CellClick;

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = processservice.PRBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Process_name"] = "전체";
            dr["Process_Code"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbProcess_Name.DisplayMember = "Process_name";
            cbProcess_Name.ValueMember = "Process_Code";
            cbProcess_Name.DataSource = dtName;

            //DataLoad("");
            GetAll("");
        }

        private void GetAll(string pr)
        {
            try
            {
                processlist = processservice.GetAll_ProcessMaster(pr);

                dgvProcess.DataSource = processlist;
                dgvProcess.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {


                DataGridViewCheckBoxCell dgv = (DataGridViewCheckBoxCell)dgvProcess.Rows[e.RowIndex].Cells[6];
                int useyn = (Convert.ToInt32(dgv.Value) == 1) ? 0 : 1;

                ProcessVO vo = new ProcessVO
                {
                    Process_code = dgvProcess.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                ProcessService service = new ProcessService();
                service.UpdateUseYN(vo);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtProcess_Code_Insert.Text) && !string.IsNullOrEmpty(txtProcess_Name_Insert.Text) && !string.IsNullOrEmpty(txtGroup.Text))
                {
                    ProcessVO additem = new ProcessVO()
                    {
                        Process_code = txtProcess_Code_Insert.Text,
                        Process_name = txtProcess_Name_Insert.Text,
                        Process_Group = txtGroup.Text,
                        Remark = txtRemark.Text
                        
                    };

                    if (processservice.InsertUpdatePR_MaVO(additem))
                    {
                        MessageBox.Show("저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAll("");
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbProcess_Name.Text == "전체")
            {
                GetAll("");
            }
            else
            {
                GetAll(cbProcess_Name.SelectedValue.ToString());
            }
        }

        private void dgvProcess_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProcess_Code_Insert.Text = dgvProcess[0, dgvProcess.CurrentRow.Index].Value.ToString();
            txtProcess_Name_Insert.Text = dgvProcess[1, dgvProcess.CurrentRow.Index].Value.ToString();
            txtGroup.Text = dgvProcess[2, dgvProcess.CurrentRow.Index].Value.ToString();
          //  txtRemark.Text = dgvProcess[3, dgvProcess.CurrentRow.Index].Value.ToString();
        }

        private void RefreshControl()
        {
            txtProcess_Name_Insert.Text = txtProcess_Code_Insert.Text = txtGroup.Text = "";
            txtProcess_Name_Insert.Focus();
        }
    }
}
