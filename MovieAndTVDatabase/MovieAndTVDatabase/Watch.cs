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
    public partial class Watch : Form
    {
        private Controller _parent;
        private string _id;
        private string _defaultImage;
        private List<List<string>[]> _episodes;

        public Watch(string id)
        {
            InitializeComponent();
            _episodes = new List<List<string>[]>();
            _id = id;
            _defaultImage = "http://www.amfmph.com/wp-content/plugins/" +
                            "social-media-builder//img/no-image.png";
            pictureBox.Load(_defaultImage);
            pictureBox.Refresh();
        }

        private void Watch_Shown(object sender, EventArgs e)
        {
            _parent = (Controller)MdiParent;
            userLabel.Text += _parent.User;

            string image = _parent.Database.GetShowLink(_id);
            if (image.Length > 0)
            {
                pictureBox.Load(image);
                favoriteCheckBox.Enabled = true;
                string user_id = _parent.Database.getSingleUser(_parent.Email, _parent.User);
                string favorite = _parent.Database.getSingleFavorit(user_id, _id);
                if (favorite.Equals(""))
                {
                    favoriteCheckBox.Checked = false;
                }
                else
                {
                    favoriteCheckBox.Checked = true;
                }
            }
            else
            {
                pictureBox.Load(_defaultImage);
            }

            showLabel.Text = _parent.Database.GetShowName(_id);
            string type = _parent.Database.MovieTVShow(_id);

            if (type == "TV Show")
            {
                seasonsCombo.Visible = true;
                seasonsDecoratorLabel.Visible = true;
                seasonsCombo.Visible = true;
                seasonsDecoratorLabel.Visible = true;
                fillSeason();
            }

            _parent.Database.addHistory(_parent.Email, _parent.User, _id);
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

        private void favoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (favoriteCheckBox.Checked)
            {
                _parent.Database.addFavorite(_parent.Email, _parent.User, _id);
            }
            else
            {
                _parent.Database.removeFavorite(_parent.Email, _parent.User, _id);
            }
        }

        private void seasonsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            episodesDecoratorLabel.Visible = false;
            episodesLabel.Visible = false;
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

            int season_num = (seasonsCombo.SelectedIndex + 1);
            int sIndex = season_num - 1;
            int episode_num = (episodesCombo.SelectedIndex + 1);
            int eIndex = episode_num - 1;
            episodesLabel.Text = _episodes[sIndex][2][eIndex];
        }

        private void Watch_Load(object sender, EventArgs e)
        {

        }

        private void seasonsDecoratorLabel_Click(object sender, EventArgs e)
        {

        }

        private void episodeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
