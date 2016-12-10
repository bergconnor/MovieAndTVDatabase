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
    public partial class Container : Form
    {
        private Login login;

        public bool UserClosing { get; set; }
        public string Email { get; set; }
        public string User { get; set; }

        public Container(Login login, string email)
        {
            InitializeComponent();
            DisableMenuItems();
            this.login = login;
            this.Email = email;
            UserClosing = false;

            Home home = new Home();
            home.MdiParent = this;
            home.Show();
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

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildren();
            Account form = new Account();
            form.MdiParent = this;
            form.Show();
        }

        private void watchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildren();
            Watch form = new Watch();
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

        public void logout()
        {
            UserClosing = true;
            this.login.Show();
            this.Close();
        }

        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!UserClosing)
            {
                Application.Exit();
            }
        }

        public void EnableMenuItems()
        {
            this.homeToolStripMenuItem.Enabled = true;
            this.accountToolStripMenuItem.Enabled = true;
            this.watchToolStripMenuItem.Enabled = true;
        }

        public void DisableMenuItems()
        {
            this.homeToolStripMenuItem.Enabled = false;
            this.accountToolStripMenuItem.Enabled = false;
            this.watchToolStripMenuItem.Enabled = false;
        }
    }
}
