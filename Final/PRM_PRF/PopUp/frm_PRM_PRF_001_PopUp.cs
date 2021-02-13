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
    public partial class frm_PRM_PRF_001_PopUp : Form
    {
        WorkOrderVO vo;

        public frm_PRM_PRF_001_PopUp()
        {
            InitializeComponent();
        }

        public frm_PRM_PRF_001_PopUp(WorkOrderVO vo)
        {
            InitializeComponent();
            this.vo = vo;
            txtWorkorderno.Text = vo.Workorderno;
            txtPlan_Date.Text = vo.Plan_Date;
            txtWo_Status.Text = vo.Wo_Status;
            txtItem_Code.Text = vo.Item_Code;
            txtItem_Name.Text = vo.Item_Name;
            txtWc_Name.Text = vo.Wc_Name;
            txtIn_Qty_Main.Text = vo.In_Qty_Main.ToString();
            txtOut_Qty_Main.Text = vo.Out_Qty_Main.ToString();
            txtPrd_Qty.Text = vo.Prd_Qty.ToString();
        }

        private void txtPrd_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void frm_PRM_PRF_001_PopUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vo.Prd_Qty = int.Parse(txtPrd_Qty.Text);
            new PRM_PRF_Service().Correction(vo);
            this.Close();
        }
    }
}
