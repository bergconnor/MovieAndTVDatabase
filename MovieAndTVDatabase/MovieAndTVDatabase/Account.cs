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
        private string user;

        public Account()
        {
            InitializeComponent();
            this.db = new DatabaseConnect();
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
                    case 1062:
                        resultTxt.Text = "Duplicate name. Please enter a unique name for this account.";
                        break;
                    case 1644:
                        resultTxt.Text = "Too many users. Each account can only have 5 users.";
                        break;
                }
            }
            nameTxt.Text = "";
        }

        private void rmvUserBtn_Click(object sender, EventArgs e)
        {
            if (usersCombo.SelectedItem == null)
            {
                resultTxt.Text = "Select a user before attempting to remove one.";
            }
            else if (String.Compare(usersCombo.SelectedItem.ToString(), this.user) == 0 )
            {
                resultTxt.Text = "Can't remove the currently selected user.";
            }
            else
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

        private void Account_Shown(object sender, EventArgs e)
        {
            this.email = ((Container)this.MdiParent).Email;
            this.user = ((Container)this.MdiParent).User;
            resultTxt.Text = String.Format("User {0} selected.", this.user);
            FillUsers();
        }
    }
}
