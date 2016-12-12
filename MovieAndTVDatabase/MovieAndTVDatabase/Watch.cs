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
        private string _defaultImage;

        public Watch()
        {
            InitializeComponent();
            _defaultImage = "http://www.amfmph.com/wp-content/plugins/" +
                            "social-media-builder//img/no-image.png";
            pictureBox.Load(_defaultImage);
            pictureBox.Refresh();
        }

        private void Watch_Shown(object sender, EventArgs e)
        {
            _parent = (Controller)MdiParent;
            userLabel.Text += _parent.User;
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
    }
}
