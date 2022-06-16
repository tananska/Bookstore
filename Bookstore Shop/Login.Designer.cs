namespace Bookstore_Shop
{
    partial class Login
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
            this.loginTabControl = new System.Windows.Forms.TabControl();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginEmailLabel = new System.Windows.Forms.Label();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginEmailTextBox = new System.Windows.Forms.TextBox();
            this.signUpTabPage = new System.Windows.Forms.TabPage();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signUpPhoneLabel = new System.Windows.Forms.Label();
            this.signUpAddressLabel = new System.Windows.Forms.Label();
            this.signUpConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.signUpPasswordLabel = new System.Windows.Forms.Label();
            this.signUpEmailLabel = new System.Windows.Forms.Label();
            this.signUpNameLabel = new System.Windows.Forms.Label();
            this.signUpPhoneTextBox = new System.Windows.Forms.TextBox();
            this.signUpAddressTextBox = new System.Windows.Forms.TextBox();
            this.signUpCofirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signUpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signUpEmailTextBox = new System.Windows.Forms.TextBox();
            this.signUpNameTextBox = new System.Windows.Forms.TextBox();
            this.loginTabControl.SuspendLayout();
            this.loginTabPage.SuspendLayout();
            this.signUpTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTabControl
            // 
            this.loginTabControl.Controls.Add(this.loginTabPage);
            this.loginTabControl.Controls.Add(this.signUpTabPage);
            this.loginTabControl.Location = new System.Drawing.Point(86, 12);
            this.loginTabControl.Name = "loginTabControl";
            this.loginTabControl.SelectedIndex = 0;
            this.loginTabControl.Size = new System.Drawing.Size(266, 320);
            this.loginTabControl.TabIndex = 0;
            // 
            // loginTabPage
            // 
            this.loginTabPage.BackColor = System.Drawing.Color.White;
            this.loginTabPage.Controls.Add(this.loginButton);
            this.loginTabPage.Controls.Add(this.loginPasswordLabel);
            this.loginTabPage.Controls.Add(this.loginEmailLabel);
            this.loginTabPage.Controls.Add(this.loginPasswordTextBox);
            this.loginTabPage.Controls.Add(this.loginEmailTextBox);
            this.loginTabPage.Location = new System.Drawing.Point(4, 22);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(258, 294);
            this.loginTabPage.TabIndex = 0;
            this.loginTabPage.Text = "Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(89, 184);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(40, 110);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.loginPasswordLabel.TabIndex = 3;
            this.loginPasswordLabel.Text = "Password";
            // 
            // loginEmailLabel
            // 
            this.loginEmailLabel.AutoSize = true;
            this.loginEmailLabel.Location = new System.Drawing.Point(61, 64);
            this.loginEmailLabel.Name = "loginEmailLabel";
            this.loginEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.loginEmailLabel.TabIndex = 2;
            this.loginEmailLabel.Text = "Email";
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(108, 110);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '•';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginPasswordTextBox.TabIndex = 1;
            // 
            // loginEmailTextBox
            // 
            this.loginEmailTextBox.Location = new System.Drawing.Point(108, 64);
            this.loginEmailTextBox.Name = "loginEmailTextBox";
            this.loginEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginEmailTextBox.TabIndex = 0;
            // 
            // signUpTabPage
            // 
            this.signUpTabPage.Controls.Add(this.signUpButton);
            this.signUpTabPage.Controls.Add(this.signUpPhoneLabel);
            this.signUpTabPage.Controls.Add(this.signUpAddressLabel);
            this.signUpTabPage.Controls.Add(this.signUpConfirmPasswordLabel);
            this.signUpTabPage.Controls.Add(this.signUpPasswordLabel);
            this.signUpTabPage.Controls.Add(this.signUpEmailLabel);
            this.signUpTabPage.Controls.Add(this.signUpNameLabel);
            this.signUpTabPage.Controls.Add(this.signUpPhoneTextBox);
            this.signUpTabPage.Controls.Add(this.signUpAddressTextBox);
            this.signUpTabPage.Controls.Add(this.signUpCofirmPasswordTextBox);
            this.signUpTabPage.Controls.Add(this.signUpPasswordTextBox);
            this.signUpTabPage.Controls.Add(this.signUpEmailTextBox);
            this.signUpTabPage.Controls.Add(this.signUpNameTextBox);
            this.signUpTabPage.Location = new System.Drawing.Point(4, 22);
            this.signUpTabPage.Name = "signUpTabPage";
            this.signUpTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.signUpTabPage.Size = new System.Drawing.Size(258, 294);
            this.signUpTabPage.TabIndex = 1;
            this.signUpTabPage.Text = "Sign Up";
            this.signUpTabPage.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(84, 247);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signUpPhoneLabel
            // 
            this.signUpPhoneLabel.AutoSize = true;
            this.signUpPhoneLabel.Location = new System.Drawing.Point(75, 197);
            this.signUpPhoneLabel.Name = "signUpPhoneLabel";
            this.signUpPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.signUpPhoneLabel.TabIndex = 11;
            this.signUpPhoneLabel.Text = "Phone";
            // 
            // signUpAddressLabel
            // 
            this.signUpAddressLabel.AutoSize = true;
            this.signUpAddressLabel.Location = new System.Drawing.Point(68, 160);
            this.signUpAddressLabel.Name = "signUpAddressLabel";
            this.signUpAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.signUpAddressLabel.TabIndex = 10;
            this.signUpAddressLabel.Text = "Address";
            // 
            // signUpConfirmPasswordLabel
            // 
            this.signUpConfirmPasswordLabel.AutoSize = true;
            this.signUpConfirmPasswordLabel.Location = new System.Drawing.Point(22, 128);
            this.signUpConfirmPasswordLabel.Name = "signUpConfirmPasswordLabel";
            this.signUpConfirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.signUpConfirmPasswordLabel.TabIndex = 9;
            this.signUpConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // signUpPasswordLabel
            // 
            this.signUpPasswordLabel.AutoSize = true;
            this.signUpPasswordLabel.Location = new System.Drawing.Point(60, 89);
            this.signUpPasswordLabel.Name = "signUpPasswordLabel";
            this.signUpPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.signUpPasswordLabel.TabIndex = 8;
            this.signUpPasswordLabel.Text = "Password";
            // 
            // signUpEmailLabel
            // 
            this.signUpEmailLabel.AutoSize = true;
            this.signUpEmailLabel.Location = new System.Drawing.Point(81, 51);
            this.signUpEmailLabel.Name = "signUpEmailLabel";
            this.signUpEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.signUpEmailLabel.TabIndex = 7;
            this.signUpEmailLabel.Text = "Email";
            // 
            // signUpNameLabel
            // 
            this.signUpNameLabel.AutoSize = true;
            this.signUpNameLabel.Location = new System.Drawing.Point(78, 16);
            this.signUpNameLabel.Name = "signUpNameLabel";
            this.signUpNameLabel.Size = new System.Drawing.Size(35, 13);
            this.signUpNameLabel.TabIndex = 6;
            this.signUpNameLabel.Text = "Name";
            // 
            // signUpPhoneTextBox
            // 
            this.signUpPhoneTextBox.Location = new System.Drawing.Point(139, 197);
            this.signUpPhoneTextBox.Name = "signUpPhoneTextBox";
            this.signUpPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.signUpPhoneTextBox.TabIndex = 5;
            // 
            // signUpAddressTextBox
            // 
            this.signUpAddressTextBox.Location = new System.Drawing.Point(139, 160);
            this.signUpAddressTextBox.Name = "signUpAddressTextBox";
            this.signUpAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.signUpAddressTextBox.TabIndex = 4;
            // 
            // signUpCofirmPasswordTextBox
            // 
            this.signUpCofirmPasswordTextBox.Location = new System.Drawing.Point(139, 125);
            this.signUpCofirmPasswordTextBox.Name = "signUpCofirmPasswordTextBox";
            this.signUpCofirmPasswordTextBox.PasswordChar = '•';
            this.signUpCofirmPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.signUpCofirmPasswordTextBox.TabIndex = 3;
            // 
            // signUpPasswordTextBox
            // 
            this.signUpPasswordTextBox.Location = new System.Drawing.Point(139, 89);
            this.signUpPasswordTextBox.Name = "signUpPasswordTextBox";
            this.signUpPasswordTextBox.PasswordChar = '•';
            this.signUpPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.signUpPasswordTextBox.TabIndex = 2;
            // 
            // signUpEmailTextBox
            // 
            this.signUpEmailTextBox.Location = new System.Drawing.Point(139, 51);
            this.signUpEmailTextBox.Name = "signUpEmailTextBox";
            this.signUpEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.signUpEmailTextBox.TabIndex = 1;
            // 
            // signUpNameTextBox
            // 
            this.signUpNameTextBox.Location = new System.Drawing.Point(139, 16);
            this.signUpNameTextBox.Name = "signUpNameTextBox";
            this.signUpNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.signUpNameTextBox.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(440, 344);
            this.Controls.Add(this.loginTabControl);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginTabControl.ResumeLayout(false);
            this.loginTabPage.ResumeLayout(false);
            this.loginTabPage.PerformLayout();
            this.signUpTabPage.ResumeLayout(false);
            this.signUpTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl loginTabControl;
        private System.Windows.Forms.TabPage loginTabPage;
        private System.Windows.Forms.TabPage signUpTabPage;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.Label loginEmailLabel;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox loginEmailTextBox;
        private System.Windows.Forms.TextBox signUpAddressTextBox;
        private System.Windows.Forms.TextBox signUpCofirmPasswordTextBox;
        private System.Windows.Forms.TextBox signUpPasswordTextBox;
        private System.Windows.Forms.TextBox signUpEmailTextBox;
        private System.Windows.Forms.TextBox signUpNameTextBox;
        private System.Windows.Forms.Label signUpPhoneLabel;
        private System.Windows.Forms.Label signUpAddressLabel;
        private System.Windows.Forms.Label signUpConfirmPasswordLabel;
        private System.Windows.Forms.Label signUpPasswordLabel;
        private System.Windows.Forms.Label signUpEmailLabel;
        private System.Windows.Forms.Label signUpNameLabel;
        private System.Windows.Forms.TextBox signUpPhoneTextBox;
        private System.Windows.Forms.Button signUpButton;
    }
}

