namespace PhanMemQLTV
{
    partial class frmGiaoDienChinh
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
            this.components = new System.ComponentModel.Container();
            this.mnuHeThong = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhậuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picAnhNen = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnuHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuHeThong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.mnuHeThong.Location = new System.Drawing.Point(0, 0);
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(774, 27);
            this.mnuHeThong.TabIndex = 0;
            this.mnuHeThong.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKýToolStripMenuItem,
            this.đổiMậtKhậuToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đăngKýToolStripMenuItem
            // 
            this.đăngKýToolStripMenuItem.Name = "đăngKýToolStripMenuItem";
            this.đăngKýToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đăngKýToolStripMenuItem.Text = "Đăng Ký";
            this.đăngKýToolStripMenuItem.Click += new System.EventHandler(this.đăngKýToolStripMenuItem_Click);
            // 
            // đổiMậtKhậuToolStripMenuItem
            // 
            this.đổiMậtKhậuToolStripMenuItem.Name = "đổiMậtKhậuToolStripMenuItem";
            this.đổiMậtKhậuToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.đổiMậtKhậuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhậuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhậuToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem1,
            this.quảnLýĐộcGiảToolStripMenuItem1});
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(154, 23);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản Lý Danh Mục";
            // 
            // quảnLýSáchToolStripMenuItem1
            // 
            this.quảnLýSáchToolStripMenuItem1.Name = "quảnLýSáchToolStripMenuItem1";
            this.quảnLýSáchToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.quảnLýSáchToolStripMenuItem1.Text = "Quản Lý Sách";
            this.quảnLýSáchToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem1_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem1
            // 
            this.quảnLýĐộcGiảToolStripMenuItem1.Name = "quảnLýĐộcGiảToolStripMenuItem1";
            this.quảnLýĐộcGiảToolStripMenuItem1.Size = new System.Drawing.Size(210, 26);
            this.quảnLýĐộcGiảToolStripMenuItem1.Text = "Quản Lý Độc Giả";
            this.quảnLýĐộcGiảToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýĐộcGiảToolStripMenuItem1_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(155, 23);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý Mượn - Trả";
            this.quảnLýMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(161, 23);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo Cáo - Thống Kê";
            this.báoCáoThốngKêToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThốngKêToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click_1);
            // 
            // picAnhNen
            // 
            this.picAnhNen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnhNen.Image = global::PhanMemQLTV.Properties.Resources.e740b676534d9513cc5c;
            this.picAnhNen.Location = new System.Drawing.Point(0, 27);
            this.picAnhNen.Name = "picAnhNen";
            this.picAnhNen.Size = new System.Drawing.Size(774, 445);
            this.picAnhNen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhNen.TabIndex = 2;
            this.picAnhNen.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNo,
            this.tsslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(774, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslNo
            // 
            this.tsslNo.Name = "tsslNo";
            this.tsslNo.Size = new System.Drawing.Size(688, 20);
            this.tsslNo.Spring = true;
            this.tsslNo.Text = "Notification";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(71, 20);
            this.tsslTime.Text = "Thời gian";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 472);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picAnhNen);
            this.Controls.Add(this.mnuHeThong);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuHeThong;
            this.MaximizeBox = false;
            this.Name = "frmGiaoDienChinh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDienChinh_FormClosing);
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            this.mnuHeThong.ResumeLayout(false);
            this.mnuHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNen)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuHeThong;
        private System.Windows.Forms.PictureBox picAnhNen;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhậuToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslNo;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.Timer timer1;
    }
}