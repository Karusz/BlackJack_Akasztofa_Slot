using MenuGames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            pccardpanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            dccardpanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            cardspanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            buttonpanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            split.Enabled = false;
            newcard.Enabled = false;
            stop.Enabled = false;
            dealerponts.Visible = false;

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
            pccardpanel.BackgroundImage = lbg;
            dccardpanel.BackgroundImage = lbg;
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
            pccardpanel.BackgroundImage = gbg;
            dccardpanel.BackgroundImage = gbg;
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
            pccardpanel.BackgroundImage = rbg;
            dccardpanel.BackgroundImage = rbg;
        }
        //Félkész:
        private void segítségToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "Segítség";
            string text = "A játék lényege, hogy több pontod legyen, mint az osztónak.\n" +
                "Viszont kevesebb kell legyen, mint 21, de ha instant 21-et kapsz, akkor nyertél!\n" +
                "Az ász minden esetben 11-et ér. Sajnálom :c\n" +
                "Minden kártyának az értéke a rajta látható szám.\n" +
                "A Jumbó, Dáma, Király kártyák 10-et érnek minden esetben.\n" +
                "SOK SIKERT A JÁTÉKHOZ!!";
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
            else
            {
                int chipnum = int.Parse(chips.Text);
                chips.Text = $"{chipnum - betnum}";
                betting.Enabled = false;
                stop.Enabled = true;
                //Deck keverés
                DeckKeveres();
                //Játékos lapjai
                Jatekkez();
                //Géplapjai
                Gepkez();
            }
        }

        private void Gepkez()
        {
            cardback.Visible = true;
            Card dealerCard1 = Card.deck[0];
            Card.deck[0].Kezben = true;
            Card.deck.RemoveAt(0);
            Card dealerCard2 = Card.deck[1];
            Card.deck[1].Kezben = true;
            Card.deck.RemoveAt(1);

            Card.dealerCards.Add(dealerCard1);
            Card.dealerCards.Add(dealerCard2);
            dc1.Image = Image.FromFile(dealerCard1.Link);
            dc2.Image = Image.FromFile(dealerCard2.Link);
            newcard.Enabled = true;

            int ert1 = int.Parse(dealerCard1.Ertek);
            int ert2 = int.Parse(dealerCard2.Ertek);
            dealerponts.Text = $"{ert1 + ert2}";

        }

        private void Jatekkez()
        {
            Card playerCard1 = Card.deck[0];
            Card.deck[0].Kezben = true;
            Card.deck.RemoveAt(0);
            Card playerCard2 = Card.deck[1];
            Card.deck[1].Kezben = true;
            Card.deck.RemoveAt(1);

            Card.playerCards.Add(playerCard1);
            Card.playerCards.Add(playerCard2);
            pc1.Image = Image.FromFile(playerCard1.Link);
            pc2.Image = Image.FromFile(playerCard2.Link);

            int ert1 = int.Parse(playerCard1.Ertek);
            int ert2 = int.Parse(playerCard2.Ertek);
            playerpoint.Text = $"{ert1 + ert2}";

            if (playerpoint.Text == "21")
            {
                Vegevizsga();
            }

            //Dlc
            if (playerCard1.Ertek == "10" && playerCard2.Ertek == "10")
            {
                split.Enabled = true;
            }

        }

        private void Vegevizsga()
        {
            bool playerwin = false;
            bool dealerwin = false;
            bool tie = false;

            if (int.Parse(playerpoint.Text) > int.Parse(dealerponts.Text))
            {
                playerwin = true;
            }
            else if (int.Parse(dealerponts.Text) > int.Parse(playerpoint.Text))
            {
                dealerwin = true;
            }
            else { tie = false; }



        }

        private void DeckKeveres()
        {
            Random random = new Random();

            int n = Card.deck.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = Card.deck[k];
                Card.deck[k] = Card.deck[n];
                Card.deck[n] = temp;
            }
        }

        private void split_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vedd meg a DLC-t hozzá", "Hiba");
            //DLC :D
        }

        private void newcard_Click(object sender, EventArgs e)
        {
            Card playerNewCard1 = Card.deck[0];
            Card.deck[0].Kezben = true;
            Card.deck.RemoveAt(0);
            Card.playerCards.Add(playerNewCard1);
            //Hozzáadni a pcnewcardpanel-hez a kapott kártyá(ka)t
            //Megjeleníteni egyben
            //Hozzáadni az értékhez
            int ert = int.Parse(playerpoint.Text);
            int sum = ert + int.Parse(playerNewCard1.Ertek);
            playerpoint.Text = $"{sum}";
        }

        private void backmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            newcard.Enabled = false;
            Vegevizsga();
        }
    }
}
