namespace ClientChat.Views
{
    partial class MainView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.displayMessageBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userMessageBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.tableUserFriendsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonHttp = new System.Windows.Forms.RadioButton();
            this.radioButtonHttps = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.displayMessageBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(162, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 170);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // displayMessageBox
            // 
            this.displayMessageBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayMessageBox.Location = new System.Drawing.Point(3, 3);
            this.displayMessageBox.Multiline = true;
            this.displayMessageBox.Name = "displayMessageBox";
            this.displayMessageBox.ReadOnly = true;
            this.displayMessageBox.Size = new System.Drawing.Size(365, 167);
            this.displayMessageBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonHttps);
            this.panel2.Controls.Add(this.radioButtonHttp);
            this.panel2.Controls.Add(this.userMessageBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.sendButton);
            this.panel2.Location = new System.Drawing.Point(162, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 132);
            this.panel2.TabIndex = 2;
            // 
            // userMessageBox
            // 
            this.userMessageBox.Location = new System.Drawing.Point(3, 32);
            this.userMessageBox.Multiline = true;
            this.userMessageBox.Name = "userMessageBox";
            this.userMessageBox.Size = new System.Drawing.Size(279, 97);
            this.userMessageBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(288, 83);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 46);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(288, 32);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(87, 45);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // tableUserFriendsLayout
            // 
            this.tableUserFriendsLayout.BackColor = System.Drawing.Color.White;
            this.tableUserFriendsLayout.ColumnCount = 1;
            this.tableUserFriendsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUserFriendsLayout.Location = new System.Drawing.Point(12, 3);
            this.tableUserFriendsLayout.Name = "tableUserFriendsLayout";
            this.tableUserFriendsLayout.RowCount = 8;
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableUserFriendsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableUserFriendsLayout.Size = new System.Drawing.Size(144, 286);
            this.tableUserFriendsLayout.TabIndex = 3;
            // 
            // radioButtonHttp
            // 
            this.radioButtonHttp.AutoSize = true;
            this.radioButtonHttp.Location = new System.Drawing.Point(4, 9);
            this.radioButtonHttp.Name = "radioButtonHttp";
            this.radioButtonHttp.Size = new System.Drawing.Size(54, 17);
            this.radioButtonHttp.TabIndex = 2;
            this.radioButtonHttp.TabStop = true;
            this.radioButtonHttp.Text = "HTTP";
            this.radioButtonHttp.UseVisualStyleBackColor = true;
            // 
            // radioButtonHttps
            // 
            this.radioButtonHttps.AutoSize = true;
            this.radioButtonHttps.Location = new System.Drawing.Point(96, 9);
            this.radioButtonHttps.Name = "radioButtonHttps";
            this.radioButtonHttps.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHttps.TabIndex = 3;
            this.radioButtonHttps.TabStop = true;
            this.radioButtonHttps.Text = "HTTPS";
            this.radioButtonHttps.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 323);
            this.Controls.Add(this.tableUserFriendsLayout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainView";
            this.Text = "ClientChat Window";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox userMessageBox;
        private System.Windows.Forms.TextBox displayMessageBox;
        private System.Windows.Forms.TableLayoutPanel tableUserFriendsLayout;
        private System.Windows.Forms.RadioButton radioButtonHttps;
        private System.Windows.Forms.RadioButton radioButtonHttp;
    }
}