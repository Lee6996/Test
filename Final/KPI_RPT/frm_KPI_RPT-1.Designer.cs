
namespace Final
{
    partial class frm_KPI_RPT_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Process = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Process)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "공정목록";
            // 
            // dgv_Process
            // 
            this.dgv_Process.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Process.Location = new System.Drawing.Point(12, 45);
            this.dgv_Process.Name = "dgv_Process";
            this.dgv_Process.RowTemplate.Height = 23;
            this.dgv_Process.Size = new System.Drawing.Size(479, 304);
            this.dgv_Process.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(143, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "공정코드 - 공정이름";
            // 
            // frm_KPI_RPT_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(503, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Process);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_KPI_RPT_1";
            this.Text = "공정찾기";
            this.Load += new System.EventHandler(this.frm_KPI_RPT_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Process)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Process;
        private System.Windows.Forms.Label label2;
    }
}