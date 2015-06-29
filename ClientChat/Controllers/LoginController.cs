using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientChat.Controllers
{
    class LoginController
    {

        WebProxy webProxy = new WebProxy(ClientChat.Utils.RequestConstants.IP_ADDRESS, ClientChat.Utils.RequestConstants.PORT);
        public bool login(string username, string password) 
        { 
            // Make a request for the server in order to authenticate
            
            return true;
        }
    }
}
