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
using System.Media;
using System.Threading;

namespace MenuGames
{
    public partial class Akasztofa : Form
    {
        static List<string> szavak;
        static Button[] gombok;
        static string szo;
        static string[] kepek;
        int counter;

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
        private void KepListaba()
        {
            kepek = new string[7];
            kepek[0] = "akaszto_img/0.png";
            kepek[1] = "akaszto_img/1.png";
            kepek[2] = "akaszto_img/2.png";
            kepek[3] = "akaszto_img/3.png";
            kepek[4] = "akaszto_img/4.png";
            kepek[5] = "akaszto_img/5.png";
            kepek[6] = "akaszto_img/6.png";
        }

        private string Kivalaszt()
        {
            Random rnd = new Random();
            return szavak[rnd.Next(0, szavak.Count)];
        }

        private void Game()
        {
            szavak = new List<string>();
            counter = 0;
            Beolvas();
            KepListaba();
            szo = Kivalaszt();
            label1.Text = "";
            for (int i = 0; i < szo.Length; i++)
            {
                label1.Text += "_ ";
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

        private bool CheckLetter(string letter)
        {
            char[] tmp;
            bool van = false;
            
            if (szo.Contains(letter))
            {
                tmp = label1.Text.ToCharArray();
                for (int i = 0; i < szo.Length; i++)
                {
                    if (szo[i] == letter[0])
                    {
                        tmp[i * 2] = letter[0];
                    }
                }
                label1.Text = new string(tmp);
                van = true;
            }
            else
            {
                KepBetolt(counter);
                counter++;
                if (counter == 7)
                {
                    GameOver();
                }
            }
            return van;
        }

        private void GameOver()
        {
            SoundPlayer gameover_sound = new SoundPlayer("gosound.wav");
            gameover_sound.Play();
            MessageBox.Show($"Ez most nem jött össze.\nEzt kellet volna kitalálni: {szo.ToUpper()}","GAME OVER");
            
        }

        private void KepBetolt(int counter)
        {
            pictureBox1.Image = Image.FromFile(kepek[counter]);
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (CheckLetter(btn.Text))
            {
                btn.BackColor = Color.Green;
                
            }
            else
            {
                btn.BackColor = Color.Red;
            }
            btn.Enabled = false;

        }

        private void Akasztofa_Load(object sender, EventArgs e)
        {
            pctBox_giveUp.Visible = false;
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            SoundPlayer giveup_sound = new SoundPlayer("giveup.wav");
            pctBox_giveUp.Visible = true;
            pctBox_giveUp.Refresh();
            giveup_sound.Play();
            Task.Delay(5000).ContinueWith(_ =>
            {
                giveup_sound.Stop();
                pctBox_giveUp.Invoke((MethodInvoker)(() => pctBox_giveUp.Visible = false));
            });
            pctBox_giveUp.Refresh();

        }

    }
}
