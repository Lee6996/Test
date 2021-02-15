using Final.Service;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final.PPS_SCH
{
    public partial class frm_PPS_SCH_001 : Final.KPI_RPT.KPI_RPT_MDIParent
    {
        public frm_PPS_SCH_001()
        {
            InitializeComponent();
        }
        private void frm_PPS_SCH_001_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
        private void DataLoad()
        {
            CommonUtil.SetInitGridView(dgv_Req);

            CommonUtil.AddGridTextColumn(dgv_Req, "생산의뢰번호", "Wo_Req_No", 120);
            CommonUtil.AddGridTextColumn(dgv_Req, "의뢰순번", "Req_Seq", 120);
            CommonUtil.AddGridTextColumn(dgv_Req, "품목코드", "Item_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_Req, "의뢰수량", "Req_Qty", 120);
            CommonUtil.AddGridTextColumn(dgv_Req, "생산완료예정일", "Prd_Plan_Date", 180);
            CommonUtil.AddGridTextColumn(dgv_Req, "거래처명", "Cust_Name", 140);
            CommonUtil.AddGridTextColumn(dgv_Req, "프로젝트명", "Project_Name", 160);
            CommonUtil.AddGridTextColumn(dgv_Req, "영업담당", "Sale_Emp", 120);
            CommonUtil.AddGridTextColumn(dgv_Req, "의뢰상태", "Req_Status", 120);

            CommonUtil.SetInitGridView(dgv_WorkOrder);

            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "생산의뢰번호 ", "Wo_Req_No", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업지시상태 ", "Wo_Status", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업지시번호 ", "Workorderno", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업지시일자 ", "Plan_Date", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "품목코드 ", "Item_Code", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "작업장코드  ", "Wc_Code", 140);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "계획수량 ", "Plan_Qty", 160);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "투입수량 ", "In_Qty_Main", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "산출수량 ", "Out_Qty_Main", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "생산수량 ", "Prd_Qty", 120);
            CommonUtil.AddGridTextColumn(dgv_WorkOrder, "비고", "Remark", 120);

            GetData();
        }
        private void GetData()
        {
            WorkOrderService service = new WorkOrderService();

            List<WorkReqVO> listReq = service.listReq(dateTimePicker1.Text, dateTimePicker2.Text);


            dgv_Req.DataSource = null;
            dgv_Req.DataSource = listReq;

            WorkOrderService services = new WorkOrderService();

            List<WorkOrderVO> listWork = services.listWork(dateTimePicker1.Text, dateTimePicker2.Text);

            dgv_WorkOrder.DataSource = null;
            dgv_WorkOrder.DataSource = listWork;

        }
        

        private void button22_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnWorkAdd_Click(object sender, EventArgs e)
        {
            frm_PPS_SCH_001_1 frm = new frm_PPS_SCH_001_1()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();
        }


    }
}
