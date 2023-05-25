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
    public partial class Pictures : Form
    {
        static SoundPlayer hm = new SoundPlayer("eastereggpicss/eemusicwaw.wav");
        static SoundPlayer gu = new SoundPlayer("giveup.wav");
        static SoundPlayer fullgu = new SoundPlayer("TeljesGive.wav");
        static SoundPlayer go = new SoundPlayer("gosound.wav");
        
        public Pictures()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            hm.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gu.Play();
        }

        private void music_off_Click(object sender, EventArgs e)
        {
            hm.Stop();
            gu.Stop();
            go.Stop();
            fullgu.Stop();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            go.Play();
        }

        private void menuback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void btn_teljes_Click(object sender, EventArgs e)
        {
            fullgu.Play();
        }
    }
}
