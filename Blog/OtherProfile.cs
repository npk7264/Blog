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
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt);

            lbTen.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + other_username + "'");
            lbUsername.Text = other_username;
            lbCongViec.Text = Functions.GetFieldValues("select CongViec from TAIKHOAN where TenDangNhap = N'" + other_username + "'");

            string sentInvite = Functions.GetFieldValues("select COUNT(*) from BANBE " +
                "where User1 = N'" + Login.login_username + "' and User2 = N'" + other_username + "' and IsFriend = N'False'");
            string receiveInvite = Functions.GetFieldValues("select COUNT(*) from BANBE " +
                "where User2 = N'" + Login.login_username + "' and User1 = N'" + other_username + "' and IsFriend = N'False'");

            string isFriend1 = Functions.GetFieldValues("select COUNT(*) from BANBE " +
                "where User1 = N'" + Login.login_username + "' and User2 = N'" + other_username + "' and IsFriend = N'True'");
            string isFriend2 = Functions.GetFieldValues("select COUNT(*) from BANBE " +
                "where User2 = N'" + Login.login_username + "' and User1 = N'" + other_username + "' and IsFriend = N'True'");

            if (sentInvite == "0" && receiveInvite == "0" && isFriend1 != "0" && isFriend2 != "0")
                btnKetBan.Text = "Kết bạn";
            else if (sentInvite == "0" && receiveInvite == "1")
                btnKetBan.Text = "Chấp nhận kết bạn";
            else if (sentInvite == "1" && receiveInvite == "0")
                btnKetBan.Text = "Đã gửi lời mời";
            else if (isFriend1 == "1" || isFriend2 == "1")
                btnKetBan.Text = "Bạn bè";

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

        private void pbAvatarLogin_Click(object sender, EventArgs e)
        {
            Profile frm = new Profile();
            frm.ShowDialog();
        }

        private void pbThuMucAnh_Click(object sender, EventArgs e)
        {
            OtherImgGallery frm = new OtherImgGallery();
            frm.ShowDialog();
        }

        private void btnKetBan_Click(object sender, EventArgs e)
        {
            if (btnKetBan.Text == "Kết bạn")
            {
                Functions.RunSQL("insert into BANBE values(N'" + Login.login_username + "', N'" + other_username + "', N'False')");
                btnKetBan.Text = "Đã gửi lời mời";
            }
            else if (btnKetBan.Text == "Chấp nhận kết bạn")
            {
                Functions.RunSQL("update BANBE set IsFriend = N'True' where User1 = N'" + other_username + "' and User2 = N'" + Login.login_username + "'");
                btnKetBan.Text = "Bạn bè";
            }
        }

        private void pbListFriend_Click(object sender, EventArgs e)
        {
            OtherListFriend frm = new OtherListFriend();
            frm.ShowDialog();
        }
    }
}
