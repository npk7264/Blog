﻿namespace Blog
{
    partial class SignUp
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
            this.txbHo = new CustomControls.RJControls.RJTextBox();
            this.txbTen = new CustomControls.RJControls.RJTextBox();
            this.txbTenDangNhap = new CustomControls.RJControls.RJTextBox();
            this.txbMatKhau = new CustomControls.RJControls.RJTextBox();
            this.btnSignUp = new CustomControls.RJControls.RJButton();
            this.txbCongViec = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // txbHo
            // 
            this.txbHo.BackColor = System.Drawing.SystemColors.Window;
            this.txbHo.BorderColor = System.Drawing.Color.Black;
            this.txbHo.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbHo.BorderRadius = 10;
            this.txbHo.BorderSize = 2;
            this.txbHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbHo.Location = new System.Drawing.Point(50, 56);
            this.txbHo.Margin = new System.Windows.Forms.Padding(4);
            this.txbHo.Multiline = false;
            this.txbHo.Name = "txbHo";
            this.txbHo.Padding = new System.Windows.Forms.Padding(15);
            this.txbHo.PasswordChar = false;
            this.txbHo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbHo.PlaceholderText = "";
            this.txbHo.Size = new System.Drawing.Size(226, 56);
            this.txbHo.TabIndex = 1;
            this.txbHo.TabStop = false;
            this.txbHo.Texts = "Họ";
            this.txbHo.UnderlinedStyle = false;
            this.txbHo.Enter += new System.EventHandler(this.txbHo_Enter);
            this.txbHo.Leave += new System.EventHandler(this.txbHo_Leave);
            // 
            // txbTen
            // 
            this.txbTen.BackColor = System.Drawing.SystemColors.Window;
            this.txbTen.BorderColor = System.Drawing.Color.Black;
            this.txbTen.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbTen.BorderRadius = 10;
            this.txbTen.BorderSize = 2;
            this.txbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbTen.Location = new System.Drawing.Point(284, 56);
            this.txbTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbTen.Multiline = false;
            this.txbTen.Name = "txbTen";
            this.txbTen.Padding = new System.Windows.Forms.Padding(15);
            this.txbTen.PasswordChar = false;
            this.txbTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTen.PlaceholderText = "";
            this.txbTen.Size = new System.Drawing.Size(226, 56);
            this.txbTen.TabIndex = 2;
            this.txbTen.TabStop = false;
            this.txbTen.Texts = "Tên";
            this.txbTen.UnderlinedStyle = false;
            this.txbTen.Enter += new System.EventHandler(this.txbTen_Enter);
            this.txbTen.Leave += new System.EventHandler(this.txbTen_Leave);
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txbTenDangNhap.BorderColor = System.Drawing.Color.Black;
            this.txbTenDangNhap.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbTenDangNhap.BorderRadius = 10;
            this.txbTenDangNhap.BorderSize = 2;
            this.txbTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenDangNhap.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbTenDangNhap.Location = new System.Drawing.Point(50, 120);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txbTenDangNhap.Multiline = false;
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Padding = new System.Windows.Forms.Padding(15);
            this.txbTenDangNhap.PasswordChar = false;
            this.txbTenDangNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbTenDangNhap.PlaceholderText = "";
            this.txbTenDangNhap.Size = new System.Drawing.Size(460, 56);
            this.txbTenDangNhap.TabIndex = 3;
            this.txbTenDangNhap.TabStop = false;
            this.txbTenDangNhap.Texts = "Tên đăng nhập";
            this.txbTenDangNhap.UnderlinedStyle = false;
            this.txbTenDangNhap.Enter += new System.EventHandler(this.txbTenDangNhap_Enter);
            this.txbTenDangNhap.Leave += new System.EventHandler(this.txbTenDangNhap_Leave);
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
            this.txbMatKhau.Location = new System.Drawing.Point(50, 184);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txbMatKhau.Multiline = false;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Padding = new System.Windows.Forms.Padding(15);
            this.txbMatKhau.PasswordChar = false;
            this.txbMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbMatKhau.PlaceholderText = "";
            this.txbMatKhau.Size = new System.Drawing.Size(460, 56);
            this.txbMatKhau.TabIndex = 4;
            this.txbMatKhau.TabStop = false;
            this.txbMatKhau.Texts = "Mật khẩu";
            this.txbMatKhau.UnderlinedStyle = false;
            this.txbMatKhau.Enter += new System.EventHandler(this.txbMatKhau_Enter);
            this.txbMatKhau.Leave += new System.EventHandler(this.txbMatKhau_Leave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(61)))));
            this.btnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(171)))), ((int)(((byte)(61)))));
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.BorderRadius = 10;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(50, 330);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(10);
            this.btnSignUp.Size = new System.Drawing.Size(460, 60);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Đăng ký tài khoản";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txbCongViec
            // 
            this.txbCongViec.BackColor = System.Drawing.SystemColors.Window;
            this.txbCongViec.BorderColor = System.Drawing.Color.Black;
            this.txbCongViec.BorderFocusColor = System.Drawing.Color.RoyalBlue;
            this.txbCongViec.BorderRadius = 10;
            this.txbCongViec.BorderSize = 2;
            this.txbCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCongViec.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txbCongViec.Location = new System.Drawing.Point(50, 248);
            this.txbCongViec.Margin = new System.Windows.Forms.Padding(4);
            this.txbCongViec.Multiline = false;
            this.txbCongViec.Name = "txbCongViec";
            this.txbCongViec.Padding = new System.Windows.Forms.Padding(15);
            this.txbCongViec.PasswordChar = false;
            this.txbCongViec.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbCongViec.PlaceholderText = "";
            this.txbCongViec.Size = new System.Drawing.Size(460, 56);
            this.txbCongViec.TabIndex = 6;
            this.txbCongViec.TabStop = false;
            this.txbCongViec.Texts = "Công việc";
            this.txbCongViec.UnderlinedStyle = false;
            this.txbCongViec.Enter += new System.EventHandler(this.txbCongViec_Enter);
            this.txbCongViec.Leave += new System.EventHandler(this.txbCongViec_Leave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.txbCongViec);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.txbHo);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txbHo;
        private CustomControls.RJControls.RJTextBox txbTen;
        private CustomControls.RJControls.RJTextBox txbTenDangNhap;
        private CustomControls.RJControls.RJTextBox txbMatKhau;
        private CustomControls.RJControls.RJButton btnSignUp;
        private CustomControls.RJControls.RJTextBox txbCongViec;
    }
}