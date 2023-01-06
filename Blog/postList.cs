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
    public partial class postList : Form
    {
        private string nameList;
        public postList()
        {
            InitializeComponent();
        }

        //hàm truyền dữ liệu cho form 
        public postList(string Message):this()
        {
            //Biến Message cho biến đây là danh sách gì để hiện thị các bài post tương ứng
            /*Message có các giá trị là 
              yêu thích
              đã lưu
              đã bình luận*/
            nameList = Message;
            lbList.Text = "Danh sách bài viết " + Message;
        }
    }
}
