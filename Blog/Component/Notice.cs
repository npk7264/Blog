using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog.Component
{
    public partial class Notice : UserControl
    {
        public Notice()
        {
            InitializeComponent();
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; lb_name.Text = value; }
        }

        private void Notice_Load(object sender, EventArgs e)
        {

            string timelogout = Functions.GetFieldValues("select ThoiGianLogout from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");

            //bai viet moi
            string count = Functions.GetFieldValues("select COUNT(ID_BaiViet) from BAIVIET where " +
                "TenDangNhap = N'" + _username + "' and ThoiGianDang >= '" + timelogout + "'");
            label1.Text = "đã thêm " + count.ToString() + " bài viết mới";

            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'"+lb_name.Text + "'");
            pic_avr.BackgroundImage = Image.FromFile("avatar/"+avt);
        }

        private void lb_name_Click(object sender, EventArgs e)
        {
            if (lb_name.Text == Login.login_username)
            {
                Profile profile = new Profile();
                profile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(profile);
                profile.Show();
            }
            else
            {
                OtherProfile.other_username = lb_name.Text;

                OtherProfile otherprofile = new OtherProfile();
                otherprofile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(otherprofile);
                otherprofile.Show();
            }
            Form frm = this.FindForm();
            frm.Close();
        }

        private void pic_avr_Click(object sender, EventArgs e)
        {
            if (lb_name.Text == Login.login_username)
            {
                Profile profile = new Profile();
                profile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(profile);
                profile.Show();
            }
            else
            {
                OtherProfile.other_username = lb_name.Text;

                OtherProfile otherprofile = new OtherProfile();
                otherprofile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(otherprofile);
                otherprofile.Show();
            }
            Form frm = this.FindForm();
            frm.Close();
        }
    }
}
