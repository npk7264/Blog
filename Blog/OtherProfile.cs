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
    public partial class OtherProfile : Form
    {
        public OtherProfile()
        {
            InitializeComponent();
        }

        public static string other_username;

        private void OtherProfile_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + other_username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt + ".jpg");
            
            lbTen.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + other_username + "'");
            lbUsername.Text = other_username;
            LoadPost();
        }

        void LoadPost()
        {
            List<string> ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from BAIVIET where TenDangNhap = N'" + other_username + "' order by ThoiGianDang desc");

            foreach (string baiviet in ListBaiViet)
            {
                string state = Functions.GetFieldValues("select CongKhai from BAIVIET where ID_BaiViet = N'" + baiviet + "'");

                if (state == "True")
                {
                    Post post = new Post();
                    // 2 thuộc tính khóa của bài viết là tên đăng nhập và thời gian đăng bài
                    post.Username = other_username;
                    post.Time = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + baiviet + "'");

                    flowLayoutPanel1.Controls.Add(post);
                }
            }
        }
    }
}
