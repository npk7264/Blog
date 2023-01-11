namespace Blog
{
    partial class SetPW
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
            this.txbMatKhau = new CustomControls.RJControls.RJTextBox();
            this.btnXacNhan = new CustomControls.RJControls.RJButton();
            this.txtMatKhaupw = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txbMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txbMatKhau.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbMatKhau.BorderRadius = 10;
            this.txbMatKhau.BorderSize = 2;
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbMatKhau.Location = new System.Drawing.Point(215, 110);
            this.txbMatKhau.Multiline = false;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txbMatKhau.PasswordChar = false;
            this.txbMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMatKhau.PlaceholderText = "";
            this.txbMatKhau.Size = new System.Drawing.Size(170, 45);
            this.txbMatKhau.TabIndex = 7;
            this.txbMatKhau.TabStop = false;
            this.txbMatKhau.Texts = "Mật khẩu mới";
            this.txbMatKhau.UnderlinedStyle = false;
            this.txbMatKhau.Enter += new System.EventHandler(this.txbMatKhau_Enter);
            this.txbMatKhau.Leave += new System.EventHandler(this.txbMatKhau_Leave);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(61)))));
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(61)))));
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadius = 10;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(215, 244);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Padding = new System.Windows.Forms.Padding(8);
            this.btnXacNhan.Size = new System.Drawing.Size(170, 49);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.White;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMatKhaupw
            // 
            this.txtMatKhaupw.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhaupw.BorderColor = System.Drawing.Color.Black;
            this.txtMatKhaupw.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txtMatKhaupw.BorderRadius = 10;
            this.txtMatKhaupw.BorderSize = 2;
            this.txtMatKhaupw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhaupw.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMatKhaupw.Location = new System.Drawing.Point(215, 161);
            this.txtMatKhaupw.Multiline = false;
            this.txtMatKhaupw.Name = "txtMatKhaupw";
            this.txtMatKhaupw.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtMatKhaupw.PasswordChar = false;
            this.txtMatKhaupw.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhaupw.PlaceholderText = "";
            this.txtMatKhaupw.Size = new System.Drawing.Size(170, 45);
            this.txtMatKhaupw.TabIndex = 10;
            this.txtMatKhaupw.TabStop = false;
            this.txtMatKhaupw.Texts = "Nhắc lại mật khẩu";
            this.txtMatKhaupw.UnderlinedStyle = false;
            this.txtMatKhaupw.Enter += new System.EventHandler(this.txtMatKhaupw_Enter);
            this.txtMatKhaupw.Leave += new System.EventHandler(this.txtMatKhaupw_Leave);
            // 
            // SetPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtMatKhaupw);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txbMatKhau);
            this.Name = "SetPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txbMatKhau;
        private CustomControls.RJControls.RJButton btnXacNhan;
        private CustomControls.RJControls.RJTextBox txtMatKhaupw;
    }
}