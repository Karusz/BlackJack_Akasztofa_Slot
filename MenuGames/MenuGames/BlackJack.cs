using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuGames
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            Image sbg = Image.FromFile("bjfiles/backg/sajatbg.png");
            BackgroundImage = sbg;

        }

        private void limebg_Click(object sender, EventArgs e)
        {
            Image lbg = Image.FromFile("bjfiles/backg/sajatbg.png");
            BackgroundImage = lbg;
        }

        private void greenbg_Click(object sender, EventArgs e)
        {
            Image gbg = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            BackgroundImage = gbg;
        }

        private void redbg_Click(object sender, EventArgs e)
        {
            Image rbg = Image.FromFile("bjfiles/backg/redbg.jpg");
            BackgroundImage = rbg;
        }

        private void segítségToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "Segítség";
            string text = "Ide a szöveg majd";
            MessageBox.Show(text,title);
        }

        private void betting_Click(object sender, EventArgs e)
        {
            int betnum;
            if (!int.TryParse(bet.Text, out betnum))
            {
                string title = "Hiba";
                string text = "Nem számot adtál meg!";
                MessageBox.Show(text, title);
            }
            Console.WriteLine(betnum);

        }
    }
}
