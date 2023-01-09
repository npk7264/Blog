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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            string searchtext = Main.txtsearchUser;
            List<string> ListUser = Functions.GetFieldValuesList(
                "select TenDangNhap from TAIKHOAN where " +
                "TenDangNhap like N'%" + searchtext + "%' " +
                "or Ten like N'%" + searchtext + "%' " +
                "or CongViec like N'%" + searchtext + "%'");

            foreach (string user in ListUser)
            {
                searchUser searchuser = new searchUser();
                searchuser.Username = user; 
                flowLayoutPanel1.Controls.Add(searchuser);
            }
        }
    }
}
