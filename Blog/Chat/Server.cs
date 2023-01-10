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
namespace Blog.Chat
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        private string idUser;
        public Server(string id):this()
        {
            idUser = id;
            //Control.CheckForIllegalCrossThreadCalls = false;
            //Connect();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            client.Close();
            tcplisten.Stop();
            this.Close();
        }

     
        private void btnSend_Click(object sender, EventArgs e)
        {
            Send(client);
            txbMessage.Clear();
        }

        IPEndPoint ipe;
        Socket client;
        TcpListener tcplisten;
        void Connect()
        {
            string port = "9999";
            ipe = new IPEndPoint(IPAddress.Parse("26.64.90.17"), int.Parse(port));
            tcplisten = new TcpListener(ipe);


            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    tcplisten.Start();
                    client = tcplisten.AcceptSocket();
                    Thread rec = new Thread(Recieve);
                    rec.IsBackground = true;
                    rec.Start(client);
                }

            });
            thread.IsBackground = true;
            thread.Start();
        }
        void Send(Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(txbMessage.Text);
            client.Send(data);
            Addmessage("Me: " + txbMessage.Text);
        }
        void Recieve(object obj)
        {
            while (true)
            {
                Socket client = obj as Socket;
                byte[] recv = new byte[1024];
                client.Receive(recv);
                string s = Encoding.UTF8.GetString(recv);
                Addmessage("You: " + s);
            }

        }

        void Addmessage(string mess)
        {
            lsvMessage.Items.Add(mess);
        }

        private void Server_Load(object sender, EventArgs e)
        {
            string avt = Functions.GetFieldValues("select Avatar from TAIKHOAN where TenDangNhap = N'" + idUser + "'");
            picAvr.BackgroundImage = Image.FromFile("avatar/" + avt);
            lbName.Text = Functions.GetFieldValues("select Ten from TAIKHOAN where TenDangNhap = N'" + idUser + "'");
        }
    }
}
