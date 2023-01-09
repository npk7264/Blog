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
    public partial class ImgGallery : Form
    {
        public ImgGallery()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImgGallery_Load(object sender, EventArgs e)
        {
            // Load ảnh
            List<string> listImgFolder = Functions.GetFieldValuesList("select ThuMucAnh from BAIVIET where TenDangNhap = N'"+Login.login_username+"' order by ThoiGianDang desc");
            
            foreach(string thumucImg in listImgFolder)
            {
                // Kiểm tra thư mục có ảnh không
                if (thumucImg != "noImg")
                {

                    string[] files = Directory.GetFiles(thumucImg);
                    foreach (string file in files)
                    {
                        ImgInGallery img = new ImgInGallery();
                        img.ImgGalleryPath = file;
                        flowLayoutPanel1.Controls.Add(img);
                    }
                }
            }
        }
    }
}
