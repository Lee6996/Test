using FinalDAC;
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

namespace Final.MSS_SYS
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
            DataLoad(cbSysNotice.Text);
        }

        private void MSS_SYS_004_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvNotice);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항번호", "Seq", 180);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항시작일자", "Notice_Date", 160);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지사항종료일자", "Notice_End", 160);
            CommonUtil.AddGridTextColumn(dgvNotice, "제목", "Title", 220);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지참조", "Notice_Rtf", 300);
            CommonUtil.AddGridTextColumn(dgvNotice, "공지내역", "Description", 300);

            dgvNotice.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNotice.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNotice.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            cbSysNotice.Items.Add("전체");
            cbSysNotice.Items.Add("만료");
            cbSysNotice.Items.Add("진행");
            cbSysNotice.Items.Add("예정");
            cbSysNotice.SelectedIndex = 0;

            DataLoad("");
        }

        private void DataLoad(string sysnotice)
        {
            try
            {
                SelectDAC service = new SelectDAC();
                List<SysNoticeVO> list = service.SelectAllNoticeInfo(sysnotice);

                dgvNotice.DataSource = list;
                dgvNotice.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //셀 더블 클릭시 공지사항폼 쇼다이얼로그
        private void dgvNotice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int seq = Convert.ToInt32(dgvNotice.Rows[e.RowIndex].Cells[0].Value);

                SysNoticeVO sysNoticeVO = new SysNoticeVO
                {
                    Seq = seq,
                    Title = dgvNotice.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Notice_Date = dgvNotice.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Notice_End = dgvNotice.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Notice_Rtf = dgvNotice.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Description = dgvNotice.Rows[e.RowIndex].Cells[5].Value.ToString()
                };
                frm_MSS_SYS_004_1 frm = new frm_MSS_SYS_004_1(sysNoticeVO);

                frm.ShowDialog();

                DataLoad("");
            }
        }

        //콤보박스 선택
        private void cbSysNotice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSysNotice.SelectedIndex < 1) return;


        }
        //공지사항등록
        private void btnNotice_Insert_Click(object sender, EventArgs e)
        {
            frm_MSS_SYS_004_2 frm = new frm_MSS_SYS_004_2();
            frm.ShowDialog();

            DataLoad("");
        }

        //헤더 클릭시 정렬
        private void dgvNotice_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
