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

        public Information(Home form)
        {
            InitializeComponent();
            this.home = form;
        }
    }
}
