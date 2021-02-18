
namespace Final.PPS_SCH
{
    partial class frm_PPS_SCH_003
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_Work = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chartDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWorkStatus = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Work)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbWorkStatus);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Size = new System.Drawing.Size(1468, 57);
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
            this.panel4.Controls.SetChildIndex(this.label17, 0);
            this.panel4.Controls.SetChildIndex(this.cbWorkStatus, 0);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.Text = "작업지시일자";
            // 
            // btn_WorkCenter
            // 
            this.btn_WorkCenter.Location = new System.Drawing.Point(1345, 7);
            this.btn_WorkCenter.Visible = false;
            this.btn_WorkCenter.Click += new System.EventHandler(this.btn_WorkCenter_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1294, 25);
            this.textBox6.Visible = false;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(1376, 21);
            this.label16.Visible = false;
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(1318, 11);
            this.btn_Process.Visible = false;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(550, 8);
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1239, 18);
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1286, 15);
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.Text = "작업장";
            this.label3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dgv_Work);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Location = new System.Drawing.Point(0, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1468, 811);
            this.panel5.TabIndex = 16;
            // 
            // dgv_Work
            // 
            this.dgv_Work.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Work.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Work.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Work.Location = new System.Drawing.Point(3, 3);
            this.dgv_Work.Name = "dgv_Work";
            this.dgv_Work.RowTemplate.Height = 23;
            this.dgv_Work.Size = new System.Drawing.Size(1460, 508);
            this.dgv_Work.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.chartDate);
            this.panel10.Location = new System.Drawing.Point(3, 517);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1460, 289);
            this.panel10.TabIndex = 4;
            // 
            // chartDate
            // 
            this.chartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDate.Legends.Add(legend1);
            this.chartDate.Location = new System.Drawing.Point(3, 3);
            this.chartDate.Name = "chartDate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDate.Series.Add(series1);
            this.chartDate.Size = new System.Drawing.Size(1448, 284);
            this.chartDate.TabIndex = 0;
            this.chartDate.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "작업지시목록";
            // 
            // cbWorkStatus
            // 
            this.cbWorkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbWorkStatus.FormattingEnabled = true;
            this.cbWorkStatus.Location = new System.Drawing.Point(1317, 17);
            this.cbWorkStatus.Name = "cbWorkStatus";
            this.cbWorkStatus.Size = new System.Drawing.Size(121, 23);
            this.cbWorkStatus.TabIndex = 16;
            this.cbWorkStatus.Visible = false;
            this.cbWorkStatus.SelectedIndexChanged += new System.EventHandler(this.cbWorkStatus_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(1356, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "작업지시상태";
            this.label17.Visible = false;
            // 
            // frm_PPS_SCH_003
            // 
            this.ClientSize = new System.Drawing.Size(1468, 923);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_PPS_SCH_003";
            this.Load += new System.EventHandler(this.frm_PPS_SCH_003_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Work)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgv_Work;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbWorkStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDate;
    }
}
