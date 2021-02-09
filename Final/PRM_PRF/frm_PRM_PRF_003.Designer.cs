
namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_003
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
            this.txtItemDetail = new System.Windows.Forms.TextBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
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
            this.panel4.Controls.Add(this.txtItemDetail);
            this.panel4.Controls.Add(this.btnItem);
            this.panel4.Controls.Add(this.txtItem);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.txtItem, 0);
            this.panel4.Controls.SetChildIndex(this.btnItem, 0);
            this.panel4.Controls.SetChildIndex(this.txtItemDetail, 0);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 9, 19, 37, 30, 739);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 2, 19, 37, 30, 739);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.Text = "조회조건 : 생산일자";
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
            this.dgvPRM_PRF.TabIndex = 23;
            this.dgvPRM_PRF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRM_PRF_CellClick);
            // 
            // txtItemDetail
            // 
            this.txtItemDetail.Location = new System.Drawing.Point(722, 29);
            this.txtItemDetail.Name = "txtItemDetail";
            this.txtItemDetail.Size = new System.Drawing.Size(100, 21);
            this.txtItemDetail.TabIndex = 19;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(692, 27);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(24, 23);
            this.btnItem.TabIndex = 18;
            this.btnItem.Text = "...";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(617, 29);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(69, 21);
            this.txtItem.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label1.Location = new System.Drawing.Point(543, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "품목";
            // 
            // frm_PRM_PRF_003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_PRM_PRF_003";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_003_Load);
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

        private System.Windows.Forms.DataGridView dgvPRM_PRF;
        private System.Windows.Forms.TextBox txtItemDetail;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
    }
}
