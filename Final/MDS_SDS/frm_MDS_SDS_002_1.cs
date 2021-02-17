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
    public partial class frm_MDS_SDS_002_1 : Form
    {
        ItemService itemservice = new ItemService();
        List<ItemInfoVO> itemgrouplist;
        public frm_MDS_SDS_002_1()
        {
            InitializeComponent();
        }

        private void MDS_SDS_002_1_Load(object sender, EventArgs e)
        {
            lblManager.Text = UserStatic.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();
            //GetAllItemGroup();
            //ControlSetting();
        }

        private void GetAllItemGroup()
        {
            itemgrouplist = new List<ItemInfoVO>();
          //  itemgrouplist = itemservice.GetAllItem_Level_Master();
        }

        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox

            ItemInfoVO first = new ItemInfoVO()
            {
                Level_Name = "",
                Level_Code = ""
            };
            //var level1list = itemgrouplist.FindAll(level => level.Item_lvl1 == "Y");
            //level1list.Insert(0, first);
            //cbLevel.DisplayMember = "Level_Name";
            //cbLevel.ValueMember = "Level_Code";
            //cbLevel.DataSource = level1list;

            //var level2list = itemgrouplist.FindAll(level => level.Item_lvl2 == "Y");
            //level2list.Insert(0, first);
            //cbLevel2.DisplayMember = "Level_Name";
            //cbLevel2.ValueMember = "Level_Code";
            //cbLevel2.DataSource = new BindingSource(level2list, null);

            //var level3list = itemgrouplist.FindAll(level => level.Item_lvl3 == "Y");
            //level3list.Insert(0, first);
            //cbLevel3.DisplayMember = "Level_Name";
            //cbLevel3.ValueMember = "Level_Code";
            //cbLevel3.DataSource = new BindingSource(level3list, null);

            //var level4list = itemgrouplist.FindAll(level => level.Item_lvl4 == "Y");
            //level4list.Insert(0, first);
            //cbLevel4.DisplayMember = "Level_Name";
            //cbLevel4.ValueMember = "Level_Code";
            //cbLevel4.DataSource = new BindingSource(level4list, null);

            //var level5list = itemgrouplist.FindAll(level => level.Item_lvl5 == "Y");
            //level5list.Insert(0, first);
            //cbLevel5.DisplayMember = "Level_Name";
            //cbLevel5.ValueMember = "Level_Code";
            //cbLevel5.DataSource = new BindingSource(level5list, null);

            ///
        }

        private void btnSave_Click(object sender, EventArgs e) // 수정필요
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(cbType.Text))
                {
                    string level;
                    if (cbLevel.Text == "Level1")
                    {
                        level = "YNNNN";
                    }
                    else if (cbLevel.Text == "Level2")
                    {
                        level = "NYNNN";
                    }
                    else if (cbLevel.Text == "Level3")
                    {
                        level = "NNYNN";
                    }
                    else if (cbLevel.Text == "Level4")
                    {
                        level = "NNNYN";
                    }
                    else if (cbLevel.Text == "Level5")
                    {
                        level = "NNNNY";
                    }
                    else
                    {
                        level = "NNNNN";
                    }

                    Item_MasterVO item = new Item_MasterVO()
                    {
                        Item_Code = txtCode.Text.Trim(),
                        Item_Name = txtName.Text.Trim(),                        
                        Item_Type = cbType.Text.Trim(),
                        Item_Spec = txtSpec.Text.Trim(),
                        Item_Unit = txtUnit.Text.Trim(),
                        Item_Stock = nuStock.Value,
                        PrdQty_Per_Hour = nuhour.Value,
                        PrdQTy_Per_Batch = nubatch.Value,
                        Cavity = int.Parse(nucavity.Value.ToString().Trim()),
                        Line_Per_Qty = int.Parse(nulinper.Value.ToString().Trim()),
                        Shot_Per_Qty = int.Parse(nushotper.Value.ToString().Trim()),
                        Dry_GV_Qty = int.Parse(nudrgdv.Value.ToString().Trim()),                       
                        Level_1 = level[0].ToString().Trim(),
                        Level_2 = level[1].ToString().Trim(),
                        Level_3 = level[2].ToString().Trim(),
                        Level_4 = level[3].ToString().Trim(),
                        Level_5 = level[4].ToString().Trim()
                    };
                    if (itemservice.InsertItemMaster(item))
                    {
                        MessageBox.Show("저장 성공", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frm_MDS_SDS_002 frm = new frm_MDS_SDS_002();
                        frm.DataLoad("");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("저장 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("필수 항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
            catch (Exception err)
            {

                MessageBox.Show("db 오류 저장 실패" + err.Message, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(err.Message);
            }
        }
    }
}
