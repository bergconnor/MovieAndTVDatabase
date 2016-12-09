namespace MovieAndTVDatabase
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(13, 278);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(163, 28);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(200, 278);
            this.signupBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(163, 28);
            this.signupBtn.TabIndex = 5;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(182, 57);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(181, 22);
            this.passTxt.TabIndex = 3;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(10, 62);
            this.passLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 17);
            this.passLbl.TabIndex = 0;
            this.passLbl.Text = "Password";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(10, 18);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(182, 13);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(181, 22);
            this.emailTxt.TabIndex = 2;
            // 
            // resultsTxt
            // 
            this.resultsTxt.Location = new System.Drawing.Point(13, 108);
            this.resultsTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultsTxt.Multiline = true;
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.ReadOnly = true;
            this.resultsTxt.Size = new System.Drawing.Size(350, 151);
            this.resultsTxt.TabIndex = 0;
            this.resultsTxt.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 311);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 358);
            this.MinimumSize = new System.Drawing.Size(394, 358);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox resultsTxt;
    }
}

