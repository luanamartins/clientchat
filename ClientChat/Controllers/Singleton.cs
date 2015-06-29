using System;

namespace ClientChat.Controllers
{
    public class Singleton
    {
        private static Singleton singleton;

        private String serverIpAddress;
        private int serverPort;

        public static Singleton getInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
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