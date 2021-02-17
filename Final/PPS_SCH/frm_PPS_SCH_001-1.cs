using Final.Service;
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

namespace Final
{
    public partial class frm_PPS_SCH_001_1 : Form
    {
        string WorkorderNum;
        public frm_PPS_SCH_001_1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtReqSeq.Text != null && txtWoReqNo.Text != null && txtItemCode.Text != null && cbWcCode.Text != null && dtpPlanDate.Text != null && txtPlanQty.Text != null && txtPrdUnit.Text != null)
            {
                WorkOrderVO work = new WorkOrderVO()
                {
                    Workorderno = WorkorderNum,
                    Req_Seq = Convert.ToInt32(txtReqSeq.Text),
                    Wo_Req_No = txtWoReqNo.Text,
                    Item_Code = txtItemCode.Text,
                    Wc_Code = cbWcCode.Text,
                    Plan_Date = dtpPlanDate.Text,
                    Plan_Qty = Convert.ToInt32(txtPlanQty.Text),
                    Plan_Unit = txtPrdUnit.Text,
                    Remark = txtRemark.Text
                };
                WorkOrderService service = new WorkOrderService();
                bool bFlag = service.InsertWorkOrder(work);
                if (bFlag == true)
                {
                    MessageBox.Show("추가가 완료되었습니다.");
                    this.Close();
                }
            }
            else
                MessageBox.Show("비고를 제외한 나머지를 채워주세요.");
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PPS_SCH_001_1_Load(object sender, EventArgs e)
        {
            WorkOrderService services = new WorkOrderService();

            List<WorkNumVO> workNums = services.getWorkNum();

            string orderNum = workNums[0].Workorderno;
            int num = Convert.ToInt32(orderNum.Substring(3));
            num = num + 1;
            WorkorderNum = orderNum.Substring(0, 3) + Convert.ToString(num);
        }
    }
}
