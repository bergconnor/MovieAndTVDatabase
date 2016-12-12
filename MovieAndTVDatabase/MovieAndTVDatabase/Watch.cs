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
        //private DatabaseConnect db;
        private string email;
        private string user;
        private string defaultImageString;
        private string currentShow;

        private Home home;
        private DatabaseConnect db;
        private string title;
        private string id;

        public Watch(Home form, string title)
        {
            InitializeComponent();
            this.db = new DatabaseConnect();
            this.defaultImageString = "http://www.amfmph.com/wp-content/plugins/" +
                                    "social-media-builder//img/no-image.png";

            //InitializeComponent();
            this.home = form;
            this.title = title;
            //db = new DatabaseConnect();
            this.id = db.GetShowId(title);
            //LoadDetails();
            //FillActors();
            //FillShowGenres();
            string type = db.MovieTVShow(title);
            this.showTxt.Text = title;
            this.showTxt2.Text = title;
            //this.pictureBox1.Load(defaultImageString);

            if (type == "TV Show")
            {
                //channelLabel.Visible = true;
                //channel2Label.Visible = true;
                seCombo.Visible = true;
                seLabel.Visible = true;
                //channel2Label.Text = db.GetChannel(title);
                FillSeason();
            }

            this.pictureBox1.Refresh();
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            string name = this.showTxt.Text;
            string show = this.db.GetShowLink(name);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (show.Length > 0)
            {
                this.pictureBox1.Load(show);
                this.title = name;

                this.FavoriteCheckBox3.Enabled = true;
                string u = this.db.getSingleUser(this.email, this.user);
                string fav = this.db.getSingleFavorit(u, name);
                if (fav.Equals(""))
                {
                    this.FavoriteCheckBox3.Checked = false;
                }
                else
                {
                    this.FavoriteCheckBox3.Checked = true;
                }
            }
            else
            {
                this.pictureBox1.Load(defaultImageString);
            }
        }

        private void watchShow(string name)
        {
            //string name = this.showTxt.Text;
            string show = this.db.GetShowLink(name);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (show.Length > 0)
            {
                this.pictureBox1.Load(show);


                this.FavoriteCheckBox3.Enabled = true;
                //Watch_Shown();
                string u = this.db.getSingleUser(this.email, this.user);
                string fav = this.db.getSingleFavorit(u, name);
                if (fav.Equals(""))
                {
                    this.FavoriteCheckBox3.Checked = false;
                }
                else
                {
                    this.FavoriteCheckBox3.Checked = true;
                }
            }
            else
            {
                this.pictureBox1.Load(defaultImageString);
            }
        }

        private void Watch_Shown(object sender, EventArgs e)
        {
            this.email = ((Container)this.MdiParent).Email;
            this.user = ((Container)this.MdiParent).User;
            currentUserLbl.Text += this.user;

            watchShow(this.title);
            this.db.addHistory(this.email, this.user, this.title);
        }

        private void FavoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string name = this.showTxt.Text;
            if (this.FavoriteCheckBox3.Checked)
            {
                this.db.addFavorite(this.email, this.user, name);
            }
            else
            {
                this.db.removeFavorite(this.email, this.user, name);
            }
        }

        private void FavoriteCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            string name = this.title;
            if (this.FavoriteCheckBox3.Checked)
            {
                this.db.addFavorite(this.email, this.user, name);
            }
            else
            {
                this.db.removeFavorite(this.email, this.user, name);
            }
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
    }
}
