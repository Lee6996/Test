﻿
namespace Final.KPI_RPT
{
    partial class frm_KPI_RPT_1
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_KPI_DAY = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KPI_DAY)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.dgv_KPI_DAY);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 739);
            this.panel5.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(583, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "생산일자 - 근무인원 - 공정- 작업장 - 제품명 - 실적 - 생산시간 - 시간당생산량 - 가스사용량 - 비가동시간";
            // 
            // dgv_KPI_DAY
            // 
            this.dgv_KPI_DAY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_KPI_DAY.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_KPI_DAY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KPI_DAY.Location = new System.Drawing.Point(6, 45);
            this.dgv_KPI_DAY.Name = "dgv_KPI_DAY";
            this.dgv_KPI_DAY.RowTemplate.Height = 23;
            this.dgv_KPI_DAY.Size = new System.Drawing.Size(1248, 682);
            this.dgv_KPI_DAY.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(6, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 26);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(-572, -229);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(194, 26);
            this.panel7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "생산의뢰";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "조회내역";
            // 
            // frm_KPI_RPT_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1266, 828);
            this.Controls.Add(this.panel5);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_KPI_RPT_1";
            this.Load += new System.EventHandler(this.frm_KPI_RPT_1_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KPI_DAY)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgv_KPI_DAY;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}