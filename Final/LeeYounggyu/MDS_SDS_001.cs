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

    public partial class MDS_SDS_001 : Form
    {
        ItemService itemservice = new ItemService();
        List<ItemInfoVO> itemlist;
        public MDS_SDS_001()
        {
            InitializeComponent();
        }

        private void MDS_SDS_001_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvItemLevel);
            CommonUtil.AddGridTextColumn(dgvItemLevel, "레벨코드", "Level_Code", 150);
            CommonUtil.AddGridTextColumn(dgvItemLevel, "레벨명", "Level_Name", 150);
            CommonUtil.AddGridTextColumn(dgvItemLevel, "팔렛당박스수", "Box_Qty", 200);
            CommonUtil.AddGridTextColumn(dgvItemLevel, "박스당PCS수", "Pcs_Qty", 200);
            CommonUtil.AddGridTextColumn(dgvItemLevel, "PCS당소재량", "Mat_Qty", 200);
            CommonUtil.AddGridTextColumn(dgvItemLevel, "사용여부", "Use_YN", 150);


            dgvItemLevel.DataSource = new ItemService().SelectItemLevel();

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.White;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvItemLevel.Columns.Add(gridbtn);

            GetAllItemGroup();
            ControlSetting();
        }

        private void GetAllItemGroup()
        {
            itemlist = new List<ItemInfoVO>();
            itemlist = itemservice.SelectItemLevel();
            dgvItemLevel.DataSource = itemlist;
        }

        private void dgvItemLevel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (btnSave.Text == "수정")
            // {
            var update = itemlist.Find(item => item.Level_Code == dgvItemLevel.SelectedRows[0].Cells[0].Value.ToString());

            txtCode.Text = update.Level_Code;
            txtName.Text = update.Level_Name;
            nuPLbox.Value = update.Box_Qty;
            nuBoxpcs.Value = update.Pcs_Qty;
            nuPCSqty.Value = update.Mat_Qty;

            if (update.Item_lvl1 == "Y")
            {
                cbLevel.SelectedIndex = 0;
            }
            else if (update.Item_lvl2 == "Y")
            {
                cbLevel.SelectedIndex = 1;
            }
            else if (update.Item_lvl3 == "Y")
            {
                cbLevel.SelectedIndex = 2;
            }
            else if (update.Item_lvl4 == "Y")
            {
                cbLevel.SelectedIndex = 3;
            }
            else if (update.Item_lvl5 == "Y")
            {
                cbLevel.SelectedIndex = 4;
            }
            
            // }
        }

        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
            Dictionary<string, string> cbblist = itemlist.ToDictionary(item => item.Level_Code, item => item.Level_Name);
            cbLevel.DisplayMember = "Value";
            cbLevel.ValueMember = "Key";
            cbLevel.DataSource = new BindingSource(cbblist, null);
            lblLevel.Text = cbLevel.SelectedValue.ToString();
            ///
        }        

        private void btnSearch_Click(object sender, EventArgs e)
        {
               foreach (DataGridViewRow row in dgvItemLevel.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains(lblLevel.Text))
                {
                    row.Cells[0].Selected = true;
                }
            }
        }

        private void cbLevelGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLevel.Text = cbLevelGroup.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text.Trim()) && !string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                string level = null;

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

                ItemInfoVO additem = new ItemInfoVO()
                {
                    Level_Code = txtCode.Text.Trim(),
                    Level_Name = txtName.Text.Trim(),
                    Item_lvl1 = level[0].ToString().Trim(),
                    Item_lvl2 = level[1].ToString().Trim(),
                    Item_lvl3 = level[2].ToString().Trim(),
                    Item_lvl4 = level[3].ToString().Trim(),
                    Item_lvl5 = level[4].ToString().Trim(),
                    Box_Qty = Convert.ToInt32(nuPLbox.Value),
                    Pcs_Qty = Convert.ToInt32(nuBoxpcs.Value),
                    Mat_Qty = nuPCSqty.Value,
                    Ins_Emp = UserStatic.User_Name,
                };

                if (itemservice.UpdateItemInfo(additem))
                {
                    MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAllItemGroup();
                    ControlSetting();
                   
                }
                else
                {
                    MessageBox.Show("db실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("필수 항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvItemLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvItemLevel.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvItemLevel.SelectedRows[0].Cells[5].Value).ToString() == "Y") //사용안함
                    {
                        itemservice.Use_YNItem_Level_Master((dgvItemLevel.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        itemservice.Use_YNItem_Level_Master((dgvItemLevel.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllItemGroup();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
//부모폼에서 추가, 편집(컨트롤활성화) <기능은 구현> , 삭제 << 기능메서드 필요.
