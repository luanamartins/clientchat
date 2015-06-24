using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClientChat.Controllers;

namespace ClientChat.Views
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            updateSettings();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateSettings()
        {
            Singleton.getInstance().setIpAddress(serverAddressTextbox.Text);
            Singleton.getInstance().setPort(Convert.ToInt32(portTextbox.Text));
            this.Close();
        }
    }
}
