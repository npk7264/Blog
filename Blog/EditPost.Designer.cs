namespace Blog
{
    partial class EditPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPost));
            this.label1 = new System.Windows.Forms.Label();
            this.rbRiengTu = new CustomControls.RJControls.RJRadioButton();
            this.rbCongKhai = new CustomControls.RJControls.RJRadioButton();
            this.btnLuuThayDoi = new CustomControls.RJControls.RJButton();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.pbFont = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpnImage = new System.Windows.Forms.FlowLayoutPanel();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.pbAddMusic = new System.Windows.Forms.PictureBox();
            this.pic_map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFont)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_map)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chế độ";
            // 
            // rbRiengTu
            // 
            this.rbRiengTu.AutoSize = true;
            this.rbRiengTu.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.rbRiengTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRiengTu.Location = new System.Drawing.Point(265, 98);
            this.rbRiengTu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbRiengTu.Name = "rbRiengTu";
            this.rbRiengTu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbRiengTu.Size = new System.Drawing.Size(114, 29);
            this.rbRiengTu.TabIndex = 26;
            this.rbRiengTu.TabStop = true;
            this.rbRiengTu.Text = "Riêng tư";
            this.rbRiengTu.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbRiengTu.UseVisualStyleBackColor = true;
            // 
            // rbCongKhai
            // 
            this.rbCongKhai.AutoSize = true;
            this.rbCongKhai.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.rbCongKhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCongKhai.Location = new System.Drawing.Point(120, 98);
            this.rbCongKhai.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbCongKhai.Name = "rbCongKhai";
            this.rbCongKhai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbCongKhai.Size = new System.Drawing.Size(132, 29);
            this.rbCongKhai.TabIndex = 25;
            this.rbCongKhai.TabStop = true;
            this.rbCongKhai.Text = "Công khai";
            this.rbCongKhai.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbCongKhai.UseVisualStyleBackColor = true;
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLuuThayDoi.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnLuuThayDoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuuThayDoi.BorderRadius = 10;
            this.btnLuuThayDoi.BorderSize = 0;
            this.btnLuuThayDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuThayDoi.FlatAppearance.BorderSize = 0;
            this.btnLuuThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(20, 10);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(752, 60);
            this.btnLuuThayDoi.TabIndex = 24;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.TextColor = System.Drawing.Color.White;
            this.btnLuuThayDoi.UseVisualStyleBackColor = false;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Location = new System.Drawing.Point(24, 156);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(752, 239);
            this.rtbStatus.TabIndex = 23;
            this.rtbStatus.TabStop = false;
            this.rtbStatus.Text = "";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(108, 62);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 22;
            this.lbTime.Text = "label2";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(107, 22);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(70, 25);
            this.lbUser.TabIndex = 21;
            this.lbUser.Text = "label1";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatar.BorderColor = System.Drawing.Color.White;
            this.pbAvatar.BorderColor2 = System.Drawing.Color.White;
            this.pbAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatar.BorderSize = 2;
            this.pbAvatar.GradientAngle = 50F;
            this.pbAvatar.Location = new System.Drawing.Point(27, 22);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(60, 60);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 20;
            this.pbAvatar.TabStop = false;
            // 
            // pbFont
            // 
            this.pbFont.BackgroundImage = global::Blog.Properties.Resources.font_icon;
            this.pbFont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFont.Location = new System.Drawing.Point(716, 82);
            this.pbFont.Margin = new System.Windows.Forms.Padding(4);
            this.pbFont.Name = "pbFont";
            this.pbFont.Size = new System.Drawing.Size(56, 45);
            this.pbFont.TabIndex = 28;
            this.pbFont.TabStop = false;
            this.pbFont.Click += new System.EventHandler(this.pbFont_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuuThayDoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 586);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 29;
            // 
            // flpnImage
            // 
            this.flpnImage.BackColor = System.Drawing.SystemColors.Control;
            this.flpnImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnImage.Location = new System.Drawing.Point(0, 401);
            this.flpnImage.Name = "flpnImage";
            this.flpnImage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flpnImage.Size = new System.Drawing.Size(800, 185);
            this.flpnImage.TabIndex = 30;
            this.flpnImage.Visible = false;
            // 
            // pbColor
            // 
            this.pbColor.BackgroundImage = global::Blog.Properties.Resources.color;
            this.pbColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbColor.Location = new System.Drawing.Point(635, 82);
            this.pbColor.Margin = new System.Windows.Forms.Padding(4);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(45, 46);
            this.pbColor.TabIndex = 31;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // pbAddMusic
            // 
            this.pbAddMusic.BackgroundImage = global::Blog.Properties.Resources.music_add;
            this.pbAddMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddMusic.Location = new System.Drawing.Point(556, 82);
            this.pbAddMusic.Margin = new System.Windows.Forms.Padding(4);
            this.pbAddMusic.Name = "pbAddMusic";
            this.pbAddMusic.Size = new System.Drawing.Size(45, 46);
            this.pbAddMusic.TabIndex = 32;
            this.pbAddMusic.TabStop = false;
            this.pbAddMusic.Click += new System.EventHandler(this.pbAddMusic_Click);
            // 
            // pic_map
            // 
            this.pic_map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_map.BackgroundImage")));
            this.pic_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_map.Location = new System.Drawing.Point(477, 82);
            this.pic_map.Margin = new System.Windows.Forms.Padding(4);
            this.pic_map.Name = "pic_map";
            this.pic_map.Size = new System.Drawing.Size(49, 46);
            this.pic_map.TabIndex = 33;
            this.pic_map.TabStop = false;
            this.pic_map.Click += new System.EventHandler(this.pic_map_Click);
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.pic_map);
            this.Controls.Add(this.pbAddMusic);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.flpnImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRiengTu);
            this.Controls.Add(this.rbCongKhai);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbAvatar);
            this.Name = "EditPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.EditPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFont)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJRadioButton rbRiengTu;
        private CustomControls.RJControls.RJRadioButton rbCongKhai;
        private CustomControls.RJControls.RJButton btnLuuThayDoi;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbUser;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbFont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpnImage;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.PictureBox pbAddMusic;
        private System.Windows.Forms.PictureBox pic_map;
    }
}