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
    public partial class Login : Form
    {
        private DatabaseConnect _database;

        public string Output
        {
            set { outputText.Text = value; }
        }

        public Login()
        {
            InitializeComponent();
            _database = new DatabaseConnect();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailText.Text;
            string password = passwordText.Text;

            if (email.Length > 0 && password.Length > 0)
            {
                if (_database.CheckPassword(email, password))
                {
                    this.Hide();
                    Controller parent = new Controller(this, email);
                    parent.Show();
                }
                else
                {
                    outputText.Text = "Invalid email address or password.";
                }
            }
            else
            {
                outputText.Text = "Missing email address and/or password.";
            }
            emailText.Text = "";
            passwordText.Text = "";
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            emailText.Text = "";
            passwordText.Text = "";
            this.Hide();
            SignUp form = new SignUp(this);
            form.Show();
        }
    }
}
