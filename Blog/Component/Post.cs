﻿using System;
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
                Profile frm = new Profile();
                frm.ShowDialog();
            }
            else
            {
                OtherProfile.other_username = lbUser.Text;
                OtherProfile frm = new OtherProfile();
                frm.ShowDialog();
            }
        }

        // Click vào username bài viết
        private void lbUser_Click(object sender, EventArgs e)
        {
            if (lbUser.Text == Login.login_username)
            {
                Profile frm = new Profile();
                frm.ShowDialog();
            }
            else
            {
                OtherProfile.other_username = lbUser.Text;
                OtherProfile frm = new OtherProfile();
                frm.ShowDialog();
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
            else
            {
                if (pnSetting0.Visible == true)
                    pnSetting0.Visible = false;
                else
                    pnSetting0.Visible = true;
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

            //parent_control = this.Parent;
            //parent_control.Controls.Clear();
            //ReLoad();
        }


        void ReLoad()
        {
            List<string> ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from BAIVIET order by ThoiGianDang desc");

            foreach (string baiviet in ListBaiViet)
            {
                Post post = new Post();
                post.Username = Functions.GetFieldValues("select TenDangNhap from BAIVIET where ID_BaiViet = N'" + baiviet + "'");
                post.Time = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + baiviet + "'");
                parent_control.Controls.Add(post);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Control temp = this.Parent;
            temp.Controls.Remove(this);
            Functions.RunSQL("delete from BAIVIET where " +
                "TenDangNhap = N'" + Login.login_username + "' and ThoiGianDang = '" + lbTime.Text + "'");
            pnSetting1.Visible = false;
        }

        private void Post_Load(object sender, EventArgs e)
        {


            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            // Ảnh đại diện
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + this.Username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt + ".jpg");

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

            rtbStatus.Height = height + 10;

            // Load ảnh
            string thumucImg = Functions.GetFieldValues("select ThuMucAnh from BAIVIET where ID_BaiViet = N'" + ID_BaiViet + "'");

            string[] files = Directory.GetFiles(thumucImg);
            int count_img = files.Length;
            if (count_img > 0)
            {
                foreach (string file in files)
                {
                    //string x = file.Replace("\\", "/");
                    Img img = new Img();
                    img.ImgPath = file;
                    flpnImage.Visible = true;
                    flpnImage.Controls.Add(img);
                    //MessageBox.Show(file);
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

            // Lượt like
            lbSoLike.Text = Functions.GetFieldValues("select COUNT(*) from YEUTHICH " +
                "where ID_BaiViet = N'" + ID_BaiViet + "'") + " thích";
            // Lượt comment
            lbSoComment.Text = Functions.GetFieldValues("select COUNT(*) from COMMENT " +
                "where ID_BaiViet = N'" + ID_BaiViet + "'") + " bình luận";
        }

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
    }
}