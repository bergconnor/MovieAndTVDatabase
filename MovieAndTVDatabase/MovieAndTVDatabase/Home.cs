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
        private Controller _parent;

        public Home()
        {
            InitializeComponent();
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

        private void fillGenres()
        {
            List<string> genres = _parent.Database.GetGenres();
            genreCombo.Items.Clear();
            genreCombo.ResetText();

            genreCombo.Items.Add("All Genres");

            foreach (string genre in genres)
            {
                genreCombo.Items.Add(genre);
            }

            genreCombo.Text = "All Genres";
        }

        private void usersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _parent.User = usersCombo.SelectedItem.ToString();
            _parent.EnableMenuItems();
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
            _parent = (Controller)this.MdiParent;
            fillUsers();
            fillGenres();
            fillMovieTV();
            string user = _parent.User;
            if (user != null)
            {
                usersCombo.Text = user;
            }
        }

        private void fillMovieTV()
        {
            
            movieCombo.Items.Clear();
            movieCombo.ResetText();

            movieCombo.Items.Add("Both");
            movieCombo.Items.Add("Movies");
            movieCombo.Items.Add("TV Shows");

            movieCombo.Text = "Both";
        }

        private void resultCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoButton.Enabled = true;
            watchButton.Enabled = true;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            string title = resultCombo.Text;
            Information form = new Information(this, title);
            form.MdiParent = this.MdiParent;
            form.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string genre = genreCombo.Text;
            string actor = actorText.Text;
            string show = showText.Text;
            string type = movieCombo.Text;

            List<string>[] results = _parent.Database.GetResults(genre, actor, show, type);
            resultCombo.Items.Clear();
            resultCombo.ResetText();

            foreach (string result in results[0])
            {
                resultCombo.Items.Add(result);
            }

        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            _parent.WatchShow();
        }

        private void recommendButton_Click(object sender, EventArgs e)
        {
            List<string> shows;
            int show_count = 25;
            int max = 4;
            while ((shows = _parent.Database.GetRecommendations(_parent.Email, _parent.User, max)).Count < 1)
            {
                max--;
            }
            resultCombo.Items.Clear();
            resultCombo.ResetText();

            if (shows.Count == 0)
            {
                MessageBox.Show("Favorite some shows to get recommendations");
            }
            else if (shows.Count > show_count)
            {
                MessageBox.Show(String.Format("Over {0} shows found.\r\n" +
                        "Favorite more shows to narrow result.", show_count));
            }
            foreach (string result in shows)
            {
                resultCombo.Items.Add(result);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            _parent.Logout();
        }
    }
}
