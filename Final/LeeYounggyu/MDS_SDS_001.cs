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

            
            ControlSetting();
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


    }
}
