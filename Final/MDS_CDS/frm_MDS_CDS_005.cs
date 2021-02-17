using Final.MDS_CDS.service;
using Final.PRM_PRF.PopUp;
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
    public partial class frm_MDS_CDS_005 : Form
    {
        public string txtCodeText { get; set; }
        public string txtNameText { get; set; }

        List<BoxingGrade_Detail_MasterVO> boxlist = new List<BoxingGrade_Detail_MasterVO>();
        BoxingGrade_Detail_MasterService boxservice = new BoxingGrade_Detail_MasterService();
        
        public frm_MDS_CDS_005()
        {
            InitializeComponent();
        }

        private void frm_MDS_CDS_005_Load(object sender, EventArgs e)
        {
           

            CommonUtil.SetInitGridView(dgvBox);
            CommonUtil.AddGridTextColumn(dgvBox, "포장등급", "Boxing_Grade_Code", 210);
            CommonUtil.AddGridTextColumn(dgvBox, "포장등급상세코드", "Grade_Detail_Code", 210);
            CommonUtil.AddGridTextColumn(dgvBox, "포장등급상세명", "Grade_Detail_Name", 210);
            CommonUtil.AddGridTextColumn(dgvBox, "입력일자", "Ins_Date", 210);
            CommonUtil.AddGridTextColumn(dgvBox, "사용여부", "Use_YN", 210, visibility: false);

            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn(false);
            col.Name = "chk";
            col.HeaderText = "사용여부";
            col.Width = 100;
            col.TrueValue = 1;
            col.FalseValue = 0;
            col.DataPropertyName = "Use_YN";
            this.dgvBox.Columns.Add(col);

            //컬럼 왼쪽 정렬
            dgvBox.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBox.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvBox.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            GetAllBoxMa("");
        }
        private void GetAllBoxMa(string box)
        {
            try
            {
                boxlist = boxservice.GetAllBox_Detail_Master(box);

                dgvBox.DataSource = boxlist;
                dgvBox.ClearSelection();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshControl();
        }
        private void RefreshControl()
        {
            txtDCode.Text = txtDName.Text =  "";
            txtCode.Focus();
        }
        public void Search()
        {
            txtCode.Text = txtCodeText;
            txtName.Text = txtNameText;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllBoxMa(txtName.Text);
        }

        private void dgvBox_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var taget = boxlist.Find(item => item.Grade_Detail_Code == dgvBox.SelectedRows[0].Cells[0].Value.ToString());
            txtDName.Text = taget.Grade_Detail_Name.ToString();
            txtDCode.Text = taget.Grade_Detail_Code.ToString();

            if (taget.Boxing_Grade_Code.Equals("포장등급 1"))
            {
                rdo1.Checked = true;
            }
            else if (taget.Boxing_Grade_Code.Equals("포장등급 2"))
            {
                rdo2.Checked = true;
            }
            else if (taget.Boxing_Grade_Code.Equals("포장등급 3"))
            {
                rdo3.Checked = true;
            }
            else if (taget.Boxing_Grade_Code.Equals("포장등급 4"))
            {
                rdo4.Checked = true;
            }
            else if (taget.Boxing_Grade_Code.Equals("포장등급 5"))
            {
                rdo5.Checked = true;
            }
            else if (taget.Boxing_Grade_Code.Equals("포장등급 6"))
            {
                rdo6.Checked = true;
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string targetBoxing = "";
                foreach (Control ctrl in gboGrade.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton rdo = (RadioButton)ctrl;
                        if (rdo.Checked)
                        {
                            targetBoxing = rdo.Tag.ToString();
                            break;
                        }
                    }
                }


                BoxingGrade_Detail_MasterVO additem = new BoxingGrade_Detail_MasterVO
                {
                    Grade_Detail_Code = txtDCode.Text,
                    Grade_Detail_Name = txtDName.Text,
                    Boxing_Grade_Code = targetBoxing
                };

                BoxingGrade_Detail_MasterService service = new BoxingGrade_Detail_MasterService();
                bool bFlag = service.InsertBox_Detail(additem);

                if (bFlag)
                {
                    MessageBox.Show("저장되었습니다..");
                    GetAllBoxMa("");
                }
                else
                    MessageBox.Show("이미 등록된 그룹코드이거나 그룹명입니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            RefreshControl();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string targetBoxing = "";
                foreach (Control ctrl in gboGrade.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        RadioButton rdo = (RadioButton)ctrl;
                        if (rdo.Checked)
                        {
                            targetBoxing = rdo.Tag.ToString();
                            break;
                        }
                    }
                }


                BoxingGrade_Detail_MasterVO additem = new BoxingGrade_Detail_MasterVO
                {
                    Grade_Detail_Code = txtDCode.Text,
                    Grade_Detail_Name = txtDName.Text,
                    Boxing_Grade_Code = targetBoxing
                };

                BoxingGrade_Detail_MasterService service = new BoxingGrade_Detail_MasterService();
                bool bFlag = service.UpdateBox_Detail(additem);

                if (bFlag)
                {
                    MessageBox.Show("저장되었습니다..");
                    GetAllBoxMa("");
                }
                else
                    MessageBox.Show("이미 등록된 그룹코드이거나 그룹명입니다.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            RefreshControl();
        }

        private void btndotdotdot_Click(object sender, EventArgs e)
        {
            MainPop frm = new MainPop("Boxing_Grade")
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCode.Text = frm.SCode;
                txtName.Text = frm.SName;
                //여기에 dgv 초기화 코딩
            }
        }
    }
}
