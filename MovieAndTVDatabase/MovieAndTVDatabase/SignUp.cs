using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieAndTVDatabase
{
    public partial class SignUp : Form
    {
        
        private DatabaseConnect _database;
        private Login _login;
        private bool _userClosing;

        public SignUp(Login login)
        {
            InitializeComponent();
            _userClosing = false;
            _database = new DatabaseConnect();
            _login = login;
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string email = emailText.Text;
            string pass1 = passwordText1.Text;
            string pass2 = password2Text.Text;

            if (name.Length < 1 || email.Length < 1 || pass1.Length < 1 || pass2.Length < 1)
            {
                outputText.Text = "Every field is required to sign up.";
            }
            else
            {
                if (String.Compare(pass1, pass2) == 0)
                {
                    int status = _database.SignUp(name, email, pass2);
                    switch (status)
                    {
                        case 0:
                            _userClosing = true;
                            _login.Output = "You successfully signed up.";
                            _login.Show();
                            this.Close();
                            break;
                        case 1:
                            outputText.Text = "Email address already in use.";
                            emailText.Text = "";
                            break;
                        case 2:
                            outputText.Text = "Connection error, try again.";
                            break;
                        case 3:
                            outputText.Text = "You have too many users.";
                            break;
                        case 4:
                            outputText.Text = "Username already taken for this account.";
                            break;
                    }
                }
                else
                {
                    outputText.Text = "Passwords do not match.";
                }
            }
            passwordText1.Text = "";
            password2Text.Text = "";
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_userClosing)
            {
                Application.Exit();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _userClosing = true;
            _login.Output = "You did not sign up.";
            _login.Show();
            this.Close();
        }
    }
}
