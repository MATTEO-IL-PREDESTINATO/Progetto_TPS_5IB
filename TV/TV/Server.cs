using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TV
{
    internal class Server
    {
        public static string data = null;
        public static int volu;
        public static int cana;
        public static string stato = null;
        public static bool acceso = false;

        public static void StartListening(Label label_stato_tv, Label vol, Label can)
        {
            byte[] bytes = new Byte[1024];

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    Socket handler = listener.Accept();

                    Task taskServingClient = Task.Run(() => { doClient(handler, label_stato_tv, vol, can, bytes); });

                    data = "";
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public static void doClient(Socket handler, Label label_stato_tv, Label label_volume, Label label_canale, byte[] bytes)
        {
            data = "";
            while(true)
            {
                bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf("$") > -1)
                {
                    break;
                }
            }

            Debug.WriteLine("Text received : {0}", data);
            while (data.IndexOf("$") == -1)
            {
                int bytesRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }

            if (data == "generale$")
            {
                if (acceso == false)
                {
                    acceso = true;
                    stato = "ACCESO";
                }
                else
                {
                    acceso = false;
                    stato = "SPENTO";
                }

                label_stato_tv.Invoke((MethodInvoker)delegate ()
                {
                    label_stato_tv.Text = stato;
                });
            }

            if (label_stato_tv.Text == "ACCESO")
            {
                if (data == "volume+$")
                {
                    volu = Convert.ToInt32(label_volume.Text);
                    if (volu >= 0 && volu <= 45)
                    {
                        volu = volu + 5;

                        label_volume.Invoke((MethodInvoker)delegate ()
                        {
                            label_volume.Text = volu.ToString();
                        });
                    }
                    else
                        MessageBox.Show("volume troppo alto!");
                }
                if (data == "volume-$")
                {
                    volu = Convert.ToInt32(label_volume.Text);
                    if (volu >= 5 && volu <= 50)
                    {
                        volu = volu - 5;

                        label_volume.Invoke((MethodInvoker)delegate ()
                        {
                            label_volume.Text = volu.ToString();
                        });
                    }
                    else
                        MessageBox.Show("Volume troppo basso!");
                }
                if(data == "canale+$")
                {
                    cana = Convert.ToInt32(label_canale.Text);
                    if (cana >= 0 && cana <= 49)
                    {
                        cana = cana + 1;

                        label_canale.Invoke((MethodInvoker)delegate ()
                        {
                            label_canale.Text = cana.ToString();
                        });
                    }
                    else
                        MessageBox.Show("Canale inesistente");
                }
                if (data == "canale-$")
                {
                    cana = Convert.ToInt32(label_canale.Text);
                    if (cana >= 1 && cana <= 50)
                    {
                        cana = cana - 1;

                        label_canale.Invoke((MethodInvoker)delegate ()
                        {
                            label_canale.Text = cana.ToString();
                        });
                    }
                    else
                        MessageBox.Show("Canale inesistente");
                }
            }
            
                    
            // Show the data on the console.  
            Console.WriteLine("Messaggio ricevuto : {0}", data);
            // Echo the data back to the client.  
            byte[] msg = Encoding.ASCII.GetBytes(data);

            handler.Send(msg);

            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
    }
}
