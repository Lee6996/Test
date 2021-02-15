using Final.MDS_SDS.service;
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

namespace Final.MDS_SDS
{
    public partial class frm_MDS_SDS_004 : Form
    {
        ItemService itemservice = new ItemService();
        List<Item_MasterVO> Itemlist; //품목

        WorkCenter_MasterService workcenterservice = new WorkCenter_MasterService();
        List<WorkCenterVO> workcenterlist; //작업장

        Condition_Spec_MasterService Conditionservice = new Condition_Spec_MasterService();
        List<ConditionSpecVO> Conditionlist; //공정조건
        public frm_MDS_SDS_004()
        {
            InitializeComponent();
        }

        private void frm_MDS_SDS_004_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvItem);

            CommonUtil.AddGridTextColumn(dgvItem, "품목코드", "Item_Code", 220);
            CommonUtil.AddGridTextColumn(dgvItem, "품목명", "Item_Name", 220);


            CommonUtil.SetInitGridView(dgvWork);

            CommonUtil.AddGridTextColumn(dgvWork, "품목코드", "Item_Code", 220);
            CommonUtil.AddGridTextColumn(dgvWork, "작업장코드", "Wc_Code", 220);
            CommonUtil.AddGridTextColumn(dgvWork, "검사항목코드", "Condition_Code", 250);
            CommonUtil.AddGridTextColumn(dgvWork, "검사항목명", "Condition_Name", 150);
            CommonUtil.AddGridTextColumn(dgvWork, "규격 상한값", "USL", 220);
            CommonUtil.AddGridTextColumn(dgvWork, "기준값", "SL", 220);
            CommonUtil.AddGridTextColumn(dgvWork, "규격 하한값", "LSL", 250);
            CommonUtil.AddGridTextColumn(dgvWork, "단위", "Condition_Unit", 150);
            CommonUtil.AddGridTextColumn(dgvWork, "비고", "Remark", 250);            



            //DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            //col.Name = "chk";
            //col.HeaderText = "사용여부";
            //col.Width = 100;
            //col.TrueValue = 1;
            //col.FalseValue = 0;
            //col.DataPropertyName = "Use_YN";
            //this.dgvWork.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvItem.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvItem.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvItem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvWork.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvWork.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvWork.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //콤보박스에 그룹 정보 바인딩
            DataTable dtName = itemservice.ItemMasterBindingName();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Item_Name"] = "전체";
            dr["Item_Code"] = "";

            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbItem.DisplayMember = "Item_Name";
            cbItem.ValueMember = "Item_Code";
            cbItem.DataSource = dtName;


            //콤보박스에 그룹 정보 바인딩
            DataTable dtName2 = workcenterservice.WorkCenterBinding();
            //빈칸을 위해 한행 추가
            DataRow dr2 = dtName2.NewRow();
            dr["WC_Name"] = "전체";
            dr["WC_Code"] = "";

            dtName2.Rows.InsertAt(dr, 0);
            dtName2.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbWorkCenter.DisplayMember = "WC_Name";
            cbWorkCenter.ValueMember = "WC_Code";
            cbWorkCenter.DataSource = dtName2;

            ItemMaterDataLoad("");
            Condition_SpecDataLoad("");
        }

        private void Condition_SpecDataLoad(string Code)
        {
            try
            {
                List<ConditionSpecVO> list = Conditionservice.ConditionSelect(Code);
                dgvItem.DataSource = list;
                dgvItem.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void ItemMaterDataLoad(string Code)
        {
            try
            {
                List<Item_MasterVO> list = itemservice.ItemMasterSelect(Code);
                dgvItem.DataSource = list;
                dgvItem.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            ItemMaterDataLoad(cbItem.SelectedValue.ToString());
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            Condition_SpecDataLoad(cbWorkCenter.SelectedValue.ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frm_MDS_SDS_004 frm = new frm_MDS_SDS_004()
            {
                StartPosition = FormStartPosition.CenterScreen,
                Location = new Point(Location.X + Width, Location.Y)
            };
            frm.Show();
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItem.SelectedIndex < 0) return;
        }

        private void cbWorkCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWorkCenter.SelectedIndex < 0) return;
        }
    }
}
