
namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_008
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
            this.dgvPRM_PRF = new System.Windows.Forms.DataGridView();
            this.txtProcessDetail = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkCenterDetail = new System.Windows.Forms.TextBox();
            this.btnWorkCenter = new System.Windows.Forms.Button();
            this.txtWorkCenter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).BeginInit();
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
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtWorkCenter);
            this.panel4.Controls.SetChildIndex(this.txtWorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.btnWorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.txtWorkCenterDetail, 0);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.label3, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.txtProcess, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.btnProcess, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.txtProcessDetail, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 8, 14, 45, 7, 676);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 1, 14, 45, 7, 676);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.Text = "조회조건 : 비가동일자";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPRM_PRF);
            this.panel5.Controls.SetChildIndex(this.panel6, 0);
            this.panel5.Controls.SetChildIndex(this.dgvPRM_PRF, 0);
            // 
            // dgvPRM_PRF
            // 
            this.dgvPRM_PRF.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPRM_PRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRM_PRF.Location = new System.Drawing.Point(6, 49);
            this.dgvPRM_PRF.Name = "dgvPRM_PRF";
            this.dgvPRM_PRF.RowTemplate.Height = 23;
            this.dgvPRM_PRF.Size = new System.Drawing.Size(1248, 763);
            this.dgvPRM_PRF.TabIndex = 31;
            // 
            // txtProcessDetail
            // 
            this.txtProcessDetail.Location = new System.Drawing.Point(662, 27);
            this.txtProcessDetail.Name = "txtProcessDetail";
            this.txtProcessDetail.Size = new System.Drawing.Size(100, 21);
            this.txtProcessDetail.TabIndex = 32;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(632, 25);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(24, 23);
            this.btnProcess.TabIndex = 30;
            this.btnProcess.Text = "...";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(557, 27);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(69, 21);
            this.txtProcess.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label3.Location = new System.Drawing.Point(513, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "공정";
            // 
            // txtWorkCenterDetail
            // 
            this.txtWorkCenterDetail.Location = new System.Drawing.Point(945, 27);
            this.txtWorkCenterDetail.Name = "txtWorkCenterDetail";
            this.txtWorkCenterDetail.Size = new System.Drawing.Size(100, 21);
            this.txtWorkCenterDetail.TabIndex = 27;
            // 
            // btnWorkCenter
            // 
            this.btnWorkCenter.Location = new System.Drawing.Point(915, 25);
            this.btnWorkCenter.Name = "btnWorkCenter";
            this.btnWorkCenter.Size = new System.Drawing.Size(24, 23);
            this.btnWorkCenter.TabIndex = 26;
            this.btnWorkCenter.Text = "...";
            this.btnWorkCenter.UseVisualStyleBackColor = true;
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.Location = new System.Drawing.Point(840, 27);
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.Size = new System.Drawing.Size(69, 21);
            this.txtWorkCenter.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label1.Location = new System.Drawing.Point(781, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "작업장";
            // 
            // frm_PRM_PRF_008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_PRM_PRF_008";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_008_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcessDetail;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkCenterDetail;
        private System.Windows.Forms.Button btnWorkCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkCenter;
        private System.Windows.Forms.DataGridView dgvPRM_PRF;
    }
}
