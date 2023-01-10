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

namespace Blog.Component
{
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
            flpnImage.AutoScroll = true;
            flpnImage.HorizontalScroll.Enabled = true;
        }

        private string _username;
        private string _time;

        public string Username
        {
            get { return _username; }
            set { _username = value; lbUser.Text = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; lbTime.Text = value; }
        }

        // Click vào avatar bài viết
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            if (lbUser.Text == Login.login_username)
            {
                Profile profile = new Profile();
                profile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(profile);
                profile.Show();
            }
            else
            {
                OtherProfile.other_username = lbUser.Text;

                OtherProfile otherprofile = new OtherProfile();
                otherprofile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(otherprofile);
                otherprofile.Show();
            }
        }

        // Click vào username bài viết
        private void lbUser_Click(object sender, EventArgs e)
        {
            if (lbUser.Text == Login.login_username)
            {
                Profile profile = new Profile();
                profile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(profile);
                profile.Show();
            }
            else
            {
                OtherProfile.other_username = lbUser.Text;

                OtherProfile otherprofile = new OtherProfile();
                otherprofile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(otherprofile);
                otherprofile.Show();
            }
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            if (this.Username == Login.login_username)
            {
                if (pnSetting1.Visible == true)
                    pnSetting1.Visible = false;
                else
                    pnSetting1.Visible = true;
            }
        }

        public static Control parent_control;

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            Profile.post_edit_id = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");
            pnSetting1.Visible = false;
            EditPost frm = new EditPost();
            frm.ShowDialog();

            flpnImage.Controls.Clear();
            LoadPost();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Control temp = this.Parent;
            temp.Controls.Remove(this);
            // Xóa bài viết
            Functions.RunSQL("delete from BAIVIET where " +
                "TenDangNhap = N'" + Login.login_username + "' and ThoiGianDang = '" + lbTime.Text + "'");

            string idbaiviet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET where " +
                "TenDangNhap = N'" + Login.login_username + "' and ThoiGianDang = '" + lbTime.Text + "'");
            Functions.RunSQL("delete from YEUTHICH where ID_BaiViet = N'" + idbaiviet + "'");
            Functions.RunSQL("delete from LUU where ID_BaiViet = N'" + idbaiviet + "'");
            Functions.RunSQL("delete from COMMENT where ID_BaiViet = N'" + idbaiviet + "'");

            pnSetting1.Visible = false;
        }

        // Hiển thị khi mở bài viết
        private void Post_Load(object sender, EventArgs e)
        {
            if (this.Username != Login.login_username)
                pbSetting.Visible = false;
            LoadPost();
        }

        // Load
        void LoadPost()
        {
            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            // Ảnh đại diện
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + this.Username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt);

            // Trạng thái
            string picpublic = Functions.GetFieldValues("select CongKhai from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");
            if (picpublic == "True")
                pbPublic.BackgroundImage = Image.FromFile("picture/icon-public.png");
            else
                pbPublic.BackgroundImage = Image.FromFile("picture/icon-private.png");

            // Nội dung bài viết
            rtbStatus.LoadFile("PostFolder/" + ID_BaiViet + ".rtf", RichTextBoxStreamType.RichText);

            // Chỉnh chiều cao cho richtextbox
            int start = 0;
            int height = 0;

            foreach (string text in rtbStatus.Lines)
            {
                int textloc = rtbStatus.Find(text, start, RichTextBoxFinds.WholeWord | RichTextBoxFinds.MatchCase);

                height += rtbStatus.SelectionFont.Height;
                start += text.Length;
            }

            rtbStatus.Height = height + 30;

            // Load ảnh
            string thumucImg = Functions.GetFieldValues("select ThuMucAnh from BAIVIET where ID_BaiViet = N'" + ID_BaiViet + "'");
            // Kiểm tra thư mục có ảnh không
            if (thumucImg != "noImg")
            {

                string[] files = Directory.GetFiles(thumucImg);
                foreach (string file in files)
                {
                    Img img = new Img();
                    img.ImgPath = file;
                    flpnImage.Visible = true;
                    flpnImage.Controls.Add(img);
                }
            }

            if (flpnImage.Controls.Count == 0)
            {
                this.Height = 200 + rtbStatus.Height;
                flpnImage.Visible = false;
            }
            else
            {
                flpnImage.Visible = true;
                this.Height = 200 + rtbStatus.Height + flpnImage.Height;
            }

            // Hiển thị trạng thái like
            string check_like = Functions.GetFieldValues(
                    "select COUNT(*) from YEUTHICH where ID_BaiViet = N'" + ID_BaiViet + "' and TenDangNhapLike = N'" + Login.login_username + "'");
            if (check_like == "0")
                pbLike.BackgroundImage = Image.FromFile("picture/icon-like.png");
            else
                pbLike.BackgroundImage = Image.FromFile("picture/icon-liked.png");

            // Hiển thị trạng thái lưu
            string check_save = Functions.GetFieldValues(
                    "select COUNT(*) from LUU where ID_BaiViet = N'" + ID_BaiViet + "' and TenDangNhapLuu = N'" + Login.login_username + "'");
            if (check_save == "0")
                pbLuu.BackgroundImage = Image.FromFile("picture/icon-save.png");
            else
                pbLuu.BackgroundImage = Image.FromFile("picture/icon-saved.png");

            // Lượt like
            lbSoLike.Text = Functions.GetFieldValues("select COUNT(*) from YEUTHICH " +
                "where ID_BaiViet = N'" + ID_BaiViet + "'") + " thích";
            // Lượt comment
            lbSoComment.Text = Functions.GetFieldValues("select COUNT(*) from COMMENT " +
                "where ID_BaiViet = N'" + ID_BaiViet + "'") + " bình luận";

            // Nhạc
            pbMusic.Tag = "music_on";
            pbMusic.BackgroundImage = Image.FromFile("picture/music_on.png");

            string musicState = Functions.GetFieldValues("select FileNhac from BAIVIET where ID_BaiViet = N'" + ID_BaiViet + "'");
            if (musicState == "noMusic")
                pbMusic.Visible = false;
            else
                pbMusic.Visible = true;

            //map
            string checkMap = Functions.GetFieldValues("select MapURL from BAIVIET where ID_BaiViet = N'" + ID_BaiViet + "'");
            pic_map.Visible = checkMap == "noMap" ? false : true;
        }

        // Comment
        private void pbComment_Click(object sender, EventArgs e)
        {
            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            CommentList.baiviet_comment = ID_BaiViet;
            CommentList frm = new CommentList();
            frm.ShowDialog();
            lbSoComment.Text = Functions.GetFieldValues("select COUNT(*) from COMMENT " +
                "where ID_BaiViet = N'" + ID_BaiViet + "'") + " bình luận";
        }

        // Like
        private void pbLike_Click(object sender, EventArgs e)
        {
            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            string count = Functions.GetFieldValues("select COUNT(*) from YEUTHICH " +
                "where ID_BaiViet=N'" + ID_BaiViet + "' and TenDangNhapLike = N'" + Login.login_username + "'");

            if (count == "0")
            {
                string sql = "insert into YEUTHICH values (N'" + ID_BaiViet + "', N'" + Login.login_username + "')";
                Functions.RunSQL(sql);
                pbLike.BackgroundImage = Image.FromFile("picture/icon-liked.png");
            }
            else
            {
                string sql = "delete from YEUTHICH where " +
                    "ID_BaiViet = N'" + ID_BaiViet + "' and TenDangNhapLike = N'" + Login.login_username + "'";
                Functions.RunSQL(sql);
                pbLike.BackgroundImage = Image.FromFile("picture/icon-like.png");
            }
            lbSoLike.Text = Functions.GetFieldValues("select COUNT(*) from YEUTHICH where ID_BaiViet = N'" + ID_BaiViet + "'") + " thích";
        }

        private void pbLuu_Click(object sender, EventArgs e)
        {
            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            string count = Functions.GetFieldValues("select COUNT(*) from LUU " +
                "where ID_BaiViet=N'" + ID_BaiViet + "' and TenDangNhapLuu = N'" + Login.login_username + "'");

            if (count == "0")
            {
                string sql = "insert into LUU values (N'" + ID_BaiViet + "', N'" + Login.login_username + "')";
                Functions.RunSQL(sql);
                pbLuu.BackgroundImage = Image.FromFile("picture/icon-saved.png");
            }
            else
            {
                string sql = "delete from LUU where " +
                    "ID_BaiViet = N'" + ID_BaiViet + "' and TenDangNhapLuu = N'" + Login.login_username + "'";
                Functions.RunSQL(sql);
                pbLuu.BackgroundImage = Image.FromFile("picture/icon-save.png");
            }
        }

        private void pbMusic_Click(object sender, EventArgs e)
        {
            Main.musicPlayer.controls.stop();

            string music = Functions.GetFieldValues("select FileNhac from BAIVIET where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");
            string musicState = (string)pbMusic.Tag;
            if (musicState == "music_on")
            {
                pbMusic.Tag = "music_off";
                pbMusic.BackgroundImage = Image.FromFile("picture/music_off.png");
                Main.musicPlayer.URL = "music/" + music;
            }
            else
            {
                pbMusic.Tag = "music_on";
                pbMusic.BackgroundImage = Image.FromFile("picture/music_on.png");
                Main.musicPlayer.controls.stop();
            }
        }

        private void pic_map_Click(object sender, EventArgs e)
        {
            //biến url đọc dữ liệu từ database
            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            string url = Functions.GetFieldValues("select MapURL from BAIVIET where ID_BaiViet = N'" + ID_BaiViet + "'");
            ShowMap showMap = new ShowMap(url);
            showMap.ShowDialog();
        }
    }
}