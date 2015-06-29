using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

using ClientChat.Utils;

namespace ClientChat.Controllers
{

    /**
     Logging: https://codingsexy.wordpress.com/2013/07/07/log4net-code/
     */

    internal class Controller
    {
        public void loginRequest(string login, string password)
        {
        }

        public void connectTest(String message) 
        {
            try
            {
                TcpClient tcpClient = new TcpClient();
                Console.WriteLine("Connecting.....");

                tcpClient.Connect(RequestConstants.IP_ADDRESS, RequestConstants.PORT);
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                Console.Write("Enter the string to be transmitted : ");

                //String message = "Mensagem a ser enviada";
                Stream stream = tcpClient.GetStream();

                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] messageBytes = encoding.GetBytes(message);
                Console.WriteLine("Transmitting.....");

                stream.Write(messageBytes, 0, messageBytes.Length);

                byte[] messageReceivedBytes = new byte[100];
                int sequenceOfBytes = stream.Read(messageReceivedBytes, 0, 100);

                for (int i = 0; i < sequenceOfBytes; i++)
                    Console.Write(Convert.ToChar(messageReceivedBytes[i]));

                tcpClient.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }
    }
}