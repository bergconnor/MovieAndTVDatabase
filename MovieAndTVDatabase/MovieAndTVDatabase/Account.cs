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
        private Controller _parent;

        private string _start;
        private string _end;
        private string _membership;
        private bool _valid;

        public Account(bool valid)
        {
            InitializeComponent();
            _valid = valid;
        }

        private void fillUsers()
        {
            List<string> users = _parent.Database.GetUsers(_parent.Email);
            usersCombo.Items.Clear();
            usersCombo.ResetText();

            foreach (string user in users)
            {
                usersCombo.Items.Add(user);
            }
        }

        private void updateValues()
        {
            List<string>[] membershipInfo = _parent.Database.GetMembershipInfo(_parent.Email);

            _start = membershipInfo[0][0].Split(' ')[0];
            _end = membershipInfo[1][0].Split(' ')[0];
            _membership = membershipInfo[2][0];
            userText.Text = _parent.User;
            startText.Text = _start;
            endText.Text = _end;
            membershipText.Text = _membership;
        }

        private void Account_Shown(object sender, EventArgs e)
        {
            _parent = (Controller)MdiParent;
            updateValues();
            fillUsers();
            nameText.Focus();
            if (_valid)
            {
                _parent.EnableMenuItems();
            }
            else
            {
                MessageBox.Show("Give us your money.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            if (name.Length < 1)
            {
                outputText.Text = "No name found.";
            }
            else
            {
                int result = _parent.Database.AddUser(name, _parent.Email);
                switch (result)
                {
                    case 0:
                        outputText.Text = String.Format("Welcome {0}!", name);
                        fillUsers();
                        break;
                    case 1062:
                        outputText.Text = "Duplicate name. Please enter a unique name for this account.";
                        break;
                    case 1644:
                        outputText.Text = "Too many users. Each account can only have 5 users.";
                        break;
                }
            }
            nameText.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (usersCombo.SelectedItem == null)
            {
                outputText.Text = "Select a user before attempting to remove one.";
            }
            else if (String.Compare(usersCombo.SelectedItem.ToString(), _parent.User) == 0)
            {
                outputText.Text = "Can't remove the currently selected user.";
            }
            else
            {
                string user = usersCombo.SelectedItem.ToString();
                int result = _parent.Database.RemoveUser(user, _parent.Email);
                if (result == 0)
                {
                    outputText.Text = String.Format("{0} successfully removed.", user);
                }
                else if (result == 3)
                {
                    outputText.Text = "Can't delete user. Each account must have at least one user.";
                }
                fillUsers();
            }
        }

        private void checkSubscription()
        {
            string end = _parent.Database.GetMembershipInfo(_parent.Email)[1][0];
            DateTime today = DateTime.Today;
            DateTime subscription_end = Convert.ToDateTime(end);
            int cmp = DateTime.Compare(today, subscription_end);
            if (cmp <= 0)
            {
                _parent.Database.UpdateSubscription(_parent.Email);
            }
            else
            {
                _parent.Database.RenewSubscription(_parent.Email);
            }
            _parent.EnableMenuItems();
        }

        private void renewButton_Click(object sender, EventArgs e)
        {
            checkSubscription();
            updateValues();
        }
    }
}
