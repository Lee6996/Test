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
        public frm_PRM_PRF_007()
        {
            InitializeComponent();
        }

        private void frm_PRM_PRF_007_Load(object sender, EventArgs e)
        {

        }

        #region MyMethod
        private void frm_PRM_PRF_005_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvPRM_PRF);
            dgvPRM_PRF.Columns.Add(new DataGridViewCheckBoxColumn());
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "대차코드", "GV_Code", 200);
            CommonUtil.AddGridTextColumn(dgvPRM_PRF, "대차명", "GV_Name", 200);
        }

        public void RefreshState()
        {
            list = new PRM_PRF_Service().GetGV();
            dgvPRM_PRF.DataSource = list;
        }
        #endregion
    }
}
