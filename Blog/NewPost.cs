using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Blog.Component;

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
            string tenfile = "PostFolder/" + key + ".rtf";

            rtbStatus.SaveFile(tenfile, RichTextBoxStreamType.RichText);

            // có folder ảnh bài viết
            if (Directory.Exists(tenthumuc))
                Functions.RunSQL("insert into BAIVIET " +
                    "values(N'" + key + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'" + rbCongKhai.Checked.ToString() + "', N'" + tenthumuc + "')");
            // bài viết không có ảnh
            else
                Functions.RunSQL("insert into BAIVIET " +
                    "values(N'" + key + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'" + rbCongKhai.Checked.ToString() + "', N'noImg')");

            this.Close();
        }

        private void NewPost_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt);
            lbUser.Text = Login.login_username;

            this.Height = this.Height - flpnImage.Height;
        }

        // Tên thư mục ảnh
        private string tenthumuc = "ImgPost/" + Functions.CreateKey("img" + Login.login_username);

        private void pbAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Picture";
            openFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|All Files|*.*";

            //Kiểm tra xem người dùng đã chọn file chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy hình ảnh
                string file_path = openFileDialog.FileName;
                Img img = new Img();
                img.ImgPath = file_path;
                flpnImage.Controls.Add(img);
                flpnImage.Visible = true;

                // Tạo thư mục nếu chưa có thư mục ảnh
                if (!Directory.Exists(tenthumuc))
                {
                    Directory.CreateDirectory(tenthumuc);
                    MessageBox.Show("Tạo thư mục thành công!");
                }
                // Copy ảnh qua thư mục mới
                File.Copy(file_path, tenthumuc + "/" + Path.GetFileName(file_path), true);
            }

            if (flpnImage.Controls.Count == 1)
                this.Height = this.Height + flpnImage.Height;
        }
    }
}
