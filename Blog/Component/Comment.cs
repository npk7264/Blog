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
    public partial class Comment : UserControl
    {
        public Comment()
        {
            InitializeComponent();
        }

        public string _username;
        public string _time;

        public string Username
        {
            get { return _username; }
            set { _username = value; lbUser.Text = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; lbTime.Text = value; }
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            string ID_Comment = Functions.GetFieldValues("select ID_Comment from COMMENT " +
                "where TenDangNhapComment = N'" + this.Username + "' and ThoiGianComment = '" + this.Time + "'");

            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + this.Username + "'");
            pbAvtComment.BackgroundImage = Image.FromFile("avatar/" + avt + ".jpg");
            lbComment.Text = Functions.GetFieldValues("select ContentComment from COMMENT where ID_Comment = N'" + ID_Comment + "'");
        }
    }
}
