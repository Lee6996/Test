
namespace Final.KPI_RPT
{
    partial class frm_KPI_RPT_W
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_WorkCenter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(142, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "작업장코드 - 작업장이름";
            // 
            // dgv_WorkCenter
            // 
            this.dgv_WorkCenter.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_WorkCenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WorkCenter.Location = new System.Drawing.Point(11, 45);
            this.dgv_WorkCenter.Name = "dgv_WorkCenter";
            this.dgv_WorkCenter.RowTemplate.Height = 23;
            this.dgv_WorkCenter.Size = new System.Drawing.Size(480, 304);
            this.dgv_WorkCenter.TabIndex = 7;
            this.dgv_WorkCenter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_WorkCenter_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "작업장";
            // 
            // frm_KPI_RPT_W
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(503, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_WorkCenter);
            this.Controls.Add(this.label1);
            this.Name = "frm_KPI_RPT_W";
            this.Text = "frm_KPI_RPT_W";
            this.Load += new System.EventHandler(this.frm_KPI_RPT_W_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WorkCenter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_WorkCenter;
        private System.Windows.Forms.Label label1;
    }
}