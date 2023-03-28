using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteChat
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        static Dictionary<string, Socket> ClientConItems = new Dictionary<string, Socket>();
        Socket socketsend;
        void Listen(object o)
        {
            Socket Dog = o as Socket;
            while (true)
            {
                socketsend = Dog.Accept();
                
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sakura12546 v0.01");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random RDPort = new Random();
            PortBox.Text = RDPort.Next(1000, 65535).ToString();//获取随机端口号
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Socket Dog = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress IP = IPAddress.Any;
                IPEndPoint point = new IPEndPoint(IP, Convert.ToInt32(this.PortBox.Text));
                //Socket绑定IP和端口号
                Dog.Bind(point);
                //监听队列
                Dog.Listen(10);
                Thread thread = new Thread(Listen);
                thread.IsBackground = true;
                thread.Start(Dog);
                Status.Text = "Starting.";
                RandPort.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("我们喵到了一个Bug!" + ex.Message);
                throw;
            }
            static void ConnectingDog()
            {
                Socket connection = null;
                //持续监听客户端
                while (true)
                {
                    try
                    {

                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show("我们喵到了一个Bug!" + ex1);
                    }
                }
            }
        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void Server_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
            
        }
    }
}
