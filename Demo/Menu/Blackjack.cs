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
            string text = "Szöveg";
            string title = "Segítség";
        }

        private void betpull_Click(object sender, EventArgs e)
        {
            int num;
            if(int.TryParse(bet.Text, out int id))
            {
                num = int.Parse(bet.Text);

                List<Card> deck = GetDeck();
                //Keverés
                ShuffleDeck(deck);

                //Laposztás
                Card playerCard1 = deck[0];
                deck[0].Kezben = true;
                deck.RemoveAt(0);
                Card playerCard2 = deck[1];
                deck[1].Kezben = true;
                deck.RemoveAt(0);
                Card dealerCard1 = deck[1];
                deck[0].Kezben = true;
                deck.RemoveAt(0);
                Card dealerCard2 = deck[1];
                deck[1].Kezben = true;
                deck.RemoveAt(0);

            }
            else
            {
                string text = "Nem számot adtál meg";
                string title = "HIBA";
                MessageBox.Show(text,title);
            }
        }

        private void ShuffleDeck(List<Card> deck)
        {
            throw new NotImplementedException();
        }

        private List<Card> GetDeck()
        {
            throw new NotImplementedException();
        }
    }
}
