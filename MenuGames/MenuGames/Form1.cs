using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blackjack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BlackJack blackjackForm = new BlackJack();
            blackjackForm.FormClosed += (s, args) => this.Close();
            blackjackForm.Show();
        }

        private void Akaszto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Akasztofa akasztofaForm = new Akasztofa();
            akasztofaForm.FormClosed += (s, args) => this.Close();
            akasztofaForm.Show();
        }


        private void Slot_Click(object sender, EventArgs e)
        {
            this.Hide();
            SlotMachine slotMachineForm = new SlotMachine();
            slotMachineForm.FormClosed += (s, args) => this.Close();
            slotMachineForm.Show();
        }
        private void galleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pictures blackjackForm = new Pictures();
            blackjackForm.FormClosed += (s, args) => this.Close();
            blackjackForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eggtext.Visible = false;
            click_btn.Visible = false;
            galleria.Visible = false;
        }

        private void easteregg_CheckedChanged(object sender, EventArgs e)
        {
            if (easteregg.Checked)
            {
                SoundPlayer opening = new SoundPlayer("eastereggpicss/eemusicwaw.wav");
                opening.Play();
                Image img = Image.FromFile("eastereggpicss/hnmenu.jpg");
                eggtext.Visible = true;
                BackgroundImage = img;
                blackjack.BackColor = Color.DeepPink;
                Akaszto.BackColor = Color.DeepPink;
                Slot.BackColor = Color.DeepPink;
                creators.BackColor = Color.DeepPink;
                minigame.BackColor = Color.DeepPink;
                galleria.BackColor = Color.DeepPink;

            }
            else
            {
                SoundPlayer opening = new SoundPlayer("eastereggpicss/eemusicwaw.wav");
                opening.Stop();
                Image img = Image.FromFile("eastereggpicss/hnmenu.jpg");
                eggtext.Visible = false;
                BackgroundImage = null;
                blackjack.BackColor = Color.White;
                Akaszto.BackColor = Color.White;
                Slot.BackColor = Color.White;
                creators.BackColor = Color.White;
                minigame.BackColor = Color.White;
                galleria.BackColor= Color.White;
            }
        }

        private void creators_Click(object sender, EventArgs e)
        {
            string text = "Fábián László, Karsai Bence, Mód Károly\nSegítők: Szieber Lili (Karesz barátnője)";
            string title = "Készítők";
            MessageBox.Show(text, title);
        }

        private void minigame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próbáld megnyomni a 'Nyomj meg!' gombot!", "MiniGame");
            click_btn.Visible = true;
        }
        private int moveCount = 0;
        private void click_btn_MouseEnter(object senedr, EventArgs e)
        {
            if (moveCount <= 10)
            {
                if (moveCount == 6)
                {
                    MessageBox.Show("Vagy mégsem?");
                }
                if (moveCount == 5)
                {
                    MessageBox.Show("Abba hagytam!");
                }
                Random rnd = new Random();
                int x = Cursor.Position.X + rnd.Next(-300, 300);
                int y = Cursor.Position.Y + rnd.Next(-300, 300);
                Cursor.Position = new Point(x, y);
                moveCount++;
            }
            else
            {
                minigame.MouseEnter -= click_btn_MouseEnter;
            }
        }

        private void click_btn_Click(object sender, EventArgs e)
        {
            click_btn.Visible = false;
            galleria.Visible = true;
            MessageBox.Show("Galléria létrehozva!", "Minigame win");
            MessageBox.Show("Nézd meg a bal alsó sarkot :D", "Secret");

        }

        
    }
}
