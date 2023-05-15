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
    }
}
