using System;

namespace ClientChat.Controllers
{
    public class Singleton
    {
        private static Singleton singleton;

        private String serverIpAddress;
        private int serverPort;

        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }

            return singleton;
        }

        public void SetIpAddress(String ipAddress)
        {
            this.serverIpAddress = ipAddress;
        }

        public void SetPort(int port)
        {
            this.serverPort = port;
        }
    }
}