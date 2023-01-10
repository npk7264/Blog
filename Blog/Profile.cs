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

            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt);
            pbAvatarInStatus.BackgroundImage = Image.FromFile("avatar/" + avt);
            lbTen.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            lbUsername.Text = Login.login_username;
            lbCongViec.Text = Functions.GetFieldValues("select CongViec from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
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

        private void lbStatus_Click(object sender, EventArgs e)
        {
            NewPost frm = new NewPost();
            frm.ShowDialog();
            // Reload trang
            if (Home.check_newpost == 1)
            {
                flowLayoutPanel1.Controls.Clear();
                LoadPost();
            }
        }

        private void btnCapNhatAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Picture";
            openFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file_path = openFileDialog.FileName;
                File.Copy(file_path, "avatar/" + Functions.CreateKey("avt") + Path.GetFileName(file_path), true);

                pbAvatar.BackgroundImage = Image.FromFile("avatar/" + Functions.CreateKey("avt") + Path.GetFileName(file_path));
                // Cập nhật avt trong sql
                Functions.RunSQL("update TAIKHOAN set Avatar = N'" + Functions.CreateKey("avt") + Path.GetFileName(file_path) + "' where TenDangNhap = N'" + Login.login_username + "'");

                // Cập nhật avt trên header
                Main.pbMainAvatarLogin.BackgroundImage = Image.FromFile(file_path);
                // Reload trang
                Profile profile = new Profile();
                profile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(profile);
                profile.Show();
            }
        }
        private void pbThuMucAnh_Click(object sender, EventArgs e)
        {
            ImgGallery frm = new ImgGallery();
            frm.ShowDialog();
        }

        private void pbListFriend_Click(object sender, EventArgs e)
        {
            ListFriend frm = new ListFriend();
            frm.ShowDialog();
        }
    }
}