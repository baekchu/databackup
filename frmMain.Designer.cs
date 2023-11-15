namespace Backup
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.백업설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dB설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.ContextMenuStrip = this.contextMenuStrip;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "notifyIcon1";
            this.tray.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.백업설정ToolStripMenuItem,
            this.dB설정ToolStripMenuItem,
            this.로그ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // 백업설정ToolStripMenuItem
            // 
            this.백업설정ToolStripMenuItem.Name = "백업설정ToolStripMenuItem";
            this.백업설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.백업설정ToolStripMenuItem.Text = "백업 설정";
            this.백업설정ToolStripMenuItem.Click += new System.EventHandler(this.백업설정ToolStripMenuItem_Click);
            // 
            // dB설정ToolStripMenuItem
            // 
            this.dB설정ToolStripMenuItem.Name = "dB설정ToolStripMenuItem";
            this.dB설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dB설정ToolStripMenuItem.Text = "DB 설정";
            this.dB설정ToolStripMenuItem.Click += new System.EventHandler(this.dB설정ToolStripMenuItem_Click);
            // 
            // 로그ToolStripMenuItem
            // 
            this.로그ToolStripMenuItem.Name = "로그ToolStripMenuItem";
            this.로그ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그ToolStripMenuItem.Text = "로그";
            this.로그ToolStripMenuItem.Click += new System.EventHandler(this.로그ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 백업설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dB설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    }
}

