
namespace Final.Login
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnSearchPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(230, 25);
            this.txtID.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(113, 70);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(230, 25);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Location = new System.Drawing.Point(183, 114);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.Color.White;
            this.btnSearchID.FlatAppearance.BorderSize = 0;
            this.btnSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchID.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchID.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchID.Location = new System.Drawing.Point(113, 180);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(100, 30);
            this.btnSearchID.TabIndex = 5;
            this.btnSearchID.Text = "아이디찾기";
            this.btnSearchID.UseVisualStyleBackColor = false;
            // 
            // btnSearchPwd
            // 
            this.btnSearchPwd.BackColor = System.Drawing.Color.White;
            this.btnSearchPwd.FlatAppearance.BorderSize = 0;
            this.btnSearchPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPwd.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchPwd.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchPwd.Location = new System.Drawing.Point(233, 180);
            this.btnSearchPwd.Name = "btnSearchPwd";
            this.btnSearchPwd.Size = new System.Drawing.Size(110, 30);
            this.btnSearchPwd.TabIndex = 6;
            this.btnSearchPwd.Text = "비밀번호찾기";
            this.btnSearchPwd.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 232);
            this.Controls.Add(this.btnSearchPwd);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Button btnSearchPwd;
    }
}