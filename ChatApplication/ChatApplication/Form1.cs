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

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string Encrypt(int rail, string plainText)
        {
             List<string> railFence = new List<string>();
             for (int i = 0; i < rail; i++)
             {
                  railFence.Add("");
             }

             int number = 0;
             int increment = 1;
             foreach (char c in plainText)
             {
                  if (number + increment == rail)
                  {
                       increment = -1;
                  }
                  else if (number + increment == -1)
                  {
                       increment = 1;
                  }
                  railFence[number] += c;
                  number += increment;
             }

             string buffer = "";
             foreach (string s in railFence)
             {
                  buffer += s;
             }
             return buffer;
        }

        public static string Decrypt(int rail, string cipherText)
        {
             int cipherLength = cipherText.Length;
             List<List<int>> railFence = new List<List<int>>();
             for (int i = 0; i < rail; i++)
             {
                  railFence.Add(new List<int>());
             }

             int number = 0;
             int increment = 1;
             for (int i = 0; i < cipherLength; i++)
             {
                  if (number + increment == rail)
                  {
                       increment = -1;
                  }
                  else if (number + increment == -1)
                  {
                       increment = 1;
                  }
                  railFence[number].Add(i);
                  number += increment;
             }

             int counter = 0;
             char[] buffer = new char[cipherLength];
             for (int i = 0; i < rail; i++)
             {
                  for (int j = 0; j < railFence[i].Count; j++)
                  {
                       buffer[railFence[i][j]] = cipherText[counter];
                       counter++;
                  }
             }

             return new string(buffer);
        }

         //End of realfence cipher


         //Start of ceaser cipher

        public static char cipher(char ch, int key)
        {
             if (!char.IsLetter(ch))
             {
                  return ch;
             }
             char d = char.IsUpper(ch) ? 'A' : 'a';
             return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Encipher(string input, int key)
        {
             string output = string.Empty;

             foreach (char ch in input)
                  output += cipher(ch, key);

             return output;
        }
        public static string Decipher(string input, int key)
        {
             return Encipher(input, 26 - key);
        }  

         //end of ceaser cipher

        int key = 17;
        Socket soc;
        EndPoint mEp, fEp;
        byte[] buffer = new byte[1024];

        private void button2_Click(object sender, EventArgs e)
        {
            soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            soc.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);


            //Binding Socket
            mEp = new IPEndPoint(IPAddress.Parse(mIp.Text), Convert.ToInt32(mPort.Text));
            soc.Bind(mEp);

            //Connecting to Remote IP
            fEp = new IPEndPoint(IPAddress.Parse(fIp.Text), Convert.ToInt32(fPort.Text));
            soc.Connect(fEp);

            //Listening To The Specific Port
            soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref fEp, new AsyncCallback(MessageCallBack), buffer);
            button2.Enabled = false;
        }
        public void MessageCallBack(IAsyncResult aResult)
        {
            byte[] receivedData = new byte[1024];
            receivedData = (byte[])aResult.AsyncState;
            string receivedMessage = Encoding.ASCII.GetString(receivedData);
            
            listBox1.Items.Add("Friend: " + receivedMessage);

            buffer = new byte[1024];
            soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref fEp, new AsyncCallback(MessageCallBack), buffer);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mIp.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            fIp.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (msg.Text != " ")
             {
                  string userString = msg.Text;
                  string cipherText = Encipher(userString, key);
                  cipherText = Encrypt(key, cipherText);
                  string decrptText = Decrypt(key, cipherText);
                  string text = Decipher(decrptText, key);
                  byte[] sendingMessage = new byte[1024];
                  string[] split = decrptText.Split(' ');
                  string msgsend = " ";
                  List<string> abusive = new List<string> { "Kameena", "Kuttay", "Zaleel" };
                  for (int i = 0; i < split.Length; i++)
                  {
                       for (int j = 0; j < abusive.Count; j++)
                       {
                            if (split[i] == abusive[j])
                            {
                                 split[i] = "****";
                                 break;
                            }

                       }
                       msgsend = msgsend + " " + split[i];
                  }
                  sendingMessage = Encoding.ASCII.GetBytes(msgsend);
                  soc.Send(sendingMessage);

                  listBox1.Items.Add("Me: " + text);
             }
             else {
                  MessageBox.Show("write some text to send");
             }
        }
    }
}
