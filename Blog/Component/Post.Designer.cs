﻿namespace Blog.Component
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.pnSetting1 = new CustomControls.RJControls.RJPanel();
            this.btnXoa = new CustomControls.RJControls.RJButton();
            this.btnChinhSua = new CustomControls.RJControls.RJButton();
            this.pnSetting0 = new CustomControls.RJControls.RJPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSoComment = new System.Windows.Forms.Label();
            this.lbSoLike = new System.Windows.Forms.Label();
            this.flpnImage = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLuu = new System.Windows.Forms.PictureBox();
            this.pbComment = new System.Windows.Forms.PictureBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new CustomControls.RJControls.RJCircularPictureBox();
            this.pnSetting1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLuu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.rtbStatus.BackColor = System.Drawing.Color.White;
            this.rtbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStatus.Location = new System.Drawing.Point(20, 100);
            this.rtbStatus.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.Size = new System.Drawing.Size(752, 164);
            this.rtbStatus.TabIndex = 3;
            this.rtbStatus.TabStop = false;
            this.rtbStatus.Text = "";
            // 
            // pnSetting1
            // 
            this.pnSetting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnSetting1.BorderRadius = 30;
            this.pnSetting1.Controls.Add(this.btnXoa);
            this.pnSetting1.Controls.Add(this.btnChinhSua);
            this.pnSetting1.ForeColor = System.Drawing.Color.Black;
            this.pnSetting1.GradientAngle = 90F;
            this.pnSetting1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.pnSetting1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.pnSetting1.Location = new System.Drawing.Point(509, 24);
            this.pnSetting1.Name = "pnSetting1";
            this.pnSetting1.Size = new System.Drawing.Size(217, 99);
            this.pnSetting1.TabIndex = 8;
            this.pnSetting1.Visible = false;
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
            this.btnXoa.Location = new System.Drawing.Point(60, 49);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "rjButton2";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnChinhSua.Location = new System.Drawing.Point(60, 3);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(150, 40);
            this.btnChinhSua.TabIndex = 0;
            this.btnChinhSua.Text = "rjButton1";
            this.btnChinhSua.TextColor = System.Drawing.Color.White;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // pnSetting0
            // 
            this.pnSetting0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnSetting0.BorderRadius = 30;
            this.pnSetting0.ForeColor = System.Drawing.Color.Black;
            this.pnSetting0.GradientAngle = 90F;
            this.pnSetting0.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.pnSetting0.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.pnSetting0.Location = new System.Drawing.Point(509, 24);
            this.pnSetting0.Name = "pnSetting0";
            this.pnSetting0.Size = new System.Drawing.Size(217, 99);
            this.pnSetting0.TabIndex = 9;
            this.pnSetting0.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbSoComment);
            this.panel1.Controls.Add(this.lbSoLike);
            this.panel1.Controls.Add(this.pbLuu);
            this.panel1.Controls.Add(this.pbComment);
            this.panel1.Controls.Add(this.pbLike);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 136);
            this.panel1.TabIndex = 10;
            // 
            // lbSoComment
            // 
            this.lbSoComment.AutoSize = true;
            this.lbSoComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoComment.Location = new System.Drawing.Point(640, 11);
            this.lbSoComment.Name = "lbSoComment";
            this.lbSoComment.Size = new System.Drawing.Size(135, 25);
            this.lbSoComment.TabIndex = 16;
            this.lbSoComment.Text = "Lượt comment";
            // 
            // lbSoLike
            // 
            this.lbSoLike.AutoSize = true;
            this.lbSoLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLike.Location = new System.Drawing.Point(17, 11);
            this.lbSoLike.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lbSoLike.Name = "lbSoLike";
            this.lbSoLike.Size = new System.Drawing.Size(84, 25);
            this.lbSoLike.TabIndex = 15;
            this.lbSoLike.Text = "Lượt like";
            // 
            // flpnImage
            // 
            this.flpnImage.BackColor = System.Drawing.Color.White;
            this.flpnImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpnImage.Location = new System.Drawing.Point(0, 280);
            this.flpnImage.Name = "flpnImage";
            this.flpnImage.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flpnImage.Size = new System.Drawing.Size(792, 185);
            this.flpnImage.TabIndex = 11;
            // 
            // pbLuu
            // 
            this.pbLuu.BackColor = System.Drawing.Color.Transparent;
            this.pbLuu.BackgroundImage = global::Blog.Properties.Resources.icon_save;
            this.pbLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLuu.Location = new System.Drawing.Point(715, 66);
            this.pbLuu.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pbLuu.Name = "pbLuu";
            this.pbLuu.Size = new System.Drawing.Size(60, 60);
            this.pbLuu.TabIndex = 14;
            this.pbLuu.TabStop = false;
            // 
            // pbComment
            // 
            this.pbComment.BackColor = System.Drawing.Color.Transparent;
            this.pbComment.BackgroundImage = global::Blog.Properties.Resources.icon_cmt;
            this.pbComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbComment.Location = new System.Drawing.Point(344, 66);
            this.pbComment.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pbComment.Name = "pbComment";
            this.pbComment.Size = new System.Drawing.Size(60, 60);
            this.pbComment.TabIndex = 13;
            this.pbComment.TabStop = false;
            this.pbComment.Click += new System.EventHandler(this.pbComment_Click);
            // 
            // pbLike
            // 
            this.pbLike.BackColor = System.Drawing.Color.Transparent;
            this.pbLike.BackgroundImage = global::Blog.Properties.Resources.icon_like;
            this.pbLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLike.Location = new System.Drawing.Point(22, 66);
            this.pbLike.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(60, 60);
            this.pbLike.TabIndex = 12;
            this.pbLike.TabStop = false;
            this.pbLike.Click += new System.EventHandler(this.pbLike_Click);
            // 
            // pbSetting
            // 
            this.pbSetting.BackColor = System.Drawing.Color.Transparent;
            this.pbSetting.BackgroundImage = global::Blog.Properties.Resources.icon_menu;
            this.pbSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSetting.Location = new System.Drawing.Point(732, 24);
            this.pbSetting.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(40, 40);
            this.pbSetting.TabIndex = 7;
            this.pbSetting.TabStop = false;
            this.pbSetting.Click += new System.EventHandler(this.pbSetting_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.Silver;
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvatar.BorderColor = System.Drawing.Color.White;
            this.pbAvatar.BorderColor2 = System.Drawing.Color.White;
            this.pbAvatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvatar.BorderSize = 2;
            this.pbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvatar.GradientAngle = 50F;
            this.pbAvatar.Location = new System.Drawing.Point(20, 15);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(60, 60);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpnImage);
            this.Controls.Add(this.pnSetting1);
            this.Controls.Add(this.pnSetting0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSetting);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbAvatar);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(792, 601);
            this.Load += new System.EventHandler(this.Post_Load);
            this.pnSetting1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLuu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pbAvatar;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.PictureBox pbSetting;
        private CustomControls.RJControls.RJPanel pnSetting1;
        private CustomControls.RJControls.RJButton btnXoa;
        private CustomControls.RJControls.RJButton btnChinhSua;
        private CustomControls.RJControls.RJPanel pnSetting0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSoComment;
        private System.Windows.Forms.Label lbSoLike;
        private System.Windows.Forms.PictureBox pbLuu;
        private System.Windows.Forms.PictureBox pbComment;
        private System.Windows.Forms.PictureBox pbLike;
        private System.Windows.Forms.FlowLayoutPanel flpnImage;
    }
}