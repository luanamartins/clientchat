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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            displayMessageBox.Text = "";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            displayMessageBox.Text = displayMessageBox.Text + userMessageBox.Text + Environment.NewLine;
            userMessageBox.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            userMessageBox.Text = "";
        }
    }
}
