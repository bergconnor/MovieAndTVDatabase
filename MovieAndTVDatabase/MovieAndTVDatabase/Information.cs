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
    public partial class Information : Form
    {
        private Controller _parent;
        private string _id;
        private string _homepage;
        private List<List<string>[]> _episodes;

        public Information(string id)
        {
            InitializeComponent();
            _episodes = new List<List<string>[]>();
            _id = id;
        }

        private void loadDetails()
        {
            string[] details = _parent.Database.GetMovieDetails(_id);
            titleLabel.Text = details[0];
            _homepage = details[1];
            if (_homepage.Length < 1)
            {
                linkLabel.Text = "No homepage available for this show.";
                linkLabel.LinkArea = new LinkArea(0, 0);
            }
            descriptionText.Text = details[2] + "";
        }

        private void fillActors()
        {
            List<string> actors = _parent.Database.GetActors(_id);
            actorsCombo.ResetText();

            foreach (string actor in actors)
            {
                actorsCombo.Text = actorsCombo.Text + actor + "\r\n";
            }
        }

        private void fillShowGenres()
        {
            List<string> genres = _parent.Database.GetShowGenres(_id);
            genresCombo.ResetText();

            foreach (string genre in genres)
            {
                genresCombo.Text = genresCombo.Text + genre + "\r\n";
            }
        }

        private void fillSeason()
        {
            int seasons = _parent.Database.GetSeason(_id);
            seasonsCombo.Items.Clear();
            seasonsCombo.ResetText();

            for (int i = 0; i < seasons; i++)
            {
                List<string>[] temp = _parent.Database.GetEpisode(_id, (i + 1).ToString());
                _episodes.Add(temp);
                if (_episodes[i][0].Count > 0)
                    seasonsCombo.Items.Add((i + 1).ToString());
            }
        }

        private void homepageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(_homepage);
            }
            catch
            {

            }
        }

        private void seasonsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            episodesDecoratorLabel.Visible = false;
            episodesLabel.Visible = false;
            dateDecoratorLabel.Visible = false;
            dateLabel.Visible = false;
            episodesCombo.Visible = true;
            episodeLabel.Visible = true;
            int season_num = (seasonsCombo.SelectedIndex + 1);
            int index = season_num - 1;
            episodesCombo.Items.Clear();
            episodesCombo.ResetText();

            for (int i = 0; i < _episodes[index][0].Count; i++)
                episodesCombo.Items.Add(_episodes[index][0][i]);
        }

        private void episodeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            episodesDecoratorLabel.Visible = true;
            episodesLabel.Visible = true;
            dateDecoratorLabel.Visible = true;
            dateLabel.Visible = true;

            int season_num = (seasonsCombo.SelectedIndex + 1);
            int sIndex = season_num - 1;
            int episode_num = (episodesCombo.SelectedIndex + 1);
            int eIndex = episode_num - 1;
            episodesLabel.Text = _episodes[sIndex][2][eIndex];
            dateLabel.Text = _episodes[sIndex][1][eIndex].Split(' ')[0];
        }

        private void Information_Shown(object sender, EventArgs e)
        {
            _parent = (Controller)MdiParent;
            loadDetails();
            fillActors();
            fillShowGenres();
            string type = _parent.Database.MovieTVShow(_id);

            if (type == "TV Show")
            {
                channelDecoratorLabel.Visible = true;
                channelLabel.Visible = true;
                seasonsCombo.Visible = true;
                seasonsDecoratorLabel.Visible = true;
                channelLabel.Text = _parent.Database.GetChannel(_id);
                fillSeason();
            }
            else
            {
                channelDecoratorLabel.Visible = true;
                channelLabel.Visible = true;
                channelDecoratorLabel.Text = "Duration:";
                channelLabel.Text = _parent.Database.GetDuration(_id) + " Minutes";
            }
        }
    }
}
