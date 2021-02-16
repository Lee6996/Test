
namespace Final.MDS_ODS
{
    partial class frm_MDS_ODS_002_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProcess
            // 
            this.dgvProcess.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Name});
            this.dgvProcess.Location = new System.Drawing.Point(4, 46);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.RowTemplate.Height = 23;
            this.dgvProcess.Size = new System.Drawing.Size(495, 469);
            this.dgvProcess.TabIndex = 2;
            // 
            // Code
            // 
            this.Code.HeaderText = "코드";
            this.Code.Name = "Code";
            this.Code.Width = 210;
            // 
            // Name
            // 
            this.Name.HeaderText = "이름";
            this.Name.Name = "Name";
            this.Name.Width = 210;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblManager);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 40);
            this.panel1.TabIndex = 111;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManager.Location = new System.Drawing.Point(231, 9);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(0, 21);
            this.lblManager.TabIndex = 154;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDay.Location = new System.Drawing.Point(386, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(0, 21);
            this.lblDay.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "▶공정 목록";
            // 
            // frm_MDS_ODS_002_1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProcess);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.Name = "frm_MDS_ODS_002_1";
            this.Tag = "공정목록";
            this.Text = "frm_MDS_ODS_002_1";
            this.Load += new System.EventHandler(this.frm_MDS_ODS_002_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label6;
    }
}