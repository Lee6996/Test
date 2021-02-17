using Final.Service;
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
    public partial class frm_MSS_CON_003 : Form
    {
        public frm_MSS_CON_003()
        {
            InitializeComponent();
        }

        private void MSS_CON_003_Load(object sender, EventArgs e)
        {
            UserService service = new UserService();

            CommonUtil.SetInitGridView(dgvUser);
            CommonUtil.AddGridTextColumn(dgvUser, "아이디", "User_ID", 175);
            CommonUtil.AddGridTextColumn(dgvUser, "이름", "User_Name", 175);

            CommonUtil.SetInitGridView(dgvUserGroup);
            CommonUtil.AddGridTextColumn(dgvUserGroup, "사용자그룹코드", "UserGroup_Code", 185);
            CommonUtil.AddGridTextColumn(dgvUserGroup, "사용자그룹명", "UserGroup_Name", 185);

            CommonUtil.SetInitGridView(dgvUserGroup_User);
            CommonUtil.AddGridCheckBoxColumn(dgvUserGroup_User);
            CommonUtil.AddGridTextColumn(dgvUserGroup_User, "아이디", "User_ID", 220);
            CommonUtil.AddGridTextColumn(dgvUserGroup_User, "이름", "User_Name", 220);
            

            //콤보박스에 유저 정보 바인딩
            DataTable dtName = service.UserNameSelectBinding();

            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["User_Name"] = "전체";
            dr["User_ID"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            cboUser_Name.DisplayMember = "User_Name";
            cboUser_Name.ValueMember = "User_ID";
            cboUser_Name.DataSource = dtName;

            //컬럼 왼쪽정렬
            dgvUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUser.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUserGroup.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUserGroup.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            UserDataLoad("");
            UserGroupDataLoad("");
        }

        private void UserDataLoad(string userName)
        {
            try
            {
                UserService service = new UserService();
                List<UserVO> list = service.SelectUserInfo(userName);

                dgvUser.DataSource = list;
                dgvUser.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void UserGroupDataLoad(string groupName)
        {
            try
            {
                UserGroupService service = new UserGroupService();
                List<UserGroupVO> list = service.UserGroupSelectInfo(groupName);

                dgvUserGroup.DataSource = list;
                dgvUserGroup.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void UserGroupUserDataLoad(string groupName)
        {
            try
            {
                UserService service = new UserService();
                List<UserVO> list = service.SelectUserInfo(groupName);

                dgvUserGroup_User.DataSource = list;
                dgvUserGroup_User.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvUserGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserGroupUserDataLoad("");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frm_MSS_CON_003_1 frm = new frm_MSS_CON_003_1();
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.ShowDialog();

            UserDataLoad("");
        }
    }
}
