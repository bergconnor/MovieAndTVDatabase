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
    public partial class Account : Form
    {
        private DatabaseConnect db;
        private string email;

        public Account(string email)
        {
            InitializeComponent();
            this.db = new DatabaseConnect();
            this.email = email;
            FillUsers();
        }

        private void FillUsers()
        {
            List<string> users = db.GetUsers(email);
            usersCombo.Items.Clear();
            usersCombo.ResetText();

            foreach (string user in users)
            {
                usersCombo.Items.Add(user);
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            if (name.Length < 1)
            {
                resultTxt.Text = "No name found.";
            }
            else
            {
                int result = db.AddUser(name, email);
                switch (result)
                {
                    case 0:
                        resultTxt.Text = String.Format("Welcome {0}!", name);
                        FillUsers();
                        break;
                    case 3:
                        resultTxt.Text = "Too many users. Each account can only have 5 users.";
                        break;
                    case 4:
                        resultTxt.Text = "Duplicate name. Please enter a unique name for this account.";
                        break;
                }
            }
            nameTxt.Text = "";
        }

        private void rmvUserBtn_Click(object sender, EventArgs e)
        {
            string user = usersCombo.SelectedItem.ToString();
            int result = db.RemoveUser(user, email);
            if (result == 0)
            {
                resultTxt.Text = String.Format("{0} successfully removed.", user);
            }
            else if (result == 3)
            {
                resultTxt.Text = "Can't delete user. Each account must have at least one user.";
            }
            FillUsers();
        }
    }
}
