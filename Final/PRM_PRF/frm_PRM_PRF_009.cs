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
    public partial class frm_PRM_PRF_009 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        WorkHistoryVO vo;
        List<WorkHistoryVO> list;
        UserVO user;

        public frm_PRM_PRF_009()
        {
            InitializeComponent();
        }

        public frm_PRM_PRF_009(UserVO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frm_PRM_PRF_009_Load(object sender, EventArgs e)
        {
            list = new PRM_PRF_Service().GetWorkHistoryVOList();

            CommonUtil.SetInitGridView(dgvPRM_PRF_009);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_009, "근무일", "Work_Date", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_009, "작업장", "Wc_Name", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_009, "작업자", "User_Name", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_009, "근무시작시간", "Work_StartTime", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_009, "근무종료시간", "Work_EndTime", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF_009, "근무시간", "Work_Time", 200);

            dgvPRM_PRF_009.DataSource = list;
        }
    }
}
