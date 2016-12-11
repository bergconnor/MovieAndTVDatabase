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
            recommendButton.Enabled = true;
            showText.Enabled = true;
            genreCombo.Enabled = true;
            actorText.Enabled = true;
            movieCombo.Enabled = true;
            searchButton.Enabled = true;
            resultCombo.Enabled = true;
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

            List<string>[] results = db.GetResults(genre, actor, show, type);
            resultCombo.Items.Clear();
            resultCombo.ResetText();

            foreach (string result in results[0])
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

        private void infoButton_Click(object sender, EventArgs e)
        {
            string title = resultCombo.Text;
            Information form = new Information(this, title);
            form.MdiParent = this.MdiParent;
            form.Show();
            this.Hide();
        }

        private void resultCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoButton.Enabled = true;
            watchButton.Enabled = true;
        }

        private void watchButton_Click(object sender, EventArgs e)
        {

        }

        private void recommendButton_Click(object sender, EventArgs e)
        {
            string user = ((Container)this.MdiParent).User;
            List<string> shows = db.GetRecommendations(email, user);
            resultCombo.Items.Clear();
            resultCombo.ResetText();

            if (shows.Count == 0)
            {
                MessageBox.Show("Favorite some shows to get recommendations");
            }
            else if (shows.Count > 25)
            {
                MessageBox.Show("Favorite more shows to improve result.");
            }
            else
            {
                foreach (string result in shows)
                {
                    resultCombo.Items.Add(result);
                }
            }
        }
    }
}
