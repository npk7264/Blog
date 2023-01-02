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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadPost();
        }

        void LoadPost()
        {
            List<string> ListBaiViet = Functions.GetFieldValuesList(
                "select ID_BaiViet from BAIVIET where TenDangNhap = N'" + Login.login_username + "' order by ThoiGianDang desc");

            foreach (string baiviet in ListBaiViet)
            {
                Post post = new Post();
                post.Username = Login.login_username;
                post.Time = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + baiviet + "'");
                flowLayoutPanel1.Controls.Add(post);
            }
        }

        private void btnTaoBaiVietMoi_Click(object sender, EventArgs e)
        {
            NewPost frm = new NewPost();
            frm.ShowDialog();
        }
    }
}