
namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_006
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
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGVDetail = new System.Windows.Forms.TextBox();
            this.btnGV = new System.Windows.Forms.Button();
            this.txtGVCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGVDetail);
            this.panel4.Controls.Add(this.btnGV);
            this.panel4.Controls.Add(this.txtGVCode);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtItemDetail);
            this.panel4.Controls.Add(this.btnItem);
            this.panel4.Controls.Add(this.txtItemCode);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.txtItemCode, 0);
            this.panel4.Controls.SetChildIndex(this.btnItem, 0);
            this.panel4.Controls.SetChildIndex(this.txtItemDetail, 0);
            this.panel4.Controls.SetChildIndex(this.label3, 0);
            this.panel4.Controls.SetChildIndex(this.txtGVCode, 0);
            this.panel4.Controls.SetChildIndex(this.btnGV, 0);
            this.panel4.Controls.SetChildIndex(this.txtGVDetail, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 9, 22, 9, 36, 674);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 2, 22, 9, 36, 674);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.Text = "조회조건 : 로딩일자";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPRM_PRF);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // dgvPRM_PRF
            // 
            this.dgvPRM_PRF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRM_PRF.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPRM_PRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRM_PRF.Location = new System.Drawing.Point(3, 3);
            this.dgvPRM_PRF.Name = "dgvPRM_PRF";
            this.dgvPRM_PRF.RowTemplate.Height = 23;
            this.dgvPRM_PRF.Size = new System.Drawing.Size(1258, 800);
            this.dgvPRM_PRF.TabIndex = 23;
            // 
            // txtItemDetail
            // 
            this.txtItemDetail.Location = new System.Drawing.Point(1069, 16);
            this.txtItemDetail.Name = "txtItemDetail";
            this.txtItemDetail.Size = new System.Drawing.Size(100, 25);
            this.txtItemDetail.TabIndex = 19;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(1039, 17);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(24, 23);
            this.btnItem.TabIndex = 18;
            this.btnItem.Text = "...";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(964, 16);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(69, 25);
            this.txtItemCode.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label1.Location = new System.Drawing.Point(920, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "품목";
            // 
            // txtGVDetail
            // 
            this.txtGVDetail.Location = new System.Drawing.Point(801, 16);
            this.txtGVDetail.Name = "txtGVDetail";
            this.txtGVDetail.Size = new System.Drawing.Size(100, 25);
            this.txtGVDetail.TabIndex = 23;
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(771, 17);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(24, 23);
            this.btnGV.TabIndex = 22;
            this.btnGV.Text = "...";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // txtGVCode
            // 
            this.txtGVCode.Location = new System.Drawing.Point(696, 16);
            this.txtGVCode.Name = "txtGVCode";
            this.txtGVCode.Size = new System.Drawing.Size(69, 25);
            this.txtGVCode.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label3.Location = new System.Drawing.Point(652, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "대차";
            // 
            // frm_PRM_PRF_006
            // 
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_PRM_PRF_006";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_006_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPRM_PRF;
        private System.Windows.Forms.TextBox txtGVDetail;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.TextBox txtGVCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemDetail;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label1;
    }
}
