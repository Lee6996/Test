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

namespace Final.PRM_PRF.PopUp
{
    public partial class frm_PRM_PRF_008_PopUp : Form
    {
        public frm_PRM_PRF_008_PopUp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NOPVO vo = new NOPVO
            {
                Wc_Code = cboWc_Name.SelectedValue.ToString(),
                Nop_Mi_Code = cboNop_Mi_Name.SelectedValue.ToString(),
                Nop_Type = txtNop_Type.Text,
                Nop_Time = nuNop_Time.Value,
                Remark = txtRemark.Text
            };
            if (new PRM_PRF_Service().Insert008(vo))
            {
                AutoClosingMessageBox.Show("저장 성공", "저장성공", 1000);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                AutoClosingMessageBox.Show("저장 실패", "저장실패", 1000);
                this.DialogResult = DialogResult.None;
            }

        }

        private void frm_PRM_PRF_008_PopUp_Load(object sender, EventArgs e)
        {
            new PRM_PRF_Service().BindCboWithNopVO(cboNop_Mi_Name);
            new PRM_PRF_Service().BindCboWithWorkCenterVO(cboWc_Name);
        }

        private void cboNop_Mi_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNop_Mi_Code.Text = cboNop_Mi_Name.SelectedValue.ToString();
        }

        private void cboWc_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWc_Code.Text = cboWc_Name.SelectedValue.ToString();
        }
    }
}
