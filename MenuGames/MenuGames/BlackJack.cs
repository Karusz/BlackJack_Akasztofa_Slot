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

        }

        private void limebg_Click(object sender, EventArgs e)
        {
            Image lbg = Image.FromFile("bjfiles/backg/sajatbg.png");
            cardspanel.BackgroundImage = lbg;
            buttonpanel.BackgroundImage = lbg;
            dc1.BackgroundImage = lbg;
            dc2.BackgroundImage = lbg;
            pc1.BackgroundImage = lbg;
            pc2.BackgroundImage = lbg;
        }

        private void greenbg_Click(object sender, EventArgs e)
        {
            Image gbg = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            cardspanel.BackgroundImage = gbg;
            buttonpanel.BackgroundImage = gbg;
            dc1.BackgroundImage = gbg;
            dc2.BackgroundImage = gbg;
            pc1.BackgroundImage = gbg;
            pc2.BackgroundImage = gbg;
        }

        private void redbg_Click(object sender, EventArgs e)
        {
            Image rbg = Image.FromFile("bjfiles/backg/redbg.jpg");
            cardspanel.BackgroundImage = rbg;
            buttonpanel.BackgroundImage = rbg;
            dc1.BackgroundImage = rbg;
            dc2.BackgroundImage = rbg;
            pc1.BackgroundImage = rbg;
            pc2.BackgroundImage = rbg;
        }

        private void segítségToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "Segítség";
            string text = "Ide a szöveg majd";
            MessageBox.Show(text, title);
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
            dc1.Image = Image.FromFile("bjfiles/cards/hatlap.png");
            dc2.Image = Image.FromFile("bjfiles/cards/hatlap.png");
            pc1.Image = Image.FromFile("bjfiles/cards/hatlap.png");
            pc2.Image = Image.FromFile("bjfiles/cards/hatlap.png");

            List<Card> deck = GetDeck();
            var dealerCards = new List<Card>();
            var playerCards = new List<Card>();

            //Deck keverés
            DeckKeveres(deck);

            //Játékos lapjai
            Jatekkez(deck, playerCards);
            //Géplapjai
            Gepkez(deck,dealerCards);
        }

        private List<Card> GetDeck()
        {
            throw new NotImplementedException();
        }

        private void Gepkez(List<Card> deck, List<Card> dealerCards)
        {
            Card dealerCard1 = deck[0];
            deck[0].Kezben = true;
            deck.RemoveAt(0);
            Card dealerCard2 = deck[1];
            deck[1].Kezben = true;
            deck.RemoveAt(1);

            dealerCards.Add(dealerCard1);
            dealerCards.Add(dealerCard2);
            
        }

        private void Jatekkez(List<Card> deck, List<Card> playerCards)
        {
            Card playerCard1 = deck[0];
            deck[0].Kezben = true;
            deck.RemoveAt(0);
            Card playerCard2 = deck[1];
            deck[1].Kezben = true;
            deck.RemoveAt(1);

            playerCards.Add(playerCard1);
            playerCards.Add(playerCard2);
            
        }

        private void DeckKeveres(List<Card> deck)
        {
            throw new NotImplementedException();
        }
    }
}
