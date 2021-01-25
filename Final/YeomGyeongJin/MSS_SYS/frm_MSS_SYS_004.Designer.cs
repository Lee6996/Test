
namespace Final
{
    partial class frm_MSS_SYS_004
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNotice_End = new System.Windows.Forms.DateTimePicker();
            this.dtpNotice_Date = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoticeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNotice_Insert = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.SystemColors.Info;
            this.pnl.Controls.Add(this.btnNotice_Insert);
            this.pnl.Controls.Add(this.label4);
            this.pnl.Controls.Add(this.dtpNotice_End);
            this.pnl.Controls.Add(this.dtpNotice_Date);
            this.pnl.Controls.Add(this.btnSelect);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(225, 152);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1357, 48);
            this.pnl.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(234, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpNotice_End
            // 
            this.dtpNotice_End.Location = new System.Drawing.Point(269, 11);
            this.dtpNotice_End.Name = "dtpNotice_End";
            this.dtpNotice_End.Size = new System.Drawing.Size(200, 26);
            this.dtpNotice_End.TabIndex = 7;
            // 
            // dtpNotice_Date
            // 
            this.dtpNotice_Date.Location = new System.Drawing.Point(14, 11);
            this.dtpNotice_Date.Name = "dtpNotice_Date";
            this.dtpNotice_Date.Size = new System.Drawing.Size(200, 26);
            this.dtpNotice_Date.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(517, 10);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dgvNotice);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(225, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1357, 704);
            this.panel4.TabIndex = 18;
            // 
            // dgvNotice
            // 
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.NoticeStart,
            this.NoticeEnd,
            this.NoticeName,
            this.Notice});
            this.dgvNotice.Location = new System.Drawing.Point(15, 50);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(1335, 645);
            this.dgvNotice.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "▶공지사항목록";
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
            // btnNotice_Insert
            // 
            this.btnNotice_Insert.AutoSize = true;
            this.btnNotice_Insert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNotice_Insert.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNotice_Insert.Location = new System.Drawing.Point(633, 10);
            this.btnNotice_Insert.Name = "btnNotice_Insert";
            this.btnNotice_Insert.Size = new System.Drawing.Size(75, 29);
            this.btnNotice_Insert.TabIndex = 9;
            this.btnNotice_Insert.Text = "추가";
            this.btnNotice_Insert.UseVisualStyleBackColor = false;
            // 
            // frm_MSS_SYS_004
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 904);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_MSS_SYS_004";
            this.Tag = "공지사항";
            this.Controls.SetChildIndex(this.pnl, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNotice_End;
        private System.Windows.Forms.DateTimePicker dtpNotice_Date;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoticeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notice;
        private System.Windows.Forms.Button btnNotice_Insert;
    }
}
