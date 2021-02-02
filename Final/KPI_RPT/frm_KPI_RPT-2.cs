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
    public partial class frm_KPI_RPT_2 : Form
    {
        public frm_KPI_RPT_2()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_2_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_WorkCenter);

            CommonUtil.AddGridTextColumn(dgv_WorkCenter, "공정코드", "Process_code", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkCenter, "공정명", "Process_name", 120);
        }
    }
}
