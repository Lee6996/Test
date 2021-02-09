
namespace Final.MSS_SYS
{
    partial class frm_MSS_SYS_003
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
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.dgvMenu_Under = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMenu_module = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu_Under)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu_module)).BeginInit();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.Location = new System.Drawing.Point(632, 51);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(700, 802);
            this.tvMenu.TabIndex = 32;
            // 
            // dgvMenu_Under
            // 
            this.dgvMenu_Under.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu_Under.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu_Under.Location = new System.Drawing.Point(12, 397);
            this.dgvMenu_Under.Name = "dgvMenu_Under";
            this.dgvMenu_Under.RowTemplate.Height = 23;
            this.dgvMenu_Under.Size = new System.Drawing.Size(614, 456);
            this.dgvMenu_Under.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(9, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "▶메뉴 하위목록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(626, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "▶메뉴트리뷰";
            // 
            // dgvMenu_module
            // 
            this.dgvMenu_module.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu_module.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu_module.Location = new System.Drawing.Point(12, 51);
            this.dgvMenu_module.Name = "dgvMenu_module";
            this.dgvMenu_module.RowTemplate.Height = 23;
            this.dgvMenu_module.Size = new System.Drawing.Size(614, 298);
            this.dgvMenu_module.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "▶메뉴모듈";
            // 
            // frm_MSS_SYS_003
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 865);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.dgvMenu_Under);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMenu_module);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frm_MSS_SYS_003";
            this.Tag = "메뉴관리";
            this.Text = "MSS_SYS_003";
            this.Load += new System.EventHandler(this.frm_MSS_SYS_003_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu_Under)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu_module)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.DataGridView dgvMenu_Under;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMenu_module;
        private System.Windows.Forms.Label label6;
    }
}