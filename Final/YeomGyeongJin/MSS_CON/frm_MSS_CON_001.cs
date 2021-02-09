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

namespace Final.YeomGyeongJin.MSS_CON
{
    public partial class frm_MSS_CON_001 : Form
    {
        public frm_MSS_CON_001()
        {
            InitializeComponent();
        }
        
        private void MSS_CON_001_Load(object sender, EventArgs e)
        {
            UserGroupService service = new UserGroupService();
            CommonUtil.SetInitGridView(dgvUser);

            CommonUtil.AddGridTextColumn(dgvUser, "사용자그룹코드", "UserGroup_Code", 220);
            CommonUtil.AddGridTextColumn(dgvUser, "사용자그룹명", "UserGroup_Name", 220);
            CommonUtil.AddGridTextColumn(dgvUser, "입력일자", "Ins_Date", 150);
            CommonUtil.AddGridTextColumn(dgvUser, "사용여부", "Use_YN", 150, visibility:false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvUser.Columns.Add(col);

            //dgvUser.CellClick += dgvUser_CellClick;

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = service.UserGroupNameSelectBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["UserGroup_Name"] = "전체";
            dr["UserGroup_Code"] = "";
            
            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbUserGroup_Name.DisplayMember = "UserGroup_Name";
            cbUserGroup_Name.ValueMember = "UserGroup_Code";
            cbUserGroup_Name.DataSource = dtName;

            DataLoad("");
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            { 
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvUser.Rows[e.RowIndex].Cells[4];
                int useyn = (Convert.ToInt32(chk.Value) == 1) ? 0: 1;

                UserGroupVO vo = new UserGroupVO
                {
                    UserGroup_Code = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                UserGroupService service = new UserGroupService();
                service.UpdateUserGroup(vo);
            }
        }

        private void DataLoad(string groupCode)
        {
            try
            {
                UserGroupService service = new UserGroupService();
                List<UserGroupVO> list = service.UserGroupSelectInfo(groupCode);

                dgvUser.DataSource = list;
                dgvUser.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        //조회 버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //string name = txtUserGroup_Code.Text;
            //if (name.Length < 1)
            //{
            //    MessageBox.Show("사용자 그룹명을 입력해주세요");
            //    return;
            //}

            DataLoad(cbUserGroup_Name.Text);
        }

        //저장하기 버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUserGroup_Code_Insert.Text.Length < 1)
            {
                MessageBox.Show("사용자 그룹코드를 입력해주세요");
                return;
            }
            if (txtUserGroup_Name_Insert.Text.Length < 1)
            {
                MessageBox.Show("사용자 그룹명을 입력해주세요");
                return;
            }
            
            try
            {
                UserGroupVO vo = new UserGroupVO
                {
                    UserGroup_Code = txtUserGroup_Code_Insert.Text,
                    UserGroup_Name = txtUserGroup_Name_Insert.Text
                };

                UserGroupService service = new UserGroupService();
                bool bFlag = service.InsertUserGroup(vo);

                if (bFlag)
                {
                    MessageBox.Show("추가되었습니다.");
                    DataLoad("");
                }
                else
                    MessageBox.Show("이미 등록된 그룹코드이거나 그룹명입니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            txtUserGroup_Code_Insert.Text = txtUserGroup_Name_Insert.Text = "";
            txtUserGroup_Code_Insert.Focus();
        }

        private void cboUserGroup_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserGroup_Name.SelectedIndex < 1) return;

            if (cbUserGroup_Name.SelectedIndex < 1)
                txtUserGroup_Code.Text = "";
            else
                txtUserGroup_Code.Text = cbUserGroup_Name.SelectedValue.ToString();

        }
    }
}
