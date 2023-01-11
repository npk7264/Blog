using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog.Component
{
    public partial class LikeNotice : UserControl
    {
        public LikeNotice()
        {
            InitializeComponent();
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; lb_name.Text = value; }
        }

        private void LikeNotice_Load(object sender, EventArgs e)
        {
            //like bai viet
            label1.Text = "đã thích bài viết của bạn";

            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + lb_name.Text + "'");
            pic_avr.BackgroundImage = Image.FromFile("avatar/" + avt);
        }
    }
}
