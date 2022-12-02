using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TELECOMANDO
{
    internal class Client
    {
        public static string data = null;

        public static void StartListening(string input)
        {
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                string data = "";

                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                Socket sender = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                string stringa_da_inviare = "";

                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                        stringa_da_inviare = input+"$";
                        byte[] msg = Encoding.ASCII.GetBytes(stringa_da_inviare);              //("This is a test<EOF>");

                        int bytesSent = sender.Send(msg);
                        data = "";

                        //System.Threading.Thread.Sleep(1000);

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
