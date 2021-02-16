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

namespace Final.MSS_CON
{
    public partial class frm_MSS_CON_002 : Form
    {
        UserGroupVO userGroupVO;

        public frm_MSS_CON_002()
        {
            InitializeComponent();
        }

        private void MSS_CON_002_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtUserGroup_Name.Visible = false;

            UserGroupService service = new UserGroupService();

            CommonUtil.SetInitGridView(dgvUser_Group);

            CommonUtil.AddGridTextColumn(dgvUser_Group, "사용자그룹명", "UserGroup_Name", 220);
            CommonUtil.AddGridTextColumn(dgvUser_Group, "사용자그룹코드", "UserGroup_Code", 220);
            
            CommonUtil.AddGridTextColumn(dgvUser_Group, "관리자여부", "Admin", 150);

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = service.UserGroupNameSelectBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["UserGroup_Name"] = "전체";
            dr["UserGroup_Code"] = "";
            
            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            cbUser_GroupName.DisplayMember = "UserGroup_Name";
            cbUser_GroupName.ValueMember = "UserGroup_Code";
            cbUser_GroupName.DataSource = dtName;

            //컬럼 왼쪽정렬
            dgvUser_Group.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser_Group.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            DataLoad("");
        }

        private void DataLoad(string groupName)
        {
            try
            {
                UserGroupService service = new UserGroupService();
                List<UserGroupVO> list = service.UserGroupSelectInfo(groupName);

                dgvUser_Group.DataSource = list;
                dgvUser_Group.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUser_GroupName.SelectedIndex < 1)
                txtUserGroup_Name.Text = "";
            else
                txtUserGroup_Name.Text = cbUser_GroupName.SelectedValue.ToString();
        }
        //조회버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataLoad(cbUser_GroupName.SelectedValue.ToString());
        }
    }
}
