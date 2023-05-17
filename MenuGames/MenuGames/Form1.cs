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

        private void easteregg_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile("eastereggpicss/hnmenu.jpg");
            eggtext.Visible = true;
            BackgroundImage = img;
            blackjack.BackColor = Color.DeepPink;
            Akaszto.BackColor = Color.DeepPink;
            Slot.BackColor = Color.DeepPink;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eggtext.Visible = false;
        }
    }
}
