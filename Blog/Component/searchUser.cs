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
    public partial class searchUser : UserControl
    {
        public searchUser()
        {
            InitializeComponent();
        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; lbUsername.Text = value; }
        }

        private void searchUser_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + lbUsername.Text + "'");
            pic_avt.BackgroundImage = Image.FromFile("avatar/" + avt);
            lb_name.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + lbUsername.Text + "'");
            lbJob.Text = Functions.GetFieldValues("select CongViec from TAIKHOAN where TenDangNhap = N'" + lbUsername.Text + "'");
        }

        private void pic_avt_Click(object sender, EventArgs e)
        {
            showProfile();
        }

        private void lb_name_Click(object sender, EventArgs e)
        {
            showProfile();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {
            showProfile();
        }

        void showProfile()
        {
            Form frm = this.FindForm();
            if ((frm is ListFriend) || (frm is OtherListFriend))
                frm.Close();

            if (lbUsername.Text == Login.login_username)
            {
                Profile profile = new Profile();
                profile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(profile);
                profile.Show();
            }
            else
            {
                OtherProfile.other_username = lbUsername.Text;

                OtherProfile otherprofile = new OtherProfile();
                otherprofile.TopLevel = false;
                Main.pnMainParent.Controls.Clear();
                Main.pnMainParent.Controls.Add(otherprofile);
                otherprofile.Show();
            }
        }
    }
}
