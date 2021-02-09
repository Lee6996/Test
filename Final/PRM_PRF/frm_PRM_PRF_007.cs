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
        UserVO user;

        public frm_PRM_PRF_007()
        {
            InitializeComponent();
        }

        public frm_PRM_PRF_007(UserVO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frm_PRM_PRF_007_Load(object sender, EventArgs e)
        {

        }
    }
}
