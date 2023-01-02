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
    public partial class NewPost : Form
    {
        public NewPost()
        {
            InitializeComponent();
            rbCongKhai.Checked = true;
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            string key = Functions.CreateKey(Login.login_username);
            Functions.RunSQL("insert into BAIVIET " +
                "values(N'" + key + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'ok', N'" + rbCongKhai.Checked.ToString() + "')");


        }

        private void rtbStatus_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            rtbStatus.Height += rtbStatus.Margin.Vertical +SystemInformation.VerticalResizeBorderThickness;
        }
    }
}
