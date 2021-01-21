
namespace Final
{
    partial class frm_KPI_RPT_004
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button22 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(225, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1357, 67);
            this.panel4.TabIndex = 16;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button22.Location = new System.Drawing.Point(365, 21);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(44, 23);
            this.button22.TabIndex = 8;
            this.button22.Text = "검색";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(255, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "~";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(273, 22);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 21);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "조회조건 : 생산월";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(225, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1357, 685);
            this.panel5.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(303, 12);
            this.label15.TabIndex = 5;
            this.label15.Text = "품목코드 - 품목명 - 누계포장량(1일부터) - 전일포장량";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 628);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Tag = "";
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
            // frm_KPI_RPT_004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1582, 904);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_KPI_RPT_004";
            this.Tag = "포장 월간 실적현황";
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
