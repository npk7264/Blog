namespace Blog.Component
{
    partial class Post
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.pnSetting1 = new CustomControls.RJControls.RJPanel();
            this.btnChinhSua = new CustomControls.RJControls.RJButton();
            this.btnXoa = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            this.pnSetting1.SuspendLayout();
            this.SuspendLayout();
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
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(100, 15);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(70, 25);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "label1";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(101, 55);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "label2";
            // 
            // rtbStatus
            // 
            this.rtbStatus.Location = new System.Drawing.Point(20, 100);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(752, 227);
            this.rtbStatus.TabIndex = 3;
            this.rtbStatus.Text = "";
            // 
            // pbLike
            // 
            this.pbLike.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbLike.Location = new System.Drawing.Point(20, 350);
            this.pbLike.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(60, 60);
            this.pbLike.TabIndex = 4;
            this.pbLike.TabStop = false;
            this.pbLike.Click += new System.EventHandler(this.pbLike_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(344, 350);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(712, 350);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pbSetting
            // 
            this.pbSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSetting.Location = new System.Drawing.Point(712, 15);
            this.pbSetting.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(60, 60);
            this.pbSetting.TabIndex = 7;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // pnSetting1
            // 
            this.pnSetting1.BackColor = System.Drawing.Color.White;
            this.pnSetting1.BorderRadius = 30;
            this.pnSetting1.Controls.Add(this.btnXoa);
            this.pnSetting1.Controls.Add(this.btnChinhSua);
            this.pnSetting1.ForeColor = System.Drawing.Color.Black;
            this.pnSetting1.GradientAngle = 90F;
            this.pnSetting1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.pnSetting1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.pnSetting1.Location = new System.Drawing.Point(492, 81);
            this.pnSetting1.Name = "pnSetting1";
            this.pnSetting1.Size = new System.Drawing.Size(256, 200);
            this.pnSetting1.TabIndex = 8;
            this.pnSetting1.Visible = false;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChinhSua.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnChinhSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChinhSua.BorderRadius = 0;
            this.btnChinhSua.BorderSize = 0;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(60, 40);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(150, 40);
            this.btnChinhSua.TabIndex = 0;
            this.btnChinhSua.Text = "rjButton1";
            this.btnChinhSua.TextColor = System.Drawing.Color.White;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(60, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "rjButton2";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSetting1);
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbLike);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbAvatar);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(792, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            this.pnSetting1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.PictureBox pbLike;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbSetting;
        private CustomControls.RJControls.RJPanel pnSetting1;
        private CustomControls.RJControls.RJButton btnXoa;
        private CustomControls.RJControls.RJButton btnChinhSua;
    }
}
