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

/// <summary>
/// 대차현황 모니터링
/// 현재 사용하고 있거나 빈대차를 확인할 수 있는 실시간 모니터링 가능
/// </summary>
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

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            RefreshState();
        }

        private void frm_PRM_PRF_007_Load(object sender, EventArgs e)
        {
            SettingDGV(dgvPRM_PRF);
            tmRefresh.Start();
            RefreshState();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tmRefresh.Stop();
            tmRefresh.Start();
            RefreshState();
        }

        #region MyMethod
        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "대차코드", "GV_Code", 133);
            CommonUtil.AddGridTextColumn(dgv, "대차명", "GV_Name", 133);
        }

        private void DrawGVState()
        {
            pnGVState.Controls.Clear();
            gvStatusList = new PRM_PRF_Service().GetGVVOList();

            foreach (GVStatusVO gvStatus in gvStatusList)
            {
                Label lbl = new Label();
                if (gvStatus.Loading_date == null) gvStatus.Loading_date = "로딩전";
                lbl.Text = $"대차명: {gvStatus.GV_Name}\n대차상태: {gvStatus.GV_Status}\n작업지시번호: {gvStatus.Workorderno}\n품목코드: {gvStatus.Item_Code}\n품목명: {gvStatus.Item_Name }\n로딩시간: {gvStatus.Loading_time}";
                lbl.Margin = new Padding(10);
                lbl.BackColor = Color.White;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.Font = new Font("나눔스퀘어OTF", 12.00F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                lbl.AutoSize = true;
                pnGVState.Controls.Add(lbl);
            }

            

            //for (int i = 0; i < (int)Math.Ceiling(gvStatusList.Count / 3.0); i++)
            //{
            //    for (int k = 0; k < 3; k++)
            //    {
            //        lbl.Location = new Point((k*300) + 10, (i*200) + 10);
                    
            //    }
            //}
        }

        public void RefreshState()
        {
            
            list = new PRM_PRF_Service().GetGV("checkExist");
            dgvPRM_PRF.DataSource = list;
            DrawGVState();
        }

        #endregion
    }
}
