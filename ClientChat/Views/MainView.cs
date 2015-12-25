using ClientChat.Controllers;
using ClientChat.Utils;
using System;
using System.Windows.Forms;

namespace ClientChat.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            displayMessageBox.Text = "";
            ChatWindowController.AddFriendTableLayout(tableUserFriendsLayout);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!displayMessageBox.Equals(RequestConstants.REQUEST_MESSAGE_EMPTY))
            {
                displayMessageBox.Text = displayMessageBox.Text + "Login> " + userMessageBox.Text + Environment.NewLine;
                cleanMessageBox();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cleanMessageBox();
        }

        private void cleanMessageBox()
        {
            userMessageBox.Text = RequestConstants.REQUEST_MESSAGE_EMPTY;
        }

        private void addOnlineFriends()
        {
            // UNDONE addOnlineFriends
            tableUserFriendsLayout.Controls.Add(new Label() { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true });
        }

        private void SendfilesButton_Click(object sender, EventArgs e)
        {
            // TODO Sendfiles
        }
    }
}