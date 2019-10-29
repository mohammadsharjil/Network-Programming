namespace GroupChatProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.panel1 = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.panel3 = new System.Windows.Forms.Panel();
               this.panel4 = new System.Windows.Forms.Panel();
               this.panel5 = new System.Windows.Forms.Panel();
               this.panel6 = new System.Windows.Forms.Panel();
               this.panel7 = new System.Windows.Forms.Panel();
               this.label1 = new System.Windows.Forms.Label();
               this.panel8 = new System.Windows.Forms.Panel();
               this.label2 = new System.Windows.Forms.Label();
               this.panel12 = new System.Windows.Forms.Panel();
               this.txt_username = new System.Windows.Forms.TextBox();
               this.panel9 = new System.Windows.Forms.Panel();
               this.panel10 = new System.Windows.Forms.Panel();
               this.label3 = new System.Windows.Forms.Label();
               this.panel13 = new System.Windows.Forms.Panel();
               this.txt_serverip = new System.Windows.Forms.TextBox();
               this.panel11 = new System.Windows.Forms.Panel();
               this.panel14 = new System.Windows.Forms.Panel();
               this.label4 = new System.Windows.Forms.Label();
               this.panel15 = new System.Windows.Forms.Panel();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
               this.panel16 = new System.Windows.Forms.Panel();
               this.label5 = new System.Windows.Forms.Label();
               this.panel17 = new System.Windows.Forms.Panel();
               this.txt_port = new System.Windows.Forms.TextBox();
               this.panel18 = new System.Windows.Forms.Panel();
               this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
               this.panel6.SuspendLayout();
               this.panel7.SuspendLayout();
               this.panel8.SuspendLayout();
               this.panel12.SuspendLayout();
               this.panel10.SuspendLayout();
               this.panel13.SuspendLayout();
               this.panel14.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
               this.panel16.SuspendLayout();
               this.panel17.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.Black;
               this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(1, 403);
               this.panel1.TabIndex = 4;
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.Black;
               this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel2.Location = new System.Drawing.Point(297, 0);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(1, 403);
               this.panel2.TabIndex = 5;
               // 
               // panel3
               // 
               this.panel3.BackColor = System.Drawing.Color.Black;
               this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel3.Location = new System.Drawing.Point(1, 0);
               this.panel3.Name = "panel3";
               this.panel3.Size = new System.Drawing.Size(296, 1);
               this.panel3.TabIndex = 6;
               // 
               // panel4
               // 
               this.panel4.BackColor = System.Drawing.Color.Black;
               this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel4.Location = new System.Drawing.Point(1, 402);
               this.panel4.Name = "panel4";
               this.panel4.Size = new System.Drawing.Size(296, 1);
               this.panel4.TabIndex = 7;
               // 
               // panel5
               // 
               this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
               this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.panel5.Location = new System.Drawing.Point(2, 44);
               this.panel5.Name = "panel5";
               this.panel5.Size = new System.Drawing.Size(294, 82);
               this.panel5.TabIndex = 8;
               // 
               // panel6
               // 
               this.panel6.BackColor = System.Drawing.Color.Gainsboro;
               this.panel6.Controls.Add(this.panel7);
               this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
               this.panel6.Location = new System.Drawing.Point(1, 1);
               this.panel6.Name = "panel6";
               this.panel6.Size = new System.Drawing.Size(296, 25);
               this.panel6.TabIndex = 9;
               this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
               // 
               // panel7
               // 
               this.panel7.BackColor = System.Drawing.Color.Red;
               this.panel7.Controls.Add(this.label1);
               this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel7.Location = new System.Drawing.Point(271, 0);
               this.panel7.Name = "panel7";
               this.panel7.Size = new System.Drawing.Size(25, 25);
               this.panel7.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(4, 2);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(20, 20);
               this.label1.TabIndex = 0;
               this.label1.Text = "X";
               this.label1.Click += new System.EventHandler(this.label1_Click_1);
               // 
               // panel8
               // 
               this.panel8.BackColor = System.Drawing.Color.Gainsboro;
               this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel8.Controls.Add(this.label2);
               this.panel8.Controls.Add(this.panel12);
               this.panel8.Controls.Add(this.panel9);
               this.panel8.Location = new System.Drawing.Point(1, 159);
               this.panel8.Name = "panel8";
               this.panel8.Size = new System.Drawing.Size(295, 61);
               this.panel8.TabIndex = 10;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.ForeColor = System.Drawing.Color.DimGray;
               this.label2.Location = new System.Drawing.Point(14, 8);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(55, 13);
               this.label2.TabIndex = 2;
               this.label2.Text = "Username";
               // 
               // panel12
               // 
               this.panel12.BackColor = System.Drawing.Color.White;
               this.panel12.Controls.Add(this.txt_username);
               this.panel12.Location = new System.Drawing.Point(14, 29);
               this.panel12.Name = "panel12";
               this.panel12.Size = new System.Drawing.Size(276, 27);
               this.panel12.TabIndex = 1;
               // 
               // txt_username
               // 
               this.txt_username.Location = new System.Drawing.Point(3, 3);
               this.txt_username.Name = "txt_username";
               this.txt_username.Size = new System.Drawing.Size(256, 20);
               this.txt_username.TabIndex = 0;
               // 
               // panel9
               // 
               this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
               this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel9.Location = new System.Drawing.Point(0, 0);
               this.panel9.Name = "panel9";
               this.panel9.Size = new System.Drawing.Size(8, 59);
               this.panel9.TabIndex = 0;
               // 
               // panel10
               // 
               this.panel10.BackColor = System.Drawing.Color.Gainsboro;
               this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel10.Controls.Add(this.label3);
               this.panel10.Controls.Add(this.panel13);
               this.panel10.Controls.Add(this.panel11);
               this.panel10.Location = new System.Drawing.Point(1, 225);
               this.panel10.Name = "panel10";
               this.panel10.Size = new System.Drawing.Size(295, 61);
               this.panel10.TabIndex = 11;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.ForeColor = System.Drawing.Color.DimGray;
               this.label3.Location = new System.Drawing.Point(14, 8);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(51, 13);
               this.label3.TabIndex = 3;
               this.label3.Text = "Server IP";
               // 
               // panel13
               // 
               this.panel13.BackColor = System.Drawing.Color.White;
               this.panel13.Controls.Add(this.txt_serverip);
               this.panel13.Location = new System.Drawing.Point(14, 29);
               this.panel13.Name = "panel13";
               this.panel13.Size = new System.Drawing.Size(276, 27);
               this.panel13.TabIndex = 2;
               // 
               // txt_serverip
               // 
               this.txt_serverip.Location = new System.Drawing.Point(3, 3);
               this.txt_serverip.Name = "txt_serverip";
               this.txt_serverip.Size = new System.Drawing.Size(256, 20);
               this.txt_serverip.TabIndex = 0;
               this.txt_serverip.TextChanged += new System.EventHandler(this.txt_serverip_TextChanged);
               this.txt_serverip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serverip_KeyPress);
               // 
               // panel11
               // 
               this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
               this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel11.Location = new System.Drawing.Point(0, 0);
               this.panel11.Name = "panel11";
               this.panel11.Size = new System.Drawing.Size(8, 59);
               this.panel11.TabIndex = 0;
               // 
               // panel14
               // 
               this.panel14.BackColor = System.Drawing.Color.MediumTurquoise;
               this.panel14.Controls.Add(this.label4);
               this.panel14.Location = new System.Drawing.Point(112, 360);
               this.panel14.Name = "panel14";
               this.panel14.Size = new System.Drawing.Size(81, 28);
               this.panel14.TabIndex = 12;
               this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.ForeColor = System.Drawing.Color.White;
               this.label4.Location = new System.Drawing.Point(16, 7);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(47, 13);
               this.label4.TabIndex = 0;
               this.label4.Text = "Connect";
               this.label4.Click += new System.EventHandler(this.label4_Click);
               // 
               // panel15
               // 
               this.panel15.BackColor = System.Drawing.Color.Gainsboro;
               this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.panel15.Location = new System.Drawing.Point(1, 394);
               this.panel15.Name = "panel15";
               this.panel15.Size = new System.Drawing.Size(296, 8);
               this.panel15.TabIndex = 13;
               // 
               // errorProvider1
               // 
               this.errorProvider1.ContainerControl = this;
               // 
               // errorProvider2
               // 
               this.errorProvider2.ContainerControl = this;
               // 
               // panel16
               // 
               this.panel16.BackColor = System.Drawing.Color.Gainsboro;
               this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
               this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel16.Controls.Add(this.label5);
               this.panel16.Controls.Add(this.panel17);
               this.panel16.Controls.Add(this.panel18);
               this.panel16.Location = new System.Drawing.Point(1, 292);
               this.panel16.Name = "panel16";
               this.panel16.Size = new System.Drawing.Size(295, 61);
               this.panel16.TabIndex = 12;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.ForeColor = System.Drawing.Color.DimGray;
               this.label5.Location = new System.Drawing.Point(14, 8);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(26, 13);
               this.label5.TabIndex = 3;
               this.label5.Text = "Port";
               // 
               // panel17
               // 
               this.panel17.BackColor = System.Drawing.Color.White;
               this.panel17.Controls.Add(this.txt_port);
               this.panel17.Location = new System.Drawing.Point(14, 29);
               this.panel17.Name = "panel17";
               this.panel17.Size = new System.Drawing.Size(276, 27);
               this.panel17.TabIndex = 2;
               // 
               // txt_port
               // 
               this.txt_port.Location = new System.Drawing.Point(3, 3);
               this.txt_port.Name = "txt_port";
               this.txt_port.Size = new System.Drawing.Size(256, 20);
               this.txt_port.TabIndex = 0;
               // 
               // panel18
               // 
               this.panel18.BackColor = System.Drawing.Color.DodgerBlue;
               this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel18.Location = new System.Drawing.Point(0, 0);
               this.panel18.Name = "panel18";
               this.panel18.Size = new System.Drawing.Size(8, 59);
               this.panel18.TabIndex = 0;
               // 
               // errorProvider3
               // 
               this.errorProvider3.ContainerControl = this;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(298, 403);
               this.Controls.Add(this.panel16);
               this.Controls.Add(this.panel15);
               this.Controls.Add(this.panel14);
               this.Controls.Add(this.panel10);
               this.Controls.Add(this.panel8);
               this.Controls.Add(this.panel6);
               this.Controls.Add(this.panel5);
               this.Controls.Add(this.panel4);
               this.Controls.Add(this.panel3);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.KeyPreview = true;
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.panel6.ResumeLayout(false);
               this.panel7.ResumeLayout(false);
               this.panel7.PerformLayout();
               this.panel8.ResumeLayout(false);
               this.panel8.PerformLayout();
               this.panel12.ResumeLayout(false);
               this.panel12.PerformLayout();
               this.panel10.ResumeLayout(false);
               this.panel10.PerformLayout();
               this.panel13.ResumeLayout(false);
               this.panel13.PerformLayout();
               this.panel14.ResumeLayout(false);
               this.panel14.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
               this.panel16.ResumeLayout(false);
               this.panel16.PerformLayout();
               this.panel17.ResumeLayout(false);
               this.panel17.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txt_serverip;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

