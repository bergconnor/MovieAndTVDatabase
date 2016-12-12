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
            
            //this.pictureBox1.Load(defaultImageString);
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
    }
}
