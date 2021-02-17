
namespace Final.QAM_SQC
{
    partial class frm_QAM_SQC_004
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
            this.dgvQAM_SQC = new System.Windows.Forms.DataGridView();
            this.txtProcessDetail = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkCenterDetail = new System.Windows.Forms.TextBox();
            this.btnWorkCenter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkCenter = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQAM_SQC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtProcessDetail);
            this.panel4.Controls.Add(this.btnProcess);
            this.panel4.Controls.Add(this.txtProcess);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtWorkCenterDetail);
            this.panel4.Controls.Add(this.btnWorkCenter);
            this.panel4.Controls.Add(this.txtWorkCenter);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.txtWorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.btnWorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.txtWorkCenterDetail, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.label3, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.txtProcess, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnProcess, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.txtProcessDetail, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 17, 14, 57, 38, 811);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 10, 14, 57, 38, 811);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvQAM_SQC);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // dgvQAM_SQC
            // 
            this.dgvQAM_SQC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQAM_SQC.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvQAM_SQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQAM_SQC.Location = new System.Drawing.Point(3, 3);
            this.dgvQAM_SQC.Name = "dgvQAM_SQC";
            this.dgvQAM_SQC.RowTemplate.Height = 23;
            this.dgvQAM_SQC.Size = new System.Drawing.Size(1258, 800);
            this.dgvQAM_SQC.TabIndex = 70;
            // 
            // txtProcessDetail
            // 
            this.txtProcessDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcessDetail.Location = new System.Drawing.Point(814, 17);
            this.txtProcessDetail.Name = "txtProcessDetail";
            this.txtProcessDetail.Size = new System.Drawing.Size(100, 25);
            this.txtProcessDetail.TabIndex = 76;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(784, 18);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(24, 23);
            this.btnProcess.TabIndex = 75;
            this.btnProcess.Text = "...";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtProcess
            // 
            this.txtProcess.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess.Location = new System.Drawing.Point(709, 17);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(69, 25);
            this.txtProcess.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(665, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "공정";
            // 
            // txtWorkCenterDetail
            // 
            this.txtWorkCenterDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterDetail.Location = new System.Drawing.Point(1097, 17);
            this.txtWorkCenterDetail.Name = "txtWorkCenterDetail";
            this.txtWorkCenterDetail.Size = new System.Drawing.Size(100, 25);
            this.txtWorkCenterDetail.TabIndex = 72;
            // 
            // btnWorkCenter
            // 
            this.btnWorkCenter.Location = new System.Drawing.Point(1067, 18);
            this.btnWorkCenter.Name = "btnWorkCenter";
            this.btnWorkCenter.Size = new System.Drawing.Size(24, 23);
            this.btnWorkCenter.TabIndex = 71;
            this.btnWorkCenter.Text = "...";
            this.btnWorkCenter.UseVisualStyleBackColor = true;
            this.btnWorkCenter.Click += new System.EventHandler(this.btnWorkCenter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(933, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "작업장";
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.Location = new System.Drawing.Point(992, 17);
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.Size = new System.Drawing.Size(69, 25);
            this.txtWorkCenter.TabIndex = 70;
            // 
            // frm_QAM_SQC_004
            // 
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_QAM_SQC_004";
            this.Load += new System.EventHandler(this.frm_QAM_SQC_004_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQAM_SQC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQAM_SQC;
        private System.Windows.Forms.TextBox txtProcessDetail;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkCenterDetail;
        private System.Windows.Forms.Button btnWorkCenter;
        private System.Windows.Forms.TextBox txtWorkCenter;
        private System.Windows.Forms.Label label1;
    }
}
