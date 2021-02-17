
namespace Final.MDS_CDS
{
    partial class frm_MDS_CDS_004
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
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNopMi = new System.Windows.Forms.DataGridView();
            this.txtNopMiCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNopMa = new System.Windows.Forms.DataGridView();
            this.txtNopMaCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtNopMiName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btndotdotdot = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNopMi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNopMa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnInsertUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsertUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertUpdate.Location = new System.Drawing.Point(1215, 695);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(118, 29);
            this.btnInsertUpdate.TabIndex = 95;
            this.btnInsertUpdate.Text = "수정 및 저장";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(937, 651);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(176, 75);
            this.txtRemark.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(897, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "비고";
            // 
            // dgvNopMi
            // 
            this.dgvNopMi.BackgroundColor = System.Drawing.Color.White;
            this.dgvNopMi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNopMi.Location = new System.Drawing.Point(558, 85);
            this.dgvNopMi.Name = "dgvNopMi";
            this.dgvNopMi.RowTemplate.Height = 23;
            this.dgvNopMi.Size = new System.Drawing.Size(783, 557);
            this.dgvNopMi.TabIndex = 89;
            this.dgvNopMi.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNopMi_CellContentDoubleClick);
            // 
            // txtNopMiCode
            // 
            this.txtNopMiCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNopMiCode.Location = new System.Drawing.Point(722, 677);
            this.txtNopMiCode.Name = "txtNopMiCode";
            this.txtNopMiCode.Size = new System.Drawing.Size(147, 23);
            this.txtNopMiCode.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(573, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "비가동 상세분류 코드";
            // 
            // dgvNopMa
            // 
            this.dgvNopMa.BackgroundColor = System.Drawing.Color.White;
            this.dgvNopMa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNopMa.Location = new System.Drawing.Point(0, 85);
            this.dgvNopMa.Name = "dgvNopMa";
            this.dgvNopMa.RowTemplate.Height = 23;
            this.dgvNopMa.Size = new System.Drawing.Size(549, 645);
            this.dgvNopMa.TabIndex = 83;
            // 
            // txtNopMaCode
            // 
            this.txtNopMaCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNopMaCode.Location = new System.Drawing.Point(722, 650);
            this.txtNopMaCode.Name = "txtNopMaCode";
            this.txtNopMaCode.Size = new System.Drawing.Size(147, 23);
            this.txtNopMaCode.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(573, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "비가동 대분류 코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "비가동 대분류";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1341, 57);
            this.splitter1.TabIndex = 77;
            this.splitter1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(0, 55);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1341, 31);
            this.textBox4.TabIndex = 131;
            this.textBox4.Text = "▶ 비가동 대분류                                                                        " +
    "              │▶ 비가동 상세분류\r\n ";
            // 
            // txtNopMiName
            // 
            this.txtNopMiName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNopMiName.Location = new System.Drawing.Point(722, 704);
            this.txtNopMiName.Name = "txtNopMiName";
            this.txtNopMiName.Size = new System.Drawing.Size(147, 23);
            this.txtNopMiName.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(573, 707);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 132;
            this.label4.Text = "비가동 상세분류 명";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(1134, 695);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 29);
            this.btnRefresh.TabIndex = 135;
            this.btnRefresh.Text = "초기화";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btndotdotdot
            // 
            this.btndotdotdot.BackColor = System.Drawing.Color.DimGray;
            this.btndotdotdot.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btndotdotdot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndotdotdot.Location = new System.Drawing.Point(178, 19);
            this.btndotdotdot.Name = "btndotdotdot";
            this.btndotdotdot.Size = new System.Drawing.Size(35, 29);
            this.btndotdotdot.TabIndex = 139;
            this.btndotdotdot.Text = "...";
            this.btndotdotdot.UseVisualStyleBackColor = false;
            this.btndotdotdot.Click += new System.EventHandler(this.btndotdotdot_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(219, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 26);
            this.txtName.TabIndex = 138;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(109, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(63, 26);
            this.txtCode.TabIndex = 137;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(348, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 136;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frm_MDS_CDS_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.btndotdotdot);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtNopMiName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnInsertUpdate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvNopMi);
            this.Controls.Add(this.txtNopMiCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvNopMa);
            this.Controls.Add(this.txtNopMaCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "frm_MDS_CDS_004";
            this.Text = "비가동 상세분류";
            this.Load += new System.EventHandler(this.frm_MDS_CDS_004_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNopMi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNopMa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNopMi;
        private System.Windows.Forms.TextBox txtNopMiCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNopMa;
        private System.Windows.Forms.TextBox txtNopMaCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtNopMiName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btndotdotdot;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSearch;
    }
}