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
                    "', N'" + txbHo.Texts + txbTen.Texts + 
                    "', N'default.jpg', N'" + txbCongViec.Texts + "')";
                Functions.RunSQL(sql);
                MessageBox.Show("Đăng ký tài khoản thành công");
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
    }
}
