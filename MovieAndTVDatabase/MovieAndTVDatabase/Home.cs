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
    public partial class Home : Form
    {
        private DatabaseConnect db;
        private string email;

        public Home()
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

        private void FillGenres()
        {
            List<string> genres = db.GetGenres();
            genreCombo.Items.Clear();
            genreCombo.ResetText();

            foreach (string genre in genres)
            {
                genreCombo.Items.Add(genre);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            ((Container)this.MdiParent).logout(); 
        }

        private void usersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Container)MdiParent).User = usersCombo.SelectedItem.ToString();
            ((Container)MdiParent).EnableMenuItems();
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            this.email = ((Container)this.MdiParent).Email;
            FillUsers();
            FillGenres();
            string user = ((Container)this.MdiParent).User;
            if (user != null)
            {
                usersCombo.Text = user;
            }
        }
    }
}
