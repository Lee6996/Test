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

namespace Final.YeomGyeongJin.MSS_SYS
{
    public partial class MSS_SYS_001 : Form
    {
        public MSS_SYS_001()
        {
            InitializeComponent();
        }

        //조회 버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string code = txtScreen_Code.Text;
            DataLoad(code);
        }

        private void MSS_SYS_001_Load(object sender, EventArgs e)
        {
            CommonUtil.SetInitGridView(dgvScreen);

            CommonUtil.AddGridTextColumn(dgvScreen, "화면코드", "Screen_Code", 220);
            CommonUtil.AddGridTextColumn(dgvScreen, "화면경로", "Screen_Path", 220);
            CommonUtil.AddGridTextColumn(dgvScreen, "입력일자", "Ins_Date", 220);
            //CommonUtil.AddGridTextColumn(dgvScreen, "사용여부", "Screen_Code", 220);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvScreen.Columns.Add(col);


        }

        private void DataLoad(string screenCode)
        {
            try
            {
                ScreenService service = new ScreenService();
                List<ScreenVO> list = service.ScreenSelectInfo(screenCode);

                dgvScreen.DataSource = list;
                dgvScreen.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgvScreen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //dgvUser.EndEdit();

                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvScreen.Rows[e.RowIndex].Cells[3];
                int useyn = (Convert.ToInt32(chk.Value) == 1) ? 0 : 1;

                ScreenVO vo = new ScreenVO
                {
                    Screen_Code = dgvScreen.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Use_YN = useyn
                };

                ScreenService service = new ScreenService();
                service.UpdateScreenUseYN(vo);
            }
        }

        private void cbScreen_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string txt;
            if (cbScreen_Name.SelectedIndex < 1)
                txt = "";
            else
                txt = cbScreen_Name.Text;

            txtScreen_Code.Text = txt;
        }
    }
}
