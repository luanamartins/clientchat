using System;

namespace ClientChat.Controllers
{
    public class ServerConfiguration
    {
        private static ServerConfiguration singleton;

        private String serverIpAddress;
        private int serverPort;

        public static ServerConfiguration getInstance()
        {
            if (singleton == null)
            {
                singleton = new ServerConfiguration();
            }

            return singleton;
        }

        public void setIpAddress(String ipAddress)
        {
            this.serverIpAddress = ipAddress;
        }

        public void setPort(int port)
        {
            this.serverPort = port;
        }
    }
}