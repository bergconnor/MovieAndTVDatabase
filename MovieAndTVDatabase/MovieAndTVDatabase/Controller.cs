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
    public partial class Controller : Form
    {
        public DatabaseConnect _database;
        private Login _login;
        private string _email;
        private string _user;
        private bool _userClosing;

        public DatabaseConnect Database
        {
            get { return _database; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public Controller(Login login, string email)
        {
            InitializeComponent();
            DisableMenuItems();
            _database = new DatabaseConnect();
            _email = email;
            _userClosing = false;
            _login = login;

            checkSubscription();
        }

        public void Logout()
        {
            _userClosing = true;
            _login.Show();
            this.Close();
        }


        public void EnableMenuItems()
        {
            this.homeToolStripMenuItem.Enabled = true;
            this.accountToolStripMenuItem.Enabled = true;
        }

        public void DisableMenuItems()
        {
            this.homeToolStripMenuItem.Enabled = false;
            this.accountToolStripMenuItem.Enabled = false;
        }

        private void checkSubscription()
        {
            string end = _database.GetMembershipInfo(_email)[1][0];
            DateTime today = DateTime.Today;
            DateTime subscription_end = Convert.ToDateTime(end);
            int cmp = DateTime.Compare(today, subscription_end);
            if (cmp < 0)
            {
                Home form = new Home();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                Account form = new Account(false);
                form.MdiParent = this;
                form.Show();
            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildren();

            Account form = new Account(true);
            form.MdiParent = this;
            form.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildren();

            Home form = new Home();
            form.MdiParent = this;
            form.Show();
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void closeChildren()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void Controller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_userClosing)
            {
                Application.Exit();
            }
        }
    }
}
