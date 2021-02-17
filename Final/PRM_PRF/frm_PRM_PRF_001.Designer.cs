
using System;
using System.Windows.Forms;

namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_001
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvPRM_PRF = new System.Windows.Forms.DataGridView();
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
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Size = new System.Drawing.Size(1304, 57);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnEdit, 0);
            this.panel4.Controls.SetChildIndex(this.txtWorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.btnWorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.txtWorkCenterDetail, 0);
            this.panel4.Controls.SetChildIndex(this.label3, 0);
            this.panel4.Controls.SetChildIndex(this.txtProcess, 0);
            this.panel4.Controls.SetChildIndex(this.btnProcess, 0);
            this.panel4.Controls.SetChildIndex(this.txtProcessDetail, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 8, 15, 7, 26, 423);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 1, 15, 7, 26, 423);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.Text = "조회조건 : 작업지시일자";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPRM_PRF);
            this.panel5.Size = new System.Drawing.Size(1304, 806);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(1202, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "실적보정";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.dgvPRM_PRF.Size = new System.Drawing.Size(1298, 800);
            this.dgvPRM_PRF.TabIndex = 2;
            this.dgvPRM_PRF.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRM_PRF_CellClick);
            // 
            // txtProcessDetail
            // 
            this.txtProcessDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcessDetail.Location = new System.Drawing.Point(801, 16);
            this.txtProcessDetail.Name = "txtProcessDetail";
            this.txtProcessDetail.Size = new System.Drawing.Size(100, 25);
            this.txtProcessDetail.TabIndex = 40;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(771, 17);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(24, 23);
            this.btnProcess.TabIndex = 39;
            this.btnProcess.Text = "...";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtProcess
            // 
            this.txtProcess.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProcess.Location = new System.Drawing.Point(696, 16);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(69, 25);
            this.txtProcess.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(652, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "공정";
            // 
            // txtWorkCenterDetail
            // 
            this.txtWorkCenterDetail.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenterDetail.Location = new System.Drawing.Point(1084, 16);
            this.txtWorkCenterDetail.Name = "txtWorkCenterDetail";
            this.txtWorkCenterDetail.Size = new System.Drawing.Size(100, 25);
            this.txtWorkCenterDetail.TabIndex = 36;
            // 
            // btnWorkCenter
            // 
            this.btnWorkCenter.Location = new System.Drawing.Point(1054, 17);
            this.btnWorkCenter.Name = "btnWorkCenter";
            this.btnWorkCenter.Size = new System.Drawing.Size(24, 23);
            this.btnWorkCenter.TabIndex = 35;
            this.btnWorkCenter.Text = "...";
            this.btnWorkCenter.UseVisualStyleBackColor = true;
            this.btnWorkCenter.Click += new System.EventHandler(this.btnWorkCenter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(920, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "작업장";
            // 
            // txtWorkCenter
            // 
            this.txtWorkCenter.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkCenter.Location = new System.Drawing.Point(979, 16);
            this.txtWorkCenter.Name = "txtWorkCenter";
            this.txtWorkCenter.Size = new System.Drawing.Size(69, 25);
            this.txtWorkCenter.TabIndex = 34;
            // 
            // frm_PRM_PRF_001
            // 
            this.ClientSize = new System.Drawing.Size(1304, 897);
            this.Name = "frm_PRM_PRF_001";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_001_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnEdit;
        private DataGridView dgvPRM_PRF;
        private TextBox txtProcessDetail;
        private Button btnProcess;
        private TextBox txtProcess;
        private Label label3;
        private TextBox txtWorkCenterDetail;
        private Button btnWorkCenter;
        private Label label1;
        private TextBox txtWorkCenter;
    }
}
