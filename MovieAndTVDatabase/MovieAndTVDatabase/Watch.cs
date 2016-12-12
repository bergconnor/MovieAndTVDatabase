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

        public Watch(string id)
        {
            InitializeComponent();
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

            _parent.Database.addHistory(_parent.Email, _parent.User, _id);
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            string name = showText.Text;
            string show = _parent.Database.GetShowLink(name);
            if (show.Length > 0)
            {
                this.pictureBox.Load(show);
            }
            else
            {
                this.pictureBox.Load(_defaultImage);
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
    }
}
