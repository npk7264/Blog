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
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.pbIconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.pbAvatarLogin = new CustomControls.RJControls.RJCircularPictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhSáchYêuThíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐãLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐãBìnhLuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pic_profile);
            this.panel1.Controls.Add(this.pic_home);
            this.panel1.Controls.Add(this.pbIconSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pbAvatarLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 81);
            this.panel1.TabIndex = 6;
            // 
            // pic_profile
            // 
            this.pic_profile.Location = new System.Drawing.Point(782, 12);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(50, 50);
            this.pic_profile.TabIndex = 6;
            this.pic_profile.TabStop = false;
            this.pic_profile.Click += new System.EventHandler(this.pic_profile_Click);
            // 
            // pic_home
            // 
            this.pic_home.Location = new System.Drawing.Point(702, 12);
            this.pic_home.Name = "pic_home";
            this.pic_home.Size = new System.Drawing.Size(50, 50);
            this.pic_home.TabIndex = 5;
            this.pic_home.TabStop = false;
            this.pic_home.Click += new System.EventHandler(this.pic_home_Click);
            // 
            // pbIconSearch
            // 
            this.pbIconSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pbIconSearch.BackgroundImage = global::Blog.Properties.Resources.icon_search;
            this.pbIconSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIconSearch.Location = new System.Drawing.Point(644, 22);
            this.pbIconSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pbIconSearch.Name = "pbIconSearch";
            this.pbIconSearch.Size = new System.Drawing.Size(27, 29);
            this.pbIconSearch.TabIndex = 4;
            this.pbIconSearch.TabStop = false;
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
            this.txtSearch.Location = new System.Drawing.Point(88, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(11, 14, 45, 14);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(594, 49);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Texts = "Tìm kiếm tài khoản";
            this.txtSearch.UnderlinedStyle = false;
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
            this.pbAvatarLogin.Location = new System.Drawing.Point(960, 8);
            this.pbAvatarLogin.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.pbAvatarLogin.Name = "pbAvatarLogin";
            this.pbAvatarLogin.Size = new System.Drawing.Size(60, 60);
            this.pbAvatarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarLogin.TabIndex = 1;
            this.pbAvatarLogin.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(0, 81);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1035, 650);
            this.pnMain.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchYêuThíchToolStripMenuItem,
            this.danhSáchĐãLưuToolStripMenuItem,
            this.danhSáchĐãBìnhLuậnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 114);
            // 
            // danhSáchYêuThíchToolStripMenuItem
            // 
            this.danhSáchYêuThíchToolStripMenuItem.Name = "danhSáchYêuThíchToolStripMenuItem";
            this.danhSáchYêuThíchToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.danhSáchYêuThíchToolStripMenuItem.Text = "Danh sách yêu thích";
            // 
            // danhSáchĐãLưuToolStripMenuItem
            // 
            this.danhSáchĐãLưuToolStripMenuItem.Name = "danhSáchĐãLưuToolStripMenuItem";
            this.danhSáchĐãLưuToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.danhSáchĐãLưuToolStripMenuItem.Text = "Danh sách đã lưu";
            // 
            // danhSáchĐãBìnhLuậnToolStripMenuItem
            // 
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Name = "danhSáchĐãBìnhLuậnToolStripMenuItem";
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Text = "Danh sách đã bình luận";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 731);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIconSearch;
        private CustomControls.RJControls.RJTextBox txtSearch;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarLogin;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.PictureBox pic_profile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchYêuThíchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐãLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐãBìnhLuậnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}