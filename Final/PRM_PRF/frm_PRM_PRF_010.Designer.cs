﻿
namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_010
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
            this.txtUser_Name = new System.Windows.Forms.TextBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser_ID = new System.Windows.Forms.TextBox();
            this.dgvPRM_PRF_1 = new System.Windows.Forms.DataGridView();
            this.dgvPRM_PRF_2 = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUser_Name);
            this.panel4.Controls.Add(this.btnUser);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtUser_ID);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.txtUser_ID, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.label1, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.btnUser, 0);
            this.panel4.Controls.SetChildIndex(this.txtUser_Name, 0);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 10, 6, 46, 11, 796);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 3, 6, 46, 11, 796);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.Text = "조회조건 : 근무일자";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPRM_PRF_1);
            this.panel5.Controls.Add(this.dgvPRM_PRF_2);
            this.panel5.Controls.SetChildIndex(this.panel6, 0);
            this.panel5.Controls.SetChildIndex(this.dgvPRM_PRF_2, 0);
            this.panel5.Controls.SetChildIndex(this.panel8, 0);
            this.panel5.Controls.SetChildIndex(this.dgvPRM_PRF_1, 0);
            // 
            // label11
            // 
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.Text = "상세내역";
            // 
            // txtUser_Name
            // 
            this.txtUser_Name.Location = new System.Drawing.Point(667, 27);
            this.txtUser_Name.Name = "txtUser_Name";
            this.txtUser_Name.Size = new System.Drawing.Size(100, 21);
            this.txtUser_Name.TabIndex = 39;
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(637, 25);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(24, 23);
            this.btnUser.TabIndex = 38;
            this.btnUser.Text = "...";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F);
            this.label1.Location = new System.Drawing.Point(503, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "작업자";
            // 
            // txtUser_ID
            // 
            this.txtUser_ID.Location = new System.Drawing.Point(562, 27);
            this.txtUser_ID.Name = "txtUser_ID";
            this.txtUser_ID.Size = new System.Drawing.Size(69, 21);
            this.txtUser_ID.TabIndex = 37;
            // 
            // dgvPRM_PRF_1
            // 
            this.dgvPRM_PRF_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRM_PRF_1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPRM_PRF_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRM_PRF_1.Location = new System.Drawing.Point(6, 48);
            this.dgvPRM_PRF_1.Name = "dgvPRM_PRF_1";
            this.dgvPRM_PRF_1.RowTemplate.Height = 23;
            this.dgvPRM_PRF_1.Size = new System.Drawing.Size(1248, 345);
            this.dgvPRM_PRF_1.TabIndex = 40;
            this.dgvPRM_PRF_1.Tag = "";
            this.dgvPRM_PRF_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRM_PRF_1_CellClick);
            // 
            // dgvPRM_PRF_2
            // 
            this.dgvPRM_PRF_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRM_PRF_2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPRM_PRF_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRM_PRF_2.Location = new System.Drawing.Point(3, 431);
            this.dgvPRM_PRF_2.Name = "dgvPRM_PRF_2";
            this.dgvPRM_PRF_2.RowTemplate.Height = 23;
            this.dgvPRM_PRF_2.Size = new System.Drawing.Size(1248, 405);
            this.dgvPRM_PRF_2.TabIndex = 41;
            this.dgvPRM_PRF_2.Tag = "";
            // 
            // frm_PRM_PRF_010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_PRM_PRF_010";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_010_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser_Name;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser_ID;
        private System.Windows.Forms.DataGridView dgvPRM_PRF_1;
        private System.Windows.Forms.DataGridView dgvPRM_PRF_2;
    }
}
