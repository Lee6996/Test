using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_005 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        public frm_PRM_PRF_005()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_005_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvPRM_PRF);
            dgvPRM_PRF.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "대차코드", "GV_Code", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "대차명", "GV_Name", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "작업지시번호", "Workorderno", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "품목코드", "Item_Code", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "품목명", "Item_Name", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "대차상태", "GV_Status", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "대차수량", "GV_Qty", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "로딩일자", "Loading_date", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "로딩시간", "Loading_time", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "로딩작업장", "Loading_Wc", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "언로딩일자", "Unloading_date", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "언로딩시간", "Unloading_time", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "언로딩작업장", "Unloading_Wc", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "요입시간", "In_Time", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "중간시간", "Center_Time", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "요출시간", "Out_Time", 200);

            new PRM_PRF_Service().BindDGV_005(dgvPRM_PRF);
        }
    }
}
