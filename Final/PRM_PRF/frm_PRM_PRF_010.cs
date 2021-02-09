using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_010 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        UserVO user;

        public frm_PRM_PRF_010()
        {
            InitializeComponent();
        }

        public frm_PRM_PRF_010(UserVO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frm_PRM_PRF_010_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvPRM_PRF_010_2);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "작업지시번호", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "작업장코드", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "작업장명", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "품목코드", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "품목명", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "작업시작일시", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "작업종료일시", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "생산수량", "", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_010_2, "할당작업자", "", 200);
            dgvPRM_PRF_010_2.DataSource = new PRM_PRF_Service().GetAttendanceManagementVOList();
        }
    }
}
