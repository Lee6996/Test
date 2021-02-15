
namespace Final.PPS_MLD
{
    partial class frm_PPS_MLD_001
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNewMold = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbMoldUse = new System.Windows.Forms.ComboBox();
            this.btnMoldUpdate = new System.Windows.Forms.Button();
            this.btnMoldInsert = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpLastSetup = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMoldAmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoldGuarCnt = new System.Windows.Forms.TextBox();
            this.cbMoldGroupB = new System.Windows.Forms.ComboBox();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMoldRemark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMoldName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoldCode = new System.Windows.Forms.TextBox();
            this.dgv_Mold = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMoldGroupT = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mold)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbMoldGroupT);
            this.panel4.Controls.SetChildIndex(this.cbMoldGroupT, 0);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.label3, 0);
            this.panel4.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.panel4.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.textBox1, 0);
            this.panel4.Controls.SetChildIndex(this.button22, 0);
            this.panel4.Controls.SetChildIndex(this.btn_Process, 0);
            this.panel4.Controls.SetChildIndex(this.label16, 0);
            this.panel4.Controls.SetChildIndex(this.textBox6, 0);
            this.panel4.Controls.SetChildIndex(this.btn_WorkCenter, 0);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.Text = "조회조건 : ";
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Location = new System.Drawing.Point(916, 2);
            this.btn_WorkCenter.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1041, 31);
            this.textBox6.Visible = false;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(384, 18);
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.Text = "금형그룹";
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(966, 18);
            this.btn_Process.Visible = false;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(163, 11);
            this.button22.TabIndex = 1;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(265, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1104, 18);
            this.label4.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1027, 15);
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1016, 15);
            this.dateTimePicker1.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(93, 19);
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.Text = "금형명";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnNewMold);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.dgv_Mold);
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 806);
            this.panel5.TabIndex = 22;
            // 
            // btnNewMold
            // 
            this.btnNewMold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMold.BackColor = System.Drawing.Color.DimGray;
            this.btnNewMold.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNewMold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewMold.Location = new System.Drawing.Point(1168, 577);
            this.btnNewMold.Name = "btnNewMold";
            this.btnNewMold.Size = new System.Drawing.Size(85, 30);
            this.btnNewMold.TabIndex = 15;
            this.btnNewMold.Text = "신규등록";
            this.btnNewMold.UseVisualStyleBackColor = false;
            this.btnNewMold.Click += new System.EventHandler(this.btnNewMold_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(0, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 26);
            this.label6.TabIndex = 70;
            this.label6.Text = "▶입력정보";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(29, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(796, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "금형코드 - 금형명 - 금형그룹 - 금형상태 - 금형누적타수 - 금형누적생산량 - 금형누적사용시간 - 보장타수 - 구입금액 -입고일자 - 최종장착" +
    "일시 - 비고 - 사용유무";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.cbMoldUse);
            this.panel10.Controls.Add(this.btnMoldUpdate);
            this.panel10.Controls.Add(this.btnMoldInsert);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.dtpLastSetup);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.txtMoldAmt);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.txtMoldGuarCnt);
            this.panel10.Controls.Add(this.cbMoldGroupB);
            this.panel10.Controls.Add(this.dtpInDate);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.txtMoldRemark);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.txtMoldName);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.txtMoldCode);
            this.panel10.Enabled = false;
            this.panel10.Location = new System.Drawing.Point(6, 608);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1253, 193);
            this.panel10.TabIndex = 4;
            // 
            // cbMoldUse
            // 
            this.cbMoldUse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMoldUse.FormattingEnabled = true;
            this.cbMoldUse.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbMoldUse.Location = new System.Drawing.Point(676, 147);
            this.cbMoldUse.Name = "cbMoldUse";
            this.cbMoldUse.Size = new System.Drawing.Size(121, 25);
            this.cbMoldUse.TabIndex = 12;
            // 
            // btnMoldUpdate
            // 
            this.btnMoldUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoldUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnMoldUpdate.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoldUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoldUpdate.Location = new System.Drawing.Point(1152, 147);
            this.btnMoldUpdate.Name = "btnMoldUpdate";
            this.btnMoldUpdate.Size = new System.Drawing.Size(85, 35);
            this.btnMoldUpdate.TabIndex = 14;
            this.btnMoldUpdate.Text = "수정";
            this.btnMoldUpdate.UseVisualStyleBackColor = false;
            this.btnMoldUpdate.Click += new System.EventHandler(this.btnMoldUpdate_Click);
            // 
            // btnMoldInsert
            // 
            this.btnMoldInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoldInsert.BackColor = System.Drawing.Color.DimGray;
            this.btnMoldInsert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMoldInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMoldInsert.Location = new System.Drawing.Point(1049, 148);
            this.btnMoldInsert.Name = "btnMoldInsert";
            this.btnMoldInsert.Size = new System.Drawing.Size(85, 35);
            this.btnMoldInsert.TabIndex = 13;
            this.btnMoldInsert.Text = "추가";
            this.btnMoldInsert.UseVisualStyleBackColor = false;
            this.btnMoldInsert.Click += new System.EventHandler(this.btnMoldInsert_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(575, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "사용유무";
            // 
            // dtpLastSetup
            // 
            this.dtpLastSetup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpLastSetup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastSetup.Location = new System.Drawing.Point(676, 48);
            this.dtpLastSetup.Name = "dtpLastSetup";
            this.dtpLastSetup.Size = new System.Drawing.Size(130, 25);
            this.dtpLastSetup.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(575, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "최종장착일시";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(351, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "구입금액";
            // 
            // txtMoldAmt
            // 
            this.txtMoldAmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoldAmt.Location = new System.Drawing.Point(445, 149);
            this.txtMoldAmt.Name = "txtMoldAmt";
            this.txtMoldAmt.Size = new System.Drawing.Size(100, 25);
            this.txtMoldAmt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(351, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "보장타수";
            // 
            // txtMoldGuarCnt
            // 
            this.txtMoldGuarCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoldGuarCnt.Location = new System.Drawing.Point(445, 115);
            this.txtMoldGuarCnt.Name = "txtMoldGuarCnt";
            this.txtMoldGuarCnt.Size = new System.Drawing.Size(100, 25);
            this.txtMoldGuarCnt.TabIndex = 7;
            // 
            // cbMoldGroupB
            // 
            this.cbMoldGroupB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMoldGroupB.FormattingEnabled = true;
            this.cbMoldGroupB.Location = new System.Drawing.Point(445, 82);
            this.cbMoldGroupB.Name = "cbMoldGroupB";
            this.cbMoldGroupB.Size = new System.Drawing.Size(100, 25);
            this.cbMoldGroupB.TabIndex = 6;
            // 
            // dtpInDate
            // 
            this.dtpInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInDate.Location = new System.Drawing.Point(676, 14);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(130, 25);
            this.dtpInDate.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(575, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "입고일자";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(575, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "비고";
            // 
            // txtMoldRemark
            // 
            this.txtMoldRemark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoldRemark.Location = new System.Drawing.Point(676, 79);
            this.txtMoldRemark.Multiline = true;
            this.txtMoldRemark.Name = "txtMoldRemark";
            this.txtMoldRemark.Size = new System.Drawing.Size(192, 52);
            this.txtMoldRemark.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(351, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "금형그룹";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(351, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "금형명";
            // 
            // txtMoldName
            // 
            this.txtMoldName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoldName.Location = new System.Drawing.Point(445, 48);
            this.txtMoldName.Name = "txtMoldName";
            this.txtMoldName.Size = new System.Drawing.Size(100, 25);
            this.txtMoldName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(351, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "금형코드";
            // 
            // txtMoldCode
            // 
            this.txtMoldCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoldCode.Location = new System.Drawing.Point(445, 14);
            this.txtMoldCode.Name = "txtMoldCode";
            this.txtMoldCode.Size = new System.Drawing.Size(100, 25);
            this.txtMoldCode.TabIndex = 4;
            // 
            // dgv_Mold
            // 
            this.dgv_Mold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Mold.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Mold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mold.Location = new System.Drawing.Point(3, 3);
            this.dgv_Mold.Name = "dgv_Mold";
            this.dgv_Mold.RowTemplate.Height = 23;
            this.dgv_Mold.Size = new System.Drawing.Size(1256, 573);
            this.dgv_Mold.TabIndex = 1;
            this.dgv_Mold.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mold_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(34, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "조회내역";
            // 
            // cbMoldGroupT
            // 
            this.cbMoldGroupT.FormattingEnabled = true;
            this.cbMoldGroupT.Location = new System.Drawing.Point(478, 15);
            this.cbMoldGroupT.Name = "cbMoldGroupT";
            this.cbMoldGroupT.Size = new System.Drawing.Size(121, 25);
            this.cbMoldGroupT.TabIndex = 3;
            this.cbMoldGroupT.SelectedIndexChanged += new System.EventHandler(this.cbMoldGroupT_SelectedIndexChanged);
            // 
            // frm_PPS_MLD_001
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Controls.Add(this.panel5);
            this.Name = "frm_PPS_MLD_001";
            this.Load += new System.EventHandler(this.frm_PPS_MLD_001_Load);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnMoldUpdate;
        private System.Windows.Forms.Button btnMoldInsert;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpLastSetup;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMoldAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoldGuarCnt;
        private System.Windows.Forms.ComboBox cbMoldGroupB;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMoldRemark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMoldName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoldCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMoldGroupT;
        private System.Windows.Forms.DataGridView dgv_Mold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMoldUse;
        private System.Windows.Forms.Button btnNewMold;
    }
}
