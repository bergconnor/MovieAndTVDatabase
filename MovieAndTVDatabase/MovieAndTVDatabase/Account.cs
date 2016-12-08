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
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string user = userTxt.Text;
        }
    }
}
