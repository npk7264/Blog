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
                Functions.RunSQL("update TAIKHOAN set Onl = N'True' where TenDangNhap = N'" + Login.login_username + "'");
                Functions.RunSQL("update TAIKHOAN set ThoiGianLogout = '" + DateTime.Now.ToString() + "' where TenDangNhap = N'" + Login.login_username + "'");

                Main frm = new Main();
                frm.ShowDialog();

                // Reset khi logout
                txbTenDangNhap.Texts = "Tên đăng nhập";
                txbTenDangNhap.ForeColor = Color.Gray;
                txbMatKhau.Texts = "Mật khẩu";
                txbMatKhau.ForeColor = Color.Gray;
                txbMatKhau.PasswordChar = false;
                Functions.RunSQL("update TAIKHOAN set Onl = N'False' where TenDangNhap = N'" + Login.login_username + "'");
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
            QuenPW frm = new QuenPW();
            frm.ShowDialog();
        }
    }
}