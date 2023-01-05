using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Home frm = new Home();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng nhập đúng tên tài khoản và mật khẩu!");
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            SignUp frm = new SignUp();
            frm.ShowDialog();
        }
    }
}