using Final.MDS_ODS.service;
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
    public partial class frm_MDS_SDS_003 : Form
    {
        SpecService service = new SpecService();
        ItemService service2 = new ItemService();
        ProcessService service3 = new ProcessService();
        public frm_MDS_SDS_003()
        {
            InitializeComponent();
        }

        private void frm_MDS_SDS_003_Load(object sender, EventArgs e)
        {
            
            CommonUtil.SetInitGridView(dgvItemInfo);

            CommonUtil.AddGridTextColumn(dgvItemInfo, "품목코드", "Item_Code", 220);
            CommonUtil.AddGridTextColumn(dgvItemInfo, "품목명", "Item_Name", 220);
           

            CommonUtil.SetInitGridView(dgvSpec);

            CommonUtil.AddGridTextColumn(dgvSpec, "검사항목코드", "Inspect_code", 220);
            CommonUtil.AddGridTextColumn(dgvSpec, "검사항목명", "Inspect_name", 220);
            CommonUtil.AddGridTextColumn(dgvSpec, "품목코드", "Item_Code", 250);
            CommonUtil.AddGridTextColumn(dgvSpec, "공정코드", "Process_code", 150);
            CommonUtil.AddGridTextColumn(dgvSpec, "규격 상한값", "USL", 220);
            CommonUtil.AddGridTextColumn(dgvSpec, "기준값", "SL", 220);
            CommonUtil.AddGridTextColumn(dgvSpec, "규격 하한값", "LSL", 250);
            CommonUtil.AddGridTextColumn(dgvSpec, "크기", "Sample_size", 150);
            CommonUtil.AddGridTextColumn(dgvSpec, "샘플단위", "Inspect_Unit", 250);
            CommonUtil.AddGridTextColumn(dgvSpec, "사용여부", "Use_YN", 150, visibility: false);

        
            

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvSpec.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvItemInfo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvItemInfo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvItemInfo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgvSpec.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvSpec.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            dgvSpec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;           

            //콤보박스에 그룹 정보 바인딩
            DataTable dtName = service2.ItemMasterBindingName();
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
            DataTable dtName2 = service3.ProcessBindingName();
            //빈칸을 위해 한행 추가
            DataRow dr2 = dtName2.NewRow();
            dr["Process_Name"] = "전체";
            dr["Process_code"] = "";

            dtName2.Rows.InsertAt(dr, 0);
            dtName2.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbProcess.DisplayMember = "Process_Name";
            cbProcess.ValueMember = "Process_code";
            cbProcess.DataSource = dtName2;

            ItemMaterDataLoad("");
            ItemSpecDataLoad("");
        }
        private void ItemMaterDataLoad(string Code)
        {
            try
            {
                List<Item_MasterVO> list = service2.ItemMasterSelect(Code);
                dgvItemInfo.DataSource = list;
                dgvItemInfo.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void ItemSpecDataLoad(string Code)
        {
            try
            {
                List<ItemSpecVO> list = service.ItemSpecSelect(Code);

                dgvSpec.DataSource = list;
                dgvSpec.ClearSelection();

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
            ItemSpecDataLoad(cbProcess.SelectedValue.ToString());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frm_MDS_SDS_003_1 frm = new frm_MDS_SDS_003_1()
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

        private void cbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProcess.SelectedIndex < 0) return;
        }
    }
}
