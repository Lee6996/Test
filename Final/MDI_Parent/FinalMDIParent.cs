﻿using Final.KPI_RPT;
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

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tv_Menu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (e.Node.Name.ToString().Length < 5)
            //{
            //    Form frm;
            //    Assembly frmAssembly = Assembly.GetExecutingAssembly();
            //    string frmName = string.Format($"Final.frm_{e.Node.Name}");
            //    frm = (Form)frmAssembly.CreateInstance("Final.PRM_PRF.frm_PRM_PRF_001");



            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Tag = e.Node.Name;

            //    TabPage newTab = new TabPage();
            //    newTab.Text = e.Node.Text;

            //    tabControl2.TabPages.Add(newTab);
            //    tabControl2.SelectedTab = newTab;
            //    frm.Show();
            //}

            if (e.Node.Name.Length == 11)
            {
                string frm1 = $"Final.{e.Node.Name.Substring(0, 7)}.frm_{e.Node.Name}";
                var frm = Activator.CreateInstance(Type.GetType(string.Format($"Final.{e.Node.Name.Substring(0, 7)}.frm_{e.Node.Name}")))  as Form;
                
                frm.MdiParent = this;

                frm.WindowState = FormWindowState.Maximized;
                frm.Tag = e.Node.Name;
                TabPage newTab = new TabPage();
                newTab.Text = e.Node.Text;

                tabControl2.TabPages.Add(newTab);
                tabControl2.SelectedTab = newTab;
                frm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FinalMDIParent_Load(object sender, EventArgs e)
        {
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "product";
            mainNode.Text = "Product Categories";

            tv_Menu.Nodes.Add(mainNode);
            List<ScreenVO> screen = new Service.MenuService().GetScreenVOList();
        }
    }
}
