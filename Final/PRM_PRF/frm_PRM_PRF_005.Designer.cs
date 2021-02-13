
namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_005
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
            this.txtGVGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGV = new System.Windows.Forms.Button();
            this.txtGVGroupDetail = new System.Windows.Forms.TextBox();
            this.txtItemDetail = new System.Windows.Forms.TextBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtItemDetail);
            this.panel4.Controls.Add(this.btnItem);
            this.panel4.Controls.Add(this.txtItem);
            this.panel4.Controls.Add(this.txtGVGroupDetail);
            this.panel4.Controls.Add(this.btnGV);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtGVGroup);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.txtGVGroup, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.btnGV, 0);
            this.panel4.Controls.SetChildIndex(this.txtGVGroupDetail, 0);
            this.panel4.Controls.SetChildIndex(this.txtItem, 0);
            this.panel4.Controls.SetChildIndex(this.btnItem, 0);
            this.panel4.Controls.SetChildIndex(this.txtItemDetail, 0);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1012, 27);
            this.label4.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(1035, 21);
            this.dtpTo.Value = new System.DateTime(2021, 2, 9, 20, 27, 40, 115);
            this.dtpTo.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(876, 21);
            this.dtpFrom.Value = new System.DateTime(2021, 2, 2, 20, 27, 40, 115);
            this.dtpFrom.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.Text = "조회조건 : 대차그룹";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPRM_PRF);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Location = new System.Drawing.Point(1168, 17);
            this.btnTimeSearch.Visible = false;
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
            this.dgvPRM_PRF.TabIndex = 3;
            // 
            // txtGVGroup
            // 
            this.txtGVGroup.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVGroup.Location = new System.Drawing.Point(159, 14);
            this.txtGVGroup.Name = "txtGVGroup";
            this.txtGVGroup.Size = new System.Drawing.Size(69, 25);
            this.txtGVGroup.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label1.Location = new System.Drawing.Point(427, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "품목";
            // 
            // btnGV
            // 
            this.btnGV.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGV.Location = new System.Drawing.Point(234, 15);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(24, 23);
            this.btnGV.TabIndex = 11;
            this.btnGV.Text = "...";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // txtGVGroupDetail
            // 
            this.txtGVGroupDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGVGroupDetail.Location = new System.Drawing.Point(264, 14);
            this.txtGVGroupDetail.Name = "txtGVGroupDetail";
            this.txtGVGroupDetail.Size = new System.Drawing.Size(100, 25);
            this.txtGVGroupDetail.TabIndex = 12;
            // 
            // txtItemDetail
            // 
            this.txtItemDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemDetail.Location = new System.Drawing.Point(576, 14);
            this.txtItemDetail.Name = "txtItemDetail";
            this.txtItemDetail.Size = new System.Drawing.Size(100, 25);
            this.txtItemDetail.TabIndex = 15;
            // 
            // btnItem
            // 
            this.btnItem.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnItem.Location = new System.Drawing.Point(546, 15);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(24, 23);
            this.btnItem.TabIndex = 14;
            this.btnItem.Text = "...";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItem.Location = new System.Drawing.Point(471, 14);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(69, 25);
            this.txtItem.TabIndex = 13;
            // 
            // frm_PRM_PRF_005
            // 
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_PRM_PRF_005";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_005_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPRM_PRF;
        private System.Windows.Forms.TextBox txtItemDetail;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtGVGroupDetail;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGVGroup;
    }
}
