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

namespace Final.PRM_PRF
{
    public partial class frm_PRM_PRF_007 : Form
    {
        List<GV> list;
        List<GVStatusVO> gvStatusList;
        public frm_PRM_PRF_007()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_007_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            RefreshState();
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "대차코드", "GV_Code", 200);
            CommonUtil.AddGridTextColumn(dgv, "대차명", "GV_Name", 200);
        }

        private void DrawGVState()
        {
            pnGVState.Controls.Clear();
            Label lbl = new Label();
            foreach(GVStatusVO gvStatus in gvStatusList)
            {
                lbl.Text = $"대차명: {gvStatus.GV_Name}\n대차상태: {gvStatus.GV_Status}\n작업지시번호: {gvStatus.Workorderno}\n품목코드: {gvStatus.Item_Code}\n품목명: {gvStatus.Item_Name }\n로딩시간: {gvStatus.Loading_time}";
                lbl.Margin = new Padding(10);
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Font = new Font("나눔스퀘어OTF", 10.00F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                lbl.AutoSize = true;
            }
            pnGVState.Controls.Add(lbl);
        }


        public void RefreshState()
        {
            list = new PRM_PRF_Service().GetGV();
            dgvPRM_PRF.DataSource = list;
            DrawGVState();
        }
        #endregion
    }
}
