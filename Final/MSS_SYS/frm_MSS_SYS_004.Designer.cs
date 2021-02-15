
namespace Final.MSS_SYS
{
    partial class frm_MSS_SYS_004
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbSysNotice = new System.Windows.Forms.ComboBox();
            this.btnNotice_Insert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.pnl.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.label2);
            this.pnl.Controls.Add(this.cbSysNotice);
            this.pnl.Controls.Add(this.btnNotice_Insert);
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1344, 56);
            this.pnl.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 115;
            this.label2.Text = "조회조건 : 공지사항기간";
            // 
            // cbSysNotice
            // 
            this.cbSysNotice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSysNotice.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSysNotice.FormattingEnabled = true;
            this.cbSysNotice.Location = new System.Drawing.Point(204, 16);
            this.cbSysNotice.Name = "cbSysNotice";
            this.cbSysNotice.Size = new System.Drawing.Size(217, 25);
            this.cbSysNotice.TabIndex = 114;
            this.cbSysNotice.SelectedIndexChanged += new System.EventHandler(this.cbSysNotice_SelectedIndexChanged);
            // 
            // btnNotice_Insert
            // 
            this.btnNotice_Insert.BackColor = System.Drawing.Color.DimGray;
            this.btnNotice_Insert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNotice_Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNotice_Insert.Location = new System.Drawing.Point(616, 11);
            this.btnNotice_Insert.Name = "btnNotice_Insert";
            this.btnNotice_Insert.Size = new System.Drawing.Size(85, 35);
            this.btnNotice_Insert.TabIndex = 113;
            this.btnNotice_Insert.Text = "등록";
            this.btnNotice_Insert.UseVisualStyleBackColor = false;
            this.btnNotice_Insert.Click += new System.EventHandler(this.btnNotice_Insert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(479, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 35);
            this.btnSelect.TabIndex = 112;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 132;
            this.label1.Text = "▶조회내역";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvNotice);
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1344, 773);
            this.panel5.TabIndex = 133;
            // 
            // dgvNotice
            // 
            this.dgvNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotice.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Location = new System.Drawing.Point(3, 3);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(1336, 765);
            this.dgvNotice.TabIndex = 24;
            // 
            // frm_MSS_SYS_004
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 865);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frm_MSS_SYS_004";
            this.Tag = "공지사항등록";
            this.Text = "MSS_SYS_004";
            this.Load += new System.EventHandler(this.MSS_SYS_004_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnNotice_Insert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbSysNotice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvNotice;
    }
}