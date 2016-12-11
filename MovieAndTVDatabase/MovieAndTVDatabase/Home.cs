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

            genreCombo.Items.Add("All Genres");

            foreach (string genre in genres)
            {
                genreCombo.Items.Add(genre);
            }

            genreCombo.Text = "All Genres";
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
            FillMovieTV();
            string user = ((Container)this.MdiParent).User;
            if (user != null)
            {
                usersCombo.Text = user;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string genre = genreCombo.Text;
            string actor = actorText.Text;
            string show = showText.Text;
            string type = movieCombo.Text;

            List<string> results = db.GetResults(genre, actor, show, type);
            resultCombo.Items.Clear();
            resultCombo.ResetText();

            foreach (string result in results)
            {
                resultCombo.Items.Add(result);
            }

        }

        private void FillMovieTV()
        {
            
            movieCombo.Items.Clear();
            movieCombo.ResetText();

            movieCombo.Items.Add("Both");
            movieCombo.Items.Add("Movies");
            movieCombo.Items.Add("TV Shows");

            movieCombo.Text = "Both";
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            Information form = new Information(this);
            form.Show();
            this.Hide();
        }
    }
}
