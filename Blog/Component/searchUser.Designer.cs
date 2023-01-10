
namespace Blog.Component
{
    partial class searchUser
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
            this.lb_name = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pic_avt = new CustomControls.RJControls.RJCircularPictureBox();
            this.lbJob = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(141, 18);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(90, 31);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.White;
            this.lbUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(177, 68);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(99, 25);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "username";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // pic_avt
            // 
            this.pic_avt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_avt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avt.BorderColor = System.Drawing.Color.White;
            this.pic_avt.BorderColor2 = System.Drawing.Color.White;
            this.pic_avt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avt.BorderSize = 2;
            this.pic_avt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_avt.GradientAngle = 50F;
            this.pic_avt.Location = new System.Drawing.Point(4, 4);
            this.pic_avt.Margin = new System.Windows.Forms.Padding(4);
            this.pic_avt.Name = "pic_avt";
            this.pic_avt.Size = new System.Drawing.Size(113, 113);
            this.pic_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avt.TabIndex = 0;
            this.pic_avt.TabStop = false;
            this.pic_avt.Click += new System.EventHandler(this.pic_avt_Click);
            // 
            // lbJob
            // 
            this.lbJob.AutoSize = true;
            this.lbJob.BackColor = System.Drawing.Color.White;
            this.lbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJob.Location = new System.Drawing.Point(539, 68);
            this.lbJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(45, 25);
            this.lbJob.TabIndex = 3;
            this.lbJob.Text = "Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "@";
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 10;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(792, 118);
            this.rjPanel1.TabIndex = 5;
            // 
            // searchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbJob);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pic_avt);
            this.Controls.Add(this.rjPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "searchUser";
            this.Size = new System.Drawing.Size(792, 118);
            this.Load += new System.EventHandler(this.searchUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pic_avt;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbJob;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJPanel rjPanel1;
    }
}
