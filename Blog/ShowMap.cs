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
    public partial class ShowMap : Form
    {
        public ShowMap()
        {
            InitializeComponent();
        }
        string Url;
        public ShowMap(string url):this()
        {
            Url = url;
        }

        private void ShowMap_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Url);
        }
    }
}
