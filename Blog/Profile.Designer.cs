namespace Blog
{
    partial class Profile
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhatAvatar = new CustomControls.RJControls.RJButton();
            this.lbCongViec = new System.Windows.Forms.Label();
            this.pbMatKhau = new System.Windows.Forms.PictureBox();
            this.pbListFriend = new System.Windows.Forms.PictureBox();
            this.pbThuMucAnh = new System.Windows.Forms.PictureBox();
            this.pbAvatarInStatus = new CustomControls.RJControls.RJCircularPictureBox();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThuMucAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarInStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 334);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 0, 8, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 284);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(206, 29);
            this.lbTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(76, 26);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "label1";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(238, 67);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(60, 24);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "label2";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.rjPanel2);
            this.rjPanel1.Controls.Add(this.pbAvatarInStatus);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(8, 234);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(594, 84);
            this.rjPanel1.TabIndex = 6;
            // 
            // rjPanel2
            // 
            this.rjPanel2.BackColor = System.Drawing.Color.White;
            this.rjPanel2.BorderRadius = 30;
            this.rjPanel2.Controls.Add(this.lbStatus);
            this.rjPanel2.ForeColor = System.Drawing.Color.Black;
            this.rjPanel2.GradientAngle = 90F;
            this.rjPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.rjPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.rjPanel2.Location = new System.Drawing.Point(100, 11);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(479, 61);
            this.rjPanel2.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(11, 11);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(455, 38);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Bạn đang nghĩ gì?";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "@";
            // 
            // btnCapNhatAvatar
            // 
            this.btnCapNhatAvatar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhatAvatar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhatAvatar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatAvatar.BorderRadius = 10;
            this.btnCapNhatAvatar.BorderSize = 0;
            this.btnCapNhatAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatAvatar.FlatAppearance.BorderSize = 0;
            this.btnCapNhatAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatAvatar.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatAvatar.Location = new System.Drawing.Point(209, 152);
            this.btnCapNhatAvatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhatAvatar.Name = "btnCapNhatAvatar";
            this.btnCapNhatAvatar.Size = new System.Drawing.Size(202, 46);
            this.btnCapNhatAvatar.TabIndex = 9;
            this.btnCapNhatAvatar.Text = "Cập nhật ảnh đại diện";
            this.btnCapNhatAvatar.TextColor = System.Drawing.Color.White;
            this.btnCapNhatAvatar.UseVisualStyleBackColor = false;
            this.btnCapNhatAvatar.Click += new System.EventHandler(this.btnCapNhatAvatar_Click);
            // 
            // lbCongViec
            // 
            this.lbCongViec.AutoSize = true;
            this.lbCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongViec.Location = new System.Drawing.Point(206, 110);
            this.lbCongViec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCongViec.Name = "lbCongViec";
            this.lbCongViec.Size = new System.Drawing.Size(151, 24);
            this.lbCongViec.TabIndex = 10;
            this.lbCongViec.Text = "Cầu thủ bóng đá";
            // 
            // pbMatKhau
            // 
            this.pbMatKhau.BackgroundImage = global::Blog.Properties.Resources.password;
            this.pbMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMatKhau.Location = new System.Drawing.Point(557, 152);
            this.pbMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.pbMatKhau.Name = "pbMatKhau";
            this.pbMatKhau.Size = new System.Drawing.Size(45, 46);
            this.pbMatKhau.TabIndex = 18;
            this.pbMatKhau.TabStop = false;
            this.pbMatKhau.Click += new System.EventHandler(this.pbMatKhau_Click);
            // 
            // pbListFriend
            // 
            this.pbListFriend.BackgroundImage = global::Blog.Properties.Resources.listfriend;
            this.pbListFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbListFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbListFriend.Location = new System.Drawing.Point(427, 152);
            this.pbListFriend.Margin = new System.Windows.Forms.Padding(2);
            this.pbListFriend.Name = "pbListFriend";
            this.pbListFriend.Size = new System.Drawing.Size(45, 46);
            this.pbListFriend.TabIndex = 17;
            this.pbListFriend.TabStop = false;
            this.pbListFriend.Click += new System.EventHandler(this.pbListFriend_Click);
            // 
            // pbThuMucAnh
            // 
            this.pbThuMucAnh.BackgroundImage = global::Blog.Properties.Resources.gallery_icon;
            this.pbThuMucAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbThuMucAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbThuMucAnh.Location = new System.Drawing.Point(492, 152);
            this.pbThuMucAnh.Margin = new System.Windows.Forms.Padding(2);
            this.pbThuMucAnh.Name = "pbThuMucAnh";
            this.pbThuMucAnh.Size = new System.Drawing.Size(45, 46);
            this.pbThuMucAnh.TabIndex = 11;
            this.pbThuMucAnh.TabStop = false;
            this.pbThuMucAnh.Click += new System.EventHandler(this.pbThuMucAnh_Click);
            // 
            // pbAvatarInStatus
            // 
            this.pbAvatarInStatus.BackColor = System.Drawing.Color.Silver;
            this.pbAvatarInStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatarInStatus.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatarInStatus.BorderColor = System.Drawing.Color.Transparent;
            this.pbAvatarInStatus.BorderColor2 = System.Drawing.Color.Transparent;
            this.pbAvatarInStatus.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatarInStatus.BorderSize = 2;
            this.pbAvatarInStatus.GradientAngle = 50F;
            this.pbAvatarInStatus.Location = new System.Drawing.Point(15, 11);
            this.pbAvatarInStatus.Margin = new System.Windows.Forms.Padding(2);
            this.pbAvatarInStatus.Name = "pbAvatarInStatus";
            this.pbAvatarInStatus.Size = new System.Drawing.Size(56, 56);
            this.pbAvatarInStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarInStatus.TabIndex = 0;
            this.pbAvatarInStatus.TabStop = false;
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatar.BorderColor = System.Drawing.Color.White;
            this.pbAvatar.BorderColor2 = System.Drawing.Color.White;
            this.pbAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatar.BorderSize = 5;
            this.pbAvatar.GradientAngle = 50F;
            this.pbAvatar.Location = new System.Drawing.Point(8, 29);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(165, 165);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(668, 650);
            this.Controls.Add(this.pbMatKhau);
            this.Controls.Add(this.pbListFriend);
            this.Controls.Add(this.pbThuMucAnh);
            this.Controls.Add(this.lbCongViec);
            this.Controls.Add(this.btnCapNhatAvatar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThuMucAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarInStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbUsername;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJPanel rjPanel2;
        private System.Windows.Forms.Label lbStatus;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarInStatus;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnCapNhatAvatar;
        private System.Windows.Forms.Label lbCongViec;
        private System.Windows.Forms.PictureBox pbThuMucAnh;
        private System.Windows.Forms.PictureBox pbListFriend;
        private System.Windows.Forms.PictureBox pbMatKhau;
    }
}

