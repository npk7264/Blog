namespace Blog
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhSáchYêuThíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐãLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐãBìnhLuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.pbIconSearch = new System.Windows.Forms.PictureBox();
            this.pbAvatarLogin = new CustomControls.RJControls.RJCircularPictureBox();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pic_home);
            this.panel1.Controls.Add(this.pbIconSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pbAvatarLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 100);
            this.panel1.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtSearch.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(272, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(15, 17, 60, 17);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(792, 60);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TabStop = false;
            this.txtSearch.Texts = "Tìm kiếm tài khoản";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchYêuThíchToolStripMenuItem,
            this.danhSáchĐãLưuToolStripMenuItem,
            this.danhSáchĐãBìnhLuậnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 108);
            // 
            // danhSáchYêuThíchToolStripMenuItem
            // 
            this.danhSáchYêuThíchToolStripMenuItem.Name = "danhSáchYêuThíchToolStripMenuItem";
            this.danhSáchYêuThíchToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.danhSáchYêuThíchToolStripMenuItem.Text = "Danh sách yêu thích";
            this.danhSáchYêuThíchToolStripMenuItem.Click += new System.EventHandler(this.danhSáchYêuThíchToolStripMenuItem_Click);
            // 
            // danhSáchĐãLưuToolStripMenuItem
            // 
            this.danhSáchĐãLưuToolStripMenuItem.Name = "danhSáchĐãLưuToolStripMenuItem";
            this.danhSáchĐãLưuToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.danhSáchĐãLưuToolStripMenuItem.Text = "Danh sách đã lưu";
            this.danhSáchĐãLưuToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐãLưuToolStripMenuItem_Click);
            // 
            // danhSáchĐãBìnhLuậnToolStripMenuItem
            // 
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Name = "danhSáchĐãBìnhLuậnToolStripMenuItem";
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Text = "Danh sách đã bình luận";
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐãBìnhLuậnToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(0, 100);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1380, 800);
            this.pnMain.TabIndex = 7;
            // 
            // pic_home
            // 
            this.pic_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_home.Location = new System.Drawing.Point(41, 16);
            this.pic_home.Margin = new System.Windows.Forms.Padding(4);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(67, 62);
            this.pic_home.TabIndex = 5;
            this.pic_home.TabStop = false;
            this.pic_home.Click += new System.EventHandler(this.pic_home_Click);
            // 
            // pbIconSearch
            // 
            this.pbIconSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pbIconSearch.BackgroundImage = global::Blog.Properties.Resources.icon_search;
            this.pbIconSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIconSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIconSearch.Location = new System.Drawing.Point(1014, 27);
            this.pbIconSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIconSearch.Name = "pbIconSearch";
            this.pbIconSearch.Size = new System.Drawing.Size(36, 36);
            this.pbIconSearch.TabIndex = 4;
            this.pbIconSearch.TabStop = false;
            this.pbIconSearch.Click += new System.EventHandler(this.pbIconSearch_Click);
            // 
            // pbAvatarLogin
            // 
            this.pbAvatarLogin.BackColor = System.Drawing.Color.Silver;
            this.pbAvatarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatarLogin.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatarLogin.BorderColor = System.Drawing.Color.Transparent;
            this.pbAvatarLogin.BorderColor2 = System.Drawing.Color.Transparent;
            this.pbAvatarLogin.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatarLogin.BorderSize = 2;
            this.pbAvatarLogin.ContextMenuStrip = this.contextMenuStrip1;
            this.pbAvatarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvatarLogin.GradientAngle = 50F;
            this.pbAvatarLogin.Location = new System.Drawing.Point(1271, 11);
            this.pbAvatarLogin.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.pbAvatarLogin.Name = "pbAvatarLogin";
            this.pbAvatarLogin.Size = new System.Drawing.Size(80, 80);
            this.pbAvatarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarLogin.TabIndex = 1;
            this.pbAvatarLogin.TabStop = false;
            this.pbAvatarLogin.Click += new System.EventHandler(this.pbAvatarLogin_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 900);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIconSearch;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchYêuThíchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐãLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐãBìnhLuậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarLogin;
    }
}