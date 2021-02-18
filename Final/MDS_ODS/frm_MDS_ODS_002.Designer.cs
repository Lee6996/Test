
namespace Final.MDS_ODS
{
    partial class frm_MDS_ODS_002
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbWorkCenter_Name = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.txtWCCode = new System.Windows.Forms.TextBox();
            this.txtWCName = new System.Windows.Forms.TextBox();
            this.txtPRCode = new System.Windows.Forms.TextBox();
            this.txtWCgroup = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Controls.Add(this.groupBox1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1582, 57);
            this.pnl.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbWorkCenter_Name);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1580, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "작업장명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbWorkCenter_Name
            // 
            this.cbWorkCenter_Name.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbWorkCenter_Name.FormattingEnabled = true;
            this.cbWorkCenter_Name.Location = new System.Drawing.Point(77, 18);
            this.cbWorkCenter_Name.Name = "cbWorkCenter_Name";
            this.cbWorkCenter_Name.Size = new System.Drawing.Size(152, 25);
            this.cbWorkCenter_Name.TabIndex = 10;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(246, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 35);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Controls.Add(this.txtWCCode);
            this.panel4.Controls.Add(this.txtWCName);
            this.panel4.Controls.Add(this.txtPRCode);
            this.panel4.Controls.Add(this.txtWCgroup);
            this.panel4.Controls.Add(this.txtRemark);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnInsertUpdate);
            this.panel4.Controls.Add(this.dgvWork);
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1582, 813);
            this.panel4.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(0, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 143;
            this.label1.Text = "▶작업장목록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvWork
            // 
            this.dgvWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWork.BackgroundColor = System.Drawing.Color.White;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(0, -1);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowTemplate.Height = 23;
            this.dgvWork.Size = new System.Drawing.Size(1580, 663);
            this.dgvWork.TabIndex = 0;
            this.dgvWork.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWork_CellClick);
            this.dgvWork.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWork_CellDoubleClick);
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.AutoSize = true;
            this.btnInsertUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnInsertUpdate.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsertUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertUpdate.Location = new System.Drawing.Point(1420, 766);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(153, 35);
            this.btnInsertUpdate.TabIndex = 10;
            this.btnInsertUpdate.Text = "수정 및 저장";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // txtWCCode
            // 
            this.txtWCCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWCCode.Location = new System.Drawing.Point(577, 762);
            this.txtWCCode.Name = "txtWCCode";
            this.txtWCCode.Size = new System.Drawing.Size(260, 25);
            this.txtWCCode.TabIndex = 30;
            // 
            // txtWCName
            // 
            this.txtWCName.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWCName.Location = new System.Drawing.Point(577, 718);
            this.txtWCName.Name = "txtWCName";
            this.txtWCName.Size = new System.Drawing.Size(260, 25);
            this.txtWCName.TabIndex = 29;
            // 
            // txtPRCode
            // 
            this.txtPRCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPRCode.Location = new System.Drawing.Point(200, 718);
            this.txtPRCode.Name = "txtPRCode";
            this.txtPRCode.Size = new System.Drawing.Size(260, 25);
            this.txtPRCode.TabIndex = 28;
            // 
            // txtWCgroup
            // 
            this.txtWCgroup.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWCgroup.Location = new System.Drawing.Point(200, 762);
            this.txtWCgroup.Name = "txtWCgroup";
            this.txtWCgroup.Size = new System.Drawing.Size(260, 25);
            this.txtWCgroup.TabIndex = 27;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(916, 683);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(260, 112);
            this.txtRemark.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(856, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "비고";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(475, 765);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "작업장코드";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(489, 721);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "작업장명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(112, 721);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "공정코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(94, 765);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "작업장 그룹";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(1340, 767);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 34);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "초기화";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frm_MDS_ODS_002
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 904);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frm_MDS_ODS_002";
            this.Tag = "작업장정보";
            this.Load += new System.EventHandler(this.frm_MDS_ODS_002_Load);
            this.pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbWorkCenter_Name;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.TextBox txtWCCode;
        private System.Windows.Forms.TextBox txtWCName;
        private System.Windows.Forms.TextBox txtPRCode;
        private System.Windows.Forms.TextBox txtWCgroup;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
    }
}
