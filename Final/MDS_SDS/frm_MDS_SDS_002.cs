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
            CommonUtil.AddGridTextColumn(dgvItemDetail, "안전재고", "Item_Stock", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "리드타임", "Lead_Time", 75, visibility: false);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "로트크기", "Lot_Size", 75, visibility: false);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "시간당생산수", "PrdQty_Per_Hour");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "배치당생산수", "PrdQTy_Per_Batch");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "캐비티수", "Cavity", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "성형줄당갯수", "Line_Per_Qty");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "포장샷당갯수", "Shot_Per_Qty");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "건조대차수량", "Dry_GV_Qty");           
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level1", "Level_1", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level2", "Level_2", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level3", "Level_3", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level4", "Level_4", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level5", "Level_5", 80);
            
            //-----------------------------------------------------------------------------------------
            DataGridViewCheckBoxColumn gridbtn = new DataGridViewCheckBoxColumn(false);
            gridbtn.HeaderText = "사용여부";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.TrueValue = 1;
            gridbtn.FalseValue = 0;
            gridbtn.DefaultCellStyle.BackColor = Color.White;
            gridbtn.DataPropertyName = "Use_YN";
            dgvItemDetail.Columns.Add(gridbtn);

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

            ////콤보박스에  정보 바인딩2
            //DataTable dtType = itemservice.ItemMasterBindingType();
            ////빈칸을 위해 한행 추가
            //DataRow dr2 = dtType.NewRow();
            //dr["Item_Code"] = "";
            //dr["Item_Type"] = "전체";
            //dtType.Rows.InsertAt(dr, 0);
            //dtType.AcceptChanges();

            //cbType.DisplayMember = "Item_Type";
            //cbType.ValueMember = "Item_Code";
            //cbType.DataSource = dtType;

            DataLoad("");


        }

        private void DataLoad(string data)
        {
            try
            {
                ItemService service = new ItemService();
                List<Item_MasterVO> list = service.ItemMasterSelect(data);

                dgvItemDetail.DataSource = list;
                dgvItemDetail.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
   

        /// <summary>
        ///  콤보박스세팅
        /// </summary>
        //private void ControlSetting()
        //{
        //    // combobox  품목명
        //    List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

        //    Dictionary<string, string> cblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
        //    cbItem.DisplayMember = "Value";
        //    cbItem.ValueMember = "Key";
        //    cbItem.DataSource = new BindingSource(cblistname, null);
        //    lblCode.Text = cbItem.SelectedValue.ToString();

        //    List<Item_MasterVO> dictiontype = Itemlist.GroupBy(name => name.Item_Type).Select(grp => grp.First()).ToList();
        //    // combobox  품목타입
        //    Dictionary<string, string> cblisttype = dictiontype.ToDictionary(type => type.Item_Type, type => type.Item_Type);
        //    cbType.DisplayMember = "Value";
        //    cbType.ValueMember = "Key";
        //    cbType.DataSource = new BindingSource(cblisttype, null);
                //}
  

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
                    Up_Date = DateTime.Now.ToString(),
                    Up_Emp = UserStatic.User_Name                    
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
    }
}
