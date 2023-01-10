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
    public partial class Invite : Form
    {
        public Invite()
        {
            InitializeComponent();
        }

        private void Invite_Load(object sender, EventArgs e)
        {
            List<string> ListUser = Functions.GetFieldValuesList("select User1 from BANBE where User2 = N'"+Login.login_username+"' and IsFriend = N'False'");

            foreach (string user in ListUser)
            {
                searchUser searchuser = new searchUser();
                searchuser.Username = user;
                flowLayoutPanel1.Controls.Add(searchuser);
            }
        }
    }
}
