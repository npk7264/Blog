namespace Blog
{
    partial class OtherProfile
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIconSearch = new System.Windows.Forms.PictureBox();
            this.pbAvatarLogin = new CustomControls.RJControls.RJCircularPictureBox();
            this.txtSearch = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(536, 304);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(79, 29);
            this.lbUsername.TabIndex = 10;
            this.lbUsername.Text = "label2";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(535, 166);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(98, 32);
            this.lbTen.TabIndex = 9;
            this.lbTen.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(272, 376);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1071, 488);
            this.flowLayoutPanel1.TabIndex = 7;
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
            this.pbAvatar.TabIndex = 8;
            this.pbAvatar.TabStop = false;
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
            this.panel1.TabIndex = 11;
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
            // OtherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtherProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtherProfile";
            this.Load += new System.EventHandler(this.OtherProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbTen;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbIconSearch;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarLogin;
        private CustomControls.RJControls.RJTextBox txtSearch;
    }
}