
namespace Final.MDS_CDS
{
    partial class frm_MDS_CDS_002_1
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgvDef = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDef)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(0, -1);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 37);
            this.textBox4.TabIndex = 55;
            this.textBox4.Text = "▶ 불량현상 대분류 목록 찾기";
            // 
            // dgvDef
            // 
            this.dgvDef.BackgroundColor = System.Drawing.Color.White;
            this.dgvDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDef.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDef.Location = new System.Drawing.Point(0, 33);
            this.dgvDef.Name = "dgvDef";
            this.dgvDef.RowTemplate.Height = 23;
            this.dgvDef.Size = new System.Drawing.Size(305, 417);
            this.dgvDef.TabIndex = 54;
            this.dgvDef.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDef_CellDoubleClick);
            // 
            // frm_MDS_CDS_002_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dgvDef);
            this.Name = "frm_MDS_CDS_002_1";
            this.Text = "MDS_CDS_002_1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_MDS_CDS_002_1_FormClosed);
            this.Load += new System.EventHandler(this.frm_MDS_CDS_002_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvDef;
    }
}