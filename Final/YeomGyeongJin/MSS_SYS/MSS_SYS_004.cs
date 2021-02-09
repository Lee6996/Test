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

namespace Final.YeomGyeongJin.MSS_SYS
{
    public partial class MSS_SYS_004 : Form
    {
        public List<SysNoticeVO> list;
        public MSS_SYS_004()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SysNoticeService service = new SysNoticeService();

            //날짜 사이의 between 쿼리문 작성

            service.Dispose();
        }

        private void MSS_SYS_004_Load(object sender, EventArgs e)
        {
            dtpNotice_Start.Value = DateTime.Now;
            dtpNotice_End.Value = DateTime.Now;

            CommonUtil.SetInitGridView(dgvNotice);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항번호", "Seq", 100);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항시작일자", "Notice_Date", 100);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항종료일자", "Notice_End", 100);
            CommonUtil.AddGridTextColumn(dgvNotice, "제목", "Title", 100);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지내역", "Description", 100);
        }
    }
}
