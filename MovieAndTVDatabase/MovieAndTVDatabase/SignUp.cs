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
        private DatabaseConnect db;
        private Login form;

        public bool UserClosing { get; set; }

        public SignUp(Login form)
        {
            InitializeComponent();
            UserClosing = false;
            this.form = form;
            db = new DatabaseConnect();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string password1 = pass1Txt.Text;
            string password2 = pass2Txt.Text;

            pass1Txt.Text = "";
            pass2Txt.Text = "";

            if (String.Compare(password1, password2) == 0)
            {
                int code = db.SignUp(name, email, password1);
                switch (code)
                {
                    case 0:
                        UserClosing = true;
                        form.Show();
                        this.Close();
                        break;
                    case 1:
                        resultsTxt.Text = "Email address already in use.";
                        emailTxt.Text = "";
                        break;
                    case 2:
                        resultsTxt.Text = "Connection error, try again.";
                        break;
                    case 3:
                        resultsTxt.Text = "You have too many users.";
                        break;
                    case 4:
                        resultsTxt.Text = "Username already taken for this account.";
                        break;
                }
            }
            else
            {
                resultsTxt.Text = "Passwords do not match.";
            }
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
