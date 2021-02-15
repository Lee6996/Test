
namespace Final.PPS_SCH
{
    partial class frm_PPS_SCH_001
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_WorkOrder = new System.Windows.Forms.DataGridView();
            this.dgv_Req = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWorkAdd = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Req)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnWorkAdd);
            this.panel4.Size = new System.Drawing.Size(1335, 57);
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
            this.panel4.Controls.SetChildIndex(this.btnWorkAdd, 0);
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Location = new System.Drawing.Point(950, 5);
            this.btn_WorkCenter.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(893, 11);
            this.textBox6.Visible = false;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(888, 8);
            this.label16.Visible = false;
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(928, 8);
            this.btn_Process.Visible = false;
            // 
            // button22
            // 
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(969, 21);
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(834, 24);
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.Text = "프로젝트번호";
            this.label3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.dgv_WorkOrder);
            this.panel5.Controls.Add(this.dgv_Req);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1335, 797);
            this.panel5.TabIndex = 16;
            this.panel5.Tag = "";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(6, 346);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(194, 26);
            this.panel8.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(71, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "작업지시";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(-572, -229);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 26);
            this.panel9.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "생산의뢰";
            // 
            // dgv_WorkOrder
            // 
            this.dgv_WorkOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_WorkOrder.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_WorkOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WorkOrder.Location = new System.Drawing.Point(6, 378);
            this.dgv_WorkOrder.Name = "dgv_WorkOrder";
            this.dgv_WorkOrder.RowTemplate.Height = 23;
            this.dgv_WorkOrder.Size = new System.Drawing.Size(1317, 407);
            this.dgv_WorkOrder.TabIndex = 3;
            // 
            // dgv_Req
            // 
            this.dgv_Req.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Req.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Req.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Req.Location = new System.Drawing.Point(6, 45);
            this.dgv_Req.Name = "dgv_Req";
            this.dgv_Req.RowTemplate.Height = 23;
            this.dgv_Req.Size = new System.Drawing.Size(1317, 274);
            this.dgv_Req.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "생산의뢰";
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
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "생산의뢰";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(34, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "생산의뢰";
            // 
            // btnWorkAdd
            // 
            this.btnWorkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnWorkAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWorkAdd.Location = new System.Drawing.Point(1194, 11);
            this.btnWorkAdd.Name = "btnWorkAdd";
            this.btnWorkAdd.Size = new System.Drawing.Size(136, 35);
            this.btnWorkAdd.TabIndex = 15;
            this.btnWorkAdd.Text = "작업지시 추가";
            this.btnWorkAdd.UseVisualStyleBackColor = false;
            this.btnWorkAdd.Click += new System.EventHandler(this.btnWorkAdd_Click);
            // 
            // frm_PPS_SCH_001
            // 
            this.ClientSize = new System.Drawing.Size(1335, 876);
            this.Controls.Add(this.panel5);
            this.Name = "frm_PPS_SCH_001";
            this.Load += new System.EventHandler(this.frm_PPS_SCH_001_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Req)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_WorkOrder;
        private System.Windows.Forms.DataGridView dgv_Req;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWorkAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}
