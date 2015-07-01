﻿using System;
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
            UpdateSettings();
            this.Close();           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSettings()
        {
            Singleton.GetInstance().SetIpAddress(serverAddressTextbox.Text);
            Singleton.GetInstance().SetPort(Convert.ToInt32(portTextbox.Text));
            this.Close();
        }
    }
}
