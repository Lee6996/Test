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

namespace Final.MSS_SYS
{
    public partial class frm_MSS_SYS_001 : Form
    {
        public frm_MSS_SYS_001()
        {
            InitializeComponent();
        }
        string code;

        //조회 버튼
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string code = txtScreen_Code.Text;
            DataLoad(code);
        }

        private void MSS_SYS_001_Load(object sender, EventArgs e)
        {
            ScreenService service = new ScreenService();

            CommonUtil.SetInitGridView(dgvScreen);

            CommonUtil.AddGridTextColumn(dgvScreen, "화면코드", "Screen_Code", 220);
            CommonUtil.AddGridTextColumn(dgvScreen, "화면명", "Screen_Name", 220);
            CommonUtil.AddGridTextColumn(dgvScreen, "화면경로", "Screen_Path", 220);
            CommonUtil.AddGridTextColumn(dgvScreen, "수정일자", "Up_Date", 220);
            //CommonUtil.AddGridTextColumn(dgvScreen, "사용여부", "Screen_Code", 220);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvScreen.Columns.Add(col);

            dgvScreen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvScreen.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //콤보박스에 화면정보 바인딩
            DataTable dtScreen = service.SelectScreenBinding();
            //빈칸을 위해 한행 추가
            DataRow dr = dtScreen.NewRow();
            dr["Screen_Code"] = "";
            dr["Screen_Name"] = "전체";
            dtScreen.Rows.InsertAt(dr, 0);
            dtScreen.AcceptChanges();

            cbScreen_Name.DisplayMember = "Screen_Name";
            cbScreen_Name.ValueMember = "Screen_Code";
            cbScreen_Name.DataSource = dtScreen;

            DataLoad("");
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
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgvScreen.Rows[e.RowIndex].Cells[4];
                int useyn = (Convert.ToInt32(chk.Value) == 1) ? 0 : 1;
                DateTime date = DateTime.Now;

                ScreenVO vo = new ScreenVO
                {
                    Screen_Code = dgvScreen.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Up_Date = date.ToString(),
                    Use_YN = useyn
                };

                ScreenService service = new ScreenService();
                service.UpdateScreenUseYN(vo);
            }
            if(cbScreen_Name.Text == "전체")
            {
                DataLoad("");
            }
            else
            {
                DataLoad(cbScreen_Name.SelectedValue.ToString());
            }
        }

        private void cbScreen_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbScreen_Name.SelectedIndex < 1)
                txtScreen_Code.Text = "";
            else
                txtScreen_Code.Text = cbScreen_Name.SelectedValue.ToString();
        }
    }
}
