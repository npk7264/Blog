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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCongViec = new System.Windows.Forms.Label();
            this.btnCapNhatAvatar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(579, 82);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(79, 29);
            this.lbUsername.TabIndex = 10;
            this.lbUsername.Text = "label2";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(535, 36);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(98, 32);
            this.lbTen.TabIndex = 9;
            this.lbTen.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(272, 276);
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
            this.pbAvatar.Location = new System.Drawing.Point(267, 36);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(20);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(220, 220);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 8;
            this.pbAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "@";
            // 
            // lbCongViec
            // 
            this.lbCongViec.AutoSize = true;
            this.lbCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongViec.Location = new System.Drawing.Point(536, 135);
            this.lbCongViec.Name = "lbCongViec";
            this.lbCongViec.Size = new System.Drawing.Size(155, 29);
            this.lbCongViec.TabIndex = 13;
            this.lbCongViec.Text = "Lập trình viên";
            // 
            // btnCapNhatAvatar
            // 
            this.btnCapNhatAvatar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhatAvatar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnCapNhatAvatar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhatAvatar.BorderRadius = 10;
            this.btnCapNhatAvatar.BorderSize = 0;
            this.btnCapNhatAvatar.FlatAppearance.BorderSize = 0;
            this.btnCapNhatAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatAvatar.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatAvatar.Location = new System.Drawing.Point(541, 187);
            this.btnCapNhatAvatar.Name = "btnCapNhatAvatar";
            this.btnCapNhatAvatar.Size = new System.Drawing.Size(250, 57);
            this.btnCapNhatAvatar.TabIndex = 14;
            this.btnCapNhatAvatar.Text = "Cập nhật ảnh đại diện";
            this.btnCapNhatAvatar.TextColor = System.Drawing.Color.White;
            this.btnCapNhatAvatar.UseVisualStyleBackColor = false;
            // 
            // OtherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 800);
            this.Controls.Add(this.btnCapNhatAvatar);
            this.Controls.Add(this.lbCongViec);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbTen;
        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCongViec;
        private CustomControls.RJControls.RJButton btnCapNhatAvatar;
    }
}