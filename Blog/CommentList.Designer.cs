namespace Blog
{
    partial class CommentList
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
            this.txtBinhLuan = new CustomControls.RJControls.RJTextBox();
            this.btnDangBinhLuan = new CustomControls.RJControls.RJButton();
            this.pbAvatarComment = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAvatarLogin = new CustomControls.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarComment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 98);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(907, 535);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtBinhLuan
            // 
            this.txtBinhLuan.BackColor = System.Drawing.Color.White;
            this.txtBinhLuan.BorderColor = System.Drawing.Color.Transparent;
            this.txtBinhLuan.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtBinhLuan.BorderRadius = 10;
            this.txtBinhLuan.BorderSize = 2;
            this.txtBinhLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinhLuan.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBinhLuan.Location = new System.Drawing.Point(184, 657);
            this.txtBinhLuan.Margin = new System.Windows.Forms.Padding(9, 24, 15, 3);
            this.txtBinhLuan.Multiline = false;
            this.txtBinhLuan.Name = "txtBinhLuan";
            this.txtBinhLuan.Padding = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.txtBinhLuan.PasswordChar = false;
            this.txtBinhLuan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBinhLuan.PlaceholderText = "";
            this.txtBinhLuan.Size = new System.Drawing.Size(530, 49);
            this.txtBinhLuan.TabIndex = 7;
            this.txtBinhLuan.Texts = "Bình luận";
            this.txtBinhLuan.UnderlinedStyle = false;
            // 
            // btnDangBinhLuan
            // 
            this.btnDangBinhLuan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangBinhLuan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangBinhLuan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangBinhLuan.BorderRadius = 10;
            this.btnDangBinhLuan.BorderSize = 0;
            this.btnDangBinhLuan.FlatAppearance.BorderSize = 0;
            this.btnDangBinhLuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangBinhLuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangBinhLuan.ForeColor = System.Drawing.Color.White;
            this.btnDangBinhLuan.Location = new System.Drawing.Point(729, 657);
            this.btnDangBinhLuan.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnDangBinhLuan.Name = "btnDangBinhLuan";
            this.btnDangBinhLuan.Size = new System.Drawing.Size(129, 49);
            this.btnDangBinhLuan.TabIndex = 8;
            this.btnDangBinhLuan.Text = "Đăng bình luận";
            this.btnDangBinhLuan.TextColor = System.Drawing.Color.White;
            this.btnDangBinhLuan.UseVisualStyleBackColor = false;
            this.btnDangBinhLuan.Click += new System.EventHandler(this.btnDangBinhLuan_Click);
            // 
            // pbAvatarComment
            // 
            this.pbAvatarComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatarComment.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatarComment.BorderColor = System.Drawing.Color.White;
            this.pbAvatarComment.BorderColor2 = System.Drawing.Color.White;
            this.pbAvatarComment.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatarComment.BorderSize = 2;
            this.pbAvatarComment.GradientAngle = 50F;
            this.pbAvatarComment.Location = new System.Drawing.Point(128, 657);
            this.pbAvatarComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAvatarComment.Name = "pbAvatarComment";
            this.pbAvatarComment.Size = new System.Drawing.Size(45, 45);
            this.pbAvatarComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarComment.TabIndex = 5;
            this.pbAvatarComment.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbAvatarLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 81);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bình luận về bài viết";
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
            this.pbAvatarLogin.Location = new System.Drawing.Point(953, 10);
            this.pbAvatarLogin.Margin = new System.Windows.Forms.Padding(2, 2, 15, 2);
            this.pbAvatarLogin.Name = "pbAvatarLogin";
            this.pbAvatarLogin.Size = new System.Drawing.Size(60, 60);
            this.pbAvatarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarLogin.TabIndex = 1;
            this.pbAvatarLogin.TabStop = false;
            // 
            // CommentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1035, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangBinhLuan);
            this.Controls.Add(this.txtBinhLuan);
            this.Controls.Add(this.pbAvatarComment);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CommentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentList";
            this.Load += new System.EventHandler(this.CommentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarComment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarComment;
        private CustomControls.RJControls.RJTextBox txtBinhLuan;
        private CustomControls.RJControls.RJButton btnDangBinhLuan;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarLogin;
        private System.Windows.Forms.Label label1;
    }
}