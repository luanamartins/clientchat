namespace ClientChat.Views
{
    partial class SettingsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serverAddress = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.serverAddressTextbox = new System.Windows.Forms.TextBox();
            this.portTextbox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverAddress
            // 
            this.serverAddress.AutoSize = true;
            this.serverAddress.Location = new System.Drawing.Point(44, 28);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(92, 13);
            this.serverAddress.TabIndex = 0;
            this.serverAddress.Text = "Server IP Address";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(44, 60);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(59, 13);
            this.labelPort.TabIndex = 1;
            this.labelPort.Text = "Server port";
            // 
            // serverAddressTextbox
            // 
            this.serverAddressTextbox.Location = new System.Drawing.Point(164, 25);
            this.serverAddressTextbox.Name = "serverAddressTextbox";
            this.serverAddressTextbox.Size = new System.Drawing.Size(141, 20);
            this.serverAddressTextbox.TabIndex = 2;
            // 
            // portTextbox
            // 
            this.portTextbox.Location = new System.Drawing.Point(164, 60);
            this.portTextbox.Name = "portTextbox";
            this.portTextbox.Size = new System.Drawing.Size(141, 20);
            this.portTextbox.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(90, 110);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(222, 110);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 165);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.portTextbox);
            this.Controls.Add(this.serverAddressTextbox);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.serverAddress);
            this.Name = "SettingsView";
            this.Text = "SettingsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverAddress;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox serverAddressTextbox;
        private System.Windows.Forms.TextBox portTextbox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}