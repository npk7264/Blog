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
    public partial class Img : UserControl
    {
        public Img()
        {
            InitializeComponent();
        }

        private string _img;

        public string ImgPath
        {
            get { return _img; }
            set { _img = value; pbImg.BackgroundImage = Image.FromFile(value); }
        }

        private void pbImg_Click(object sender, EventArgs e)
        {

        }

        private void Img_Load(object sender, EventArgs e)
        {
        }
    }
}
