
namespace Final.MDS_CDS
{
    partial class frm_MDS_CDS_005_1
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
            this.dgvBox = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(305, 37);
            this.textBox4.TabIndex = 59;
            this.textBox4.Text = "▶ 포장 등급 목록";
            // 
            // dgvBox
            // 
            this.dgvBox.BackgroundColor = System.Drawing.Color.White;
            this.dgvBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBox.Location = new System.Drawing.Point(0, 35);
            this.dgvBox.Name = "dgvBox";
            this.dgvBox.RowTemplate.Height = 23;
            this.dgvBox.Size = new System.Drawing.Size(305, 415);
            this.dgvBox.TabIndex = 58;
            this.dgvBox.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBox_CellContentDoubleClick);
            // 
            // frm_MDS_CDS_005_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dgvBox);
            this.Name = "frm_MDS_CDS_005_1";
            this.Text = "frm_MDS_CDS_005_1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgvBox;
    }
}