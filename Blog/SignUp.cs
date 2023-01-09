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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            Functions.Connect();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Functions.GetFieldValues(
                "select count(TenDangNhap) from TAIKHOAN where TenDangNhap = N'" + txbTenDangNhap.Texts + "'"));
            if (count == 0)
            {
                string sql = "insert into TAIKHOAN values (" +
                    "N'" + txbTenDangNhap.Texts +
                    "', N'" + txbMatKhau.Texts +
                    "', N'" + txbHo.Texts + " " + txbTen.Texts +
                    "', N'default.jpg', N'" + txbCongViec.Texts + "')";
                Functions.RunSQL(sql);
                MessageBox.Show("Đăng ký tài khoản thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count = Functions.GetFieldValues("select count(MatKhau) from TAIKHOAN");
            MessageBox.Show(count);
        }

        private void txbHo_Enter(object sender, EventArgs e)
        {
            if (txbHo.Texts == "Họ")
            {
                txbHo.Texts = "";
                txbHo.ForeColor = Color.Black;
            }
        }

        private void txbTen_Enter(object sender, EventArgs e)
        {
            if (txbTen.Texts == "Tên")
            {
                txbTen.Texts = "";
                txbTen.ForeColor = Color.Black;
            }
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
            }
        }

        private void txbCongViec_Enter(object sender, EventArgs e)
        {
            if (txbCongViec.Texts == "Công việc")
            {
                txbCongViec.Texts = "";
                txbCongViec.ForeColor = Color.Black;
            }
        }

        private void txbHo_Leave(object sender, EventArgs e)
        {
            if (txbHo.Texts == "")
            {
                txbHo.Texts = "Họ";
                txbHo.ForeColor = Color.Gray;
            }
        }

        private void txbTen_Leave(object sender, EventArgs e)
        {
            if (txbTen.Texts == "")
            {
                txbTen.Texts = "Tên";
                txbTen.ForeColor = Color.Gray;
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
            }
        }

        private void txbCongViec_Leave(object sender, EventArgs e)
        {
            if (txbCongViec.Texts == "")
            {
                txbCongViec.Texts = "Công việc";
                txbCongViec.ForeColor = Color.Gray;
            }
        }
    }
}
