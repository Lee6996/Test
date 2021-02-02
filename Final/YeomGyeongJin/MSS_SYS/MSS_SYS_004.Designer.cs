
namespace Final.YeomGyeongJin.MSS_SYS
{
    partial class MSS_SYS_004
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
            this.pnl = new System.Windows.Forms.Panel();
            this.btnNotice_Insert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNotice_End = new System.Windows.Forms.DateTimePicker();
            this.dtpNotice_Date = new System.Windows.Forms.DateTimePicker();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.White;
            this.pnl.Controls.Add(this.btnNotice_Insert);
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.dtpNotice_End);
            this.pnl.Controls.Add(this.dtpNotice_Date);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1344, 56);
            this.pnl.TabIndex = 18;
            // 
            // btnNotice_Insert
            // 
            this.btnNotice_Insert.BackColor = System.Drawing.Color.DimGray;
            this.btnNotice_Insert.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNotice_Insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNotice_Insert.Location = new System.Drawing.Point(712, 10);
            this.btnNotice_Insert.Name = "btnNotice_Insert";
            this.btnNotice_Insert.Size = new System.Drawing.Size(85, 35);
            this.btnNotice_Insert.TabIndex = 113;
            this.btnNotice_Insert.Text = "등록";
            this.btnNotice_Insert.UseVisualStyleBackColor = false;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DimGray;
            this.btnSelect.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelect.Location = new System.Drawing.Point(568, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 35);
            this.btnSelect.TabIndex = 112;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(234, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpNotice_End
            // 
            this.dtpNotice_End.Location = new System.Drawing.Point(269, 14);
            this.dtpNotice_End.Name = "dtpNotice_End";
            this.dtpNotice_End.Size = new System.Drawing.Size(200, 26);
            this.dtpNotice_End.TabIndex = 7;
            // 
            // dtpNotice_Date
            // 
            this.dtpNotice_Date.Location = new System.Drawing.Point(14, 14);
            this.dtpNotice_Date.Name = "dtpNotice_Date";
            this.dtpNotice_Date.Size = new System.Drawing.Size(200, 26);
            this.dtpNotice_Date.TabIndex = 6;
            // 
            // dgvNotice
            // 
            this.dgvNotice.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.NoticeStart,
            this.NoticeEnd,
            this.NoticeName,
            this.Notice});
            this.dgvNotice.Location = new System.Drawing.Point(12, 105);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(1320, 748);
            this.dgvNotice.TabIndex = 23;
            // 
            // num
            // 
            this.num.HeaderText = "공지사항번호";
            this.num.Name = "num";
            this.num.Width = 140;
            // 
            // NoticeStart
            // 
            this.NoticeStart.HeaderText = "공지사항시작일자";
            this.NoticeStart.Name = "NoticeStart";
            this.NoticeStart.Width = 160;
            // 
            // NoticeEnd
            // 
            this.NoticeEnd.HeaderText = "공지사항종료일자";
            this.NoticeEnd.Name = "NoticeEnd";
            this.NoticeEnd.Width = 160;
            // 
            // NoticeName
            // 
            this.NoticeName.HeaderText = "제목";
            this.NoticeName.Name = "NoticeName";
            this.NoticeName.Width = 150;
            // 
            // Notice
            // 
            this.Notice.HeaderText = "공지내역";
            this.Notice.Name = "Notice";
            this.Notice.Width = 500;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(9, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "▶공지사항목록";
            // 
            // MSS_SYS_004
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 865);
            this.Controls.Add(this.dgvNotice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔스퀘어OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MSS_SYS_004";
            this.Tag = "공지사항등록";
            this.Text = "MSS_SYS_004";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNotice_End;
        private System.Windows.Forms.DateTimePicker dtpNotice_Date;
        private System.Windows.Forms.Button btnNotice_Insert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notice;
        private System.Windows.Forms.Label label6;
    }
}