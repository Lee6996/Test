
namespace Final.PPS_SCH
{
    partial class frm_PPS_SCH_002
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.nuPlanQty = new System.Windows.Forms.NumericUpDown();
            this.dtpPlanDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlanUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWorkorder = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Work = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPlanQty)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Work)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Size = new System.Drawing.Size(1333, 57);
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
            this.panel4.Controls.SetChildIndex(this.button20, 0);
            this.panel4.Controls.SetChildIndex(this.button21, 0);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.Text = "작업지시일자";
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Location = new System.Drawing.Point(706, 11);
            this.btn_WorkCenter.Click += new System.EventHandler(this.btn_WorkCenter_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(797, 16);
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(647, 19);
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(990, 10);
            this.btn_Process.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(975, 16);
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1012, 21);
            this.label3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.dgv_Work);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1333, 781);
            this.panel5.TabIndex = 16;
            this.panel5.Tag = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1278, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "작업지시상태 - 작업지시번호 - 계획일자 - 계획수량 - 계획수량단위 - 품목코드 - 품목명 - 작업장명 - 작업일자 - 작업시작시간 - 작업종료" +
    "시작- 투입시간 - 산출수량 - 생산수량 - 생산의뢰순번 - 프로젝트명";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.button25);
            this.panel10.Controls.Add(this.nuPlanQty);
            this.panel10.Controls.Add(this.dtpPlanDate);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.txtPlanUnit);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.txtItem);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.txtWorkorder);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Enabled = false;
            this.panel10.Location = new System.Drawing.Point(5, 553);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1315, 215);
            this.panel10.TabIndex = 4;
            // 
            // button25
            // 
            this.button25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button25.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button25.Location = new System.Drawing.Point(944, 143);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(125, 25);
            this.button25.TabIndex = 13;
            this.button25.Text = "작업지시 수정";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // nuPlanQty
            // 
            this.nuPlanQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nuPlanQty.Location = new System.Drawing.Point(798, 99);
            this.nuPlanQty.Name = "nuPlanQty";
            this.nuPlanQty.Size = new System.Drawing.Size(100, 25);
            this.nuPlanQty.TabIndex = 14;
            this.nuPlanQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanDate.Location = new System.Drawing.Point(798, 52);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(100, 25);
            this.dtpPlanDate.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(697, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "계획일자";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(697, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "계획수량";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(697, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "계획수량단위";
            // 
            // txtPlanUnit
            // 
            this.txtPlanUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlanUnit.Location = new System.Drawing.Point(798, 143);
            this.txtPlanUnit.Name = "txtPlanUnit";
            this.txtPlanUnit.Size = new System.Drawing.Size(100, 25);
            this.txtPlanUnit.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "품목코드";
            // 
            // txtItem
            // 
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem.Location = new System.Drawing.Point(567, 99);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 25);
            this.txtItem.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "작업지시번호";
            // 
            // txtWorkorder
            // 
            this.txtWorkorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWorkorder.Location = new System.Drawing.Point(567, 52);
            this.txtWorkorder.Name = "txtWorkorder";
            this.txtWorkorder.Size = new System.Drawing.Size(100, 25);
            this.txtWorkorder.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(194, 28);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(-572, -248);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 28);
            this.panel9.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "생산의뢰";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "입력정보";
            // 
            // dgv_Work
            // 
            this.dgv_Work.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Work.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Work.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Work.Location = new System.Drawing.Point(6, 49);
            this.dgv_Work.Name = "dgv_Work";
            this.dgv_Work.RowTemplate.Height = 23;
            this.dgv_Work.Size = new System.Drawing.Size(1315, 497);
            this.dgv_Work.TabIndex = 1;
            this.dgv_Work.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Work_CellMouseDoubleClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(6, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 28);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(-572, -248);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(194, 28);
            this.panel7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "생산의뢰";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "조회내역";
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button21.Location = new System.Drawing.Point(1193, 29);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(132, 25);
            this.button21.TabIndex = 14;
            this.button21.Text = "작업지시 마감취소";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.Location = new System.Drawing.Point(1193, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(132, 25);
            this.button20.TabIndex = 13;
            this.button20.Text = "작업지시 마감";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // frm_PPS_SCH_002
            // 
            this.ClientSize = new System.Drawing.Size(1333, 860);
            this.Controls.Add(this.panel5);
            this.Name = "frm_PPS_SCH_002";
            this.Load += new System.EventHandler(this.frm_PPS_SCH_002_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPlanQty)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Work)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.NumericUpDown nuPlanQty;
        private System.Windows.Forms.DateTimePicker dtpPlanDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlanUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWorkorder;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Work;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
    }
}
