
namespace Final
{
    partial class frm_MSS_CON_001
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbUserGroup_Name = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtUserGroup_Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserGroup_Name_Insert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserGroup_Code_Insert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserGroup_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ins_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use_btn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.cbUserGroup_Name);
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.txtUserGroup_Code);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(225, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1357, 48);
            this.panel4.TabIndex = 12;
            // 
            // cbUserGroup_Name
            // 
            this.cbUserGroup_Name.FormattingEnabled = true;
            this.cbUserGroup_Name.Location = new System.Drawing.Point(237, 13);
            this.cbUserGroup_Name.Name = "cbUserGroup_Name";
            this.cbUserGroup_Name.Size = new System.Drawing.Size(130, 22);
            this.cbUserGroup_Name.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(735, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // txtUserGroup_Code
            // 
            this.txtUserGroup_Code.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Code.Location = new System.Drawing.Point(581, 11);
            this.txtUserGroup_Code.Name = "txtUserGroup_Code";
            this.txtUserGroup_Code.Size = new System.Drawing.Size(120, 26);
            this.txtUserGroup_Code.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(440, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자 그룹코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(29, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "조회조건 : 사용자 그룹명";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.txtUserGroup_Name_Insert);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtUserGroup_Code_Insert);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(225, 827);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1357, 77);
            this.panel5.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(1079, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(988, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtUserGroup_Name_Insert
            // 
            this.txtUserGroup_Name_Insert.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Name_Insert.Location = new System.Drawing.Point(483, 18);
            this.txtUserGroup_Name_Insert.Name = "txtUserGroup_Name_Insert";
            this.txtUserGroup_Name_Insert.Size = new System.Drawing.Size(140, 26);
            this.txtUserGroup_Name_Insert.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(349, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "사용자 그룹명";
            // 
            // txtUserGroup_Code_Insert
            // 
            this.txtUserGroup_Code_Insert.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Code_Insert.Location = new System.Drawing.Point(170, 18);
            this.txtUserGroup_Code_Insert.Name = "txtUserGroup_Code_Insert";
            this.txtUserGroup_Code_Insert.Size = new System.Drawing.Size(140, 26);
            this.txtUserGroup_Code_Insert.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(28, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "사용자 그룹코드";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserGroup_Code,
            this.UserGroup_Name,
            this.Ins_Date,
            this.Use_YN,
            this.Use_btn});
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 530);
            this.dataGridView1.TabIndex = 14;
            // 
            // UserGroup_Code
            // 
            this.UserGroup_Code.HeaderText = "사용자그룹코드";
            this.UserGroup_Code.Name = "UserGroup_Code";
            this.UserGroup_Code.Width = 220;
            // 
            // UserGroup_Name
            // 
            this.UserGroup_Name.HeaderText = "사용자그룹명";
            this.UserGroup_Name.Name = "UserGroup_Name";
            this.UserGroup_Name.Width = 220;
            // 
            // Ins_Date
            // 
            this.Ins_Date.HeaderText = "최초입력일자";
            this.Ins_Date.Name = "Ins_Date";
            this.Ins_Date.Width = 220;
            // 
            // Use_YN
            // 
            this.Use_YN.HeaderText = "사용여부";
            this.Use_YN.Name = "Use_YN";
            this.Use_YN.Width = 220;
            // 
            // Use_btn
            // 
            this.Use_btn.HeaderText = "사용여부";
            this.Use_btn.Name = "Use_btn";
            this.Use_btn.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(6, 599);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "▶사용자 그룹설정";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel6.Location = new System.Drawing.Point(225, 200);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1357, 627);
            this.panel6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 19;
            this.label7.Tag = "사용자 그룹관리";
            this.label7.Text = "▶사용자 그룹목록";
            // 
            // frm_MSS_CON_001
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 904);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_MSS_CON_001";
            this.Tag = "사용자 그룹관리";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtUserGroup_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUserGroup_Name_Insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserGroup_Code_Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUserGroup_Name;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ins_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Use_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Use_btn;
    }
}
