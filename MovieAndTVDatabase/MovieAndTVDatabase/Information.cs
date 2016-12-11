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
        private Home home;
        private DatabaseConnect db;
        private string title;
        private string id;

        public Information(Home form, string title)
        {
            InitializeComponent();
            this.home = form;
            this.title = title;
            db = new DatabaseConnect();
            this.id = db.GetShowId(title);
            LoadDetails();
            FillActors();
            FillShowGenres();
            string type = db.MovieTVShow(title);

            if (type == "TV Show")
            {
                channelLabel.Visible = true;
                channel2Label.Visible = true;
                seCombo.Visible = true;
                seLabel.Visible = true;
                channel2Label.Text = db.GetChannel(title);
                FillSeason();
            }
        }

        private void LoadDetails()
        {
            string[] details = this.db.GetMovieDetails(this.title);
            titleLabel.Text = this.title;
            descriptionTxt.Text = details[1];
            homepageLink.Text = details[0];
        }

        private void FillActors()
        {
            List<string> actors = db.GetActors(this.title);
            actorsCombo.ResetText();

            foreach (string actor in actors)
            {
                actorsCombo.Text = actorsCombo.Text + actor + "\r\n";
            }
        }

        private void FillShowGenres()
        {
            List<string> genres = db.GetShowGenres(this.title);
            genreCombo.ResetText();

            foreach (string genre in genres)
            {
                genreCombo.Text = genreCombo.Text + genre + "\r\n";
            }
        }

        private void FillSeason()
        {
            int num = db.GetSeason(this.id);
            int temp;
            seCombo.Items.Clear();
            seCombo.ResetText();

            for (int i = 0; i < num; i++)
            {
                temp = i + 1;
                seCombo.Items.Add(temp.ToString());
            }
        }


        private void homepageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(homepageLink.Text);
            }
            catch { }
        }

        private void seCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            etitleLabel1.Visible = false;
            etitleLabel2.Visible = false;
            episodeCombo.Visible = true;
            episodeLabel.Visible = true;
            int num = db.GetEpisode(this.id, seCombo.Text);
            int temp;
            episodeCombo.Items.Clear();
            episodeCombo.ResetText();

            for (int i = 0; i < num; i++)
            {
                temp = i + 1;
                episodeCombo.Items.Add(temp.ToString());
            }

        }

        private void episodeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            etitleLabel1.Visible = true;
            etitleLabel2.Visible = true;
            string result = db.GetETitle(this.id, episodeCombo.Text);
            int temp;
            etitleLabel2.Text = result;

        }
    }
}
