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
            Home.check_newpost = 0;

            flpnImage.AutoScroll = true;
            flpnImage.HorizontalScroll.Enabled = true;
            //flpnImage.VerticalScroll.Visible = false;
            //flpnImage.VerticalScroll.Maximum = 0;
            //flpnImage.AutoScroll = true;
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            string key = Functions.CreateKey(Login.login_username);
            string tenfile = "PostFolder/" + key + ".rtf";

            rtbStatus.SaveFile(tenfile, RichTextBoxStreamType.RichText);

            // có folder ảnh bài viết
            if (Directory.Exists(tenthumuc))
                Functions.RunSQL("insert into BAIVIET " +
                    "values(N'" + key + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'" + rbCongKhai.Checked.ToString() + "', N'" + tenthumuc + "', N'" + tennhac + "')");
            // bài viết không có ảnh
            else
                Functions.RunSQL("insert into BAIVIET " +
                    "values(N'" + key + "', N'" + Login.login_username + "', '" + DateTime.Now.ToString() + "', N'" + rbCongKhai.Checked.ToString() + "', N'noImg', N'" + tennhac + "')");
            Home.check_newpost = 1;
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
                    //MessageBox.Show("Tạo thư mục thành công!");
                }
                // Copy ảnh qua thư mục mới
                File.Copy(file_path, tenthumuc + "/" + Path.GetFileName(file_path), true);
            }

            if (flpnImage.Controls.Count == 1)
                this.Height = this.Height + flpnImage.Height;
        }

        private void pbFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                rtbStatus.SelectionFont = fontDialog.Font;
        }

        private void rtbStatus_Enter(object sender, EventArgs e)
        {
            if (rtbStatus.Text == "Bạn đang nghĩ gì?")
            {
                rtbStatus.Text = "";
                rtbStatus.ForeColor = Color.Black;
            }
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbStatus.SelectionColor = colorDialog.Color;
                //rtbStatus.BackColor = colorDialog.Color;
            }
        }

        private string tennhac = "noMusic";

        private void pbAddMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Music";
            openFileDialog.Filter = "mp3|*.mp3|All Files|*.*";

            //Kiểm tra xem người dùng đã chọn file chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy nhạc
                string file_path = openFileDialog.FileName;
                tennhac = Path.GetFileName(file_path);

                // Copy nhạc vào thư mục music nếu chưa có file nhạc
                if (!File.Exists("music/" + tennhac))
                {
                    File.Copy(file_path, "music/" + tennhac, true);
                }
            }
        }
    }
}
