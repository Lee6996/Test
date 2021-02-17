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

    public partial class frm_MDS_SDS_001 : Form
    {
        ItemService itemservice = new ItemService();
        List<ItemInfoVO> list;
        ItemInfoVO vo;
        public frm_MDS_SDS_001()
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
            CommonUtil.AddGridTextColumn(dgvItemLevel, "사용여부", "Use_YN", 150, visibility: false);

            DataGridViewCheckBoxColumn gridbtn = new DataGridViewCheckBoxColumn(false);
            gridbtn.HeaderText = "사용여부";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.TrueValue = 1;
            gridbtn.FalseValue = 0;
            gridbtn.DataPropertyName = "Use_YN";
            this.dgvItemLevel.Columns.Add(gridbtn);

            //콤보박스에 유저 그룹 정보 바인딩
            DataTable dtName = itemservice.ItemLevelBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtName.NewRow();
            dr["Level_Code"] = "";
            dr["Level_Name"] = "전체";
            dtName.Rows.InsertAt(dr, 0);
            dtName.AcceptChanges();

            cbLevelGroup.DisplayMember = "Level_Name";
            cbLevelGroup.ValueMember = "Level_Code";
            cbLevelGroup.DataSource = dtName;

            DataLoad("");
        }

        private void DataLoad(string groupName)
        {
            try
            {
                ItemService service = new ItemService();
                List<ItemInfoVO> list = service.ItemLevelGroupSelect(groupName);

                dgvItemLevel.DataSource = list;
                dgvItemLevel.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvItemLevel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              //var update = itemlist.Find(item => item.Level_Code == dgvItemLevel[1, dgvItemLevel.CurrentRow.Index].Value.ToString());
            if (e.RowIndex >= 0)
                vo = list[e.RowIndex];
            txtCode.Text = vo.Level_Code;
            txtName.Text = vo.Level_Name;
            nuPLbox.Value = vo.Box_Qty;
            nuBoxpcs.Value = vo.Pcs_Qty;
            nuPCSqty.Value = vo.Mat_Qty;
           
            if (vo.Item_lvl1 == "Y")
            {
                cbLevel.SelectedIndex = 0;
            }
            else if (vo.Item_lvl2 == "Y")
            {
                cbLevel.SelectedIndex = 1;
            }
            else if (vo.Item_lvl3 == "Y")
            {
                cbLevel.SelectedIndex = 2;
            }
            else if (vo.Item_lvl4 == "Y")
            {
                cbLevel.SelectedIndex = 3;
            }
            else if (vo.Item_lvl5 == "Y")
            {
                cbLevel.SelectedIndex = 4;
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataLoad(cbLevelGroup.Text);
        }

        private void RefreshControl()
        {
            txtCode.Text = txtName.Text = "";
            txtCode.Focus();
            nuBoxpcs.Value = nuPCSqty.Value = nuPLbox.Value = 0;
        }

        private void dgvItemLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                //dgvUser.EndEdit();

                DataGridViewCheckBoxCell dgv = (DataGridViewCheckBoxCell)dgvItemLevel.Rows[e.RowIndex].Cells[6];
                int useyn = (Convert.ToInt32(dgv.Value) == 1) ? 0 : 1;

                ItemInfoVO vo = new ItemInfoVO
                {
                    Level_Code = dgvItemLevel.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                ItemService service = new ItemService();
                service.UpdateItemLevel(vo);
            }
            if (cbLevelGroup.Text == "전체")
            {
                DataLoad("");
            }
            else
            {
                DataLoad(cbLevelGroup.SelectedValue.ToString());
            }
        }

        private void cbLevelGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cbtext;
            if (cbLevelGroup.SelectedIndex < 1)
                cbtext = "";
            else
                cbtext = cbLevelGroup.Text;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtCode.Text.Trim()) && !string.IsNullOrEmpty(txtName.Text.Trim()))
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
                    //Ins_Emp = UserStatic.User_Name,
                };

                if (itemservice.InsertUpdateItemInfo(additem))
                {
                    MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataLoad("");
                    RefreshControl();
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
    }
}

