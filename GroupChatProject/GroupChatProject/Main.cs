using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace GroupChatProject
{
    public partial class Main : Form
    {
        public string u = null;
        public string s_ip = null;
        public int p = 0;
        Socket server;

        //private TextBox newText;
        //private TextBox conStatus;
        //private ListBox results;
        private Socket client;
        private byte[] data = new byte[1024];
        private int size = 1024;

        public Main(string ip, int port, string name, Socket server)
        {
            InitializeComponent();
            label6.Enabled = false;
            p = port;
            s_ip = ip;
            u = name;
            this.server = server;
            byte[] onlineUsers = SocketHelp.ReceiveVarData(server);
            String onlin = ASCIIEncoding.ASCII.GetString(onlineUsers);
            if (onlin.IndexOf(",") != -1)
            {
                String[] users = onlin.Split(',');
                foreach (var item in users)
                {
                    listBox2.Items.Add(item);
                }
            }
            else
            {
                listBox2.Items.Add(onlin);
            }
            Thread thread = new Thread(new ThreadStart(RecieveMessage));
            thread.Start();
        }


        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SocketHelp.SendVarData(server, ASCIIEncoding.ASCII.GetBytes("quit"));
            server.Close();
            System.Environment.Exit(0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_username.Text =u;
            lbl_serverip.Text = s_ip;
            lbl_port.Text = p.ToString();
            //listBox1.Items.Add("list box");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sendit_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(txt_newtext.Text);
            txt_newtext.Clear();
            SocketHelp.SendVarData(server, message);
            
        }

        private void btn_discon_Click(object sender, EventArgs e)
        {
            client.Close();
            lbl_constatus.Text = "Disconnected";
        }

        public void RecieveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] message = SocketHelp.ReceiveVarData(server);
                    String msg = ASCIIEncoding.ASCII.GetString(message);
                    if (msg.IndexOf("Leaving") != -1)
                    {
                        String[] msgArr = msg.Split(' ');
                        listBox2.Invoke(new MethodInvoker(delegate { listBox2.Items.Remove(msgArr[0]); }));
                    }
                    else if (msg.IndexOf("Joined") != -1)
                    {
                        String[] msgArr = msg.Split(' ');
                        listBox2.Invoke(new MethodInvoker(delegate { listBox2.Items.Add(msgArr[0]); }));
                    }
                    else
                    {
                        listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add(msg); }));
                    }


                }
                catch (Exception)
                {
                }
                                
                //listBox1.Items.Add(ASCIIEncoding.ASCII.GetString(message));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.ASCII.GetBytes(txt_newtext.Text);
            txt_newtext.Clear();
            SocketHelp.SendVarData(server, message);
        }

        private void txt_newtext_TextChanged(object sender, EventArgs e)
        {
            if (txt_newtext.Text == string.Empty)
            {
                label6.Enabled = false;
            }
            else 
            {
                label6.Enabled = true;
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
