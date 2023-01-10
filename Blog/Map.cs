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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            map_type.SelectedIndex = 1;
            checkBox1.Checked = true;
        }
        private static readonly string[] VietNamChar = new string[]
        {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
        };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        private void show_map_Click(object sender, EventArgs e)
        {
            string[] types = new string[] { "m", "k", "h", "p", "e" };
            string dc = LocDau(name_Location.Text).ToString();
            string url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1}",
                types[map_type.SelectedIndex], dc);
            if (checkBox1.Checked)
                url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1},{2}",
                    types[map_type.SelectedIndex], lat.Text, lon.Text);
            webBrowser1.Navigate(url);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                name_Location.Enabled = false;
                lat.Enabled = true;
                lon.Enabled = true;
            }
            else
            {
                name_Location.Enabled = true;
                lat.Enabled = false;
                lon.Enabled = false;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            //lưu url và database
            string url = webBrowser1.Url.ToString();
        }
    }
}
