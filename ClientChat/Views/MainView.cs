﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClientChat.Controllers;
using ClientChat.Utils;

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
            if (!displayMessageBox.Equals(RequestConstants.EMPTY_MESSAGE))
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
            userMessageBox.Text = RequestConstants.EMPTY_MESSAGE;
        }

        private void addOnlineFriends() 
        {
            // UNDONE
            tableUserFriendsLayout.Controls.Add(new Label() { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true });
        }

        private void SendfilesButton_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
