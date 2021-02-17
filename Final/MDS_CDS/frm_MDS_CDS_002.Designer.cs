
namespace Final.MDS_CDS
{
    partial class frm_MDS_CDS_002
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
            this.txtDef_Miname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDefDetail = new System.Windows.Forms.DataGridView();
            this.txtDef_Micode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDefMaster = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDef_Macode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblDefM = new System.Windows.Forms.Label();
            this.btndotdotdot = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnInsertUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtDef_Maname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDef_Miname
            // 
            this.txtDef_Miname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDef_Miname.Location = new System.Drawing.Point(772, 701);
            this.txtDef_Miname.Name = "txtDef_Miname";
            this.txtDef_Miname.Size = new System.Drawing.Size(100, 23);
            this.txtDef_Miname.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(605, 703);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "불량현상 상세분류 명";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(935, 611);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(196, 110);
            this.txtRemark.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(895, 611);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 98;
            this.label3.Text = "비고";
            // 
            // dgvDefDetail
            // 
            this.dgvDefDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDefDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefDetail.Location = new System.Drawing.Point(542, 85);
            this.dgvDefDetail.Name = "dgvDefDetail";
            this.dgvDefDetail.RowTemplate.Height = 23;
            this.dgvDefDetail.Size = new System.Drawing.Size(799, 518);
            this.dgvDefDetail.TabIndex = 94;
            this.dgvDefDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefDetail_CellDoubleClick);
            this.dgvDefDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefDetail_CellDoubleClick);
            // 
            // txtDef_Micode
            // 
            this.txtDef_Micode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDef_Micode.Location = new System.Drawing.Point(772, 669);
            this.txtDef_Micode.Name = "txtDef_Micode";
            this.txtDef_Micode.Size = new System.Drawing.Size(100, 23);
            this.txtDef_Micode.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(605, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "불량현상 상세분류 코드";
            // 
            // dgvDefMaster
            // 
            this.dgvDefMaster.BackgroundColor = System.Drawing.Color.White;
            this.dgvDefMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefMaster.Location = new System.Drawing.Point(0, 85);
            this.dgvDefMaster.Name = "dgvDefMaster";
            this.dgvDefMaster.RowTemplate.Height = 23;
            this.dgvDefMaster.Size = new System.Drawing.Size(527, 641);
            this.dgvDefMaster.TabIndex = 88;
            this.dgvDefMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDefMaster_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(361, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDef_Macode
            // 
            this.txtDef_Macode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDef_Macode.Location = new System.Drawing.Point(772, 613);
            this.txtDef_Macode.Name = "txtDef_Macode";
            this.txtDef_Macode.Size = new System.Drawing.Size(100, 23);
            this.txtDef_Macode.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(605, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "불량현상 대분류 코드";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(12, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 17);
            this.lblName.TabIndex = 84;
            this.lblName.Text = "불량현상 대분류";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1341, 57);
            this.splitter1.TabIndex = 83;
            this.splitter1.TabStop = false;
            // 
            // lblDefM
            // 
            this.lblDefM.AutoSize = true;
            this.lblDefM.BackColor = System.Drawing.Color.White;
            this.lblDefM.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDefM.ForeColor = System.Drawing.Color.Black;
            this.lblDefM.Location = new System.Drawing.Point(124, 25);
            this.lblDefM.Name = "lblDefM";
            this.lblDefM.Size = new System.Drawing.Size(0, 17);
            this.lblDefM.TabIndex = 107;
            // 
            // btndotdotdot
            // 
            this.btndotdotdot.BackColor = System.Drawing.Color.DimGray;
            this.btndotdotdot.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btndotdotdot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndotdotdot.Location = new System.Drawing.Point(191, 19);
            this.btndotdotdot.Name = "btndotdotdot";
            this.btndotdotdot.Size = new System.Drawing.Size(35, 29);
            this.btndotdotdot.TabIndex = 111;
            this.btndotdotdot.Text = "...";
            this.btndotdotdot.UseVisualStyleBackColor = false;
            this.btndotdotdot.Click += new System.EventHandler(this.btndotdotdot_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(232, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 26);
            this.txtName.TabIndex = 110;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(122, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(63, 26);
            this.txtCode.TabIndex = 109;
            // 
            // btnInsertUpdate
            // 
            this.btnInsertUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnInsertUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsertUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertUpdate.Location = new System.Drawing.Point(1218, 697);
            this.btnInsertUpdate.Name = "btnInsertUpdate";
            this.btnInsertUpdate.Size = new System.Drawing.Size(111, 29);
            this.btnInsertUpdate.TabIndex = 112;
            this.btnInsertUpdate.Text = "수정 및 저장";
            this.btnInsertUpdate.UseVisualStyleBackColor = false;
            this.btnInsertUpdate.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(1137, 697);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 29);
            this.btnRefresh.TabIndex = 113;
            this.btnRefresh.Text = "초기화";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtDef_Maname
            // 
            this.txtDef_Maname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDef_Maname.Location = new System.Drawing.Point(772, 640);
            this.txtDef_Maname.Name = "txtDef_Maname";
            this.txtDef_Maname.Size = new System.Drawing.Size(100, 23);
            this.txtDef_Maname.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(605, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 114;
            this.label1.Text = "불량현상 대분류 명";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(0, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1341, 31);
            this.textBox1.TabIndex = 129;
            this.textBox1.Text = "▶ 불량현상 대분류                                                                       " +
    "          │▶ 불량현상 상세분류\r\n ";
            // 
            // frm_MDS_CDS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDef_Maname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInsertUpdate);
            this.Controls.Add(this.btndotdotdot);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDefM);
            this.Controls.Add(this.txtDef_Miname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDefDetail);
            this.Controls.Add(this.txtDef_Micode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDefMaster);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDef_Macode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.splitter1);
            this.Name = "frm_MDS_CDS_002";
            this.Text = "불량현상 상세분류";
            this.Load += new System.EventHandler(this.MDS_CDS_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDef_Miname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDefDetail;
        private System.Windows.Forms.TextBox txtDef_Micode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDefMaster;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDef_Macode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblDefM;
        private System.Windows.Forms.Button btndotdotdot;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnInsertUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtDef_Maname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}