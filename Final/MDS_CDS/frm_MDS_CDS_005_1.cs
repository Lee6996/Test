using Final.MDS_CDS.service;
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

namespace Final.MDS_CDS
{
    public partial class frm_MDS_CDS_005_1 : Form
    {    
        List<BoxingGrade_Detail_MasterVO> boxlist; //비가동 대분류
        BoxingGrade_Detail_MasterService boxservice = new BoxingGrade_Detail_MasterService();
        public frm_MDS_CDS_005_1()
        {
            CommonUtil.SetInitGridView(dgvBox);
            CommonUtil.AddGridTextColumn(dgvBox, "포장등급코드", "Boxing_Grade_Code", 210);
            CommonUtil.AddGridTextColumn(dgvBox, "포장등급명", "Boxing_Grade_Name", 210);

            dgvBox.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBox.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBox.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetAllBoxMa("");
        }

        private void GetAllBoxMa(string box)
        {
            try
            {
                boxlist = boxservice.GetAllBoxMa(box);

                dgvBox.DataSource = boxlist;
                dgvBox.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvBox_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_MDS_CDS_005 searchfrm = new frm_MDS_CDS_005();
            if (searchfrm.ShowDialog() == DialogResult.OK)
            {
                searchfrm.txtCodeText = dgvBox[0, dgvBox.CurrentRow.Index].Value.ToString();
                searchfrm.txtNameText = dgvBox[1, dgvBox.CurrentRow.Index].Value.ToString();
            }

            searchfrm.Search();
            this.Close();
        }
    }
}
