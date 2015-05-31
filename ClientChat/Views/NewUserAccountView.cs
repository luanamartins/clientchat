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
    public partial class NewUserAccountView : Form
    {
        public NewUserAccountView()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // TODO Create new user
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginView().Show();
        }
    }
}
