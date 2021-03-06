﻿using System;
using System.Windows.Forms;

namespace ClientChat.Views
{
    public partial class NewAccountView : Form
    {
        public NewAccountView()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // TODO Send new user information for server
            string name = textBoxName.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginView().Show();
        }
    }
}