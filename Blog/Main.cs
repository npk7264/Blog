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
using Blog.Component;

namespace Blog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static Panel pnMainParent;
        public static Panel pnChat;
        public static PictureBox pbMainAvatarLogin;
        public static string txtsearchUser;
        public static WMPLib.WindowsMediaPlayer musicPlayer = new WMPLib.WindowsMediaPlayer();

        private void Main_Load(object sender, EventArgs e)
        {
            pnMainParent = pnMain;
            pnChat = pnl_chat;
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatarLogin.BackgroundImage = Image.FromFile("avatar/" + avt);
            pbMainAvatarLogin = pbAvatarLogin;

            pic_home.Image = Resources.icon_homeClick;
            pic_home.SizeMode = PictureBoxSizeMode.Zoom;
            Home home = new Home();
            home.TopLevel = false;
            pnMain.Controls.Add(home);
            home.Show();


            //load friendChat
            List<string> ListFriend1 = Functions.GetFieldValuesList("select User2 from BANBE " +
                "where User1 = N'" + Login.login_username + "' and IsFriend = N'True'");
            List<string> ListFriend2 = Functions.GetFieldValuesList("select User1 from BANBE " +
                "where User2 = N'" + Login.login_username + "' and IsFriend = N'True'");
            List<string> ListFriend = ListFriend1.Concat(ListFriend2).ToList();
            foreach (string user in ListFriend)
            {
                FriendChat friendChat = new FriendChat();
                friendChat.Username = user;
                fLP_friend.Controls.Add(friendChat);
            }

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

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void pbIconSearch_Click(object sender, EventArgs e)
        {
            txtsearchUser = txtSearch.Texts;
            pic_home.Image = Resources.icon_home;
            Search searchList = new Search();
            searchList.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            Main.pnMainParent.Controls.Add(searchList);
            searchList.Show();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Texts == "Tìm kiếm tài khoản")
            {
                txtSearch.Texts = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Texts == "")
            {
                txtSearch.Texts = "Tìm kiếm tài khoản";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            setList("yêu thích");
        }

        private void btnDaLuu_Click(object sender, EventArgs e)
        {
            setList("đã lưu");
        }

        private void btnDaBinhLuan_Click(object sender, EventArgs e)
        {

            setList("đã bình luận");
        }

        private void btnKyNiem_Click(object sender, EventArgs e)
        {
            pic_home.Image = Resources.icon_home;
            History historyList = new History();
            historyList.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            Main.pnMainParent.Controls.Add(historyList);
            historyList.Show();
        }

        private void btnLoiMoi_Click(object sender, EventArgs e)
        {
            pic_home.Image = Resources.icon_home;
            Invite inviteList = new Invite();
            inviteList.TopLevel = false;
            Main.pnMainParent.Controls.Clear();
            Main.pnMainParent.Controls.Add(inviteList);
            inviteList.Show();
        }
    }
}