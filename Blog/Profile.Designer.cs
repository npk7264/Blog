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
            this.btnCapNhatThongTin = new CustomControls.RJControls.RJButton();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.rjPanel2 = new CustomControls.RJControls.RJPanel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pbAvatarInStatus = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIconSearch = new System.Windows.Forms.PictureBox();
            this.pbAvatarLogin = new CustomControls.RJControls.RJCircularPictureBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.rjPanel1.SuspendLayout();
            this.rjPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarInStatus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(272, 511);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1071, 349);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(535, 166);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(98, 32);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "label1";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(536, 304);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(79, 29);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "label2";
            // 
            // btnCapNhatThongTin
            // 
            this.btnCapNhatThongTin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhatThongTin.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhatThongTin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatThongTin.BorderRadius = 10;
            this.btnCapNhatThongTin.BorderSize = 0;
            this.btnCapNhatThongTin.FlatAppearance.BorderSize = 0;
            this.btnCapNhatThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatThongTin.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatThongTin.Location = new System.Drawing.Point(843, 299);
            this.btnCapNhatThongTin.Name = "btnCapNhatThongTin";
            this.btnCapNhatThongTin.Size = new System.Drawing.Size(199, 57);
            this.btnCapNhatThongTin.TabIndex = 5;
            this.btnCapNhatThongTin.Text = "Cập nhật thông tin";
            this.btnCapNhatThongTin.TextColor = System.Drawing.Color.White;
            this.btnCapNhatThongTin.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTin.Click += new System.EventHandler(this.btnCapNhatThongTin_Click);
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
            this.pbAvatar.Location = new System.Drawing.Point(267, 136);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(20);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(220, 220);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
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
            this.rjPanel1.Location = new System.Drawing.Point(272, 388);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(800, 103);
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
            this.rjPanel2.Location = new System.Drawing.Point(133, 14);
            this.rjPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rjPanel2.Name = "rjPanel2";
            this.rjPanel2.Size = new System.Drawing.Size(647, 75);
            this.rjPanel2.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(15, 14);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(616, 47);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Bạn đang nghĩ gì?";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
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
            this.pbAvatarInStatus.Location = new System.Drawing.Point(20, 14);
            this.pbAvatarInStatus.Name = "pbAvatarInStatus";
            this.pbAvatarInStatus.Size = new System.Drawing.Size(75, 75);
            this.pbAvatarInStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarInStatus.TabIndex = 0;
            this.pbAvatarInStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbIconSearch);
            this.panel1.Controls.Add(this.pbAvatarLogin);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 100);
            this.panel1.TabIndex = 7;
            // 
            // pbIconSearch
            // 
            this.pbIconSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pbIconSearch.BackgroundImage = global::Blog.Properties.Resources.icon_search;
            this.pbIconSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIconSearch.Location = new System.Drawing.Point(1026, 32);
            this.pbIconSearch.Name = "pbIconSearch";
            this.pbIconSearch.Size = new System.Drawing.Size(36, 36);
            this.pbIconSearch.TabIndex = 3;
            this.pbIconSearch.TabStop = false;
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
            this.pbAvatarLogin.GradientAngle = 50F;
            this.pbAvatarLogin.Location = new System.Drawing.Point(1271, 12);
            this.pbAvatarLogin.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.pbAvatarLogin.Name = "pbAvatarLogin";
            this.pbAvatarLogin.Size = new System.Drawing.Size(80, 80);
            this.pbAvatarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarLogin.TabIndex = 1;
            this.pbAvatarLogin.TabStop = false;
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
            this.txtSearch.Location = new System.Drawing.Point(272, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(15, 17, 60, 17);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(800, 60);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Texts = "Tìm kiếm tài khoản";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.btnCapNhatThongTin);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarInStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbUsername;
        private CustomControls.RJControls.RJButton btnCapNhatThongTin;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private CustomControls.RJControls.RJPanel rjPanel2;
        private System.Windows.Forms.Label lbStatus;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarInStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIconSearch;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarLogin;
        private CustomControls.RJControls.RJTextBox txtSearch;
    }
}

