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
    public partial class ImgInGallery : UserControl
    {
        public ImgInGallery()
        {
            InitializeComponent();
        }

        private string _img;

        public string ImgGalleryPath
        {
            get { return _img; }
            set { _img = value; pbImgGallery.BackgroundImage = Image.FromFile(value); }
        }
    }
}
