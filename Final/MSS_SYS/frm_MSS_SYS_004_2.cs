using Final.MSS_SYS;
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
    public partial class frm_MSS_SYS_004_2 : Form
    {
        public frm_MSS_SYS_004_2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //저장버튼
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTitle.Text))
            {
                AutoClosingMessageBox.Show("제목을 입력해주세요", "1초 후 자동종료", 1000);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtDescription.Text))
            {
                AutoClosingMessageBox.Show("공지내역을 입력해주세요", "1초 후 자동종료", 1000);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtNotice_Rtf.Text))
            {
                AutoClosingMessageBox.Show("공지사항 참조를 입력해주세요", "1초 후 자동종료", 1000);
                return;
            }
            SysNoticeService service = new SysNoticeService();
            try
            {
                SysNoticeVO vo = new SysNoticeVO
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Notice_Date = dtpStart.Value.ToString("yyyy-MM-dd"),
                    Notice_End = dtpEnd.Value.ToString("YYYY-MM-dd"),
                    Notice_Rtf = txtNotice_Rtf.Text
                };
                bool bFlag = service.InsertSysNotice(vo);

            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            AutoClosingMessageBox.Show("공지사항이 등록되었습니다.", "1초 후 자동종료", 1000);

            Close();
        }
    }
}
