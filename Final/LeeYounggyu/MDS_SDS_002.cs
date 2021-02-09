using Final.LeeYounggyu.service;
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

namespace Final.LeeYounggyu
{
    public partial class MDS_SDS_002 : Form
    {
        ItemService itemservice = new ItemService();
        List<Item_MasterVO> Itemlist;
        Item_MasterVO upitem = new Item_MasterVO();
        public MDS_SDS_002()
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
            //CommonUtil.AddGridTextColumn(dgvItemDetail, "리드타임", "Lead_Time", 75);
            //CommonUtil.AddGridTextColumn(dgvItemDetail, "로트크기", "Lot_Size", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "시간당생산수", "PrdQty_Per_Hour");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "배치당생산수", "PrdQTy_Per_Batch");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "캐비티수", "Cavity", 75);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "성형줄당갯수", "Line_Per_Qty");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "포장샷당갯수", "Shot_Per_Qty");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "건조대차수량", "Dry_GV_Qty");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "소성대차수량", "Heat_GV_Qty");
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level1", "Level_1", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level2", "Level_2", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level3", "Level_3", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level4", "Level_4", 80);
            CommonUtil.AddGridTextColumn(dgvItemDetail, "Level5", "Level_5", 80);

            dgvItemDetail.DataSource = new ItemService().SelectItemLevel();

            GetAllItem();
            ControlSetting();
        }

        private void GetAllItem()
        {
            try
            {
                Itemlist = new List<Item_MasterVO>();
                Itemlist = itemservice.GetAllItem_Master();
                dgvItemDetail.DataSource = Itemlist;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
        }

        /// <summary>
        ///  콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            // combobox  품목명
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

            Dictionary<string, string> cblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbItem.DisplayMember = "Value";
            cbItem.ValueMember = "Key";
            cbItem.DataSource = new BindingSource(cblistname, null);
            lblCode.Text = cbItem.SelectedValue.ToString();

            List<Item_MasterVO> dictiontype = Itemlist.GroupBy(name => name.Item_Type).Select(grp => grp.First()).ToList();
            // combobox  품목타입
            Dictionary<string, string> cblisttype = dictiontype.ToDictionary(type => type.Item_Type, type => type.Item_Type);
            cbType.DisplayMember = "Value";
            cbType.ValueMember = "Key";
            cbType.DataSource = new BindingSource(cblisttype, null);

        }

        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            cbItem.Enabled = true;
            lblCode.Enabled = true;
            btnSearch.Enabled = true;

            cbType.Enabled = false;
            btnSearch2.Enabled = false;
        }

        private void rdoType_CheckedChanged(object sender, EventArgs e)
        {
            cbItem.Enabled = false;
            btnSearch.Enabled = false;
            cbType.Enabled = true;
            btnSearch2.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvItemDetail.DataSource = null;
            dgvItemDetail.DataSource = Itemlist;
            foreach (DataGridViewRow row in dgvItemDetail.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblCode.Text.Trim()))
                {
                    row.Selected = true;
                }
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            List<Item_MasterVO> typelist = Itemlist.FindAll(item => item.Item_Type == cbType.Text);

            dgvItemDetail.DataSource = typelist;
        }

        private void dgvItemDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            upitem = Itemlist.Find(item => item.Item_Code == dgvItemDetail.SelectedRows[0].Cells[0].Value.ToString());

            lblupdateCode.Text = upitem.Item_Code;
            lblupdateName.Text = upitem.Item_Name;
            nudCavity.Text = (upitem.Cavity).ToString();

            nuLine_Per_Qty.Text = upitem.Line_Per_Qty.ToString();
            nuShot_Per_Qty.Text = upitem.Shot_Per_Qty.ToString();
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCode.Text = cbItem.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            upitem.Cavity = Convert.ToInt32(nudCavity.Value);
            upitem.Line_Per_Qty = Convert.ToInt32(nuLine_Per_Qty.Value);
            upitem.Shot_Per_Qty = Convert.ToInt32(nuShot_Per_Qty.Value);
            upitem.Ins_Date = DateTime.Now;
            upitem.Ins_Emp = UserStatic.User_Name;

            try
            {
                if (itemservice.UpdateAllItem_Master(upitem))
                {
                    MessageBox.Show(upitem.Item_Name + "이 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllItem();
                    ControlSetting();
                }
                else
                {
                    MessageBox.Show(upitem.Item_Name + "의 수정에 실패했습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
        }
    }
}
