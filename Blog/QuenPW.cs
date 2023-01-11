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
    public partial class QuenPW : Form
    {
        public QuenPW()
        {
            InitializeComponent();
        }

        private void txbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txbMatKhau.Texts == "Tên đăng nhập")
            {
                txbMatKhau.Texts = "";
                txbMatKhau.ForeColor = Color.Black;
            }
        }

        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            if (txbMatKhau.Texts == "")
            {
                txbMatKhau.Texts = "Tên đăng nhập";
                txbMatKhau.ForeColor = Color.Gray;
            }
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string username = Functions.GetFieldValues("select COUNT(TenDangNhap) from TAIKHOAN where TenDangNhap = N'" + txbMatKhau.Texts + "'");
            if (username == "0")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập để reset mật khẩu!");
                return;
            }

            string SendToGmail = Functions.GetFieldValues("select DiaChiGmail from TAIKHOAN where TenDangNhap = N'" + txbMatKhau.Texts + "'");
            //MessageBox.Show(SendToGmail);
            MailMessage mailMessage = new MailMessage("gnahkgnahknp@gmail.com", SendToGmail);
            mailMessage.Subject = "Your password";
            //mailMessage.Body = Functions.GetFieldValues("select MatKhau from TAIKHOAN where TenDangNhap = N'" + txbTenDangNhap.Texts + "'");
            string newpw = CreatePassword(10);
            mailMessage.Body = "Mật khẩu mới của bạn là: " + newpw;
            Functions.RunSQL("update TAIKHOAN set MatKhau = N'" + newpw + "' where TenDangNhap = N'" + txbMatKhau.Texts + "'");

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential("gnahkgnahknp@gmail.com", "xbysomintgcxrexg");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
            MessageBox.Show("Đã gửi mật khẩu về gmail của bạn!");
            this.Close();
        }
    }
}
