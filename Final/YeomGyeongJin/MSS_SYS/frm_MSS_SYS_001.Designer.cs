
namespace Final
{
    partial class frm_MSS_SYS_001
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
            this.pnl = new System.Windows.Forms.Panel();
            this.cbScreen_Name = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScreen_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvScreen = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.Info;
            this.pnl.Controls.Add(this.cbScreen_Name);
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.txtScreen_Code);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.Location = new System.Drawing.Point(225, 152);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1357, 48);
            this.pnl.TabIndex = 15;
            // 
            // cbScreen_Name
            // 
            this.cbScreen_Name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbScreen_Name.FormattingEnabled = true;
            this.cbScreen_Name.Location = new System.Drawing.Point(462, 11);
            this.cbScreen_Name.Name = "cbScreen_Name";
            this.cbScreen_Name.Size = new System.Drawing.Size(152, 27);
            this.cbScreen_Name.TabIndex = 5;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(665, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(380, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "화면명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtScreen_Code
            // 
            this.txtScreen_Code.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScreen_Code.Location = new System.Drawing.Point(139, 11);
            this.txtScreen_Code.Name = "txtScreen_Code";
            this.txtScreen_Code.Size = new System.Drawing.Size(187, 26);
            this.txtScreen_Code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "화면 코드";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.dgvScreen);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Location = new System.Drawing.Point(225, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1357, 704);
            this.panel5.TabIndex = 16;
            this.panel5.Tag = "화면관리";
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
            this.dgvScreen.Location = new System.Drawing.Point(15, 50);
            this.dgvScreen.Name = "dgvScreen";
            this.dgvScreen.RowTemplate.Height = 23;
            this.dgvScreen.Size = new System.Drawing.Size(1335, 650);
            this.dgvScreen.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "▶화면목록";
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
            // frm_MSS_SYS_001
            // 
            this.ClientSize = new System.Drawing.Size(1582, 904);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnl);
            this.Name = "frm_MSS_SYS_001";
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.ComboBox cbScreen_Name;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScreen_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvScreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
