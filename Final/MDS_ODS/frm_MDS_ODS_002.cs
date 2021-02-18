using Final.MDS_SDS.service;
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
    public partial class frm_MDS_ODS_002 : Form
    {
        List<WorkCenter_Master2VO> worklist; //작업장
        WorkCenter_MasterService workservice = new WorkCenter_MasterService();
        public frm_MDS_ODS_002()
        {
            InitializeComponent();
        }

        private void frm_MDS_ODS_002_Load(object sender, EventArgs e)
        {            
            CommonUtil.SetInitGridView(dgvWork);
            CommonUtil.AddGridTextColumn(dgvWork, "작업장코드", "Wc_Code", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "작업장명", "Wc_Name", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "공정코드", "Process_Code", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "작업장 그룹", "Wc_Group", 210);            
            CommonUtil.AddGridTextColumn(dgvWork, "실적등록유형", "Prd_Req_Type", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "팔렛생성여부", "Pallet_YN", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "최종작업품목", "Item_Code", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "실적단위", "Prd_Unit", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "금형장착여부", "Mold_Setup_YN", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "비고", "비고", 210);
            CommonUtil.AddGridTextColumn(dgvWork, "사용여부", "Use_YN", 210, visibility: false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvWork.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvWork.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvWork.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvWork.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvUser.CellClick += dgvUser_CellClick;

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = workservice.WorkCenterBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Wc_Name"] = "전체";
            dr["Wc_Code"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbWorkCenter_Name.DisplayMember = "Wc_Name";
            cbWorkCenter_Name.ValueMember = "Wc_Code";
            cbWorkCenter_Name.DataSource = dtName;

          
            GetAll("");
        }

        private void GetAll(string def)
        {
            try
            {
                worklist = workservice.WorkCenterSelect(def);

                dgvWork.DataSource = worklist;
                dgvWork.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbWorkCenter_Name.Text == "전체")
            {
                GetAll("");
            }
            else
            {
                GetAll(cbWorkCenter_Name.SelectedValue.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void RefreshControl()
        {
            txtPRCode.Text = txtWCgroup.Text = txtWCCode.Text = txtWCName.Text = txtRemark.Text = "";
            txtPRCode.Focus();
        }

        private void dgvWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell dgv = (DataGridViewCheckBoxCell)dgvWork.Rows[e.RowIndex].Cells[11];
                int useyn = (Convert.ToInt32(dgv.Value) == 1) ? 0 : 1;

                WorkCenter_Master2VO vo = new WorkCenter_Master2VO
                {
                    Wc_Code = dgvWork.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                WorkCenter_MasterService service = new WorkCenter_MasterService();
                service.UpdateUseYN(vo);
            }
        }

        private void dgvWork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWCCode.Text = dgvWork[0, dgvWork.CurrentRow.Index].Value.ToString();
            txtWCName.Text = dgvWork[1, dgvWork.CurrentRow.Index].Value.ToString();
            txtPRCode.Text = dgvWork[2, dgvWork.CurrentRow.Index].Value.ToString();
            txtWCgroup.Text = dgvWork[3, dgvWork.CurrentRow.Index].Value.ToString();
        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPRCode.Text) && !string.IsNullOrEmpty(txtWCCode.Text) && !string.IsNullOrEmpty(txtWCgroup.Text) && !string.IsNullOrEmpty(txtWCName.Text))
                {
                    WorkCenterVO additem = new WorkCenterVO()
                    {
                        Wc_Code = txtWCCode.Text,
                        Wc_Name = txtWCName.Text,
                        Wc_Group = txtWCgroup.Text,
                        Process_Code = txtPRCode.Text,
                        Remark = txtRemark.Text

                    };

                    if (workservice.InsertUpdateWC_Ma2VO(additem))
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
    }
}
