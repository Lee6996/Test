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
    public partial class frm_MDS_CDS_002_1 : Form
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }
      

        List<Def_MaVO> Defmalist; //불량 대분류
        Def_MaService Defservice = new Def_MaService();
        public frm_MDS_CDS_002_1()
        {
            InitializeComponent();
        }

        private void frm_MDS_CDS_002_1_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvDef);
            CommonUtil.AddGridTextColumn(dgvDef, "불량현상대분류코드", "Def_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvDef, "불량현상대분류 명", "Def_Ma_Name", 210);

            dgvDef.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDef.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDef.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetAllDefMa("");
        }

        private void GetAllDefMa(string def)
        {
            try
            {
                Defmalist = Defservice.GetAllDef_Ma_Master(def);

                dgvDef.DataSource = Defmalist;
                dgvDef.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvDef_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_MDS_CDS_002 searchfrm = new frm_MDS_CDS_002();
            if (searchfrm.ShowDialog() == DialogResult.OK)
            {
                searchfrm.txtCodeText = dgvDef[0, dgvDef.CurrentRow.Index].Value.ToString();
                searchfrm.txtNameText = dgvDef[1, dgvDef.CurrentRow.Index].Value.ToString();
            }
            this.Close();
        }

        private void frm_MDS_CDS_002_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_MDS_CDS_002 search = new frm_MDS_CDS_002();
            search.Search();
        }
    }
}
