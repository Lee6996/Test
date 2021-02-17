using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.MDI_Parent
{
    public partial class frm_MDIParent_2Grid : Form
    {
        private int childFormNumber = 0;

        public frm_MDIParent_2Grid()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "창 " + childFormNumber++;
            childForm.Show();
        }

        private void frm_MDIParent_2Grid_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddDays(-6);
            dtpTo.Value = DateTime.Now;
        }
    }
}
