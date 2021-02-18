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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtPwd.Text.Length == 0)
            {
                txtPwd.PasswordChar = (char)0;
            }
            else
                txtPwd.PasswordChar = (char)42;
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            pwd = txtPwd.Text;
            
            if(new UserService().CheckLoginAble(id,pwd))//로그인 성공
            {
                new FinalMDIParent().Show();
                this.Hide();
            }
            else
            {
                AutoClosingMessageBox.Show("로그인 정보가 잘못되었습니다.", "2초뒤 종료...", 2000);
            }
        }
    }
}
