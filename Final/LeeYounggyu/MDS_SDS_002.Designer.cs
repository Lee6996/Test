
namespace Final.LeeYounggyu
{
    partial class MDS_SDS_002
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
            this.rdoType = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvItemDetail = new System.Windows.Forms.DataGridView();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.nudCavity = new System.Windows.Forms.NumericUpDown();
            this.nuLine_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.nuShot_Per_Qty = new System.Windows.Forms.NumericUpDown();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblupdateName = new System.Windows.Forms.Label();
            this.lblupdateCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCavity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLine_Per_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuShot_Per_Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(618, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoType
            // 
            this.rdoType.AutoSize = true;
            this.rdoType.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoType.Location = new System.Drawing.Point(776, 24);
            this.rdoType.Name = "rdoType";
            this.rdoType.Size = new System.Drawing.Size(78, 21);
            this.rdoType.TabIndex = 133;
            this.rdoType.TabStop = true;
            this.rdoType.Text = "품목유형";
            this.rdoType.UseVisualStyleBackColor = true;
            this.rdoType.CheckedChanged += new System.EventHandler(this.rdoType_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoName.Location = new System.Drawing.Point(237, 24);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(65, 21);
            this.rdoName.TabIndex = 132;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "품목명";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox11.Location = new System.Drawing.Point(456, 641);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(152, 23);
            this.textBox11.TabIndex = 131;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox10.Location = new System.Drawing.Point(754, 639);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 23);
            this.textBox10.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(701, 643);
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
            this.label8.Location = new System.Drawing.Point(390, 645);
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
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.Location = new System.Drawing.Point(512, 22);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(446, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 124;
            this.label7.Text = "품목코드";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(973, 693);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
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
            this.label6.Location = new System.Drawing.Point(753, 698);
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
            this.label5.Location = new System.Drawing.Point(525, 697);
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
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch2.Location = new System.Drawing.Point(987, 22);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 29);
            this.btnSearch2.TabIndex = 115;
            this.btnSearch2.Text = "조회";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(354, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 113;
            this.label2.Text = "캐비티수";
            // 
            // cbItem
            // 
            this.cbItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(308, 22);
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
            // nudCavity
            // 
            this.nudCavity.Location = new System.Drawing.Point(420, 697);
            this.nudCavity.Name = "nudCavity";
            this.nudCavity.Size = new System.Drawing.Size(99, 21);
            this.nudCavity.TabIndex = 135;
            // 
            // nuLine_Per_Qty
            // 
            this.nuLine_Per_Qty.Location = new System.Drawing.Point(637, 698);
            this.nuLine_Per_Qty.Name = "nuLine_Per_Qty";
            this.nuLine_Per_Qty.Size = new System.Drawing.Size(99, 21);
            this.nuLine_Per_Qty.TabIndex = 136;
            // 
            // nuShot_Per_Qty
            // 
            this.nuShot_Per_Qty.Location = new System.Drawing.Point(849, 697);
            this.nuShot_Per_Qty.Name = "nuShot_Per_Qty";
            this.nuShot_Per_Qty.Size = new System.Drawing.Size(99, 21);
            this.nuShot_Per_Qty.TabIndex = 137;
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(860, 24);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 23);
            this.cbType.TabIndex = 138;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.White;
            this.lblCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(516, 25);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 17);
            this.lblCode.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(459, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 140;
            // 
            // lblupdateName
            // 
            this.lblupdateName.AutoSize = true;
            this.lblupdateName.BackColor = System.Drawing.Color.White;
            this.lblupdateName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblupdateName.ForeColor = System.Drawing.Color.Black;
            this.lblupdateName.Location = new System.Drawing.Point(757, 643);
            this.lblupdateName.Name = "lblupdateName";
            this.lblupdateName.Size = new System.Drawing.Size(0, 17);
            this.lblupdateName.TabIndex = 141;
            // 
            // lblupdateCode
            // 
            this.lblupdateCode.AutoSize = true;
            this.lblupdateCode.BackColor = System.Drawing.Color.White;
            this.lblupdateCode.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblupdateCode.ForeColor = System.Drawing.Color.Black;
            this.lblupdateCode.Location = new System.Drawing.Point(460, 644);
            this.lblupdateCode.Name = "lblupdateCode";
            this.lblupdateCode.Size = new System.Drawing.Size(0, 17);
            this.lblupdateCode.TabIndex = 142;
            // 
            // MDS_SDS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 732);
            this.Controls.Add(this.lblupdateCode);
            this.Controls.Add(this.lblupdateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.nuShot_Per_Qty);
            this.Controls.Add(this.nuLine_Per_Qty);
            this.Controls.Add(this.nudCavity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rdoType);
            this.Controls.Add(this.rdoName);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvItemDetail);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.splitter1);
            this.Name = "MDS_SDS_002";
            this.Text = "품목 정보";
            this.Load += new System.EventHandler(this.MDS_SDS_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCavity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLine_Per_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuShot_Per_Qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoType;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvItemDetail;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown nudCavity;
        private System.Windows.Forms.NumericUpDown nuLine_Per_Qty;
        private System.Windows.Forms.NumericUpDown nuShot_Per_Qty;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblupdateName;
        private System.Windows.Forms.Label lblupdateCode;
    }
}