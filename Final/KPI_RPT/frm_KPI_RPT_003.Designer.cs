
namespace Final.KPI_RPT
{
    partial class frm_KPI_RPT_003
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
            this.dgv_KPI_MONTH = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWCodeText = new System.Windows.Forms.TextBox();
            this.txtPCodeText = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KPI_MONTH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtWCodeText);
            this.panel4.Controls.Add(this.txtPCodeText);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.Text = "조회조건 : 생산월";
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Location = new System.Drawing.Point(704, 11);
            this.btn_WorkCenter.Click += new System.EventHandler(this.btn_WorkCenter_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1163, 21);
            this.textBox6.Visible = false;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(645, 19);
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(1163, 12);
            this.btn_Process.Visible = false;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(922, 22);
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1119, 20);
            this.label3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgv_KPI_MONTH);
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1266, 716);
            this.panel5.TabIndex = 17;
            // 
            // dgv_KPI_MONTH
            // 
            this.dgv_KPI_MONTH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_KPI_MONTH.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_KPI_MONTH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KPI_MONTH.Location = new System.Drawing.Point(3, 3);
            this.dgv_KPI_MONTH.Name = "dgv_KPI_MONTH";
            this.dgv_KPI_MONTH.RowTemplate.Height = 23;
            this.dgv_KPI_MONTH.Size = new System.Drawing.Size(1258, 708);
            this.dgv_KPI_MONTH.TabIndex = 1;
            this.dgv_KPI_MONTH.Tag = "";
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
            // txtWCodeText
            // 
            this.txtWCodeText.Enabled = false;
            this.txtWCodeText.Location = new System.Drawing.Point(795, 16);
            this.txtWCodeText.Name = "txtWCodeText";
            this.txtWCodeText.Size = new System.Drawing.Size(100, 25);
            this.txtWCodeText.TabIndex = 19;
            // 
            // txtPCodeText
            // 
            this.txtPCodeText.Location = new System.Drawing.Point(1001, 25);
            this.txtPCodeText.Name = "txtPCodeText";
            this.txtPCodeText.Size = new System.Drawing.Size(100, 25);
            this.txtPCodeText.TabIndex = 18;
            this.txtPCodeText.Visible = false;
            // 
            // frm_KPI_RPT_003
            // 
            this.ClientSize = new System.Drawing.Size(1266, 828);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_KPI_RPT_003";
            this.Load += new System.EventHandler(this.frm_KPI_RPT_3_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KPI_MONTH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgv_KPI_MONTH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWCodeText;
        private System.Windows.Forms.TextBox txtPCodeText;
    }
}
