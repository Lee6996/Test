
namespace Final.YeomGyeongJin.MSS_SYS
{
    partial class MSS_SYS_004
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
            this.pnl = new System.Windows.Forms.Panel();
            this.btnNotice_Insert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbScreen_Name = new System.Windows.Forms.ComboBox();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.cbScreen_Name);
            this.pnl.Controls.Add(this.btnNotice_Insert);
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1344, 56);
            this.pnl.TabIndex = 18;
            // 
            // btnNotice_Insert
            // 
            this.btnNotice_Insert.BackColor = System.Drawing.Color.DimGray;
            this.btnNotice_Insert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNotice_Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNotice_Insert.Location = new System.Drawing.Point(712, 11);
            this.btnNotice_Insert.Name = "btnNotice_Insert";
            this.btnNotice_Insert.Size = new System.Drawing.Size(85, 35);
            this.btnNotice_Insert.TabIndex = 113;
            this.btnNotice_Insert.Text = "등록";
            this.btnNotice_Insert.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(568, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 35);
            this.btnSelect.TabIndex = 112;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvNotice
            // 
            this.dgvNotice.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Location = new System.Drawing.Point(12, 105);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(1320, 748);
            this.dgvNotice.TabIndex = 23;
            this.dgvNotice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotice_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(9, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "▶공지사항목록";
            // 
            // cbScreen_Name
            // 
            this.cbScreen_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreen_Name.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbScreen_Name.FormattingEnabled = true;
            this.cbScreen_Name.Location = new System.Drawing.Point(324, 15);
            this.cbScreen_Name.Name = "cbScreen_Name";
            this.cbScreen_Name.Size = new System.Drawing.Size(217, 26);
            this.cbScreen_Name.TabIndex = 114;
            // 
            // MSS_SYS_004
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 865);
            this.Controls.Add(this.dgvNotice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MSS_SYS_004";
            this.Tag = "공지사항등록";
            this.Text = "MSS_SYS_004";
            this.Load += new System.EventHandler(this.MSS_SYS_004_Load);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnNotice_Insert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbScreen_Name;
    }
}