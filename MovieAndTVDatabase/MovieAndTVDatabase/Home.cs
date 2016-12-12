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
        private List<string>[] _results;

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
            resultsCombo.Enabled = true;
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
            string id = _results[1][resultsCombo.SelectedIndex];
            Information form = new Information(id);
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

            infoButton.Enabled = false;
            watchButton.Enabled = false;

            _results = _parent.Database.GetResults(genre, actor, show, type);
            resultsCombo.Items.Clear();
            resultsCombo.ResetText();

            foreach (string result in _results[0])
            {
                resultsCombo.Items.Add(result);
            }
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            string id = _results[1][resultsCombo.SelectedIndex];
            Watch form = new Watch(id);
            form.MdiParent = this.MdiParent;
            form.Show();
            this.Hide();
        }

        private void recommendButton_Click(object sender, EventArgs e)
        {
            int show_count = 15;
            int max = 4;
            while ((_results = _parent.Database.GetRecommendations(_parent.Email, _parent.User, max))[0].Count < 1)
            {
                if (--max < 1)
                    break;
            }
            resultsCombo.Items.Clear();
            resultsCombo.ResetText();

            infoButton.Enabled = false;
            watchButton.Enabled = false;

            if (_results[0].Count == 0)
            {
                MessageBox.Show("Favorite some shows to get recommendations");
            }
            else if (_results[0].Count > show_count)
            {
                MessageBox.Show(String.Format("Over {0} shows found.\r\n" +
                        "Favorite more shows to narrow result.", show_count));
            }
            foreach (string result in _results[0])
            {
                resultsCombo.Items.Add(result);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            _parent.Logout();
        }
    }
}
