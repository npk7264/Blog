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
    public partial class Post : UserControl
    {
        public Post()
        {
            InitializeComponent();
        }

        private string _username;
        private string _time;
        private Image _avatar;

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
        public Image Avatar
        {
            get { return _avatar; }
            set { _avatar = value; pbAvatar.BackgroundImage = value; }
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Username);
        }

        private void pbLike_Click(object sender, EventArgs e)
        {
            string ID_BaiViet = Functions.GetFieldValues("select ID_BaiViet from BAIVIET " +
                "where TenDangNhap = N'" + this.Username + "' and ThoiGianDang = '" + this.Time + "'");

            string sql = "insert into YEUTHICH values (N'" + ID_BaiViet + "', N'" + Login.login_username + "')";
            Functions.RunSQL(sql);
        }

        private void pbSetting_Click(object sender, EventArgs e)
        {
            if (pnSetting1.Visible == true)
                pnSetting1.Visible = false;
            else
                pnSetting1.Visible = true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            pnSetting1.Visible = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Control temp = this.Parent;
            temp.Controls.Remove(this);
            pnSetting1.Visible = false;
        }
    }
}