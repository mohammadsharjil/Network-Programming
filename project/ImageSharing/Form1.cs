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
using System.Threading;
using System.IO;
using System.Drawing.Imaging;


namespace ImageSharing
{
     public partial class Form1 : Form
     {
          IPAddress ip;
          EndPoint EpLocal, EpRemote;
          Socket soc;
          string message;
          byte[] buffer;
          public static byte[] imageByte;
          byte[] messageByte;
          string path;
          public static string imgName;
          
          string[] data;
          int pointer = 0;

          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               //string check = "THExxQUICKxxBROWNxxFOX";
               //data = check.Split(new[] { "xx" }, StringSplitOptions.None);
               //MessageBox.Show(data[0]);
               IPHostEntry iphe = Dns.GetHostByName(Dns.GetHostName());
               ip = iphe.AddressList[0];               
               textBox1.Text = ip.ToString();
               textBox2.Text = "8080";
               //me = "d34b31a2583c7a50100661044e6b0051";
               soc = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);               
               //EpLocal = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
               //soc.Bind(EpLocal);
               
               //IPEndPoint ipep = (IPEndPoint)soc.LocalEndPoint;
               //MessageBox.Show("IPAddress:Port = "+ipep);
               
          }

          private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void label6_Click(object sender, EventArgs e)
          {

          }

          private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void label5_Click(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               
               EpLocal = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
               soc.Bind(EpLocal);
               try
               {
                MessageBox.Show("Connection Established: ","Information Status" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    EpRemote = new IPEndPoint(IPAddress.Parse(textBox4.Text), Convert.ToInt32(textBox3.Text));
                    soc.Connect(EpRemote);
                    buffer = new byte[26214400];
                    soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(MessageCallBack),buffer);
                    //soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(ImageCallBack), buffer);
                    listBox1.Visible = true;
                    textBox5.Visible = true;
                    button2.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    textBox5.Visible = true;
                    button3.Visible = true;
                    listBox2.Visible = true;
               }
               catch (SocketException)
               {
                    MessageBox.Show("Unable To Connect...");
               }


          }

          private void button2_Click(object sender, EventArgs e)
          {
               try
               {
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    buffer = new byte[26214400];
                    if (pointer == 1)
                    {
                         imageByte = new byte[26214350];
                         messageByte = new byte[50];
                         ////File.WriteAllBytes("temp.JPG", buffer);
                         //imageByte = File.ReadAllBytes("Temp.JPG");
                         buffer = File.ReadAllBytes(imgName);
                         messageByte = aEncoding.GetBytes(textBox5.Text);
                         //buffer = messageByte.Concat(Encoding.ASCII.GetBytes(me)).Concat(imageByte).ToArray();
                         soc.Send(buffer);
                         listBox1.Items.Add("Me : " + textBox5.Text);
                         textBox5.Text = "";
                         MessageBox.Show("Send Success...");
                    }
                    else if (pointer == 0)
                    {
                         buffer = aEncoding.GetBytes(textBox5.Text);
                         soc.Send(buffer);
                         listBox1.Items.Add("Me : " + textBox5.Text);
                         textBox5.Text = "";
                         MessageBox.Show("Send Success...");
                    }
               }
               catch (Exception)
               {
                    Console.WriteLine("Message Size Is Too Large...");
               }

          }

          private void MessageCallBack(IAsyncResult aResult)
          {
               try
               {

                    buffer = new byte[26214400];
                    //soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(MessageCallBack), soc);
                    buffer = (byte[])aResult.AsyncState;
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    message = aEncoding.GetString(buffer);

                    if (pointer == 1)
                    {
                         ImageConverter converter = new ImageConverter();
                         Image img = (Image)converter.ConvertFrom(buffer);
                         pictureBox1.Image = img;
                         pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                         File.WriteAllBytes("1.JPG", buffer);
                         MessageBox.Show("Message Received...!");
                         buffer = new byte[26214400];
                         soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(MessageCallBack), buffer);
                    }
                    else
                    {
                         listBox1.Items.Add("Friend : " + message);
                         buffer = new byte[26214400];
                         soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(MessageCallBack), buffer);
                    }
                    
               }
               catch(SocketException se)
               {
                    MessageBox.Show(se.ToString());
               }
          }

          private void textBox5_TextChanged(object sender, EventArgs e)
          {

          }

          private void richTextBox1_TextChanged(object sender, EventArgs e)
          {

          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {

          }

          private void button3_Click(object sender, EventArgs e)
          {
               try
               {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.ShowDialog();
                    path = openFileDialog1.FileName;
                    imgName = openFileDialog1.SafeFileName;
                    pictureBox1.Image = Image.FromFile(path);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    MessageBox.Show("Image Name : "+imgName);
                    buffer = new byte[26214400];
                    
                    buffer = File.ReadAllBytes(path);
                    File.WriteAllBytes(imgName, buffer);
                    textBox5.Text = imgName;
                    listBox2.Items.Add(imgName);
                    pointer = 1;
                    
               }
               catch (Exception)
               {
                    pointer = 0;
                    MessageBox.Show("No Picture Is Selected...");
               }

          }

          private void ImageCallBack(IAsyncResult aResult)
          {
               try
               {

                    buffer = new byte[26214400];
                    //soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(MessageCallBack), soc);
                    buffer = (byte[])aResult.AsyncState;
                    
                    ImageConverter converter = new ImageConverter();
                    Image img = (Image)converter.ConvertFrom(buffer);
                    pictureBox1.Image = img;
                    File.WriteAllBytes("1.JPG", buffer);
                    MessageBox.Show("Message Received...!");
                    listBox2.Items.Add("1.JPG");
                    buffer = new byte[26214400];
                    soc.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref EpRemote, new AsyncCallback(ImageCallBack), buffer);

               }
               catch (SocketException se)
               {
                    MessageBox.Show(se.ToString());
               }
          }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
          {
               imageByte = new byte[26214350];
               imgName = listBox2.SelectedItem.ToString();
               imageByte = File.ReadAllBytes(imgName);               
               Form f = new Form2();
               this.Hide();
               f.Show();
          }
     }
}
