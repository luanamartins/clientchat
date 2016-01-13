using System.Net;

namespace ClientChat.Controllers
{
    internal class LoginController
    {
        private WebProxy webProxy = new WebProxy(ClientChat.Utils.RequestConstants.IP_ADDRESS, ClientChat.Utils.RequestConstants.PORT);

        public bool Login(string username, string password)
        {
            // Make a request for the server in order to authenticate

            return true;
        }
    }
}