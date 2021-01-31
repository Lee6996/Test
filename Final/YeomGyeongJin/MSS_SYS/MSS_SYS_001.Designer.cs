
namespace Final.YeomGyeongJin.MSS_SYS
{
    partial class MSS_SYS_001
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
            this.pnl = new System.Windows.Forms.Panel();
            this.cbScreen_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScreen_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvScreen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Controls.Add(this.cbScreen_Name);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.txtScreen_Code);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1344, 56);
            this.pnl.TabIndex = 16;
            // 
            // cbScreen_Name
            // 
            this.cbScreen_Name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbScreen_Name.FormattingEnabled = true;
            this.cbScreen_Name.Location = new System.Drawing.Point(462, 15);
            this.cbScreen_Name.Name = "cbScreen_Name";
            this.cbScreen_Name.Size = new System.Drawing.Size(152, 27);
            this.cbScreen_Name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(380, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "화면명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScreen_Code
            // 
            this.txtScreen_Code.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScreen_Code.Location = new System.Drawing.Point(139, 15);
            this.txtScreen_Code.Name = "txtScreen_Code";
            this.txtScreen_Code.Size = new System.Drawing.Size(187, 26);
            this.txtScreen_Code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "화면 코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvScreen
            // 
            this.dgvScreen.BackgroundColor = System.Drawing.Color.White;
            this.dgvScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvScreen.Location = new System.Drawing.Point(12, 105);
            this.dgvScreen.Name = "dgvScreen";
            this.dgvScreen.RowTemplate.Height = 23;
            this.dgvScreen.Size = new System.Drawing.Size(1320, 748);
            this.dgvScreen.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "화면코드";
            this.Column1.Name = "Column1";
            this.Column1.Width = 240;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "화면명";
            this.Column2.Name = "Column2";
            this.Column2.Width = 240;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "화면경로";
            this.Column3.Name = "Column3";
            this.Column3.Width = 240;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "입력일자";
            this.Column4.Name = "Column4";
            this.Column4.Width = 240;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "사용여부";
            this.Column5.Name = "Column5";
            this.Column5.Width = 240;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "사용여부";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(9, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "▶화면목록";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(700, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 35);
            this.btnSelect.TabIndex = 110;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // MSS_SYS_001
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 865);
            this.Controls.Add(this.dgvScreen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MSS_SYS_001";
            this.Text = "MSS_SYS_001";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox cbScreen_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScreen_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelect;
    }
}