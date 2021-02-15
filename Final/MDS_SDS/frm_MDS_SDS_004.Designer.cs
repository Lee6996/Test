
namespace Final.MDS_SDS
{
    partial class frm_MDS_SDS_004
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cbWorkCenter = new System.Windows.Forms.ComboBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8.Location = new System.Drawing.Point(0, 57);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(1341, 33);
            this.textBox8.TabIndex = 128;
            this.textBox8.Text = "▶ 품목 목록                                                    │▶ 공정 조건 목록\r\n";
            // 
            // cbWorkCenter
            // 
            this.cbWorkCenter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbWorkCenter.FormattingEnabled = true;
            this.cbWorkCenter.Location = new System.Drawing.Point(415, 13);
            this.cbWorkCenter.Name = "cbWorkCenter";
            this.cbWorkCenter.Size = new System.Drawing.Size(121, 23);
            this.cbWorkCenter.TabIndex = 127;
            this.cbWorkCenter.SelectedIndexChanged += new System.EventHandler(this.cbWorkCenter_SelectedIndexChanged);
            // 
            // dgvWork
            // 
            this.dgvWork.BackgroundColor = System.Drawing.Color.White;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(361, 90);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowTemplate.Height = 23;
            this.dgvWork.Size = new System.Drawing.Size(980, 603);
            this.dgvWork.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(349, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 123;
            this.label7.Text = "작업장명";
            // 
            // dgvItem
            // 
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(0, 90);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowTemplate.Height = 23;
            this.dgvItem.Size = new System.Drawing.Size(355, 642);
            this.dgvItem.TabIndex = 121;
            // 
            // cbItem
            // 
            this.cbItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(62, 13);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(121, 23);
            this.cbItem.TabIndex = 120;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 119;
            this.label1.Text = "품목명";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1341, 57);
            this.splitter1.TabIndex = 118;
            this.splitter1.TabStop = false;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch1.Location = new System.Drawing.Point(189, 9);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 29);
            this.btnSearch1.TabIndex = 136;
            this.btnSearch1.Text = "조회";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch2.Location = new System.Drawing.Point(542, 9);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 29);
            this.btnSearch2.TabIndex = 137;
            this.btnSearch2.Text = "조회";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DimGray;
            this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(1210, 698);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 29);
            this.btnInsert.TabIndex = 141;
            this.btnInsert.Text = "신규 등록";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frm_MDS_SDS_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.cbWorkCenter);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Name = "frm_MDS_SDS_004";
            this.Text = "공정조건 설정";
            this.Load += new System.EventHandler(this.frm_MDS_SDS_004_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox cbWorkCenter;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnInsert;
    }
}