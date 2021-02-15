using Final.Service;
using System;
using System.Windows.Forms;

namespace Final.Login
{
    public partial class frmLogin : Form
    {
        string id, pwd;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            pwd = txtPwd.Text;
            if(new UserService().CheckLoginAble(id,pwd))//로그인 성공
            {
                new FinalMDIParent().Show();
            }
            else
            {
                AutoClosingMessageBox.Show("로그인 정보가 잘못되었습니다.", "2초뒤 종료...", 2000);
            }
        }
    }
}
