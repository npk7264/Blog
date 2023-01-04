using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Blog.Component;

namespace Blog
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt + ".jpg");
            pbAvatarInStatus.BackgroundImage = Image.FromFile("avatar/" + avt + ".jpg");
            lbTen.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            lbUsername.Text = Login.login_username;
            LoadPost();
        }

        void LoadPost()
        {
            List<string> ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from BAIVIET where TenDangNhap = N'" + Login.login_username + "' order by ThoiGianDang desc");

            foreach (string baiviet in ListBaiViet)
            {
                Post post = new Post();
                // 2 thuộc tính khóa của bài viết là tên đăng nhập và thời gian đăng bài
                post.Username = Login.login_username;
                post.Time = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + baiviet + "'");

                flowLayoutPanel1.Controls.Add(post);
            }
        }

        public static string post_edit_id;

        private void btnCapNhatThongTin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.BackgroundImage = Image.FromFile(openFileDialog.FileName);
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
    }
}