
namespace Final.PPS_MLD
{
    partial class frm_PPS_MLD_002
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
            this.dgv_Mold = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mold)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Click += new System.EventHandler(this.btn_WorkCenter_Click);
            // 
            // textBox6
            // 
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btn_Process
            // 
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // button22
            // 
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox1
            // 
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Text = "품목";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgv_Mold);
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 806);
            this.panel5.TabIndex = 19;
            // 
            // dgv_Mold
            // 
            this.dgv_Mold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Mold.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Mold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mold.Location = new System.Drawing.Point(3, 3);
            this.dgv_Mold.Name = "dgv_Mold";
            this.dgv_Mold.RowTemplate.Height = 23;
            this.dgv_Mold.Size = new System.Drawing.Size(1258, 798);
            this.dgv_Mold.TabIndex = 1;
            this.dgv_Mold.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(34, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "조회내역";
            // 
            // frm_PPS_MLD_002
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Controls.Add(this.panel5);
            this.Name = "frm_PPS_MLD_002";
            this.Load += new System.EventHandler(this.frm_PPS_MLD_002_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgv_Mold;
        private System.Windows.Forms.Label label5;
    }
}
