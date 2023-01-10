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
    public partial class EditPost : Form
    {
        public EditPost()
        {
            InitializeComponent();
        }

        private void EditPost_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues(
                "select Avatar from TAIKHOAN where TenDangNhap = N'" + Login.login_username + "'");
            pbAvatar.BackgroundImage = Image.FromFile("avatar/" + avt);

            string id = Profile.post_edit_id;
            lbUser.Text = Functions.GetFieldValues("select TenDangNhap from BAIVIET where ID_BaiViet = N'" + id + "'");
            lbTime.Text = Functions.GetFieldValues("select ThoiGianDang from BAIVIET where ID_BaiViet = N'" + id + "'");
            string state = Functions.GetFieldValues("select CongKhai from BAIVIET where ID_BaiViet = N'" + id + "'");
            if (state == "True")
                rbCongKhai.Checked = true;
            else
                rbRiengTu.Checked = true;

            rtbStatus.LoadFile("PostFolder/" + id + ".rtf", RichTextBoxStreamType.RichText);

            // Load ảnh
            string thumucImg = Functions.GetFieldValues("select ThuMucAnh from BAIVIET where ID_BaiViet = N'" + Profile.post_edit_id + "'");
            // Kiểm tra thư mục có ảnh không
            if (thumucImg != "noImg")
            {

                string[] files = Directory.GetFiles(thumucImg);
                foreach (string file in files)
                {
                    Img img = new Img();
                    img.ImgPath = file;
                    flpnImage.Visible = true;
                    flpnImage.Controls.Add(img);
                }
            }

            if (flpnImage.Controls.Count == 0)
            {
                this.Height = 200 + rtbStatus.Height;
                flpnImage.Visible = false;
            }
            else
            {
                flpnImage.Visible = true;
                this.Height = 200 + rtbStatus.Height + flpnImage.Height;
            }

        }

        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            string sql = "update BAIVIET " +
                "set CongKhai = N'" + rbCongKhai.Checked.ToString() +
                "', FileNhac = N'" + tennhac + "', " +
                "MapURL = N'" + Map.mapurl + "'" +
                " where ID_BaiViet = N'" + Profile.post_edit_id + "'";

            string key = Profile.post_edit_id;
            string tenfile = "PostFolder/" + key + ".rtf";

            rtbStatus.SaveFile(tenfile, RichTextBoxStreamType.RichText);
            Functions.RunSQL(sql);
            this.Close();
        }

        private void pbFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbStatus.SelectionFont = fontDialog.Font;
                //rtbStatus.Font = fontDialog.Font;
            }
        }

        private void pic_map_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.ShowDialog();
        }

        private string tennhac = Functions.GetFieldValues("select FileNhac from BAIVIET " +
            "where ID_BaiViet = N'" + Profile.post_edit_id + "'");

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

        private void pbColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbStatus.SelectionColor = colorDialog.Color;
                //rtbStatus.BackColor = colorDialog.Color;
            }
        }
    }
}
