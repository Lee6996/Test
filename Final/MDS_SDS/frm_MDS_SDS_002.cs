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
    public partial class frm_MDS_SDS_002 : Form
    {
        ItemService itemservice = new ItemService();
        List<Item_MasterVO> Itemlist;        

        Item_MasterVO upitem = new Item_MasterVO();
        public frm_MDS_SDS_002()
        {
            InitializeComponent();
        }

        private void MDS_SDS_002_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvItemDetail);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "품목코드", "Item_Code", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "품목명", "Item_Name", 150);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "유형", "Item_Type", 65);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "규격", "Item_Spec", 130);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "단위", "Item_Unit", 65);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level1", "Level_1", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level2", "Level_2", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level3", "Level_3", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level4", "Level_4");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level5", "Level_5");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "로트크기", "LotSize", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "리드타임", "Lead_Time", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "안전재고", "Item_Stock");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "시간당 생산수", "PrdQty_Per_Hour");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "배치당 생산수", "PrdQTy_Per_Batch");           
            CommonUtil.AddGridTextColumn(dgvItemDetail, "캐비티수", "Cavity", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "성형줄당갯수", "Line_Per_Qty", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "포장샷당갯수", "Shot_Per_Qty", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "건조대차수량", "Dry_GV_Qty", 80);            
            CommonUtil.AddGridTextColumn(dgvItemDetail, "사용여부", "Use_YN", 150, visibility: false);            
            
            //-----------------------------------------------------------------------------------------
            DataGridViewCheckBoxColumn gridbtn = new DataGridViewCheckBoxColumn(false);
            gridbtn.HeaderText = "사용여부";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.TrueValue = 1;
            gridbtn.FalseValue = 0;            
            gridbtn.DataPropertyName = "Use_YN";
            this.dgvItemDetail.Columns.Add(gridbtn);

            //콤보박스에  정보 바인딩1
            DataTable dtName = itemservice.ItemMasterBindingName();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Item_Code"] = "";
            dr["Item_Name"] = "전체";
            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            cbItem.DisplayMember = "Item_Name";
            cbItem.ValueMember = "Item_Code";
            cbItem.DataSource = dtName;

            DataLoad("");
        }

        private void DataLoad(string groupName)
        {
            try
            {
                ItemService service = new ItemService();
                List<Item_MasterVO> list = service.ItemMasterSelect(groupName);

                dgvItemDetail.DataSource = list;
                dgvItemDetail.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
   

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataLoad(cbItem.Text);
        }
     
        private void RefreshControl()
        {
            txtCode.Text = txtName.Text = "";
            txtCode.Focus();
            nuCavity.Value = nuLine_Per_Qty.Value = nuShot_Per_Qty.Value = 0;

        }

        private void dgvItemDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            upitem = Itemlist.Find(item => item.Item_Code == dgvItemDetail[0, dgvItemDetail.CurrentRow.Index].Value.ToString());//수정하기

            txtCode.Text = upitem.Item_Code;
            txtName.Text = upitem.Item_Name;
            nuCavity.Text = (upitem.Cavity).ToString();

            nuLine_Per_Qty.Text = upitem.Line_Per_Qty.ToString();
            nuShot_Per_Qty.Text = upitem.Shot_Per_Qty.ToString();
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbtext;
            
            if (cbItem.SelectedIndex < 1)
            { cbtext = ""; }
            else
            { cbtext = cbItem.Text; }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {    
            if (txtCode.Text.Length < 1)
            {
                MessageBox.Show("코드 미입력");
                return;
            }
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show("이름 미입력");
                return;
            }

            if (!string.IsNullOrEmpty(txtCode.Text.Trim()) && !string.IsNullOrEmpty(txtName.Text.Trim()))
            {

                Item_MasterVO additem = new Item_MasterVO()
                {                    
                    Cavity = Convert.ToInt32(nuCavity.Value),
                    Line_Per_Qty = Convert.ToInt32(nuLine_Per_Qty.Value),
                    Shot_Per_Qty = Convert.ToInt32(nuShot_Per_Qty.Value),
                    //Up_Date = DateTime.Now.ToString(),
                    //Up_Emp = UserStatic.User_Name                    
                };
                try
                {
                    ItemService service = new ItemService();
                    bool bFlag = service.UpdateAllItem_Master(additem);

                    if (bFlag)
                    {
                        MessageBox.Show("수정되었습니다.");
                        DataLoad("");
                    }
                    else
                        MessageBox.Show("이미 가지고있는 항목입니다.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                RefreshControl();
            }
        }      

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frm_MDS_SDS_002_1 frm = new frm_MDS_SDS_002_1()
            {
                StartPosition = FormStartPosition.CenterScreen,
                Location = new Point(Location.X + Width, Location.Y)
            };            
            frm.Show();
            
        }

        private void dgvItemDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 20 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvItemDetail.Rows[e.RowIndex].Cells[20];
                int useyn = (Convert.ToInt32(chk.Value) == 1) ? 0 : 1;

                Item_MasterVO vo = new Item_MasterVO
                {
                    Item_Code = dgvItemDetail.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                ItemService service = new ItemService();
                service.UpdateUSEYN(vo);

            }
            if (cbItem.Text == "전체")
            {
                DataLoad("");
            }
            else
            {
                DataLoad(cbItem.SelectedValue.ToString());
            }
        }
    }
}
