using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MenuGames
{
    public partial class Akasztofa : Form
    {
        static List<string> szavak;
        static Button[] gombok;
        static string szo;

        public Akasztofa()
        {
            InitializeComponent();
            Game();
        }
        private void Beolvas()
        {
            using (StreamReader sr = new StreamReader("magyar-szavak.txt"))
            {
                while (!sr.EndOfStream)
                {
                    szavak.Add(sr.ReadLine());
                }
            }
        }

        private string Kivalaszt()
        {
            Random rnd = new Random();
            return szavak[rnd.Next(0, szavak.Count)];
        }

        private void Game()
        {
            szavak = new List<string>();
            Beolvas();
            szo = Kivalaszt();
            label1.Text = "";
            for (int i = 0; i < szo.Length; i++)
            {
                label1.Text += $" _";
            }
            gombok = Controls.OfType<Button>().ToArray();
            Feliratkoztat();
            
        }

        private void Feliratkoztat()
        {
            for (int i = 0; i < gombok.Length; i++)
            {
                gombok[i].Click += allBtn_Click;
            }
        }

        private void CheckLetter(string letter)
        {
            char[] tmp;
            if (szo.Contains(letter))
            {
                for (int i = 0; i < szo.Length; i++)
                {
                    if (szo[i] == letter[0])
                    {
                        tmp = label1.Text.ToCharArray();
                        tmp[i + 1] = letter[0];
                        label1.Text = new string(tmp);
                    }
                }
            }
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CheckLetter(btn.Text);
            
        }

        private void Akasztofa_Load(object sender, EventArgs e)
        {
        }

    }
}
