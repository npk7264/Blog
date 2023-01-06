using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blog.Component;

namespace Blog
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");

            pbAvatarInStatus.BackgroundImage = Image.FromFile("avatar/" + avt);
            LoadPost();
        }

        void LoadPost()
        {
            List<string> ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from BAIVIET order by ThoiGianDang desc");

            foreach (string baiviet in ListBaiViet)
            {
                string state = Functions.GetFieldValues("select CongKhai from BAIVIET where ID_BaiViet = N'" + baiviet + "'");
                string user_dangbai = Functions.GetFieldValues("select TenDangNhap from BAIVIET where ID_BaiViet = N'" + baiviet + "'");
                
                if (state == "True" || (state == "False" && user_dangbai == Login.login_username))
                {
                    Post post = new Post();
                    // 2 thuộc tính khóa của bài viết là tên đăng nhập và thời gian đăng bài
                    post.Username = user_dangbai; // user đăng bài
                    post.Time = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + baiviet + "'");

                    flowLayoutPanel1.Controls.Add(post);
                }
            }
        }

        private void lbStatus_Click(object sender, EventArgs e)
        {
            NewPost frm = new NewPost();
            frm.ShowDialog();
            // Reload trang
            flowLayoutPanel1.Controls.Clear();
            LoadPost();
        }

        private void pbAvatarLogin_Click(object sender, EventArgs e)
        {
            Profile frm = new Profile();
            frm.ShowDialog();
        }
    }
}
