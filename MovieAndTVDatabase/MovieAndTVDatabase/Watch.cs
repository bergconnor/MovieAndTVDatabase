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
        private DatabaseConnect db;
        private string defaultImageString;

        public Watch()
        {
            InitializeComponent();
            this.db = new DatabaseConnect();
            this.defaultImageString = "http://www.amfmph.com/wp-content/plugins/" +
                                    "social-media-builder//img/no-image.png";
            this.pictureBox1.Load(defaultImageString);
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
            }
            else
            {
                this.pictureBox1.Load(defaultImageString);
            }
        }
    }
}
