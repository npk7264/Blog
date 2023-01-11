
namespace Blog.Component
{
    partial class FriendChat
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
            this.pic_avr = new CustomControls.RJControls.RJCircularPictureBox();
            this.pbOnl = new CustomControls.RJControls.RJCircularPictureBox();
            this.rjPanel1 = new CustomControls.RJControls.RJPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnl)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.White;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(83, 23);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(70, 20);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "lb_name";
            // 
            // pic_avr
            // 
            this.pic_avr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_avr.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_avr.BorderColor = System.Drawing.Color.White;
            this.pic_avr.BorderColor2 = System.Drawing.Color.White;
            this.pic_avr.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_avr.BorderSize = 2;
            this.pic_avr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_avr.GradientAngle = 50F;
            this.pic_avr.Location = new System.Drawing.Point(4, 9);
            this.pic_avr.Name = "pic_avr";
            this.pic_avr.Size = new System.Drawing.Size(48, 48);
            this.pic_avr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avr.TabIndex = 0;
            this.pic_avr.TabStop = false;
            this.pic_avr.Click += new System.EventHandler(this.pic_avr_Click);
            // 
            // pbOnl
            // 
            this.pbOnl.BackColor = System.Drawing.Color.Silver;
            this.pbOnl.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbOnl.BorderColor = System.Drawing.Color.Transparent;
            this.pbOnl.BorderColor2 = System.Drawing.Color.Transparent;
            this.pbOnl.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbOnl.BorderSize = 2;
            this.pbOnl.GradientAngle = 50F;
            this.pbOnl.Location = new System.Drawing.Point(286, 18);
            this.pbOnl.Margin = new System.Windows.Forms.Padding(2);
            this.pbOnl.Name = "pbOnl";
            this.pbOnl.Size = new System.Drawing.Size(28, 28);
            this.pbOnl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOnl.TabIndex = 2;
            this.pbOnl.TabStop = false;
            // 
            // rjPanel1
            // 
            this.rjPanel1.BackColor = System.Drawing.Color.White;
            this.rjPanel1.BorderRadius = 30;
            this.rjPanel1.ForeColor = System.Drawing.Color.Black;
            this.rjPanel1.GradientAngle = 90F;
            this.rjPanel1.GradientBottomColor = System.Drawing.Color.White;
            this.rjPanel1.GradientTopColor = System.Drawing.Color.White;
            this.rjPanel1.Location = new System.Drawing.Point(0, 0);
            this.rjPanel1.Name = "rjPanel1";
            this.rjPanel1.Size = new System.Drawing.Size(328, 67);
            this.rjPanel1.TabIndex = 3;
            // 
            // FriendChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pbOnl);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pic_avr);
            this.Controls.Add(this.rjPanel1);
            this.Name = "FriendChat";
            this.Size = new System.Drawing.Size(328, 67);
            this.Load += new System.EventHandler(this.FriendChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJCircularPictureBox pic_avr;
        private System.Windows.Forms.Label lb_name;
        private CustomControls.RJControls.RJCircularPictureBox pbOnl;
        private CustomControls.RJControls.RJPanel rjPanel1;
    }
}
