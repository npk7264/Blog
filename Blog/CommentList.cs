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
    public partial class CommentList : Form
    {
        public CommentList()
        {
            InitializeComponent();
        }

        public static string baiviet_comment;

        private void CommentList_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatarComment.BackgroundImage = Image.FromFile("avatar/" + avt);

            List<string> comments = Functions.GetFieldValuesList("select ID_Comment from COMMENT where ID_BaiViet = N'" + baiviet_comment + "' order by ThoiGianComment desc");
            foreach(string comment in comments)
            {
                Comment cmt = new Comment();
                // 2 thuộc tính khóa của bài viết là tên đăng nhập và thời gian đăng bài
                cmt.Username = Functions.GetFieldValues("select TenDangNhapComment from COMMENT where ID_Comment = N'" + comment + "'");
                cmt.Time = Functions.GetFieldValues("select ThoiGianComment from COMMENT where ID_Comment = N'" + comment + "'");

                flowLayoutPanel1.Controls.Add(cmt);
            }
        }

        private void btnDangBinhLuan_Click(object sender, EventArgs e)
        {
            string ID_Comment = Functions.CreateKey(Login.login_username);
            Functions.RunSQL("insert into COMMENT values(N'" + ID_Comment + "', N'" + baiviet_comment + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'" + txtBinhLuan.Texts + "')");

            Comment comment = new Comment();
            // 2 thuộc tính khóa của bài viết là tên đăng nhập và thời gian đăng bài
            comment.Username = Login.login_username;
            comment.Time = DateTime.Now.ToString();

            flowLayoutPanel1.Controls.Add(comment);
        }
    }
}
