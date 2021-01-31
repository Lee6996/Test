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

        private void frm_MSS_CON_003_1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        //저장버튼
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUser_Name.Text))
            {
                AutoClosingMessageBox.Show("사용자명을 입력해주세요.", "1초 후 종료", 1000);
                return;
            }
            else if (String.IsNullOrWhiteSpace(txtUser_ID.Text))
            {
                AutoClosingMessageBox.Show("사용자ID를 입력해주세요.", "1초 후 종료", 1000);
                return;
            }
            else if (String.IsNullOrWhiteSpace(txtUser_Pwd.Text))
            {
                AutoClosingMessageBox.Show("사용자 비밀번호를 입력해주세요.", "1초 후 종료", 1000);
                return;
            }
            //콤보박스 바인딩 후 작성 예정

        }
        //취소 버튼
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
