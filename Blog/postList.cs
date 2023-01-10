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
    public partial class postList : Form
    {
        private string nameList;
        public postList()
        {
            InitializeComponent();
        }

        //hàm truyền dữ liệu cho form 
        public postList(string Message) : this()
        {
            //Biến Message cho biến đây là danh sách gì để hiện thị các bài post tương ứng
            /*Message có các giá trị là 
              yêu thích
              đã lưu
              đã bình luận*/
            nameList = Message;
            lbList.Text = "Bài viết " + Message;

            List<string> ListBaiViet = new List<string>();

            if (nameList == "yêu thích")
            {
                ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from YEUTHICH where " +
                "TenDangNhapLike = N'" + Login.login_username+"'");
            }
            else if (nameList == "đã lưu")
            {
                ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from LUU where " +
                "TenDangNhapLuu = N'" + Login.login_username + "'");
            }
            else if (nameList == "đã bình luận")
            {
                ListBaiViet = Functions.GetFieldValuesList(
                "select distinct(ID_BaiViet) from COMMENT where " +
                "TenDangNhapComment = N'" + Login.login_username + "'");
            }

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
    }
}
