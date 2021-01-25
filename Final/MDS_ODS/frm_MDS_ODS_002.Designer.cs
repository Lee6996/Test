
namespace Final
{
    partial class frm_MDS_ODS_002
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWorkCenter_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcess_Name = new System.Windows.Forms.TextBox();
            this.btnProcessSearch = new System.Windows.Forms.Button();
            this.rdoWorkshop = new System.Windows.Forms.RadioButton();
            this.rdoProcess = new System.Windows.Forms.RadioButton();
            this.cbWorkCenter_Name = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcess_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvWorkCenter = new System.Windows.Forms.DataGridView();
            this.ProcessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Process_Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.Info;
            this.pnl.Controls.Add(this.groupBox1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnl.Location = new System.Drawing.Point(225, 152);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1357, 48);
            this.pnl.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWorkCenter_Code);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProcess_Name);
            this.groupBox1.Controls.Add(this.btnProcessSearch);
            this.groupBox1.Controls.Add(this.rdoWorkshop);
            this.groupBox1.Controls.Add(this.rdoProcess);
            this.groupBox1.Controls.Add(this.cbWorkCenter_Name);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProcess_Code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1357, 48);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtWorkCenter_Code
            // 
            this.txtWorkCenter_Code.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter_Code.Location = new System.Drawing.Point(708, 6);
            this.txtWorkCenter_Code.Name = "txtWorkCenter_Code";
            this.txtWorkCenter_Code.Size = new System.Drawing.Size(148, 26);
            this.txtWorkCenter_Code.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(877, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "작업장명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcess_Name
            // 
            this.txtProcess_Name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess_Name.Location = new System.Drawing.Point(346, 7);
            this.txtProcess_Name.Name = "txtProcess_Name";
            this.txtProcess_Name.Size = new System.Drawing.Size(148, 26);
            this.txtProcess_Name.TabIndex = 14;
            // 
            // btnProcessSearch
            // 
            this.btnProcessSearch.Location = new System.Drawing.Point(289, 6);
            this.btnProcessSearch.Name = "btnProcessSearch";
            this.btnProcessSearch.Size = new System.Drawing.Size(52, 28);
            this.btnProcessSearch.TabIndex = 13;
            this.btnProcessSearch.Text = "...";
            this.btnProcessSearch.UseVisualStyleBackColor = true;
            // 
            // rdoWorkshop
            // 
            this.rdoWorkshop.AutoSize = true;
            this.rdoWorkshop.Location = new System.Drawing.Point(593, 13);
            this.rdoWorkshop.Name = "rdoWorkshop";
            this.rdoWorkshop.Size = new System.Drawing.Size(14, 13);
            this.rdoWorkshop.TabIndex = 12;
            this.rdoWorkshop.TabStop = true;
            this.rdoWorkshop.UseVisualStyleBackColor = true;
            // 
            // rdoProcess
            // 
            this.rdoProcess.AutoSize = true;
            this.rdoProcess.Location = new System.Drawing.Point(63, 14);
            this.rdoProcess.Name = "rdoProcess";
            this.rdoProcess.Size = new System.Drawing.Size(14, 13);
            this.rdoProcess.TabIndex = 11;
            this.rdoProcess.TabStop = true;
            this.rdoProcess.UseVisualStyleBackColor = true;
            // 
            // cbWorkCenter_Name
            // 
            this.cbWorkCenter_Name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbWorkCenter_Name.FormattingEnabled = true;
            this.cbWorkCenter_Name.Location = new System.Drawing.Point(992, 6);
            this.cbWorkCenter_Name.Name = "cbWorkCenter_Name";
            this.cbWorkCenter_Name.Size = new System.Drawing.Size(152, 27);
            this.cbWorkCenter_Name.TabIndex = 10;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(1236, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(613, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "작업장코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProcess_Code
            // 
            this.txtProcess_Code.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess_Code.Location = new System.Drawing.Point(136, 7);
            this.txtProcess_Code.Name = "txtProcess_Code";
            this.txtProcess_Code.Size = new System.Drawing.Size(148, 26);
            this.txtProcess_Code.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "공정";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvWorkCenter);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(225, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1357, 704);
            this.panel4.TabIndex = 21;
            // 
            // dgvWorkCenter
            // 
            this.dgvWorkCenter.BackgroundColor = System.Drawing.Color.White;
            this.dgvWorkCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkCenter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessCode,
            this.ProcessName,
            this.Process_Remarks,
            this.Date,
            this.Use,
            this.btnUse});
            this.dgvWorkCenter.Location = new System.Drawing.Point(15, 50);
            this.dgvWorkCenter.Name = "dgvWorkCenter";
            this.dgvWorkCenter.RowTemplate.Height = 23;
            this.dgvWorkCenter.Size = new System.Drawing.Size(1323, 623);
            this.dgvWorkCenter.TabIndex = 24;
            // 
            // ProcessCode
            // 
            this.ProcessCode.HeaderText = "공정코드";
            this.ProcessCode.Name = "ProcessCode";
            this.ProcessCode.Width = 180;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "공정이름";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Width = 180;
            // 
            // Process_Remarks
            // 
            this.Process_Remarks.HeaderText = "비고란";
            this.Process_Remarks.Name = "Process_Remarks";
            this.Process_Remarks.Width = 180;
            // 
            // Date
            // 
            this.Date.HeaderText = "입력일자";
            this.Date.Name = "Date";
            this.Date.Width = 180;
            // 
            // Use
            // 
            this.Use.HeaderText = "사용여부";
            this.Use.Name = "Use";
            this.Use.Width = 140;
            // 
            // btnUse
            // 
            this.btnUse.HeaderText = "사용여부";
            this.btnUse.Name = "btnUse";
            this.btnUse.Width = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "▶작업장목록";
            // 
            // frm_MDS_ODS_002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1582, 904);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_MDS_ODS_002";
            this.Tag = "작업장정보";
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWorkCenter_Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcess_Name;
        private System.Windows.Forms.Button btnProcessSearch;
        private System.Windows.Forms.RadioButton rdoWorkshop;
        private System.Windows.Forms.RadioButton rdoProcess;
        private System.Windows.Forms.ComboBox cbWorkCenter_Name;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcess_Code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvWorkCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process_Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Use;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnUse;
        private System.Windows.Forms.Label label6;
    }
}
