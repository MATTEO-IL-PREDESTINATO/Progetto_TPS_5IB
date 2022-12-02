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

namespace TV
{
    public partial class Form1 : Form
    {
        private bool serverOn = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!serverOn)
            {
                Task taskServingClient = Task.Run(() => { Server.StartListening(label_stato_tv, label_volume, label_canale); });
                serverOn = true;
                guna2Button1.Text = "Server Acceso";
            }
            else
            {
                MessageBox.Show("SERVER GIA' AVVIATO");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

   
