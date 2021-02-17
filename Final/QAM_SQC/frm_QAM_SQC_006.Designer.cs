
namespace Final.QAM_SQC
{
    partial class frm_QAM_SQC_006
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nuYear = new System.Windows.Forms.NumericUpDown();
            this.dgvQAM_SQC = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQAM_SQC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nuYear);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.nuYear, 0);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1033, 23);
            this.label4.Visible = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(1070, 19);
            this.dtpTo.Value = new System.DateTime(2021, 2, 16, 21, 23, 58, 370);
            this.dtpTo.Visible = false;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(882, 19);
            this.dtpFrom.Value = new System.DateTime(2021, 2, 9, 0, 0, 0, 0);
            this.dtpFrom.Visible = false;
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.Text = "조회조건 : 생산년도";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvQAM_SQC);
            this.panel5.Size = new System.Drawing.Size(1732, 1253);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Location = new System.Drawing.Point(260, 11);
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // nuYear
            // 
            this.nuYear.Location = new System.Drawing.Point(177, 17);
            this.nuYear.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nuYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nuYear.Name = "nuYear";
            this.nuYear.Size = new System.Drawing.Size(63, 25);
            this.nuYear.TabIndex = 10;
            this.nuYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // dgvQAM_SQC
            // 
            this.dgvQAM_SQC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQAM_SQC.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvQAM_SQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQAM_SQC.Location = new System.Drawing.Point(3, 3);
            this.dgvQAM_SQC.Name = "dgvQAM_SQC";
            this.dgvQAM_SQC.RowTemplate.Height = 23;
            this.dgvQAM_SQC.Size = new System.Drawing.Size(1258, 800);
            this.dgvQAM_SQC.TabIndex = 69;
            // 
            // frm_QAM_SQC_006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 897);
            this.Name = "frm_QAM_SQC_006";
            this.Text = "QAM_SQC_006";
            this.Load += new System.EventHandler(this.QAM_SQC_006_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQAM_SQC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nuYear;
        private System.Windows.Forms.DataGridView dgvQAM_SQC;
    }
}