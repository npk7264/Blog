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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string nowDay = DateTime.Now.Day.ToString();
            string nowMonth = DateTime.Now.Month.ToString();

            List<string> ListBaiViet = Functions.GetFieldValuesList("select ID_BaiViet from BAIVIET where " +
                "DAY(ThoiGianDang) = '" + nowDay + "' and MONTH(ThoiGianDang) = '" + nowMonth + "' " +
                "order by ThoiGianDang desc");

            foreach (string baiviet in ListBaiViet)
            {
                string state = Functions.GetFieldValues("select CongKhai from BAIVIET where ID_BaiViet = N'" + baiviet + "'");
                string user_dangbai = Functions.GetFieldValues("select TenDangNhap from BAIVIET where ID_BaiViet = N'" + baiviet + "'");

                Post post = new Post();
                // 2 thuộc tính khóa của bài viết là tên đăng nhập và thời gian đăng bài
                post.Username = user_dangbai; // user đăng bài
                post.Time = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + baiviet + "'");

                flowLayoutPanel1.Controls.Add(post);
            }
        }
    }
}
