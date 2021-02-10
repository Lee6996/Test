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
    public partial class frm_MSS_SYS_004_1 : Form
    {
        SysNoticeVO SysNoticeVO;
        public frm_MSS_SYS_004_1()
        {
            InitializeComponent();
        }
        public frm_MSS_SYS_004_1(SysNoticeVO SysNoticeVO)
        {
            InitializeComponent();
            this.SysNoticeVO = SysNoticeVO;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_MSS_SYS_004_1_Load(object sender, EventArgs e)
        {
            lblNum.Text = SysNoticeVO.Seq.ToString();
            txtTitle.Text = SysNoticeVO.Title.ToString();
            dtpStart.Value = Convert.ToDateTime(SysNoticeVO.Notice_Date); 
            dtpEnd.Value = Convert.ToDateTime(SysNoticeVO.Notice_End);
            txtNotice_Rtf.Text = SysNoticeVO.Notice_Rtf.ToString();
            txtDescription.Text = SysNoticeVO.Description.ToString();

        }
        //수정버튼
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SysNoticeService service = new SysNoticeService();
            if(dtpStart.Value > dtpEnd.Value)
            {
                AutoClosingMessageBox.Show("날짜 선택이 잘못되었습니다.", "1초 후 종료", 1000);
                return;
            }
            try
            {
                SysNoticeVO vo = new SysNoticeVO
                {  
                    Seq = Convert.ToInt32(lblNum.Text),
                    Notice_Date = dtpStart.Value.ToString("yyyy-MM-dd"),
                    Notice_End = dtpEnd.Value.ToString("yyyy-MM-dd"),
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Notice_Rtf = txtNotice_Rtf.Text
                };
                bool bFlag = service.UpdateSysNotice(vo);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            AutoClosingMessageBox.Show("공지사항이 수정되었습니다.", "1초 후 자동종료", 1000);

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
