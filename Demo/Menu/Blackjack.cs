using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Blackjack : Form
    {
        Form opener;
        public Blackjack(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void red_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("backg/redbg.jpg");
            BackgroundImage = img;
        }

        private void lime_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("backg/sajatbg.png");
            BackgroundImage = img;
        }

        private void green_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("backg/zoldbg.jpg");
            BackgroundImage = img;
        }

        private void help_Click(object sender, EventArgs e)
        {

        }
    }
}
