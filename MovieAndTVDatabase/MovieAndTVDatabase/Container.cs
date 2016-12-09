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
        private string email;

        public Container(string email)
        {
            InitializeComponent();
            this.email = email;
            Home form = new Home(email);
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

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildren();
            Account form = new Account(email);
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
            Home form = new Home(email);
            form.MdiParent = this;
            form.Show();
        }
    }
}
