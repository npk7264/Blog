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
    public partial class SetPW : Form
    {
        public SetPW()
        {
            InitializeComponent();
        }

        private void txbMatKhau_Enter(object sender, EventArgs e)
        {
            if (txbMatKhau.Texts == "Mật khẩu mới")
            {
                txbMatKhau.Texts = "";
                txbMatKhau.ForeColor = Color.Black;
                txbMatKhau.PasswordChar = true;
            }
        }

        private void txtMatKhaupw_Enter(object sender, EventArgs e)
        {
            if (txtMatKhaupw.Texts == "Nhắc lại mật khẩu")
            {
                txtMatKhaupw.Texts = "";
                txtMatKhaupw.ForeColor = Color.Black;
                txtMatKhaupw.PasswordChar = true;
            }
        }

        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            if (txbMatKhau.Texts == "")
            {
                txbMatKhau.Texts = "Mật khẩu mới";
                txbMatKhau.ForeColor = Color.Gray;
                txbMatKhau.PasswordChar = false;
            }
        }

        private void txtMatKhaupw_Leave(object sender, EventArgs e)
        {
            if (txtMatKhaupw.Texts == "")
            {
                txtMatKhaupw.Texts = "Nhắc lại mật khẩu";
                txtMatKhaupw.ForeColor = Color.Gray;
                txtMatKhaupw.PasswordChar = false;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string pw1 = txtMatKhaupw.Texts;
            string pw2 = txbMatKhau.Texts;
            if ( pw1!="" && pw2!="" && pw1 == pw2)
            {
                Functions.RunSQL("update TAIKHOAN set MatKhau = N'" + pw1 + "' where TenDangNhap = N'" + Login.login_username + "'");
                MessageBox.Show("Đặt mật khẩu mới thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập chính xác mật khẩu nhắc lại!");
            }
        }
    }
}
