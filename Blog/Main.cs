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
            Home home = new Home();
            home.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            pnMain.Controls.Add(home);
            home.Show();
        }

        private void pic_profile_Click(object sender, EventArgs e)
        {
           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAvatarLogin_Click(object sender, EventArgs e)
        {
            pic_home.Image = Resources.icon_home;
            Profile profile = new Profile();
            profile.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            Main.pnMainParent.Controls.Add(profile);
            profile.Show();
        }

        void setList(string list)
        {
            pic_home.Image = Resources.icon_home;
            postList postList = new postList(list);
            postList.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            Main.pnMainParent.Controls.Add(postList);
            postList.Show();
        }

        private void danhSáchYêuThíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setList("yêu thích");
        }

        private void danhSáchĐãLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setList("đã lưu");
        }

        private void danhSáchĐãBìnhLuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setList("đã bình luận");
        }
    }
}