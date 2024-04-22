namespace NewBookRentalShop
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoginUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuBookDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuBookRental = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.이프로그램은ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.MnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기XToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "파일(&F)";
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLoginUsers,
            this.toolStripSeparator1,
            this.MnuBookDivision,
            this.MnuBookInfo,
            this.MnuMembers,
            this.toolStripSeparator2,
            this.MnuBookRental});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem2.Text = "관리(&M)";
            // 
            // MnuLoginUsers
            // 
            this.MnuLoginUsers.Image = ((System.Drawing.Image)(resources.GetObject("MnuLoginUsers.Image")));
            this.MnuLoginUsers.Name = "MnuLoginUsers";
            this.MnuLoginUsers.Size = new System.Drawing.Size(180, 22);
            this.MnuLoginUsers.Text = "로그인사용자 관리";
            this.MnuLoginUsers.Click += new System.EventHandler(this.MnuLoginUsers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuBookDivision
            // 
            this.MnuBookDivision.Name = "MnuBookDivision";
            this.MnuBookDivision.Size = new System.Drawing.Size(180, 22);
            this.MnuBookDivision.Text = "책장르 관리";
            // 
            // MnuBookInfo
            // 
            this.MnuBookInfo.Name = "MnuBookInfo";
            this.MnuBookInfo.Size = new System.Drawing.Size(180, 22);
            this.MnuBookInfo.Text = "책정보 관리";
            // 
            // MnuMembers
            // 
            this.MnuMembers.Name = "MnuMembers";
            this.MnuMembers.Size = new System.Drawing.Size(180, 22);
            this.MnuMembers.Text = "도서회원 관리";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuBookRental
            // 
            this.MnuBookRental.Name = "MnuBookRental";
            this.MnuBookRental.Size = new System.Drawing.Size(180, 22);
            this.MnuBookRental.Text = "대출관리";
            // 
            // MnuAbout
            // 
            this.MnuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이프로그램은ToolStripMenuItem});
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(72, 20);
            this.MnuAbout.Text = "도움말(&H)";
            // 
            // 이프로그램은ToolStripMenuItem
            // 
            this.이프로그램은ToolStripMenuItem.Name = "이프로그램은ToolStripMenuItem";
            this.이프로그램은ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.이프로그램은ToolStripMenuItem.Text = "이 프로그램은...(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel1.Text = "로그인아이디";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "책 대여점 v1.2";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLoginUsers;
        private System.Windows.Forms.ToolStripMenuItem MnuBookDivision;
        private System.Windows.Forms.ToolStripMenuItem MnuBookInfo;
        private System.Windows.Forms.ToolStripMenuItem MnuMembers;
        private System.Windows.Forms.ToolStripMenuItem MnuBookRental;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 이프로그램은ToolStripMenuItem;
    }
}

