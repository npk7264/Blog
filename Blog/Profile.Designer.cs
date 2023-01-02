namespace Blog
{
    partial class Profile
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTaoBaiVietMoi = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1338, 470);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTaoBaiVietMoi
            // 
            this.btnTaoBaiVietMoi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTaoBaiVietMoi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTaoBaiVietMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaoBaiVietMoi.BorderRadius = 0;
            this.btnTaoBaiVietMoi.BorderSize = 0;
            this.btnTaoBaiVietMoi.FlatAppearance.BorderSize = 0;
            this.btnTaoBaiVietMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoBaiVietMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoBaiVietMoi.Location = new System.Drawing.Point(386, 86);
            this.btnTaoBaiVietMoi.Name = "btnTaoBaiVietMoi";
            this.btnTaoBaiVietMoi.Size = new System.Drawing.Size(150, 40);
            this.btnTaoBaiVietMoi.TabIndex = 1;
            this.btnTaoBaiVietMoi.Text = "Tạo bài viết mới";
            this.btnTaoBaiVietMoi.TextColor = System.Drawing.Color.White;
            this.btnTaoBaiVietMoi.UseVisualStyleBackColor = false;
            this.btnTaoBaiVietMoi.Click += new System.EventHandler(this.btnTaoBaiVietMoi_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 797);
            this.Controls.Add(this.btnTaoBaiVietMoi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton btnTaoBaiVietMoi;
    }
}

