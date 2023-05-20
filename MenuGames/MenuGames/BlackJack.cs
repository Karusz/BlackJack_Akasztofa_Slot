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
            Gepkez(deck, dealerCards);
        }


        private List<Card> GetDeck()
        {
            //Csinálni egy lsitaát 1 pakli - ertek, tipus, kezben, link
            var deck = new List<Card>();

            for (int i = 0; i < 2; i++)
            {
                #region Pikk
                deck.Add(new Card("2", "Pikk", "bjfilse/cards/P2"));
                deck.Add(new Card("3", "Pikk", "bjfilse/cards/P3"));
                deck.Add(new Card("4", "Pikk", "bjfilse/cards/P4"));
                deck.Add(new Card("5", "Pikk", "bjfilse/cards/P5"));
                deck.Add(new Card("6", "Pikk", "bjfilse/cards/P6"));
                deck.Add(new Card("7", "Pikk", "bjfilse/cards/P7"));
                deck.Add(new Card("8", "Pikk", "bjfilse/cards/P8"));
                deck.Add(new Card("9", "Pikk", "bjfilse/cards/P9"));
                deck.Add(new Card("10", "Pikk", "bjfilse/cards/P10"));
                deck.Add(new Card("10", "Pikk", "bjfilse/cards/PJ"));
                deck.Add(new Card("10", "Pikk", "bjfilse/cards/PD"));
                deck.Add(new Card("10", "Pikk", "bjfilse/cards/PK"));
                deck.Add(new Card("11", "Pikk", "bjfilse/cards/PA"));
                #endregion
                #region Kőr
                deck.Add(new Card("2", "Kőr", "bjfiles/cards/Ko2"));
                deck.Add(new Card("3", "Kőr", "bjfiles/cards/Ko3"));
                deck.Add(new Card("4", "Kőr", "bjfiles/cards/Ko4"));
                deck.Add(new Card("5", "Kőr", "bjfiles/cards/Ko5"));
                deck.Add(new Card("6", "Kőr", "bjfiles/cards/Ko6"));
                deck.Add(new Card("7", "Kőr", "bjfiles/cards/Ko7"));
                deck.Add(new Card("8", "Kőr", "bjfiles/cards/Ko8"));
                deck.Add(new Card("9", "Kőr", "bjfiles/cards/Ko9"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/Ko10"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/KoJ"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/KoD"));
                deck.Add(new Card("10", "Kőr", "bjfiles/cards/KoK"));
                deck.Add(new Card("11", "Kőr", "bjfiles/cards/KoA"));
                #endregion
                #region Káro
                deck.Add(new Card("2", "Káró", "bjfiles/cards/Ka2"));
                deck.Add(new Card("3", "Káró", "bjfiles/cards/Ka3"));
                deck.Add(new Card("4", "Káró", "bjfiles/cards/Ka4"));
                deck.Add(new Card("5", "Káró", "bjfiles/cards/Ka5"));
                deck.Add(new Card("6", "Káró", "bjfiles/cards/Ka6"));
                deck.Add(new Card("7", "Káró", "bjfiles/cards/Ka7"));
                deck.Add(new Card("8", "Káró", "bjfiles/cards/Ka8"));
                deck.Add(new Card("9", "Káró", "bjfiles/cards/Ka9"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/Ka10"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/KaJ"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/KaD"));
                deck.Add(new Card("10", "Káró", "bjfiles/cards/KaK"));
                deck.Add(new Card("11", "Káró", "bjfiles/cards/KaA"));
                #endregion
                #region Treff
                deck.Add(new Card("2", "Treff", "bjfiles/cards/T2"));
                deck.Add(new Card("3", "Treff", "bjfiles/cards/T3"));
                deck.Add(new Card("4", "Treff", "bjfiles/cards/T4"));
                deck.Add(new Card("5", "Treff", "bjfiles/cards/T5"));
                deck.Add(new Card("6", "Treff", "bjfiles/cards/T6"));
                deck.Add(new Card("7", "Treff", "bjfiles/cards/T7"));
                deck.Add(new Card("8", "Treff", "bjfiles/cards/T8"));
                deck.Add(new Card("9", "Treff", "bjfiles/cards/T9"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/T10"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/TJ"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/TD"));
                deck.Add(new Card("10", "Treff", "bjfiles/cards/TK"));
                deck.Add(new Card("11", "Treff", "bjfiles/cards/TA"));
                #endregion 
            }

            
            return deck;
        }

        private void Gepkez(List<Card> deck, List<Card> dealerCards)
        {
            cardback.Visible = true;
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
            Random random = new Random();

            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = deck[k];
                deck[k] = deck[n];
                deck[n] = temp;
            }
        }
    }
}
