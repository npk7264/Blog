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
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            List<string> ListFriend1 = Functions.GetFieldValuesList("select User2 from BANBE " +
                "where User1 = N'" + Login.login_username + "' and IsFriend = N'True'");
            List<string> ListFriend2 = Functions.GetFieldValuesList("select User1 from BANBE " +
                "where User2 = N'" + Login.login_username + "' and IsFriend = N'True'");
            List<string> ListFriend = ListFriend1.Concat(ListFriend2).ToList();

            string timelogout = Functions.GetFieldValues("select ThoiGianLogout from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");

            foreach (string user in ListFriend)
            {
                string count = Functions.GetFieldValues("select COUNT(ID_BaiViet) from BAIVIET where " +
                "TenDangNhap = N'" + user + "' and ThoiGianDang >= '" + timelogout + "'");
                if (count != "0")
                {
                    Notice notice = new Notice();
                    notice.Username = user;
                    flowLayoutPanel1.Controls.Add(notice);
                }

                List<string> baiviet = Functions.GetFieldValuesList("select A.ID_BaiViet from BAIVIET A, YEUTHICH B where " +
                    "TenDangNhap = N'" + Login.login_username + "' and TenDangNhapLike = N'" + user + "' and ThoiGianLike >= '" + timelogout + "' and A.ID_BaiViet = B.ID_BaiViet");
                if (baiviet.Count != 0)
                {
                    foreach (string bai in baiviet)
                    {
                        LikeNotice likenotice = new LikeNotice();
                        likenotice.Username = user;
                        flowLayoutPanel1.Controls.Add(likenotice);
                    }
                }
            }
        }
    }
}
