using Final.KPI_RPT;
using Final.MDI_Parent;
using FinalVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class FinalMDIParent : Form
    {
        private int childFormNumber = 0;
        Image CloseImage;
        Form frm;
        public FinalMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "창 " + childFormNumber++;
            childForm.Show();
        }

        private void FinalMDIParent_Load(object sender, EventArgs e)
        {
            LoginInfoVO.User_ID = "Test";
            LoginInfoVO.User_Name = "Test";

            //TreeNode mainNode = new TreeNode();
            //mainNode.Name = "product";
            ////mainNode.Text = "Product Categories";
            //ImageList imgList = new ImageList();
            //this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            //CloseImage = Properties.Resources.x;
            //this.tabControl2.Padding = new Point(10, 0);

            //tv_Menu.Nodes.Add(mainNode);
            //List<ScreenVO> screen = new Service.MenuService().GetScreenVOList();
        }

        private void MenuClick(object sender, EventArgs e)
        {
            //string.Format($"Final.{e.Node.Name.Substring(0, 7)}.frm_{e.Node.Name}"))
            openNewForm(sender: (ToolStripMenuItem)sender);
        }

        private void tv_Menu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name.Length == 11)
            {
                openNewForm(e);
            }
        }

        private void openNewForm(TreeNodeMouseClickEventArgs e = null, ToolStripMenuItem sender = null)
        {
            Form frm;
            if (e != null)
            {
                frm = Activator.CreateInstance(Type.GetType(string.Format($"Final.{e.Node.Name.Substring(0, 7)}.frm_{e.Node.Name}"))) as Form;

                frm.Tag = e.Node.Name;
            }

            else
            {
                frm = Activator.CreateInstance(Type.GetType(string.Format($"Final.{sender.Name.Substring(0, 7)}.frm_{sender.Name}"))) as Form;
                frm.Tag = sender.Name;
            }

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            TabPage newTab = new TabPage();
            if (e != null)
            {
                newTab.Text = e.Node.Text;
                newTab.Tag = e.Node.Name;
            }
            else
            {
                newTab.Text = sender.Text;
                newTab.Tag = sender.Name;
            }
            newTab.Font = new Font("나눔스퀘어OTF", 10);
            tabControl2.TabPages.Add(newTab);
            tabControl2.SelectedTab = newTab;

            frm.Show();
        }
        public void newForm(string formName, string folderName, string formText)
        {
            Form frm;
            string nameSpace = "Final"; //네임스페이스 명
            Assembly cuasm = Assembly.GetExecutingAssembly();
            //string Format 의 따옴표와 마침표 주의!!
            string childFormName = string.Format($"{nameSpace}.{folderName}.frm_{formName}");
            frm = (Form)cuasm.CreateInstance(childFormName);

            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Tag = formName;
            TabPage newTab = new TabPage();
            newTab.Tag = formName;
            newTab.Text = formText;

            tabControl2.TabPages.Add(newTab);

            ImageList imgList = new ImageList();

            tv_Menu.ImageList = imgList;

            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            CloseImage = Properties.Resources.x;
            this.tabControl2.Padding = new Point(10, 3);

            // tv_Menu.Nodes.Add(mainNode);
            List<ScreenVO> screen = new Service.MenuService().GetScreenVOList();
            tabControl2.SelectedTab = newTab; //새로연 메뉴의 화면 텝페이지 눌릴 수 있도록
            frm.Show();
        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabRect = this.tabControl2.GetTabRect(e.Index);
                //tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);

                var sf = new StringFormat(StringFormat.GenericDefault);
                if (this.tabControl2.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    this.tabControl2.RightToLeftLayout == true)
                {
                    tabRect = GetRTLCoordinates(this.tabControl2.ClientRectangle, tabRect);
                    imageRect = GetRTLCoordinates(this.tabControl2.ClientRectangle, imageRect);
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                }

                e.Graphics.FillRectangle(Brushes.Aquamarine, e.Bounds); //텝페이지 색
                e.Graphics.DrawString(this.tabControl2.TabPages[e.Index].Text,
                                      this.Font, Brushes.Black, tabRect, sf);//텝페이지 폰트랑 글자 색

                e.Graphics.DrawImage(CloseImage, imageRect.Location); //텝페이지 취소이미지 생성

            }
            catch (Exception) { }
        }
        public static Rectangle GetRTLCoordinates(Rectangle container, Rectangle drawRectangle)
        {
            return new Rectangle(
                container.Width - drawRectangle.Width - drawRectangle.X,
                drawRectangle.Y,
                drawRectangle.Width,
                drawRectangle.Height);
        }

        private void tabControl2_MouseClick(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < tabControl2.TabPages.Count; i++)
            {
                var tabRect = tabControl2.GetTabRect(i);
                //tabRect.Inflate(-2, -2);
                var closeImage = Properties.Resources.x;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    tabControl2.TabPages.RemoveAt(i);
                    break;
                }
            }

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab != null && tabControl2.SelectedTab.Tag != null)
            {
                (tabControl2.SelectedTab.Tag as Form).Select();
            }
        }

        private void FinalMDIParent_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabControl2.Visible = false;
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

                if (this.ActiveMdiChild.Tag == null)
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "    ");
                    tp.Parent = tabControl2;
                    tp.Tag = this.ActiveMdiChild;
                    tabControl2.SelectedTab = tp;

                    this.ActiveMdiChild.FormClosed += FinalMDIParent_FormClosed;
                    this.ActiveMdiChild.Tag = tp;
                }

                if (!tabControl2.Visible) tabControl2.Visible = true;
            }
        }

        private void FinalMDIParent_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((sender as Form).Tag as TabPage).Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}
