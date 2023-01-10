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
    public partial class OtherListFriend : Form
    {
        public OtherListFriend()
        {
            InitializeComponent();
        }

        private void OtherListFriend_Load(object sender, EventArgs e)
        {
            List<string> ListFriend1 = Functions.GetFieldValuesList("select User2 from BANBE " +
                "where User1 = N'" + OtherProfile.other_username + "' and IsFriend = N'True'");
            List<string> ListFriend2 = Functions.GetFieldValuesList("select User1 from BANBE " +
                "where User2 = N'" + OtherProfile.other_username + "' and IsFriend = N'True'");
            List<string> ListFriend = ListFriend1.Concat(ListFriend2).ToList();

            foreach (string user in ListFriend)
            {
                searchUser searchuser = new searchUser();
                searchuser.Username = user;
                flowLayoutPanel1.Controls.Add(searchuser);
            }
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
