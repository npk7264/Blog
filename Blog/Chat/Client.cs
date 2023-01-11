using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Blog.Chat
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        private string idUser;

        public Client(string id) : this()
        {
            idUser = id;
            //Control.CheckForIllegalCrossThreadCalls = false;
            //Connect();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
            txbMessage.Clear();
        }
        IPEndPoint ipe;
        TcpClient tcpClient;
        Stream stream;
        void Connect()
        {
            string port = "9999";
            ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(port));
            tcpClient = new TcpClient();
            tcpClient.Connect(ipe);
            stream = tcpClient.GetStream();
            Thread recv = new Thread(Recieve);
            recv.IsBackground = true;
            recv.Start();

        }
        void Send()
        {
            byte[] data = Encoding.UTF8.GetBytes(txbMessage.Text);
            stream.Write(data, 0, data.Length);
            Addmessage("Me: " + txbMessage.Text);
        }
        void Recieve()
        {
            while (true)
            {
                byte[] recv = new byte[1024];
                stream.Read(recv, 0, recv.Length);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage("You: " + s);
            }
        }

        void Addmessage(string mess)
        {
            lsvMessage.Items.Add(mess);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + idUser + "'");
            picAvr.BackgroundImage = Image.FromFile("avatar/" + avt);
            lbName.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + idUser + "'");
        }

    }
}
