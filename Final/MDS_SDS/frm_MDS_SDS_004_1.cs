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
    public partial class frm_MDS_SDS_004_1 : Form
    {
        ItemService itemservice = new ItemService();
        List<Item_MasterVO> Itemlist;

        WorkCenter_MasterService workcenterservice = new WorkCenter_MasterService();
        List<WorkCenterVO> workcenterlist;

        public frm_MDS_SDS_004_1()
        {
            InitializeComponent();
        }

        private void frm_MDS_SDS_004_1_Load(object sender, EventArgs e)
        {
            GetAllItem();

            lblManager.Text = UserStatic.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();

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
            cbWC_Code.DisplayMember = "WC_Name";
            cbWC_Code.ValueMember = "WC_Code";
            cbWC_Code.DataSource = dtName2;
        }

        private void GetAllItem()
        {
            try
            {
                Itemlist = new List<Item_MasterVO>();
                Itemlist = itemservice.GetAllItem_Master();

                workcenterlist = new List<WorkCenterVO>();
                workcenterlist = workcenterservice.GetAllWorkCenter();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtConditionCode.Text) && !string.IsNullOrEmpty(txtConditionName.Text))
                {
                    Condition_Spec_MasterService service = new Condition_Spec_MasterService();


                    ConditionSpecVO condition = new ConditionSpecVO
                    {
                        Item_Code = cbItem.SelectedIndex.ToString().Trim(),
                        Wc_Code = cbWC_Code.SelectedIndex.ToString().Trim(),
                        Condition_Code = txtConditionCode.Text.Trim(),
                        Condition_Name = txtConditionName.Text.Trim(),
                        USL = nuUSL.Value,
                        SL = nuSL.Value,
                        LSL = nuLSL.Value,
                        Condition_Unit = txtUnit.Text,
                        Condition_Group = txtGroup.Text.Trim(),
                        Remark = txtRemark.Text.Trim()     
                     };
                    bool bFlag = service.InsertCondition(condition);

                    if (bFlag)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 공정조건입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("필수 항목을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
