using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientChat
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            Views.MainView v = new Views.MainView();
            this.Hide();
            v.Show();
            
        }

        private void newUserAccountButton_Click(object sender, EventArgs e)
        {
            Views.NewAccountView v = new Views.NewAccountView();
            this.Hide();
            v.Show();
        }

    }
}
