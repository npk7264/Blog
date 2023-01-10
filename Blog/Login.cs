using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Blog
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Functions.Connect();
        }

        public static string login_username;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbTenDangNhap.Texts;
            string password = txbMatKhau.Texts;
            string check_user = Functions.GetFieldValues("select COUNT(*) from TAIKHOAN where TenDangNhap = N'" + username + "' and MatKhau = N'" + password + "'");
            
            if (check_user != "0")
            {
                login_username = txbTenDangNhap.Texts;
                Main frm = new Main();
                frm.ShowDialog();

                // Reset khi logout
                txbTenDangNhap.Texts = "Tên đăng nhập";
                txbTenDangNhap.ForeColor = Color.Gray;
                txbMatKhau.Texts = "Mật khẩu";
                txbMatKhau.ForeColor = Color.Gray;
                txbMatKhau.PasswordChar = false;
            }
            else
                MessageBox.Show("Vui lòng nhập đúng tên tài khoản và mật khẩu!");
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.ShowDialog();
        }

        private void txbTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txbTenDangNhap.Texts == "Tên đăng nhập")
            {
                txbTenDangNhap.Texts = "";
                txbTenDangNhap.ForeColor = Color.Black;
            }
        }

        private void txbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txbMatKhau.Texts == "Mật khẩu")
            {
                txbMatKhau.Texts = "";
                txbMatKhau.ForeColor = Color.Black;
                txbMatKhau.PasswordChar = true;
            }
        }

        private void txbTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txbTenDangNhap.Texts == "")
            {
                txbTenDangNhap.Texts = "Tên đăng nhập";
                txbTenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            if (txbMatKhau.Texts == "")
            {
                txbMatKhau.Texts = "Mật khẩu";
                txbMatKhau.ForeColor = Color.Gray;
                txbMatKhau.PasswordChar = false;
            }
        }

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {
            string username = Functions.GetFieldValues("select COUNT(TenDangNhap) from TAIKHOAN where TenDangNhap = N'"+txbTenDangNhap.Texts+"'");
            if (username == "0")
            {
                MessageBox.Show("Tên đăng nhập này chưa được đăng ký!");
                return;
            }

            string SendToGmail = Functions.GetFieldValues("select DiaChiGmail from TAIKHOAN where TenDangNhap = N'" + txbTenDangNhap.Texts + "'");
            MessageBox.Show(SendToGmail);
            MailMessage mailMessage = new MailMessage("gnahkgnahknp@gmail.com", SendToGmail);
            mailMessage.Subject = "Your password";
            mailMessage.Body = Functions.GetFieldValues("select MatKhau from TAIKHOAN where TenDangNhap = N'" + txbTenDangNhap.Texts + "'");
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential("gnahkgnahknp@gmail.com", "xbysomintgcxrexg");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
            MessageBox.Show("Đã gửi mật khẩu về gmail của bạn!");
        }
    }
}