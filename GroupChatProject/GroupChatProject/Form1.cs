using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace GroupChatProject
{
    public partial class Form1 : Form
    {
        Socket socket; 

        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            bool ValidateIP = IPAddress.TryParse(txt_serverip.Text, out ip); 
            if (txt_username.Text == "") 
            {
                errorProvider1.SetError(txt_username,"Username Required");
            }
            else if (txt_serverip.Text == "")
            {
                errorProvider2.SetError(txt_serverip, "Server IP Required");
            }
            else if(txt_port.Text=="")
            {
                errorProvider3.SetError(txt_port, "Port Required");
            }
            else if (!ValidateIP) 
            {
                errorProvider2.SetError(txt_serverip, "Not Valid IP Address");
            }
            else
            {
                try
                {
                    socket.Connect(new IPEndPoint(IPAddress.Parse(txt_serverip.Text), int.Parse(txt_port.Text)));
                    SocketHelp.SendVarData(socket, ASCIIEncoding.ASCII.GetBytes(txt_username.Text));
                    Form main = new Main(txt_serverip.Text, int.Parse(txt_port.Text), txt_username.Text, socket);
                    main.Show();
                    this.Hide();    
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                
            }
        }

        private void txt_serverip_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_serverip_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
           
        }

          private void panel6_Paint(object sender, PaintEventArgs e)
          {

          }
     }
}
