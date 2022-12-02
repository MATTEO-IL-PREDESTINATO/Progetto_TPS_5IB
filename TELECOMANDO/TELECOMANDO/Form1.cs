using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;


namespace TELECOMANDO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        string input = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

        }

        private void Spegni_Accendi_Click(object sender, EventArgs e)
        {
            input = "generale";
            Task taskServingClient = Task.Run(() => { Client.StartListening(input); });
        }

        private void Alza_volume_Click(object sender, EventArgs e)
        {
            input = "volume+";
            Task taskServingClient = Task.Run(() => { Client.StartListening(input); });
        }

        private void Abbassa_volume_Click(object sender, EventArgs e)
        {
            input = "volume-";
            Task taskServingClient = Task.Run(() => { Client.StartListening(input); });
        }

        private void canale_successivo_Click(object sender, EventArgs e)
        {
            input = "canale+";
            Task taskServingClient = Task.Run(() => { Client.StartListening(input); });
        }

        private void canale_precedente_Click(object sender, EventArgs e)
        {
            input = "canale-";
            Task taskServingClient = Task.Run(() => { Client.StartListening(input); });
        }
    }
}

