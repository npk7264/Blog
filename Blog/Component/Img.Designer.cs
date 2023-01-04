namespace Blog.Component
{
    partial class Img
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
            this.pbImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImg.Location = new System.Drawing.Point(1, 1);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(180, 180);
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            // 
            // Img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImg);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.Name = "Img";
            this.Size = new System.Drawing.Size(182, 182);
            this.Load += new System.EventHandler(this.Img_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
    }
}
