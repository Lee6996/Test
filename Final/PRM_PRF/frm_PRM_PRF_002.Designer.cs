
namespace Final.PRM_PRF
{
    partial class frm_PRM_PRF_002
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
            this.dgvPRM_PRF_2 = new System.Windows.Forms.DataGridView();
            this.dgvPRM_PRF_1 = new System.Windows.Forms.DataGridView();
            this.btnWoEnd = new System.Windows.Forms.Button();
            this.btnPalletEnd = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPRM_PRF_1);
            this.panel5.Controls.Add(this.dgvPRM_PRF_2);
            this.panel5.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel5.Size = new System.Drawing.Size(1676, 914);
            this.panel5.Controls.SetChildIndex(this.label11, 0);
            this.panel5.Controls.SetChildIndex(this.dgvPRM_PRF_2, 0);
            this.panel5.Controls.SetChildIndex(this.dgvPRM_PRF_1, 0);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.Text = "조회조건 : 생산일자";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Value = new System.DateTime(2021, 2, 1, 20, 57, 47, 970);
            // 
            // dtpTo
            // 
            this.dtpTo.Value = new System.DateTime(2021, 2, 8, 20, 57, 47, 970);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPalletEnd);
            this.panel4.Controls.Add(this.btnWoEnd);
            this.panel4.Controls.SetChildIndex(this.label2, 0);
            this.panel4.Controls.SetChildIndex(this.dtpFrom, 0);
            this.panel4.Controls.SetChildIndex(this.dtpTo, 0);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.btnTimeSearch, 0);
            this.panel4.Controls.SetChildIndex(this.btnWoEnd, 0);
            this.panel4.Controls.SetChildIndex(this.btnPalletEnd, 0);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Location = new System.Drawing.Point(3, 441);
            this.label11.Size = new System.Drawing.Size(256, 26);
            this.label11.Text = "▶팔렛트내역";
            // 
            // dgvPRM_PRF_2
            // 
            this.dgvPRM_PRF_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRM_PRF_2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPRM_PRF_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRM_PRF_2.Location = new System.Drawing.Point(3, 470);
            this.dgvPRM_PRF_2.Name = "dgvPRM_PRF_2";
            this.dgvPRM_PRF_2.RowTemplate.Height = 23;
            this.dgvPRM_PRF_2.Size = new System.Drawing.Size(1668, 465);
            this.dgvPRM_PRF_2.TabIndex = 24;
            this.dgvPRM_PRF_2.Tag = "";
            this.dgvPRM_PRF_2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRM_PRF_2_CellDoubleClick);
            // 
            // dgvPRM_PRF_1
            // 
            this.dgvPRM_PRF_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRM_PRF_1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPRM_PRF_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRM_PRF_1.Location = new System.Drawing.Point(3, 3);
            this.dgvPRM_PRF_1.Name = "dgvPRM_PRF_1";
            this.dgvPRM_PRF_1.RowTemplate.Height = 23;
            this.dgvPRM_PRF_1.Size = new System.Drawing.Size(1668, 435);
            this.dgvPRM_PRF_1.TabIndex = 23;
            this.dgvPRM_PRF_1.Tag = "";
            this.dgvPRM_PRF_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRM_PRF_1_CellClick);
            // 
            // btnWoEnd
            // 
            this.btnWoEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWoEnd.BackColor = System.Drawing.Color.DimGray;
            this.btnWoEnd.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWoEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWoEnd.Location = new System.Drawing.Point(1334, 13);
            this.btnWoEnd.Name = "btnWoEnd";
            this.btnWoEnd.Size = new System.Drawing.Size(130, 35);
            this.btnWoEnd.TabIndex = 9;
            this.btnWoEnd.Text = "작업지시 마감";
            this.btnWoEnd.UseVisualStyleBackColor = false;
            this.btnWoEnd.Click += new System.EventHandler(this.btnWoEnd_Click);
            // 
            // btnPalletEnd
            // 
            this.btnPalletEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPalletEnd.BackColor = System.Drawing.Color.DimGray;
            this.btnPalletEnd.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPalletEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPalletEnd.Location = new System.Drawing.Point(1489, 13);
            this.btnPalletEnd.Name = "btnPalletEnd";
            this.btnPalletEnd.Size = new System.Drawing.Size(120, 35);
            this.btnPalletEnd.TabIndex = 10;
            this.btnPalletEnd.Text = "팔렛트 마감";
            this.btnPalletEnd.UseVisualStyleBackColor = false;
            this.btnPalletEnd.Click += new System.EventHandler(this.btnPalletEnd_Click);
            // 
            // frm_PRM_PRF_002
            // 
            this.ClientSize = new System.Drawing.Size(1676, 1006);
            this.Name = "frm_PRM_PRF_002";
            this.Load += new System.EventHandler(this.frm_PRM_PRF_002_Load);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRM_PRF_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPRM_PRF_2;
        private System.Windows.Forms.DataGridView dgvPRM_PRF_1;
        private System.Windows.Forms.Button btnWoEnd;
        private System.Windows.Forms.Button btnPalletEnd;
    }
}
