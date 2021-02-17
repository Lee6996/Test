using Final.MSS_CON;
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

namespace Final
{
    public partial class frm_MSS_CON_003_1 : Form
    {
        UserService service;
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
            service = new UserService();

            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");



            //기본공정 바인딩
            DataTable dtProcessCode = service.DefaultProcessCodeSelectBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtProcessCode.NewRow();
            dr["Process_name"] = "전체";
            dr["Default_Process_Code"] = "";

            dtProcessCode.Rows.InsertAt(dr, 0);
            dtProcessCode.AcceptChanges();

            cbDefault_ProcessCode.DisplayMember = "Process_name";
            cbDefault_ProcessCode.ValueMember = "Default_Process_Code";
            cbDefault_ProcessCode.DataSource = dtProcessCode;



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

            try
            {
                UserVO vo = new UserVO
                {
                    User_ID = txtUser_ID.Text,
                    User_Name = txtUser_Name.Text,
                    User_PW=txtUser_Pwd.Text,
                    Default_Process_Code = cbDefault_ProcessCode.ValueMember
                };

                bool bFlag = service.InsertUser(vo);

                if (bFlag)
                {
                    AutoClosingMessageBox.Show("사용자가 추가되었습니다.", "1초 후 자동종료", 1000);
                }
                else
                    AutoClosingMessageBox.Show("이미 등록된 사용자아이디입니다.", "1초 후 자동종료", 1000);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}
