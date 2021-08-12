using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class FormAboutMe : Form
    {

        public string sHoten;
        public FormAboutMe()
        {
            InitializeComponent();
        }

        private void FormAboutMe_Load(object sender, EventArgs e)
        {
            lblAboutMe.Text = sHoten;
        }
    }
}
