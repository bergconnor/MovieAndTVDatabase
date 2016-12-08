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

        public Watch()
        {
            InitializeComponent();
            db = new DatabaseConnect();
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            string name = showTxt.Text;
            string show = db.GetShowLink(name);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (show.Length > 0)
            {
                pictureBox1.Load(show);
            }
            else
            {
                pictureBox1.Load("http://www.amfmph.com/wp-content/plugins/social-media-builder//img/no-image.png");
            }
        }
    }
}
