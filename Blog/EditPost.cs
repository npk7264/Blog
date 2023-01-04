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
    public partial class EditPost : Form
    {
        public EditPost()
        {
            InitializeComponent();
        }

        private void EditPost_Load(object sender, EventArgs e)
        {
            string id = Profile.post_edit_id;
            lbUser.Text = Functions.GetFieldValues("select TenDangNhap from BAIVIET where ID_BaiViet = N'" + id + "'");
            lbTime.Text = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + id + "'");
            string state = Functions.GetFieldValues("select CongKhai from BAIVIET where ID_BaiViet = N'" + id + "'");
            if(state == "True")
                rbCongKhai.Checked = true; 
            else
                rbRiengTu.Checked = true;

            rtbStatus.LoadFile("PostFolder/" + id + ".rtf", RichTextBoxStreamType.RichText);

        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            string sql = "update BAIVIET " +
                "set CongKhai = N'" + rbCongKhai.Checked.ToString() + 
                "' where ID_BaiViet = N'" + Profile.post_edit_id + "'";

            string key = Profile.post_edit_id;
            string tenfile = "PostFolder/" + key + ".rtf";

            rtbStatus.SaveFile(tenfile, RichTextBoxStreamType.RichText);
            Functions.RunSQL(sql);
            this.Close();
        }
    }
}
