
namespace Final.MSS_CON
{
    partial class frm_MSS_CON_002
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbUser_GroupName = new System.Windows.Forms.ComboBox();
            this.dgvUser_Group = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserGroup_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1344, 57);
            this.splitter1.TabIndex = 32;
            this.splitter1.TabStop = false;
            this.splitter1.Tag = "사용자 그룹별 권한설정";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(113, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "사용자 그룹명";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(879, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSelect.TabIndex = 54;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbUser_GroupName
            // 
            this.cbUser_GroupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser_GroupName.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbUser_GroupName.FormattingEnabled = true;
            this.cbUser_GroupName.Location = new System.Drawing.Point(234, 15);
            this.cbUser_GroupName.Name = "cbUser_GroupName";
            this.cbUser_GroupName.Size = new System.Drawing.Size(200, 26);
            this.cbUser_GroupName.TabIndex = 53;
            this.cbUser_GroupName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvUser_Group
            // 
            this.dgvUser_Group.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser_Group.Location = new System.Drawing.Point(15, 103);
            this.dgvUser_Group.Name = "dgvUser_Group";
            this.dgvUser_Group.RowTemplate.Height = 23;
            this.dgvUser_Group.Size = new System.Drawing.Size(1317, 750);
            this.dgvUser_Group.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 57;
            this.label2.Tag = "사용자 그룹관리";
            this.label2.Text = "▶사용자 그룹관리";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(461, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "사용자 그룹코드";
            // 
            // txtUserGroup_Name
            // 
            this.txtUserGroup_Name.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserGroup_Name.Location = new System.Drawing.Point(596, 15);
            this.txtUserGroup_Name.Name = "txtUserGroup_Name";
            this.txtUserGroup_Name.ReadOnly = true;
            this.txtUserGroup_Name.Size = new System.Drawing.Size(196, 26);
            this.txtUserGroup_Name.TabIndex = 81;
            // 
            // MSS_CON_002
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 865);
            this.Controls.Add(this.txtUserGroup_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser_Group);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbUser_GroupName);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MSS_CON_002";
            this.Tag = "사용자 그룹 관리";
            this.Text = "MSS_CON_002";
            this.Load += new System.EventHandler(this.MSS_CON_002_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbUser_GroupName;
        private System.Windows.Forms.DataGridView dgvUser_Group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserGroup_Name;
    }
}