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
    public partial class MSS_CON_001 : Form
    {
        public MSS_CON_001()
        {
            InitializeComponent();
        }

        private void MSS_CON_001_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvUser);

            CommonUtil.AddGridTextColumn(dgvUser, "사용자그룹코드", "UserGroup_Code", 220);
            CommonUtil.AddGridTextColumn(dgvUser, "사용자그룹명", "UserGroup_Name", 220);
            CommonUtil.AddGridTextColumn(dgvUser, "입력일자", "Ins_Date", 150);
            CommonUtil.AddGridTextColumn(dgvUser, "사용여부", "Use_YN", 150);

            DataLoad("");
        }
        private void DataLoad(string groupName)
        {
            try
            {
                UserGroupService service = new UserGroupService();
                List<UserGroupVO> list = service.UserGroupSelectInfo(groupName);

                dgvUser.DataSource = list;
                dgvUser.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserGroup_Code_Insert.Text = txtUserGroup_Name_Insert.Text = "";
            txtUserGroup_Code_Insert.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string name = txtUserGroup_Name.Text;
            if (name.Length < 1)
            {
                MessageBox.Show("사용자 그룹명을 입력해주세요");
                return;
            }

            DataLoad(name);
        }
    }
}
