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
    public partial class frm_MDS_SDS_003_1 : Form
    {
        ItemService itemservice = new ItemService();
        List<Item_MasterVO> Itemlist;

        List<ProcessVO> processlist;
        ProcessService processservice = new ProcessService();
        public frm_MDS_SDS_003_1()
        {
            InitializeComponent();
        }

        private void frm_MDS_SDS_003_1_Load(object sender, EventArgs e)
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
            DataTable dtName2 = processservice.ProcessBindingName();
            //빈칸을 위해 한행 추가
            DataRow dr2 = dtName2.NewRow();
            dr2["Process_Name"] = "전체";
            dr2["Process_code"] = "";

            dtName2.Rows.InsertAt(dr2, 0);
            dtName2.AcceptChanges();

            //콤보박스에 표시될 컬럼 바인딩
            cbProcess.DisplayMember = "Process_Name";
            cbProcess.ValueMember = "Process_code";
            cbProcess.DataSource = dtName2;
        }

        private void GetAllItem()
        {
            try
            {
                Itemlist = new List<Item_MasterVO>();
                Itemlist = itemservice.GetAllItem_Master();

                processlist = new List<ProcessVO>();
                processlist = processservice.GetAllProcess();

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

                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    SpecService service = new SpecService();
                    

                    ItemSpecVO inspect = new ItemSpecVO
                    {
                        Item_Code = cbItem.SelectedValue.ToString().Trim(),
                        Process_code = cbProcess.SelectedValue.ToString().Trim(),
                        Inspect_code = txtCode.Text.Trim(),
                        Inspect_name = txtName.Text.Trim(),
                        USL = nuUSL.Value,
                        SL = nuSL.Value,
                        LSL = nuLSL.Value,
                        Sample_size = Convert.ToInt32(nuSize.Value),
                        Inspect_Unit = txtUnit.Text.Trim(),
                        Remark = txtRemark.Text.Trim()

                    };
                    bool bFlag = service.InsertSpec(inspect);
                    
                    if (bFlag)
                    {
                        MessageBox.Show("저장 완료.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_MDS_SDS_003 frm = new frm_MDS_SDS_003();
                        frm.ItemSpecDataLoad("");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

