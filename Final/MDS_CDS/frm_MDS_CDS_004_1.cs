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
    public partial class frm_MDS_CDS_004_1 : Form
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }


        List<Nop_MaVO> NopMalist; //비가동 대분류
        Nop_MaService NopMaservice = new Nop_MaService();
        public frm_MDS_CDS_004_1()
        {
            InitializeComponent();
        }

        private void frm_MDS_CDS_004_1_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvNop);
            CommonUtil.AddGridTextColumn(dgvNop, "비가동 대분류 코드", "Nop_Ma_Code", 210);
            CommonUtil.AddGridTextColumn(dgvNop, "비가동 대분류 명", "Nop_Ma_Name", 210);

            dgvNop.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNop.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvNop.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetAllNopMa("");
        }

        private void GetAllNopMa(string nop)
        {
            try
            {
                NopMalist = NopMaservice.GetAllNop_Ma_Master(nop);

                dgvNop.DataSource = NopMalist;
                dgvNop.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvNop_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_MDS_CDS_004 searchfrm = new frm_MDS_CDS_004();
            if (searchfrm.ShowDialog() == DialogResult.OK)
            {
                searchfrm.txtCodeText = dgvNop[0, dgvNop.CurrentRow.Index].Value.ToString();
                searchfrm.txtNameText = dgvNop[1, dgvNop.CurrentRow.Index].Value.ToString();
            }
            frm_MDS_CDS_004 search = new frm_MDS_CDS_004();
            search.Search();
            this.Close();
        }
    }
}
