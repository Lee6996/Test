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
            txtNotice_Date.Text = SysNoticeVO.Notice_Date.ToString();
            txtNotice_End.Text = SysNoticeVO.Notice_End.ToString();
            txtDescription.Text = SysNoticeVO.Description.ToString();

        }
    }
}
