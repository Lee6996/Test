
namespace Final.MDS_SDS
{
    partial class frm_MDS_SDS_002
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvItemDetail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.nuCavity = new System.Windows.Forms.NumericUpDown();
            this.nuLine_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.nuShot_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCavity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLine_Per_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuShot_Per_Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(201, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(441, 619);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(152, 23);
            this.txtCode.TabIndex = 131;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(739, 617);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 23);
            this.txtName.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(686, 621);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 129;
            this.label9.Text = "품목명";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(375, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 128;
            this.label8.Text = "품목코드";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox9.Location = new System.Drawing.Point(0, 555);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(1341, 33);
            this.textBox9.TabIndex = 127;
            this.textBox9.Text = "▶품목 수정";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8.Location = new System.Drawing.Point(0, 57);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(1341, 33);
            this.textBox8.TabIndex = 126;
            this.textBox8.Text = "▶품목 정보";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(973, 695);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 123;
            this.btnSave.Text = "수정";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(703, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 121;
            this.label6.Text = "Shot당 PCS수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(475, 699);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 119;
            this.label5.Text = "성형 줄당 PCS수";
            // 
            // dgvItemDetail
            // 
            this.dgvItemDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDetail.Location = new System.Drawing.Point(0, 90);
            this.dgvItemDetail.Name = "dgvItemDetail";
            this.dgvItemDetail.RowTemplate.Height = 23;
            this.dgvItemDetail.Size = new System.Drawing.Size(1341, 465);
            this.dgvItemDetail.TabIndex = 116;
            this.dgvItemDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemDetail_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(304, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "캐비티수";
            // 
            // cbItem
            // 
            this.cbItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(74, 16);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(121, 23);
            this.cbItem.TabIndex = 112;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1341, 57);
            this.splitter1.TabIndex = 111;
            this.splitter1.TabStop = false;
            // 
            // nuCavity
            // 
            this.nuCavity.Location = new System.Drawing.Point(370, 699);
            this.nuCavity.Name = "nuCavity";
            this.nuCavity.Size = new System.Drawing.Size(99, 21);
            this.nuCavity.TabIndex = 135;
            // 
            // nuLine_Per_Qty
            // 
            this.nuLine_Per_Qty.Location = new System.Drawing.Point(587, 700);
            this.nuLine_Per_Qty.Name = "nuLine_Per_Qty";
            this.nuLine_Per_Qty.Size = new System.Drawing.Size(99, 21);
            this.nuLine_Per_Qty.TabIndex = 136;
            // 
            // nuShot_Per_Qty
            // 
            this.nuShot_Per_Qty.Location = new System.Drawing.Point(799, 699);
            this.nuShot_Per_Qty.Name = "nuShot_Per_Qty";
            this.nuShot_Per_Qty.Size = new System.Drawing.Size(99, 21);
            this.nuShot_Per_Qty.TabIndex = 137;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DimGray;
            this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsert.Location = new System.Drawing.Point(973, 660);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 29);
            this.btnInsert.TabIndex = 139;
            this.btnInsert.Text = "신규 등록";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 140;
            this.label1.Text = "품목명";
            // 
            // frm_MDS_SDS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.nuShot_Per_Qty);
            this.Controls.Add(this.nuLine_Per_Qty);
            this.Controls.Add(this.nuCavity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvItemDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.splitter1);
            this.Name = "frm_MDS_SDS_002";
            this.Text = "품목 정보";
            this.Load += new System.EventHandler(this.MDS_SDS_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCavity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLine_Per_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuShot_Per_Qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvItemDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown nuCavity;
        private System.Windows.Forms.NumericUpDown nuLine_Per_Qty;
        private System.Windows.Forms.NumericUpDown nuShot_Per_Qty;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
    }
}