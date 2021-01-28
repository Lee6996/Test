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
    public partial class MSS_CON_002 : Form
    {
        public MSS_CON_002()
        {
            InitializeComponent();
        }

        private void MSS_CON_002_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvUser_Group);

            CommonUtil.AddGridTextColumn(dgvUser_Group, "사용자그룹명", "UserGroup_Name", 220);
            CommonUtil.AddGridTextColumn(dgvUser_Group, "사용자그룹코드", "UserGroup_Code", 220);
            CommonUtil.AddGridTextColumn(dgvUser_Group, "입력일자", "Ins_Date", 150);
            CommonUtil.AddGridTextColumn(dgvUser_Group, "사용여부", "Use_YN", 150);

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
    }
}
