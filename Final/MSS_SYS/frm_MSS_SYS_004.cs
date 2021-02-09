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
    public partial class frm_MSS_SYS_004 : Form
    {
        public List<SysNoticeVO> list;
        public frm_MSS_SYS_004()
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
            CommonUtil.SetInitGridView(dgvNotice);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항번호", "Seq", 180);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항시작일자", "Notice_Date", 220);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항종료일자", "Notice_End", 220);
            CommonUtil.AddGridTextColumn(dgvNotice, "제목", "Title", 220);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지내역", "Description");
        }

        //셀 더블 클릭시 공지사항폼 쇼다이얼로그
        private void dgvNotice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seq = Convert.ToInt32(dgvNotice.Rows[e.RowIndex].Cells[0].Value);
            SysNoticeVO sysNoticeVO = new SysNoticeVO
            {
                Seq = seq,
                Title = dgvNotice.Rows[e.RowIndex].Cells[3].Value.ToString()
            };
            frm_MSS_SYS_004_1 frm = new frm_MSS_SYS_004_1(sysNoticeVO);
            
            frm.ShowDialog();
        }
    }
}
