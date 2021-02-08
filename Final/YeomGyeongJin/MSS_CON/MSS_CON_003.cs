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
    public partial class MSS_CON_003 : Form
    {
        public MSS_CON_003()
        {
            InitializeComponent();
        }

        private void MSS_CON_003_Load(object sender, EventArgs e)
        {

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

    }
}
