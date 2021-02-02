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
    public partial class frm_KPI_RPT_1 : Form
    {
        public frm_KPI_RPT_1()
        {
            InitializeComponent();
        }

        private void frm_KPI_RPT_1_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgv_Process);

            CommonUtil.AddGridTextColumn(dgv_Process, "작업장코드", "Wc_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Process, "작업장명", "Wc_Name", 120);
        }
    }
}
