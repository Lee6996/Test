
namespace Final.MDS_ODS
{
    partial class frm_MDS_ODS_001
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new System.Windows.Forms.Panel();
            this.cbProcess_Name = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcess_Name_Insert = new System.Windows.Forms.TextBox();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcess_Code_Insert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.cbProcess_Name);
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1341, 57);
            this.pnl.TabIndex = 20;
            // 
            // cbProcess_Name
            // 
            this.cbProcess_Name.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbProcess_Name.FormattingEnabled = true;
            this.cbProcess_Name.Location = new System.Drawing.Point(81, 16);
            this.cbProcess_Name.Name = "cbProcess_Name";
            this.cbProcess_Name.Size = new System.Drawing.Size(152, 25);
            this.cbProcess_Name.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(252, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 35);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "공정명";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgvProcess);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1341, 645);
            this.panel5.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-1, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 148;
            this.label1.Text = "▶공정설정";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtGroup);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtRemark);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtProcess_Name_Insert);
            this.panel4.Controls.Add(this.btnInsertUpdate);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtProcess_Code_Insert);
            this.panel4.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(3, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1333, 116);
            this.panel4.TabIndex = 146;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 144;
            this.label9.Text = "공정 코드";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(642, 8);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(304, 100);
            this.txtRemark.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(560, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "비고";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcess_Name_Insert
            // 
            this.txtProcess_Name_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess_Name_Insert.Location = new System.Drawing.Point(88, 69);
            this.txtProcess_Name_Insert.Name = "txtProcess_Name_Insert";
            this.txtProcess_Name_Insert.Size = new System.Drawing.Size(187, 26);
            this.txtProcess_Name_Insert.TabIndex = 5;
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertUpdate.AutoSize = true;
            this.btnInsertUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnInsertUpdate.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsertUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertUpdate.Location = new System.Drawing.Point(1147, 66);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(177, 35);
            this.btnInsertUpdate.TabIndex = 4;
            this.btnInsertUpdate.Text = "수정 및 저장";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(-1, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "*공정명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcess_Code_Insert
            // 
            this.txtProcess_Code_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess_Code_Insert.Location = new System.Drawing.Point(88, 16);
            this.txtProcess_Code_Insert.Name = "txtProcess_Code_Insert";
            this.txtProcess_Code_Insert.Size = new System.Drawing.Size(187, 26);
            this.txtProcess_Code_Insert.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(0, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 26);
            this.label5.TabIndex = 150;
            this.label5.Text = "▶공정목록";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProcess
            // 
            this.dgvProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProcess.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcess.Location = new System.Drawing.Point(-1, -1);
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.RowTemplate.Height = 23;
            this.dgvProcess.Size = new System.Drawing.Size(1341, 522);
            this.dgvProcess.TabIndex = 149;
            this.dgvProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcess_CellClick);
            this.dgvProcess.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcess_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(1056, 66);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 35);
            this.btnRefresh.TabIndex = 145;
            this.btnRefresh.Text = "초기화";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGroup.Location = new System.Drawing.Point(420, 66);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(187, 26);
            this.txtGroup.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(313, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 146;
            this.label2.Text = "공정그룹코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_MDS_ODS_001
            // 
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frm_MDS_ODS_001";
            this.Tag = "공정정보";
            this.Load += new System.EventHandler(this.frm_MDS_ODS_001_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox cbProcess_Name;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProcess_Name_Insert;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcess_Code_Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
    }
}
