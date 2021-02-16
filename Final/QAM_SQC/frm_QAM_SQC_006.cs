using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.QAM_SQC
{
    public partial class frm_QAM_SQC_006 : Final.MDI_Parent.frm_MDIParent_1Grid
    {
        int year = DateTime.Now.Year;
        string YYYY;
        public frm_QAM_SQC_006()
        {
            InitializeComponent();
        }

        private void QAM_SQC_006_Load(object sender, EventArgs e)
        {
            nuYear.Maximum = year;
            nuYear.Value = year;
            SettingDGV(dgvQAM_SQC);
            RefreshState();
        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            YYYY = year.ToString();
            RefreshState();
        }


        #region Mymethod

        private void SettingDGV(DataGridView dgv)
        {
            CommonUtil.SetInitGridView(dgv);
            CommonUtil.AddGridTextColumn(dgv, "생산년도", "YYYY", 336);
            CommonUtil.AddGridTextColumn(dgv, "레벨코드", "Level_Code", 336);
            CommonUtil.AddGridTextColumn(dgv, "레벨명", "Level_Name", 336);
            CommonUtil.AddGridTextColumn(dgv, "차수", "Prd_Order", 336);
            CommonUtil.AddGridTextColumn(dgv, "원자재LOT번호", "Mat_LotNo", 336);
        }

        private void RefreshState()
        {
            dgvQAM_SQC.DataSource = new QAM_SQC_Service().GetLotVOList(YYYY);
        }
        #endregion
    }
}
