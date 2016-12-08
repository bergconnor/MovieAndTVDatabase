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

        public Login()
        {
            InitializeComponent();
            db = new DatabaseConnect();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passTxt.Text;

            if (db.CheckPassword(email, password))
            {
                this.Hide();
                Homepage homepageForm = new Homepage();
                homepageForm.Show(this);
            }
            else
            {
                resultsTxt.Text = "Invalid email address or password.";
            }
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passTxt.Text;

            if (db.SignUp(email, password))
            {
                resultsTxt.Text = "You successfully signed up.";
            }
            else
            {
                resultsTxt.Text = "Email address is already in use.";
            }
        }
    }
}
