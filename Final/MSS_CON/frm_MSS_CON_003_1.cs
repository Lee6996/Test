using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class frm_MSS_CON_003_1 : Form
    {
        public frm_MSS_CON_003_1()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void frm_MSS_CON_003_1_Load(object sender, EventArgs e)
        {

        }
        //저장버튼
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUser_Name.Text))
            {
                AutoClosingMessageBox.Show("사용자명을 입력해주세요.", "1초 후 자동종료", 1000);
                return;
            }
            else if (String.IsNullOrWhiteSpace(txtUser_ID.Text))
            {
                AutoClosingMessageBox.Show("사용자ID를 입력해주세요.", "1초 후 자동종료", 1000);
                return;
            }
            else if (String.IsNullOrWhiteSpace(txtUser_Pwd.Text))
            {
                AutoClosingMessageBox.Show("사용자 패스워드를 입력해주세요.", "1초 후 자동종료", 1000);
                return;
            }
            else if(cbDefault_ProcessCode.SelectedIndex < 1)
            {
                AutoClosingMessageBox.Show("기본공정코드를 선택해주세요.", "1초 후 자동종료", 1000);
                return;
            }

        }
    }
}
