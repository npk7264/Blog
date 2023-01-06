using Blog.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static Panel pnMainParent;

        private void Main_Load(object sender, EventArgs e)
        {
            pnMainParent = pnMain;
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatarLogin.BackgroundImage = Image.FromFile("avatar/" + avt);

            pic_profile.Image = Resources.icon_person;
            pic_profile.SizeMode = PictureBoxSizeMode.Zoom;

            pic_home.Image = Resources.icon_homeClick;
            pic_home.SizeMode = PictureBoxSizeMode.Zoom;
            Home home = new Home();
            home.TopLevel = false;
            pnMain.Controls.Add(home);
            home.Show();
        }

        //private void pbAvatarLogin_Click(object sender, EventArgs e)
        //{
        //    pic_home.Image = Resources.icon_home;
        //    Profile profile = new Profile();
        //    profile.TopLevel = false;
        //    Main.pnMainParent.Controls.Clear();
        //    Main.pnMainParent.Controls.Add(profile);
        //    profile.Show();
        //}

        private void pic_home_Click(object sender, EventArgs e)
        {
            pic_home.Image = Resources.icon_homeClick;
            pic_profile.Image = Resources.icon_person;
            Home home = new Home();
            home.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            pnMain.Controls.Add(home);
            home.Show();
        }

        private void pic_profile_Click(object sender, EventArgs e)
        {
            pic_home.Image = Resources.icon_home;
            pic_profile.Image = Resources.icon_personClick;
            Profile profile = new Profile();
            profile.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            Main.pnMainParent.Controls.Add(profile);
            profile.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}