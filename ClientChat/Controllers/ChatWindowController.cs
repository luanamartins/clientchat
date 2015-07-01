using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientChat.Controllers
{
    class ChatWindowController
    {

        private static List<string> GetListOfFriends()
        { 
            // TODO make request of a list of friends 
            List<string> listOfFriends = new List<string>();
            listOfFriends.Add("Name 1");
            listOfFriends.Add("Name 2");
            listOfFriends.Add("Name 3");
            return listOfFriends;
        }


        internal static void AddFriendTableLayout(TableLayoutPanel table)
        {
            Button button = new Button();
            button.Text = "Friend";
            button.BackColor = new System.Drawing.Color();
            table.Controls.Add(button);
            
            List<string> listOfFriends = GetListOfFriends();
            foreach(string friendName in listOfFriends)
            {
                Label label = new Label();
                label.Text = friendName;
                table.Controls.Add(label);
            }
        }
    }
}
