using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageSharing
{
     public partial class Form2 : Form
     {
          public Form2()
          {
               InitializeComponent();
          }

          private void Form2_Load(object sender, EventArgs e)
          {
               ImageConverter converter = new ImageConverter();
               Image img = (Image)converter.ConvertFrom(Form1.imageByte);
               pictureBox1.Image = img;
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               label1.Text = Form1.imgName;
          }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
