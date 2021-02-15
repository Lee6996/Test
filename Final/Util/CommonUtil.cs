using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final
{
    public class CommonUtil
    {
        public static void ComboBindingMold(ComboBox cbo, List<MoldGroupVO> list, string Category, bool blankItem = true, string blankText = "")
        {
            //var codeList = (from item in list where item.Category.Equals(Category) select item).ToList();
            var codeList = list.ToList();
            if (blankItem)
            {
                MoldGroupVO blank = new MoldGroupVO
                { Mold_Group = blankText };
                codeList.Insert(0, blank);
            }
            cbo.DisplayMember = "Mold_Group";
            cbo.ValueMember = "Mold_Group";
            cbo.DataSource = codeList;
        }
        public static void BindingComboBox(ComboBox cbo, DataTable dt, string valueMember, string displayMember, bool blankItemAdd = true)
        {
            if (blankItemAdd)
            {

                DataRow dr = dt.NewRow();
                dr[valueMember] = "";
                dr[displayMember] = "";
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }

            cbo.ValueMember = valueMember;
            cbo.DisplayMember = displayMember;
            cbo.DataSource = dt;
        }

        public static void BindingComboBox(ComboBox cbo, DataTable dt, bool blankItemAdd = true)
        {
            bool bflag;
            if (blankItemAdd)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bflag = true;
                    for (int a = 0; a < i; a++)
                    {
                        if (dt.Rows[i][0].ToString() == dt.Rows[a][0].ToString())
                        {
                            bflag = false;
                            break;
                        }
                    }
                    if (bflag == true)
                        cbo.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
        }

        public static void AddGridTextColumn(
                            DataGridView dgv,
                            string headerText,
                            string dataPropertyName,
                            int colWidth = 100,
                            bool visibility = true,
                            DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleCenter,
                            DataGridViewContentAlignment headerAlign = DataGridViewContentAlignment.MiddleCenter
                            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn
            {
                Name = dataPropertyName,
                HeaderText = headerText,
                DataPropertyName = dataPropertyName,
                Width = colWidth,
                Visible = visibility,
                ReadOnly = true
            };
            col.HeaderCell.Style.Alignment = headerAlign;
            col.DefaultCellStyle.Alignment = textAlign;

            dgv.Columns.Add(col);
        }

        public static void AddGridCheckBoxColumn(
                            DataGridView dgv,
                            int colWidth = 30,
                            bool visibility = true
                            )
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn
            {
                Width = colWidth,
                Visible = visibility,
                ReadOnly = true
            };
            dgv.Columns.Add(col);
        }


        public static bool IsMatchPwd(string pwd1, string pwd2)
        {
            if (pwd1 == pwd2)
                return true;
            else return false;
        }

        public static void ClearDataGridView(DataGridView dgv)
        {
            if (dgv.Columns.Count > 1)
            {
                dgv.Columns.Clear();
                dgv.Rows.Clear();
                dgv.Refresh();
            }
        }

        public static object GetValue(DataGridView dgv, string columnName)
        {
            int rowIndex = dgv.CurrentRow.Index;
            return dgv[columnName, rowIndex].Value;
        }

        public static void ClearControls(Control inputCtrl)
        {
            foreach (Control ctrl in inputCtrl.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl != null)
                        ctrl.Text = string.Empty;
                }
                else if (ctrl is ComboBox)
                {
                    if (ctrl != null)
                        ctrl.Text = null;
                }
            }
        }

        public static void ChangeEnables(Control inputCtrl)
        {
            foreach (Control ctrl in inputCtrl.Controls)
            {
                if (ctrl.Enabled)
                    ctrl.Enabled = false;
                else
                    ctrl.Enabled = true;
            }
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image ByteToImage(byte[] data)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            return (Bitmap)(tc.ConvertFrom(data));
        }
    }
}

