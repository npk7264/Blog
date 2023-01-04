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

            Functions.RunSQL("insert into BAIVIET " +
                "values(N'" + key + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'" + rbCongKhai.Checked.ToString() + "', N'" + tenthumuc + "')");


            this.Close();
        }

        private void NewPost_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt + ".jpg");
            lbUser.Text = Login.login_username;

            this.Height = this.Height - flpnImage.Height;

            // Tạo thư mục
            if (!Directory.Exists(tenthumuc))
            {
                Directory.CreateDirectory(tenthumuc);
                MessageBox.Show("Tạo thư mục thành công!");
            }
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
                // Copy ảnh qua thư mục mới
                File.Copy(file_path, tenthumuc + "/" + Path.GetFileName(file_path), true);
            }

            if (flpnImage.Controls.Count == 1)
                this.Height = this.Height + flpnImage.Height;


            //////////////
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "mp3|*.mp3";
            //bool flag = false;
            //string destPath = "";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    flag = true;
            //    destPath = saveFileDialog.FileName;
            //}
            //if (flag)
            //{
            //    string sourceFile = axWindowsMediaPlayer1.URL;
            //    string destFile = destPath;
            //    File.Copy(sourceFile, destFile, true);
            //    MessageBox.Show("Đã tải nhạc về máy");
            //}
            ///////////
        }
    }
}
