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
    public partial class frm_MSS_SYS_003_1 : Form
    {
        public frm_MSS_SYS_003_1()
        {
            InitializeComponent();
        }

        private void frm_MSS_SYS_003_1_Load(object sender, EventArgs e)
        {
            txtUpper_DateNow.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtLower_DateNow.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        //하위메뉴 등록버튼
        private void btnInsert_Lower_Click(object sender, EventArgs e)
        {
            if(cbUpper_Name.SelectedIndex < -1)
            {
                AutoClosingMessageBox.Show("상위메뉴코드를 선택해주세요.", "1초 후 자동종료", 1000);
                return;
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancle2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //상위메뉴 등록버튼
        private void btnInsert_Upper_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMenu_Code.Text))
            {
                AutoClosingMessageBox.Show("메뉴코드를 입력해주세요", "1초후 자동종료", 1000);
                return;
            }
            else if (String.IsNullOrWhiteSpace(txtMenu_Name.Text))
            {
                AutoClosingMessageBox.Show("메뉴이름을 입력해주세요", "1초 후 자동종료", 1000);
                return;
            }

            //등록 
        }
    }
}
