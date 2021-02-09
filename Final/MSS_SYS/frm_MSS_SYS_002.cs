using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.MSS_SYS
{
    public partial class frm_MSS_SYS_002 : Form
    {
        public frm_MSS_SYS_002()
        {
            InitializeComponent();
        }

        private void MSS_SYS_002_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvLogin_History);
            //CommonUtil.AddGridTextColumn(dgvLogin_History, "이름", )
        }
    }
}
