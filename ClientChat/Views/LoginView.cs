using System;
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Views.SettingsView view = new Views.SettingsView();
            this.Hide();
            view.Show();
        }

        public void insertImage()
        {
            // UNDONE
            pictureBoxLogo.ImageLocation = "../SamuderaJayaMotor.png";
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}