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

        public void ConnectTCP(String message) 
        {
            try
            {
                TcpClient tcpClient = new TcpClient();

                PrintOnConsole("Connecting.....");

                tcpClient.Connect(RequestConstants.IP_ADDRESS, RequestConstants.PORT);

                PrintOnConsole("Connected");
                PrintOnConsole("Enter the string to be transmitted : ");

                Stream stream = tcpClient.GetStream();

                SendMessage(message, stream);

                String receivedMessage = ReceiveMessage(stream);

                CloseConnection(tcpClient);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Error..... " + e.StackTrace);
            }
        }

        public void SendMessage(String message, Stream stream) 
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] messageBytes = encoding.GetBytes(message);
            Console.WriteLine("Transmitting.....");

            stream.Write(messageBytes, 0, messageBytes.Length);
        }

        public String ReceiveMessage(Stream stream)
        {
            byte[] messageReceivedBytes = new byte[100];
            int sequenceOfBytes = stream.Read(messageReceivedBytes, 0, 100);
            String receivedMessage = messageReceivedBytes.ToString();
            for (int i = 0; i < sequenceOfBytes; i++)
                Console.Write(Convert.ToChar(messageReceivedBytes[i]));
            return receivedMessage;
        }

        public void CloseConnection(TcpClient tcpClient) 
        {
            tcpClient.Close();
        }

        public void PrintOnConsole(String message)
        {
            Console.WriteLine(message);
        }
    }
}