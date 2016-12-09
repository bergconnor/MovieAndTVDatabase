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
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.pass1Lbl = new System.Windows.Forms.Label();
            this.pass1Txt = new System.Windows.Forms.TextBox();
            this.signupBtn = new System.Windows.Forms.Button();
            this.pass2Txt = new System.Windows.Forms.TextBox();
            this.pass2Lbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultsTxt
            // 
            this.resultsTxt.Location = new System.Drawing.Point(13, 183);
            this.resultsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.resultsTxt.Multiline = true;
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.ReadOnly = true;
            this.resultsTxt.Size = new System.Drawing.Size(350, 68);
            this.resultsTxt.TabIndex = 0;
            this.resultsTxt.TabStop = false;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(184, 52);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(181, 22);
            this.emailTxt.TabIndex = 2;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(13, 57);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email";
            // 
            // pass1Lbl
            // 
            this.pass1Lbl.AutoSize = true;
            this.pass1Lbl.Location = new System.Drawing.Point(12, 98);
            this.pass1Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass1Lbl.Name = "pass1Lbl";
            this.pass1Lbl.Size = new System.Drawing.Size(69, 17);
            this.pass1Lbl.TabIndex = 0;
            this.pass1Lbl.Text = "Password";
            // 
            // pass1Txt
            // 
            this.pass1Txt.Location = new System.Drawing.Point(184, 93);
            this.pass1Txt.Margin = new System.Windows.Forms.Padding(4);
            this.pass1Txt.Name = "pass1Txt";
            this.pass1Txt.PasswordChar = '*';
            this.pass1Txt.Size = new System.Drawing.Size(181, 22);
            this.pass1Txt.TabIndex = 3;
            // 
            // signupBtn
            // 
            this.signupBtn.Location = new System.Drawing.Point(15, 274);
            this.signupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(350, 28);
            this.signupBtn.TabIndex = 5;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.UseVisualStyleBackColor = true;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // pass2Txt
            // 
            this.pass2Txt.Location = new System.Drawing.Point(184, 135);
            this.pass2Txt.Margin = new System.Windows.Forms.Padding(4);
            this.pass2Txt.Name = "pass2Txt";
            this.pass2Txt.PasswordChar = '*';
            this.pass2Txt.Size = new System.Drawing.Size(181, 22);
            this.pass2Txt.TabIndex = 4;
            // 
            // pass2Lbl
            // 
            this.pass2Lbl.AutoSize = true;
            this.pass2Lbl.Location = new System.Drawing.Point(13, 140);
            this.pass2Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass2Lbl.Name = "pass2Lbl";
            this.pass2Lbl.Size = new System.Drawing.Size(129, 17);
            this.pass2Lbl.TabIndex = 0;
            this.pass2Lbl.Text = "Re-enter Password";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(184, 13);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(181, 22);
            this.nameTxt.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(13, 18);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 311);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.pass2Lbl);
            this.Controls.Add(this.pass2Txt);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.pass1Lbl);
            this.Controls.Add(this.pass1Txt);
            this.Controls.Add(this.signupBtn);
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

        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label pass1Lbl;
        private System.Windows.Forms.TextBox pass1Txt;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.TextBox pass2Txt;
        private System.Windows.Forms.Label pass2Lbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
    }
}