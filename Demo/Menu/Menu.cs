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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bj_Click(object sender, EventArgs e)
        {
            //Átmegy a BlackJack form-ba
            Blackjack frm = new Blackjack(this);
            frm.Show();
            this.Visible = false;   //Eltünteti a menu-t
        }

        private void af_Click(object sender, EventArgs e)
        {
            //Átmegy az Akasztófa form-ba
            Akasztofa frm = new Akasztofa(this);
            frm.Show();
            //this.Visible = false;
        }

        private void sm_Click(object sender, EventArgs e)
        {
            //Átmegy a Slot Machine form-ba
            SlotMachine frm = new SlotMachine(this);
            frm.Show();
            //this.Visible = false;
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Close(); //Bezárja a programot
        }
    }
}
