using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blog.Chat;

namespace Blog.Component
{
    public partial class FriendChat : UserControl
    {
        public FriendChat()
        {
            InitializeComponent();
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private void FriendChat_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + _username + "'");
            pic_avr.BackgroundImage = Image.FromFile("avatar/" + avt);
            lb_name.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + _username + "'");
        }

        private void pic_avr_Click(object sender, EventArgs e)
        {
            Main.pnChat.Controls.Clear();
            if (Login.login_username == "kienvo")
            {
                Server server = new Server();
                server.TopLevel = false;
                Main.pnChat.Controls.Add(server);
                server.Show();
            }
            else
            {
                Client client = new Client();
                client.TopLevel = false;
                Main.pnChat.Controls.Add(client);
                client.Show();
            }    
        }
    }
}
