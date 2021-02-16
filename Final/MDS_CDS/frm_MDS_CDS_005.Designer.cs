
namespace Final.MDS_CDS
{
    partial class frm_MDS_CDS_005
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBox = new System.Windows.Forms.DataGridView();
            this.txtDCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gboGrade = new System.Windows.Forms.GroupBox();
            this.rdo6 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo4 = new System.Windows.Forms.RadioButton();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btndotdotdot = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).BeginInit();
            this.gboGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.Location = new System.Drawing.Point(1173, 686);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 29);
            this.btnRefresh.TabIndex = 114;
            this.btnRefresh.Text = "초기화";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(0, 70);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(356, 33);
            this.textBox4.TabIndex = 107;
            this.textBox4.Text = "▶ 포장등급 상세정의";
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDName.Location = new System.Drawing.Point(485, 684);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(100, 23);
            this.txtDName.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(344, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "포장등급 상세명";
            // 
            // dgvBox
            // 
            this.dgvBox.BackgroundColor = System.Drawing.Color.White;
            this.dgvBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBox.Location = new System.Drawing.Point(0, 104);
            this.dgvBox.Name = "dgvBox";
            this.dgvBox.RowTemplate.Height = 23;
            this.dgvBox.Size = new System.Drawing.Size(1341, 517);
            this.dgvBox.TabIndex = 102;
            this.dgvBox.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBox_CellContentDoubleClick);
            // 
            // txtDCode
            // 
            this.txtDCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDCode.Location = new System.Drawing.Point(485, 649);
            this.txtDCode.Name = "txtDCode";
            this.txtDCode.Size = new System.Drawing.Size(100, 23);
            this.txtDCode.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(331, 651);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "포장등급 상세코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 97;
            this.label1.Text = "포장등급 상세 정의";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1341, 57);
            this.splitter1.TabIndex = 96;
            this.splitter1.TabStop = false;
            // 
            // gboGrade
            // 
            this.gboGrade.Controls.Add(this.rdo6);
            this.gboGrade.Controls.Add(this.rdo5);
            this.gboGrade.Controls.Add(this.rdo4);
            this.gboGrade.Controls.Add(this.rdo3);
            this.gboGrade.Controls.Add(this.rdo2);
            this.gboGrade.Controls.Add(this.rdo1);
            this.gboGrade.Location = new System.Drawing.Point(664, 628);
            this.gboGrade.Name = "gboGrade";
            this.gboGrade.Size = new System.Drawing.Size(297, 100);
            this.gboGrade.TabIndex = 118;
            this.gboGrade.TabStop = false;
            this.gboGrade.Text = "포장등급";
            // 
            // rdo6
            // 
            this.rdo6.AutoSize = true;
            this.rdo6.Location = new System.Drawing.Point(183, 72);
            this.rdo6.Name = "rdo6";
            this.rdo6.Size = new System.Drawing.Size(81, 16);
            this.rdo6.TabIndex = 5;
            this.rdo6.TabStop = true;
            this.rdo6.Tag = "BG_Pet_005";
            this.rdo6.Text = "포장등급 6";
            this.rdo6.UseVisualStyleBackColor = true;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(183, 46);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(81, 16);
            this.rdo5.TabIndex = 4;
            this.rdo5.TabStop = true;
            this.rdo5.Tag = "BG_Pet_004";
            this.rdo5.Text = "포장등급 5";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo4
            // 
            this.rdo4.AutoSize = true;
            this.rdo4.Location = new System.Drawing.Point(183, 20);
            this.rdo4.Name = "rdo4";
            this.rdo4.Size = new System.Drawing.Size(81, 16);
            this.rdo4.TabIndex = 3;
            this.rdo4.TabStop = true;
            this.rdo4.Tag = "BG_Pet_003";
            this.rdo4.Text = "포장등급 4";
            this.rdo4.UseVisualStyleBackColor = true;
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(12, 72);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(81, 16);
            this.rdo3.TabIndex = 2;
            this.rdo3.TabStop = true;
            this.rdo3.Tag = "BG_Pet_002";
            this.rdo3.Text = "포장등급 3";
            this.rdo3.UseVisualStyleBackColor = true;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(12, 46);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(81, 16);
            this.rdo2.TabIndex = 1;
            this.rdo2.TabStop = true;
            this.rdo2.Tag = "BG_Pet_001";
            this.rdo2.Text = "포장등급 2";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(12, 20);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(81, 16);
            this.rdo1.TabIndex = 0;
            this.rdo1.TabStop = true;
            this.rdo1.Tag = "BG_Cap_001";
            this.rdo1.Text = "포장등급 1";
            this.rdo1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(1254, 651);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 119;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(1254, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 120;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btndotdotdot
            // 
            this.btndotdotdot.BackColor = System.Drawing.Color.DimGray;
            this.btndotdotdot.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btndotdotdot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndotdotdot.Location = new System.Drawing.Point(209, 20);
            this.btndotdotdot.Name = "btndotdotdot";
            this.btndotdotdot.Size = new System.Drawing.Size(35, 29);
            this.btndotdotdot.TabIndex = 143;
            this.btndotdotdot.Text = "...";
            this.btndotdotdot.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(250, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 26);
            this.txtName.TabIndex = 142;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(140, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(63, 26);
            this.txtCode.TabIndex = 141;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(379, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 140;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frm_MDS_CDS_005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.btndotdotdot);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gboGrade);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvBox);
            this.Controls.Add(this.txtDCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "frm_MDS_CDS_005";
            this.Text = "포장등급 상세정의";
            this.Load += new System.EventHandler(this.frm_MDS_CDS_005_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).EndInit();
            this.gboGrade.ResumeLayout(false);
            this.gboGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBox;
        private System.Windows.Forms.TextBox txtDCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox gboGrade;
        private System.Windows.Forms.RadioButton rdo6;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btndotdotdot;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnSearch;
    }
}