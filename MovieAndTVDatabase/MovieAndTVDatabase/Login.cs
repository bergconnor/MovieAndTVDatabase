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
        private DatabaseConnect db;

        public TextBox result { get; set; }

        public Login()
        {
            InitializeComponent();
            db = new DatabaseConnect();
            result = this.resultsTxt;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passTxt.Text;

            if (db.CheckPassword(email, password))
            {
                this.Hide();
                Container container = new Container(this, email);
                container.Show(this);
            }
            else
            {
                result.Text = "Invalid email address or password.";
            }
            emailTxt.Text = "";
            passTxt.Text = "";
            result.Text = "";
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            emailTxt.Text = "";
            passTxt.Text = "";
            this.Hide();
            SignUp form = new SignUp(this);
            form.Show();
            //resultsTxt.Text = "You successfully signed up.";
        }
    }
}
