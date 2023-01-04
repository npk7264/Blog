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
            this.label1 = new System.Windows.Forms.Label();
            this.rbRiengTu = new CustomControls.RJControls.RJRadioButton();
            this.rbCongKhai = new CustomControls.RJControls.RJRadioButton();
            this.btnLuuThayDoi = new CustomControls.RJControls.RJButton();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chế độ";
            // 
            // rbRiengTu
            // 
            this.rbRiengTu.AutoSize = true;
            this.rbRiengTu.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbRiengTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRiengTu.Location = new System.Drawing.Point(310, 133);
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
            this.rbCongKhai.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbCongKhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCongKhai.Location = new System.Drawing.Point(112, 133);
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
            this.btnLuuThayDoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuuThayDoi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLuuThayDoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuuThayDoi.BorderRadius = 0;
            this.btnLuuThayDoi.BorderSize = 0;
            this.btnLuuThayDoi.FlatAppearance.BorderSize = 0;
            this.btnLuuThayDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThayDoi.ForeColor = System.Drawing.Color.White;
            this.btnLuuThayDoi.Location = new System.Drawing.Point(27, 425);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(752, 40);
            this.btnLuuThayDoi.TabIndex = 24;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.TextColor = System.Drawing.Color.White;
            this.btnLuuThayDoi.UseVisualStyleBackColor = false;
            this.btnLuuThayDoi.Click += new System.EventHandler(this.btnLuuThayDoi_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.Location = new System.Drawing.Point(27, 192);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(752, 227);
            this.rtbStatus.TabIndex = 23;
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
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRiengTu);
            this.Controls.Add(this.rbCongKhai);
            this.Controls.Add(this.btnLuuThayDoi);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbAvatar);
            this.Name = "EditPost";
            this.Text = " ";
            this.Load += new System.EventHandler(this.EditPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
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
    }
}