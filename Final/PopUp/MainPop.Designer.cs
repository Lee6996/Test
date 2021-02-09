
namespace Final.PRM_PRF.PopUp
{
    partial class MainPop
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
            this.lblType = new System.Windows.Forms.Label();
            this.dgvMainPop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("나눔스퀘어OTF ExtraBold", 18F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(12, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(136, 27);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "{type} 목록";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMainPop
            // 
            this.dgvMainPop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMainPop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainPop.Location = new System.Drawing.Point(12, 52);
            this.dgvMainPop.Name = "dgvMainPop";
            this.dgvMainPop.RowTemplate.Height = 23;
            this.dgvMainPop.Size = new System.Drawing.Size(394, 426);
            this.dgvMainPop.TabIndex = 20;
            this.dgvMainPop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainPop_CellDoubleClick);
            // 
            // MainPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 483);
            this.Controls.Add(this.dgvMainPop);
            this.Controls.Add(this.lblType);
            this.Name = "MainPop";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPop_FormClosed);
            this.Load += new System.EventHandler(this.frm_PRM_PRF_MainPop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridView dgvMainPop;
    }
}