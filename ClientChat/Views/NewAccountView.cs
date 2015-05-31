using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginView().Show();
        }
    }
}
