﻿
namespace Final.KPI_RPT
{
    partial class frm_KPI_RPT_001
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
            this.dgv_KPI_DAY = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPCodeText = new System.Windows.Forms.TextBox();
            this.txtWCodeText = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KPI_DAY)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtWCodeText);
            this.panel4.Controls.Add(this.txtPCodeText);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.label3, 0);
            this.panel4.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.panel4.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.textBox1, 0);
            this.panel4.Controls.SetChildIndex(this.button22, 0);
            this.panel4.Controls.SetChildIndex(this.btn_Process, 0);
            this.panel4.Controls.SetChildIndex(this.label16, 0);
            this.panel4.Controls.SetChildIndex(this.textBox6, 0);
            this.panel4.Controls.SetChildIndex(this.btn_WorkCenter, 0);
            this.panel4.Controls.SetChildIndex(this.txtPCodeText, 0);
            this.panel4.Controls.SetChildIndex(this.txtWCodeText, 0);
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Click += new System.EventHandler(this.btn_WorkCenter_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1153, 61);
            this.textBox6.Visible = false;
            // 
            // btn_Process
            // 
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(528, 11);
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1153, 46);
            this.textBox1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.dgv_KPI_DAY);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 749);
            this.panel5.TabIndex = 16;
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
            this.dgv_KPI_DAY.Size = new System.Drawing.Size(1248, 692);
            this.dgv_KPI_DAY.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(6, 13);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 26);
            this.panel6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "조회내역";
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
            this.label6.Size = new System.Drawing.Size(60, 18);
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
            // txtPCodeText
            // 
            this.txtPCodeText.Enabled = false;
            this.txtPCodeText.Location = new System.Drawing.Point(787, 17);
            this.txtPCodeText.Name = "txtPCodeText";
            this.txtPCodeText.Size = new System.Drawing.Size(100, 24);
            this.txtPCodeText.TabIndex = 13;
            this.txtPCodeText.TextChanged += new System.EventHandler(this.txtPCodeText_TextChanged);
            // 
            // txtWCodeText
            // 
            this.txtWCodeText.Enabled = false;
            this.txtWCodeText.Location = new System.Drawing.Point(1074, 16);
            this.txtWCodeText.Name = "txtWCodeText";
            this.txtWCodeText.Size = new System.Drawing.Size(100, 24);
            this.txtWCodeText.TabIndex = 14;
            this.txtWCodeText.TextChanged += new System.EventHandler(this.txtWCodeText_TextChanged);
            // 
            // frm_KPI_RPT_001
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1266, 828);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_KPI_RPT_001";
            this.Load += new System.EventHandler(this.frm_KPI_RPT_001_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgv_KPI_DAY;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWCodeText;
        private System.Windows.Forms.TextBox txtPCodeText;
        private System.Windows.Forms.Label label1;
    }
}
