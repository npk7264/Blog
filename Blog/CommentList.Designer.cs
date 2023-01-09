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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbAvatarComment = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarComment)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(171, 121);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1209, 658);
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
            this.txtBinhLuan.Location = new System.Drawing.Point(245, 809);
            this.txtBinhLuan.Margin = new System.Windows.Forms.Padding(12, 30, 20, 4);
            this.txtBinhLuan.Multiline = false;
            this.txtBinhLuan.Name = "txtBinhLuan";
            this.txtBinhLuan.Padding = new System.Windows.Forms.Padding(11, 17, 11, 17);
            this.txtBinhLuan.PasswordChar = false;
            this.txtBinhLuan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBinhLuan.PlaceholderText = "";
            this.txtBinhLuan.Size = new System.Drawing.Size(707, 60);
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
            this.btnDangBinhLuan.Location = new System.Drawing.Point(972, 809);
            this.btnDangBinhLuan.Margin = new System.Windows.Forms.Padding(0, 2, 3, 2);
            this.btnDangBinhLuan.Name = "btnDangBinhLuan";
            this.btnDangBinhLuan.Size = new System.Drawing.Size(172, 60);
            this.btnDangBinhLuan.TabIndex = 8;
            this.btnDangBinhLuan.Text = "Đăng bình luận";
            this.btnDangBinhLuan.TextColor = System.Drawing.Color.White;
            this.btnDangBinhLuan.UseVisualStyleBackColor = false;
            this.btnDangBinhLuan.Click += new System.EventHandler(this.btnDangBinhLuan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 100);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bình luận về bài viết";
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BackgroundImage = global::Blog.Properties.Resources.back_icon;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Location = new System.Drawing.Point(64, 10);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(80, 80);
            this.pbBack.TabIndex = 3;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbAvatarComment
            // 
            this.pbAvatarComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatarComment.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatarComment.BorderColor = System.Drawing.Color.Transparent;
            this.pbAvatarComment.BorderColor2 = System.Drawing.Color.Transparent;
            this.pbAvatarComment.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatarComment.BorderSize = 2;
            this.pbAvatarComment.GradientAngle = 50F;
            this.pbAvatarComment.Location = new System.Drawing.Point(171, 809);
            this.pbAvatarComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatarComment.Name = "pbAvatarComment";
            this.pbAvatarComment.Size = new System.Drawing.Size(60, 60);
            this.pbAvatarComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatarComment.TabIndex = 5;
            this.pbAvatarComment.TabStop = false;
            // 
            // CommentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1380, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangBinhLuan);
            this.Controls.Add(this.txtBinhLuan);
            this.Controls.Add(this.pbAvatarComment);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CommentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommentList";
            this.Load += new System.EventHandler(this.CommentList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatarComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatarComment;
        private CustomControls.RJControls.RJTextBox txtBinhLuan;
        private CustomControls.RJControls.RJButton btnDangBinhLuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBack;
    }
}