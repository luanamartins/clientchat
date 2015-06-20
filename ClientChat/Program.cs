using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

using ClientChat.Utils;

namespace ClientChat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView());*/
            
            try
            {
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpclnt.Connect(RequestConstants.IP_ADDRESS, RequestConstants.PORT);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                Console.Write("Enter the string to be transmitted : ");

                String str = "Mensagem a ser enviada";
                Stream stream = tcpclnt.GetStream();

                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] ba = encoding.GetBytes(str);
                Console.WriteLine("Transmitting.....");

                stream.Write(ba, 0, ba.Length);



                byte[] bb = new byte[100];
                int k = stream.Read(bb, 0, 100);

                for (int i = 0; i < k; i++)
                    Console.Write(Convert.ToChar(bb[i]));

                tcpclnt.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error..... " + e.StackTrace);
            }


        }
    }
}
