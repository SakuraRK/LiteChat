using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteChat
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Socket socketSend;
        private void Client_Load(object sender, EventArgs e)
        {

        }
        bool A = false;
        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                socketSend =new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(this.IPB.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(this.PB.Text));
                socketSend.Connect(point);
                Thread t = new Thread(Recv);
                t.IsBackground = true;
                t.Start();
                A = true;
                MessageBox.Show("连接成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                listBox1.Text = content;
                listBox1.Focus();
                AddContent(content);
            }));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (A==true) 
            {
                try
                {
                    listBox1.Items.Add(TB.Text);
                    
                }
                catch 
                {
                    
                }
            }
            else
            {
                MessageBox.Show("你尚未连接服务器！");
            }
            
        }
        void Recv()
        {
            while (true) 
            {
                try
                {
                    byte[] Pool = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(Pool);
                    if (r == 0) 
                    {
                        break;
                    }
                    if (Pool[0] == 1) 
                    {
                        string str = Encoding.UTF8.GetString(Pool);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }
        private void TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
