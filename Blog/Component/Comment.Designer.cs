namespace Blog.Component
{
    partial class Comment
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
            this.lbComment = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            this.pbAvtComment = new CustomControls.RJControls.RJCircularPictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.rjPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvtComment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(14, 5);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(70, 25);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "label1";
            // 
            // lbComment
            // 
            this.lbComment.AutoSize = true;
            this.lbComment.BackColor = System.Drawing.Color.Transparent;
            this.lbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComment.Location = new System.Drawing.Point(14, 40);
            this.lbComment.Name = "lbComment";
            this.lbComment.Size = new System.Drawing.Size(64, 25);
            this.lbComment.TabIndex = 3;
            this.lbComment.Text = "label2";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.Controls.Add(this.lbUser);
            this.rjPanel1.Controls.Add(this.lbComment);
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.rjPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.rjPanel1.Location = new System.Drawing.Point(75, 0);
            this.rjPanel1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(707, 80);
            this.rjPanel1.TabIndex = 4;
            // 
            // pbAvtComment
            // 
            this.pbAvtComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvtComment.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbAvtComment.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbAvtComment.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbAvtComment.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbAvtComment.BorderSize = 2;
            this.pbAvtComment.GradientAngle = 50F;
            this.pbAvtComment.Location = new System.Drawing.Point(0, 5);
            this.pbAvtComment.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pbAvtComment.Name = "pbAvtComment";
            this.pbAvtComment.Size = new System.Drawing.Size(60, 60);
            this.pbAvtComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvtComment.TabIndex = 0;
            this.pbAvtComment.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTime.Location = new System.Drawing.Point(90, 87);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(53, 20);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "label2";
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.rjPanel1);
            this.Controls.Add(this.pbAvtComment);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(786, 110);
            this.Load += new System.EventHandler(this.Comment_Load);
            this.rjPanel1.ResumeLayout(false);
            this.rjPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvtComment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pbAvtComment;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbComment;
        private CustomControls.RJControls.RJPanel rjPanel1;
        private System.Windows.Forms.Label lbTime;
    }
}
