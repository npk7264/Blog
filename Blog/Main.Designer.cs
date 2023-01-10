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
            this.pic_home = new System.Windows.Forms.PictureBox();
            this.pbIconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            this.pbAvatarLogin = new CustomControls.RJControls.RJCircularPictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.danhSáchYêuThíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐãLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐãBìnhLuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_chat = new System.Windows.Forms.Panel();
            this.btnQuanLi = new CustomControls.RJControls.RJButton();
            this.btnLoiMoi = new CustomControls.RJControls.RJButton();
            this.btnKyNiem = new CustomControls.RJControls.RJButton();
            this.btnDaBinhLuan = new CustomControls.RJControls.RJButton();
            this.btnDaLuu = new CustomControls.RJControls.RJButton();
            this.btnYeuThich = new CustomControls.RJControls.RJButton();
            this.fLP_friend = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_friend = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fLP_friend.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1273, 81);
            this.panel1.TabIndex = 6;
            // 
            // pic_home
            // 
            this.pic_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_home.Location = new System.Drawing.Point(80, 13);
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
            this.pbIconSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIconSearch.Location = new System.Drawing.Point(738, 22);
            this.pbIconSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pbIconSearch.Name = "pbIconSearch";
            this.pbIconSearch.Size = new System.Drawing.Size(27, 29);
            this.pbIconSearch.TabIndex = 4;
            this.pbIconSearch.TabStop = false;
            this.pbIconSearch.Click += new System.EventHandler(this.pbIconSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(375, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(11, 14, 45, 14);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 49);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TabStop = false;
            this.txtSearch.Texts = "Tìm kiếm tài khoản";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            this.pbAvatarLogin.Location = new System.Drawing.Point(1173, 11);
            this.pbAvatarLogin.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.pbAvatarLogin.Name = "pbAvatarLogin";
            this.pbAvatarLogin.Size = new System.Drawing.Size(60, 60);
            this.pbAvatarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarLogin.TabIndex = 1;
            this.pbAvatarLogin.TabStop = false;
            this.pbAvatarLogin.Click += new System.EventHandler(this.pbAvatarLogin_Click);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 108);
            // 
            // danhSáchYêuThíchToolStripMenuItem
            // 
            this.danhSáchYêuThíchToolStripMenuItem.Name = "danhSáchYêuThíchToolStripMenuItem";
            this.danhSáchYêuThíchToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.danhSáchYêuThíchToolStripMenuItem.Text = "Danh sách yêu thích";
            this.danhSáchYêuThíchToolStripMenuItem.Click += new System.EventHandler(this.danhSáchYêuThíchToolStripMenuItem_Click);
            // 
            // danhSáchĐãLưuToolStripMenuItem
            // 
            this.danhSáchĐãLưuToolStripMenuItem.Name = "danhSáchĐãLưuToolStripMenuItem";
            this.danhSáchĐãLưuToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.danhSáchĐãLưuToolStripMenuItem.Text = "Danh sách đã lưu";
            this.danhSáchĐãLưuToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐãLưuToolStripMenuItem_Click);
            // 
            // danhSáchĐãBìnhLuậnToolStripMenuItem
            // 
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Name = "danhSáchĐãBìnhLuậnToolStripMenuItem";
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Text = "Danh sách đã bình luận";
            this.danhSáchĐãBìnhLuậnToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐãBìnhLuậnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(252, 83);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(668, 650);
            this.pnMain.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuanLi);
            this.panel2.Controls.Add(this.btnLoiMoi);
            this.panel2.Controls.Add(this.btnKyNiem);
            this.panel2.Controls.Add(this.btnDaBinhLuan);
            this.panel2.Controls.Add(this.btnDaLuu);
            this.panel2.Controls.Add(this.btnYeuThich);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 650);
            this.panel2.TabIndex = 8;
            // 
            // pnl_chat
            // 
            this.pnl_chat.Location = new System.Drawing.Point(940, 375);
            this.pnl_chat.Name = "pnl_chat";
            this.pnl_chat.Size = new System.Drawing.Size(321, 344);
            this.pnl_chat.TabIndex = 6;
            // 
            // btnQuanLi
            // 
            this.btnQuanLi.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnQuanLi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuanLi.BorderRadius = 0;
            this.btnQuanLi.BorderSize = 0;
            this.btnQuanLi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLi.FlatAppearance.BorderSize = 0;
            this.btnQuanLi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLi.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLi.Location = new System.Drawing.Point(34, 247);
            this.btnQuanLi.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuanLi.Name = "btnQuanLi";
            this.btnQuanLi.Size = new System.Drawing.Size(181, 41);
            this.btnQuanLi.TabIndex = 5;
            this.btnQuanLi.Text = "Quản lý tài khoản";
            this.btnQuanLi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLi.TextColor = System.Drawing.Color.Black;
            this.btnQuanLi.UseVisualStyleBackColor = false;
            // 
            // btnLoiMoi
            // 
            this.btnLoiMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLoiMoi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLoiMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoiMoi.BorderRadius = 0;
            this.btnLoiMoi.BorderSize = 0;
            this.btnLoiMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoiMoi.FlatAppearance.BorderSize = 0;
            this.btnLoiMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoiMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoiMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLoiMoi.Location = new System.Drawing.Point(34, 202);
            this.btnLoiMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoiMoi.Name = "btnLoiMoi";
            this.btnLoiMoi.Size = new System.Drawing.Size(181, 41);
            this.btnLoiMoi.TabIndex = 4;
            this.btnLoiMoi.Text = "Lời mời kết bạn";
            this.btnLoiMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoiMoi.TextColor = System.Drawing.Color.Black;
            this.btnLoiMoi.UseVisualStyleBackColor = false;
            this.btnLoiMoi.Click += new System.EventHandler(this.btnLoiMoi_Click);
            // 
            // btnKyNiem
            // 
            this.btnKyNiem.BackColor = System.Drawing.Color.Transparent;
            this.btnKyNiem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKyNiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKyNiem.BorderRadius = 0;
            this.btnKyNiem.BorderSize = 0;
            this.btnKyNiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKyNiem.FlatAppearance.BorderSize = 0;
            this.btnKyNiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyNiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyNiem.ForeColor = System.Drawing.Color.Black;
            this.btnKyNiem.Location = new System.Drawing.Point(34, 157);
            this.btnKyNiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnKyNiem.Name = "btnKyNiem";
            this.btnKyNiem.Size = new System.Drawing.Size(181, 41);
            this.btnKyNiem.TabIndex = 3;
            this.btnKyNiem.Text = "Kỷ niệm";
            this.btnKyNiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKyNiem.TextColor = System.Drawing.Color.Black;
            this.btnKyNiem.UseVisualStyleBackColor = false;
            this.btnKyNiem.Click += new System.EventHandler(this.btnKyNiem_Click);
            // 
            // btnDaBinhLuan
            // 
            this.btnDaBinhLuan.BackColor = System.Drawing.Color.Transparent;
            this.btnDaBinhLuan.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDaBinhLuan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDaBinhLuan.BorderRadius = 0;
            this.btnDaBinhLuan.BorderSize = 0;
            this.btnDaBinhLuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaBinhLuan.FlatAppearance.BorderSize = 0;
            this.btnDaBinhLuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaBinhLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaBinhLuan.ForeColor = System.Drawing.Color.Black;
            this.btnDaBinhLuan.Location = new System.Drawing.Point(34, 112);
            this.btnDaBinhLuan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaBinhLuan.Name = "btnDaBinhLuan";
            this.btnDaBinhLuan.Size = new System.Drawing.Size(181, 41);
            this.btnDaBinhLuan.TabIndex = 2;
            this.btnDaBinhLuan.Text = "Đã bình luận";
            this.btnDaBinhLuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaBinhLuan.TextColor = System.Drawing.Color.Black;
            this.btnDaBinhLuan.UseVisualStyleBackColor = false;
            this.btnDaBinhLuan.Click += new System.EventHandler(this.btnDaBinhLuan_Click);
            // 
            // btnDaLuu
            // 
            this.btnDaLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnDaLuu.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDaLuu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDaLuu.BorderRadius = 0;
            this.btnDaLuu.BorderSize = 0;
            this.btnDaLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaLuu.FlatAppearance.BorderSize = 0;
            this.btnDaLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaLuu.ForeColor = System.Drawing.Color.Black;
            this.btnDaLuu.Location = new System.Drawing.Point(34, 65);
            this.btnDaLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaLuu.Name = "btnDaLuu";
            this.btnDaLuu.Size = new System.Drawing.Size(181, 41);
            this.btnDaLuu.TabIndex = 1;
            this.btnDaLuu.Text = "Đã lưu";
            this.btnDaLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaLuu.TextColor = System.Drawing.Color.Black;
            this.btnDaLuu.UseVisualStyleBackColor = false;
            this.btnDaLuu.Click += new System.EventHandler(this.btnDaLuu_Click);
            // 
            // btnYeuThich
            // 
            this.btnYeuThich.BackColor = System.Drawing.Color.Transparent;
            this.btnYeuThich.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnYeuThich.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnYeuThich.BorderRadius = 0;
            this.btnYeuThich.BorderSize = 0;
            this.btnYeuThich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeuThich.FlatAppearance.BorderSize = 0;
            this.btnYeuThich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeuThich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeuThich.ForeColor = System.Drawing.Color.Black;
            this.btnYeuThich.Location = new System.Drawing.Point(34, 17);
            this.btnYeuThich.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeuThich.Name = "btnYeuThich";
            this.btnYeuThich.Size = new System.Drawing.Size(181, 41);
            this.btnYeuThich.TabIndex = 0;
            this.btnYeuThich.Text = "Yêu thích";
            this.btnYeuThich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeuThich.TextColor = System.Drawing.Color.Black;
            this.btnYeuThich.UseVisualStyleBackColor = false;
            this.btnYeuThich.Click += new System.EventHandler(this.btnYeuThich_Click);
            // 
            // fLP_friend
            // 
            this.fLP_friend.AutoSize = true;
            this.fLP_friend.Controls.Add(this.lb_friend);
            this.fLP_friend.Location = new System.Drawing.Point(939, 84);
            this.fLP_friend.Name = "fLP_friend";
            this.fLP_friend.Size = new System.Drawing.Size(334, 268);
            this.fLP_friend.TabIndex = 9;
            // 
            // lb_friend
            // 
            this.lb_friend.AutoSize = true;
            this.lb_friend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_friend.Location = new System.Drawing.Point(3, 0);
            this.lb_friend.Name = "lb_friend";
            this.lb_friend.Size = new System.Drawing.Size(155, 16);
            this.lb_friend.TabIndex = 0;
            this.lb_friend.Text = "DANH SÁCH BẠN BÈ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1273, 731);
            this.Controls.Add(this.pnl_chat);
            this.Controls.Add(this.fLP_friend);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.fLP_friend.ResumeLayout(false);
            this.fLP_friend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btnYeuThich;
        private CustomControls.RJControls.RJButton btnLoiMoi;
        private CustomControls.RJControls.RJButton btnKyNiem;
        private CustomControls.RJControls.RJButton btnDaBinhLuan;
        private CustomControls.RJControls.RJButton btnDaLuu;
        private CustomControls.RJControls.RJButton btnQuanLi;
        private System.Windows.Forms.Panel pnl_chat;
        private System.Windows.Forms.FlowLayoutPanel fLP_friend;
        private System.Windows.Forms.Label lb_friend;
    }
}