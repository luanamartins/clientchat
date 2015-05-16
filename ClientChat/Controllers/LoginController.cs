using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientChat.Controllers
{
    class LoginController
    {

        WebProxy p = new WebProxy(ClientChat.Utils.Constants.SERVER_IP_ADDRESS, ClientChat.Utils.Constants.SERVER_PORT);

        public bool login(string username, string password) 
        { 
            // Make a request for the server in order to authenticate
            
            return true;
        }
    }
}
