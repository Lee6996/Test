
namespace Final.YeomGyeongJin.MSS_CON
{
    partial class MSS_CON_001
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
            this.components = new System.ComponentModel.Container();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserGroup_Name_Insert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserGroup_Code_Insert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.UserGroup_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ins_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use_YN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use_btn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtUserGroup_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.dgvUser);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1566, 865);
            this.panel6.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 21;
            this.label1.Tag = "사용자 그룹관리";
            this.label1.Text = "▶사용자 그룹목록";
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
            this.panel5.Location = new System.Drawing.Point(0, 746);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1566, 119);
            this.panel5.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(1079, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(988, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtUserGroup_Name_Insert
            // 
            this.txtUserGroup_Name_Insert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Name_Insert.Location = new System.Drawing.Point(483, 18);
            this.txtUserGroup_Name_Insert.Name = "txtUserGroup_Name_Insert";
            this.txtUserGroup_Name_Insert.Size = new System.Drawing.Size(140, 26);
            this.txtUserGroup_Name_Insert.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(349, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "사용자 그룹명";
            // 
            // txtUserGroup_Code_Insert
            // 
            this.txtUserGroup_Code_Insert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Code_Insert.Location = new System.Drawing.Point(170, 18);
            this.txtUserGroup_Code_Insert.Name = "txtUserGroup_Code_Insert";
            this.txtUserGroup_Code_Insert.Size = new System.Drawing.Size(140, 26);
            this.txtUserGroup_Code_Insert.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(28, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "사용자 그룹코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(12, 706);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "▶사용자 그룹설정";
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
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserGroup_Code,
            this.UserGroup_Name,
            this.Ins_Date,
            this.Use_YN,
            this.Use_btn});
            this.dgvUser.Location = new System.Drawing.Point(12, 105);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(1551, 584);
            this.dgvUser.TabIndex = 14;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.txtUserGroup_Name);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1566, 48);
            this.panel4.TabIndex = 17;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(475, 14);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtUserGroup_Name
            // 
            this.txtUserGroup_Name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Name.Location = new System.Drawing.Point(234, 13);
            this.txtUserGroup_Name.Name = "txtUserGroup_Name";
            this.txtUserGroup_Name.Size = new System.Drawing.Size(160, 26);
            this.txtUserGroup_Name.TabIndex = 3;
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MSS_CON_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 865);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Name = "MSS_CON_001";
            this.Text = "MSS_CON_001";
            this.Load += new System.EventHandler(this.MSS_CON_001_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ins_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Use_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Use_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtUserGroup_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUserGroup_Name_Insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserGroup_Code_Insert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}