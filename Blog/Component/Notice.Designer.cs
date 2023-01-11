namespace Blog.Component
{
    partial class Notice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_avr = new CustomControls.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(94, 30);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(70, 20);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "lb_name";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "@";
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
            this.pic_avr.Location = new System.Drawing.Point(9, 7);
            this.pic_avr.Name = "pic_avr";
            this.pic_avr.Size = new System.Drawing.Size(48, 48);
            this.pic_avr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avr.TabIndex = 3;
            this.pic_avr.TabStop = false;
            this.pic_avr.Click += new System.EventHandler(this.pic_avr_Click);
            // 
            // Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pic_avr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Notice";
            this.Size = new System.Drawing.Size(371, 67);
            this.Load += new System.EventHandler(this.Notice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_name;
        private CustomControls.RJControls.RJCircularPictureBox pic_avr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
