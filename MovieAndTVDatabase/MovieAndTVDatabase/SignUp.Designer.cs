namespace MovieAndTVDatabase
{
    partial class SignUp
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
            this.outputText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.passwordText1 = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.password2Text = new System.Windows.Forms.TextBox();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(13, 183);
            this.outputText.Margin = new System.Windows.Forms.Padding(4);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(350, 68);
            this.outputText.TabIndex = 0;
            this.outputText.TabStop = false;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(184, 53);
            this.emailText.Margin = new System.Windows.Forms.Padding(4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(181, 22);
            this.emailText.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(13, 58);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Location = new System.Drawing.Point(12, 98);
            this.passwordLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel1.TabIndex = 0;
            this.passwordLabel1.Text = "Password";
            // 
            // passwordText1
            // 
            this.passwordText1.Location = new System.Drawing.Point(184, 93);
            this.passwordText1.Margin = new System.Windows.Forms.Padding(4);
            this.passwordText1.Name = "passwordText1";
            this.passwordText1.PasswordChar = '*';
            this.passwordText1.Size = new System.Drawing.Size(181, 22);
            this.passwordText1.TabIndex = 3;
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(200, 274);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(163, 28);
            this.signupButton.TabIndex = 5;
            this.signupButton.Text = "Sign Up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // password2Text
            // 
            this.password2Text.Location = new System.Drawing.Point(184, 133);
            this.password2Text.Margin = new System.Windows.Forms.Padding(4);
            this.password2Text.Name = "password2Text";
            this.password2Text.PasswordChar = '*';
            this.password2Text.Size = new System.Drawing.Size(181, 22);
            this.password2Text.TabIndex = 4;
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Location = new System.Drawing.Point(13, 138);
            this.passwordLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(129, 17);
            this.passwordLabel2.TabIndex = 0;
            this.passwordLabel2.Text = "Re-enter Password";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(184, 13);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(181, 22);
            this.nameText.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 18);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 274);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(163, 28);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // SignUp
            // 
            this.AcceptButton = this.signupButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 311);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.password2Text);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.passwordText1);
            this.Controls.Add(this.signupButton);
            this.MaximumSize = new System.Drawing.Size(394, 358);
            this.MinimumSize = new System.Drawing.Size(394, 358);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.TextBox passwordText1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.TextBox password2Text;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button backButton;
    }
}