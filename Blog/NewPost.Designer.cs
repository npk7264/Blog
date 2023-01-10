namespace Blog
{
    partial class NewPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPost));
            this.btnDangBai = new CustomControls.RJControls.RJButton();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.rbCongKhai = new CustomControls.RJControls.RJRadioButton();
            this.rbRiengTu = new CustomControls.RJControls.RJRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpnImage = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbAddImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_map = new System.Windows.Forms.PictureBox();
            this.pbAddMusic = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.pbFont = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangBai
            // 
            this.btnDangBai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangBai.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangBai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangBai.BorderRadius = 10;
            this.btnDangBai.BorderSize = 0;
            this.btnDangBai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangBai.FlatAppearance.BorderSize = 0;
            this.btnDangBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangBai.ForeColor = System.Drawing.Color.White;
            this.btnDangBai.Location = new System.Drawing.Point(20, 10);
            this.btnDangBai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(752, 60);
            this.btnDangBai.TabIndex = 16;
            this.btnDangBai.Text = "Đăng bài viết";
            this.btnDangBai.TextColor = System.Drawing.Color.White;
            this.btnDangBai.UseVisualStyleBackColor = false;
            this.btnDangBai.Click += new System.EventHandler(this.btnDangBai_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.ForeColor = System.Drawing.Color.Gray;
            this.rtbStatus.Location = new System.Drawing.Point(27, 156);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(733, 239);
            this.rtbStatus.TabIndex = 15;
            this.rtbStatus.TabStop = false;
            this.rtbStatus.Text = "Bạn đang nghĩ gì?";
            this.rtbStatus.Enter += new System.EventHandler(this.rtbStatus_Enter);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(100, 30);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(70, 25);
            this.lbUser.TabIndex = 13;
            this.lbUser.Text = "label1";
            // 
            // rbCongKhai
            // 
            this.rbCongKhai.AutoSize = true;
            this.rbCongKhai.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbCongKhai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCongKhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCongKhai.Location = new System.Drawing.Point(105, 98);
            this.rbCongKhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCongKhai.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbCongKhai.Name = "rbCongKhai";
            this.rbCongKhai.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbCongKhai.Size = new System.Drawing.Size(133, 29);
            this.rbCongKhai.TabIndex = 17;
            this.rbCongKhai.TabStop = true;
            this.rbCongKhai.Text = "Công khai";
            this.rbCongKhai.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbCongKhai.UseVisualStyleBackColor = true;
            // 
            // rbRiengTu
            // 
            this.rbRiengTu.AutoSize = true;
            this.rbRiengTu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbRiengTu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRiengTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRiengTu.Location = new System.Drawing.Point(257, 98);
            this.rbRiengTu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRiengTu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbRiengTu.Name = "rbRiengTu";
            this.rbRiengTu.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.rbRiengTu.Size = new System.Drawing.Size(115, 29);
            this.rbRiengTu.TabIndex = 18;
            this.rbRiengTu.TabStop = true;
            this.rbRiengTu.Text = "Riêng tư";
            this.rbRiengTu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbRiengTu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Chế độ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangBai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 676);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 20;
            // 
            // flpnImage
            // 
            this.flpnImage.AutoScroll = true;
            this.flpnImage.BackColor = System.Drawing.SystemColors.Control;
            this.flpnImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnImage.Location = new System.Drawing.Point(0, 461);
            this.flpnImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnImage.Name = "flpnImage";
            this.flpnImage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flpnImage.Size = new System.Drawing.Size(800, 215);
            this.flpnImage.TabIndex = 21;
            this.flpnImage.Visible = false;
            this.flpnImage.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbAddImage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 22;
            // 
            // pbAddImage
            // 
            this.pbAddImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAddImage.BackgroundImage")));
            this.pbAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddImage.Location = new System.Drawing.Point(284, 7);
            this.pbAddImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAddImage.Name = "pbAddImage";
            this.pbAddImage.Size = new System.Drawing.Size(45, 46);
            this.pbAddImage.TabIndex = 24;
            this.pbAddImage.TabStop = false;
            this.pbAddImage.Click += new System.EventHandler(this.pbAddImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thêm ảnh vào bài viết";
            // 
            // pic_map
            // 
            this.pic_map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_map.BackgroundImage")));
            this.pic_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_map.Location = new System.Drawing.Point(477, 82);
            this.pic_map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_map.Name = "pic_map";
            this.pic_map.Size = new System.Drawing.Size(49, 46);
            this.pic_map.TabIndex = 28;
            this.pic_map.TabStop = false;
            this.pic_map.Click += new System.EventHandler(this.pic_map_Click);
            // 
            // pbAddMusic
            // 
            this.pbAddMusic.BackgroundImage = global::Blog.Properties.Resources.music_add;
            this.pbAddMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddMusic.Location = new System.Drawing.Point(556, 82);
            this.pbAddMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAddMusic.Name = "pbAddMusic";
            this.pbAddMusic.Size = new System.Drawing.Size(45, 46);
            this.pbAddMusic.TabIndex = 27;
            this.pbAddMusic.TabStop = false;
            this.pbAddMusic.Click += new System.EventHandler(this.pbAddMusic_Click);
            // 
            // pbColor
            // 
            this.pbColor.BackgroundImage = global::Blog.Properties.Resources.color;
            this.pbColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColor.Location = new System.Drawing.Point(635, 82);
            this.pbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(45, 46);
            this.pbColor.TabIndex = 26;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // pbFont
            // 
            this.pbFont.BackgroundImage = global::Blog.Properties.Resources.font_icon;
            this.pbFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFont.Location = new System.Drawing.Point(716, 82);
            this.pbFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbFont.Name = "pbFont";
            this.pbFont.Size = new System.Drawing.Size(56, 46);
            this.pbFont.TabIndex = 25;
            this.pbFont.TabStop = false;
            this.pbFont.Click += new System.EventHandler(this.pbFont_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatar.BorderColor = System.Drawing.Color.White;
            this.pbAvatar.BorderColor2 = System.Drawing.Color.White;
            this.pbAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatar.BorderSize = 2;
            this.pbAvatar.GradientAngle = 50F;
            this.pbAvatar.Location = new System.Drawing.Point(20, 15);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(60, 60);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 12;
            this.pbAvatar.TabStop = false;
            // 
            // NewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 756);
            this.Controls.Add(this.pic_map);
            this.Controls.Add(this.pbAddMusic);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.pbFont);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpnImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRiengTu);
            this.Controls.Add(this.rbCongKhai);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPost";
            this.Load += new System.EventHandler(this.NewPost_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnDangBai;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lbUser;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private CustomControls.RJControls.RJRadioButton rbCongKhai;
        private CustomControls.RJControls.RJRadioButton rbRiengTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpnImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbAddImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFont;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.PictureBox pbAddMusic;
        private System.Windows.Forms.PictureBox pic_map;
    }
}