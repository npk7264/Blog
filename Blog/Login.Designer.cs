namespace Blog
{
    partial class Login
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
            this.btnNewAcc = new CustomControls.RJControls.RJButton();
            this.btnLogin = new CustomControls.RJControls.RJButton();
            this.txbMatKhau = new CustomControls.RJControls.RJTextBox();
            this.txbTenDangNhap = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewAcc.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewAcc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewAcc.BorderRadius = 10;
            this.btnNewAcc.BorderSize = 0;
            this.btnNewAcc.FlatAppearance.BorderSize = 0;
            this.btnNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAcc.ForeColor = System.Drawing.Color.White;
            this.btnNewAcc.Location = new System.Drawing.Point(568, 518);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Padding = new System.Windows.Forms.Padding(10);
            this.btnNewAcc.Size = new System.Drawing.Size(226, 60);
            this.btnNewAcc.TabIndex = 8;
            this.btnNewAcc.Text = "Tạo tài khoản mới";
            this.btnNewAcc.TextColor = System.Drawing.Color.White;
            this.btnNewAcc.UseVisualStyleBackColor = false;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(568, 452);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(10);
            this.btnLogin.Size = new System.Drawing.Size(226, 60);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txbMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txbMatKhau.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbMatKhau.BorderRadius = 10;
            this.txbMatKhau.BorderSize = 1;
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbMatKhau.Location = new System.Drawing.Point(568, 342);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txbMatKhau.Multiline = false;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Padding = new System.Windows.Forms.Padding(15);
            this.txbMatKhau.PasswordChar = false;
            this.txbMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMatKhau.PlaceholderText = "";
            this.txbMatKhau.Size = new System.Drawing.Size(226, 56);
            this.txbMatKhau.TabIndex = 6;
            this.txbMatKhau.Texts = "Mật khẩu";
            this.txbMatKhau.UnderlinedStyle = false;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txbTenDangNhap.BorderColor = System.Drawing.Color.Black;
            this.txbTenDangNhap.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbTenDangNhap.BorderRadius = 10;
            this.txbTenDangNhap.BorderSize = 1;
            this.txbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDangNhap.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbTenDangNhap.Location = new System.Drawing.Point(568, 274);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenDangNhap.Multiline = false;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Padding = new System.Windows.Forms.Padding(15);
            this.txbTenDangNhap.PasswordChar = false;
            this.txbTenDangNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTenDangNhap.PlaceholderText = "";
            this.txbTenDangNhap.Size = new System.Drawing.Size(226, 56);
            this.txbTenDangNhap.TabIndex = 5;
            this.txbTenDangNhap.Texts = "Tên đăng nhập";
            this.txbTenDangNhap.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 853);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton btnNewAcc;
        private CustomControls.RJControls.RJButton btnLogin;
        private CustomControls.RJControls.RJTextBox txbMatKhau;
        private CustomControls.RJControls.RJTextBox txbTenDangNhap;
    }
}