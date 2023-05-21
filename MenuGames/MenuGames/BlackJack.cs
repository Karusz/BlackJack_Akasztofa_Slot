﻿using MenuGames;
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
            //cardback.Image = Image.FromFile("bjfiles/cards/hatlap.png");
            dealernewcardpanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            cardspanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            pcnewcardpanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            playerpoint.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            chips.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            winpont.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            losepont.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            winbet.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            losebet.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            nowbet.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            label1.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            buttonpanel.BackgroundImage = Image.FromFile("bjfiles/backg/sajatbg.png");
            split.Enabled = false;
            newcard.Enabled = false;
            stop.Enabled = false;
            dealerponts.Visible = false;


        }

        private void limebg_Click(object sender, EventArgs e)
        {
            playerpoint.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            chips.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            winpont.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            losepont.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            winbet.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            losebet.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            nowbet.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            label1.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            Image lbg = Image.FromFile("bjfiles/backg/sajatbg.png");
            cardspanel.BackgroundImage = lbg;
            buttonpanel.BackgroundImage = lbg;
            pcnewcardpanel.BackgroundImage = lbg;
            dc1.BackgroundImage = lbg;
            dc2.BackgroundImage = lbg;
            pc1.BackgroundImage = lbg;
            pc2.BackgroundImage = lbg;

            dealernewcardpanel.BackgroundImage = lbg;

        }

        private void greenbg_Click(object sender, EventArgs e)
        {
            Image gbg = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            playerpoint.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            chips.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            winpont.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            losepont.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            winbet.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            losebet.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            nowbet.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            label1.Image = Image.FromFile("bjfiles/backg/zoldbg.jpg");
            cardspanel.BackgroundImage = gbg;
            buttonpanel.BackgroundImage = gbg;
            dc1.BackgroundImage = gbg;
            dc2.BackgroundImage = gbg;
            pc1.BackgroundImage = gbg;
            pc2.BackgroundImage = gbg;
            pcnewcardpanel.BackgroundImage = gbg;
            dealernewcardpanel.BackgroundImage = gbg;
        }

        private void redbg_Click(object sender, EventArgs e)
        {
            Image rbg = Image.FromFile("bjfiles/backg/redbg.jpg");
            playerpoint.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            chips.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            winpont.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            losepont.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            winbet.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            losebet.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            nowbet.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            label1.Image = Image.FromFile("bjfiles/backg/redbg.jpg");
            cardspanel.BackgroundImage = rbg;
            buttonpanel.BackgroundImage = rbg;
            dc1.BackgroundImage = rbg;
            dc2.BackgroundImage = rbg;
            pc1.BackgroundImage = rbg;
            pc2.BackgroundImage = rbg;
            pcnewcardpanel.BackgroundImage = rbg;
            dealernewcardpanel.BackgroundImage = rbg;
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
            else if (int.Parse(bet.Text) > 0) { string title = "Hiba!"; string text = "0-t adtál meg!"; MessageBox.Show(text, title); }
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
            losebet.Text = "0";
            winbet.Text = "0";
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
            //if (dealerponts.Text == "21")
            //{
            //    Vegevizsga();
            //}
        }

        private void Jatekkez()
        {
            newcard.Enabled = true;
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
            if (playerCard1.Ertek == playerCard2.Ertek)
            {
                split.Enabled = true;
            }

        }

        private void Vegevizsga()
        {
            bool playerwin = false;
            bool playerwinin21 = false;
            bool dealerwin = false;
            bool tie = false;
            int nyer;
            int alapchips = int.Parse(chips.Text);//jelenlegi zseton 

            if (int.Parse(playerpoint.Text) == 21)
            {

            }
            else if (int.Parse(playerpoint.Text) > int.Parse(dealerponts.Text))
            {
                playerwinin21 = true;
            }
            else if (int.Parse(dealerponts.Text) > int.Parse(playerpoint.Text))
            {
                dealerwin = true;
            }
            else { tie = true; }

            //Ha a játékos nyert = 2x ezze a zsetont
            // Jóváírás
            //Reset game
            if (playerwinin21)
            {
                int playerbet21 = int.Parse(bet.Text);
                nyer = ((playerbet21 * 2) + playerbet21);
                winbet.Text = $"{nyer}";
                chips.Text = $"{nyer + alapchips}";
                ResetGame();
            }
            else if (playerwin)
            {
                int playerbet = int.Parse(bet.Text);
                winbet.Text = $"{playerbet * 2}";
                nyer = playerbet * 2;
                chips.Text = $"{nyer + alapchips}";
                ResetGame();
            }
            //Ha a gép nyert = Zseton elvesztés
            //Reset game
            else if (dealerwin)
            {
                int playerbetlose = int.Parse(bet.Text);
                losebet.Text = $"{playerbetlose}";
                chips.Text = $"{alapchips - playerbetlose}";
                ResetGame();
            }

            //Ha Döntetlen = Zseton visszakap
            //Reset game
            else if (tie)
            {
                int playerbettie = int.Parse(bet.Text); //Feltett tét
                chips.Text = $"{playerbettie + alapchips}";
                ResetGame();
            }


        }

        private void ResetGame()
        {
            pc1.Image = Image.FromFile("bjfiles/backg/sajatbg.png");
            pc2.Image = Image.FromFile("bjfiles/backg/sajatbg.png"); ;
            dc1.Image = Image.FromFile("bjfiles/backg/sajatbg.png"); ;
            dc2.Image = Image.FromFile("bjfiles/backg/sajatbg.png"); ;
            cardback.Visible = true;
            betting.Enabled = true;
            pcnewcardpanel.Controls.Clear();
            dealernewcardpanel.Controls.Clear();
            bet.Text = string.Empty;
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
            PictureBox newPCard = new PictureBox();
            newPCard.Height = 96;
            newPCard.Width = 72;
            pcnewcardpanel.Controls.Add(newPCard);
            newPCard.Image = Image.FromFile(playerNewCard1.Link);
            //Hozzáadni a pcnewcardpanel-hez a kapott kártyá(ka)t
            //Megjeleníteni egyben
            //Hozzáadni az értékhez
            int ert = int.Parse(playerpoint.Text);
            int sum = ert + int.Parse(playerNewCard1.Ertek);
            playerpoint.Text = $"{sum}";

        }

        private void Dealermove()
        {
            int dealernewpont;
            int dealerpont = int.Parse(dealerponts.Text);
            cardback.Visible = false;
            while (dealerpont < 7)
            {
                Card dealerNewCard = Card.deck[0];
                Card.deck[0].Kezben = true;
                Card.deck.RemoveAt(0);
                Card.dealerCards.Add(dealerNewCard);
                PictureBox newDCard = new PictureBox();
                newDCard.Height = 96;
                newDCard.Width = 72;
                dealernewcardpanel.Controls.Add(newDCard);
                newDCard.Image = Image.FromFile(dealerNewCard.Link);
                dealernewpont = int.Parse(dealerNewCard.Ertek);
                dealerpont += dealernewpont;
                dealerponts.Text = $"{dealerpont}";

            }
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
            cardback.BackgroundImage = null;
            cardback.BackColor = Color.Transparent;
            stop.Enabled = false;
            betting.Enabled = false;
            newcard.Enabled = false;
            Dealermove();
            Vegevizsga();
        }
    }
}
