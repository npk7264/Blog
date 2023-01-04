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
            this.lbTime = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.rbCongKhai = new CustomControls.RJControls.RJRadioButton();
            this.rbRiengTu = new CustomControls.RJControls.RJRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpnImage = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAddImage = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangBai
            // 
            this.btnDangBai.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangBai.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangBai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangBai.BorderRadius = 10;
            this.btnDangBai.BorderSize = 0;
            this.btnDangBai.FlatAppearance.BorderSize = 0;
            this.btnDangBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangBai.ForeColor = System.Drawing.Color.White;
            this.btnDangBai.Location = new System.Drawing.Point(20, 10);
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
            this.rtbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.rtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.Location = new System.Drawing.Point(20, 156);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(752, 239);
            this.rtbStatus.TabIndex = 15;
            this.rtbStatus.Text = "";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(101, 55);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "label2";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(100, 15);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(70, 25);
            this.lbUser.TabIndex = 13;
            this.lbUser.Text = "label1";
            // 
            // rbCongKhai
            // 
            this.rbCongKhai.AutoSize = true;
            this.rbCongKhai.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbCongKhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCongKhai.Location = new System.Drawing.Point(105, 98);
            this.rbCongKhai.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbCongKhai.Name = "rbCongKhai";
            this.rbCongKhai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbCongKhai.Size = new System.Drawing.Size(132, 29);
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
            this.rbRiengTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRiengTu.Location = new System.Drawing.Point(257, 98);
            this.rbRiengTu.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbRiengTu.Name = "rbRiengTu";
            this.rbRiengTu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbRiengTu.Size = new System.Drawing.Size(114, 29);
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
            this.panel1.Location = new System.Drawing.Point(0, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 20;
            // 
            // flpnImage
            // 
            this.flpnImage.BackColor = System.Drawing.Color.White;
            this.flpnImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnImage.Location = new System.Drawing.Point(0, 461);
            this.flpnImage.Name = "flpnImage";
            this.flpnImage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flpnImage.Size = new System.Drawing.Size(800, 185);
            this.flpnImage.TabIndex = 21;
            this.flpnImage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbAddImage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 60);
            this.panel2.TabIndex = 22;
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
            // pbAddImage
            // 
            this.pbAddImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAddImage.BackgroundImage")));
            this.pbAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAddImage.Location = new System.Drawing.Point(284, 8);
            this.pbAddImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbAddImage.Name = "pbAddImage";
            this.pbAddImage.Size = new System.Drawing.Size(45, 45);
            this.pbAddImage.TabIndex = 24;
            this.pbAddImage.TabStop = false;
            this.pbAddImage.Click += new System.EventHandler(this.pbAddImage_Click);
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
            this.pbAvatar.Location = new System.Drawing.Point(20, 15);
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
            this.ClientSize = new System.Drawing.Size(800, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpnImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRiengTu);
            this.Controls.Add(this.rbCongKhai);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbAvatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPost";
            this.Load += new System.EventHandler(this.NewPost_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnDangBai;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lbTime;
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
    }
}