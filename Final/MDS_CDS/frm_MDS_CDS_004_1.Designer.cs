
namespace Final.MDS_CDS
{
    partial class frm_MDS_CDS_004_1
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
            this.dgvNop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNop)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 37);
            this.textBox4.TabIndex = 57;
            this.textBox4.Text = "▶ 비가동 대분류 목록 찾기";
            // 
            // dgvNop
            // 
            this.dgvNop.BackgroundColor = System.Drawing.Color.White;
            this.dgvNop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNop.Location = new System.Drawing.Point(0, 37);
            this.dgvNop.Name = "dgvNop";
            this.dgvNop.RowTemplate.Height = 23;
            this.dgvNop.Size = new System.Drawing.Size(305, 413);
            this.dgvNop.TabIndex = 56;
            this.dgvNop.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNop_CellContentDoubleClick);
            // 
            // frm_MDS_CDS_004_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dgvNop);
            this.Name = "frm_MDS_CDS_004_1";
            this.Text = "frm_MDS_CDS_004_1";
            this.Load += new System.EventHandler(this.frm_MDS_CDS_004_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvNop;
    }
}