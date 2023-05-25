using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuGames
{
    public partial class SlotMachine : Form
    {
        public SlotMachine()
        {
            InitializeComponent();
        }

        public static long credits = 1000;
        public static long total = 0;
        public static int bet = 5;

        public static int p1;
        public static int p2;
        public static int p3;
        public static int p4;
        public static int p5;
        public static int p6;
        public static int p7;
        public static int p8;
        public static int p9;


        public static class IntUtil
        {
            private static Random random;
            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        private void SlotMachine_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("img/1.png");
            pictureBox2.Image = Image.FromFile("img/2.png");
            pictureBox3.Image = Image.FromFile("img/3.png");
            pictureBox4.Image = Image.FromFile("img/4.png");
            pictureBox5.Image = Image.FromFile("img/5.png");
            pictureBox6.Image = Image.FromFile("img/6.png");
            pictureBox7.Image = Image.FromFile("img/7.png");
            pictureBox8.Image = Image.FromFile("img/1.png");
            pictureBox9.Image = Image.FromFile("img/2.png");
            label1.Text = "Credits: " + credits.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (credits >= bet)
            {
                credits -= bet;
                label1.Text = "Credits: " + credits.ToString();
                for (int i = 0; i < 10; i++)
                {
                    p1 = IntUtil.Random(1, 8);
                    p2 = IntUtil.Random(1, 8);
                    p3 = IntUtil.Random(1, 8);
                    p4 = IntUtil.Random(1, 8);
                    p5 = IntUtil.Random(1, 8);
                    p6 = IntUtil.Random(1, 8);
                    p7 = IntUtil.Random(1, 8);
                    p8 = IntUtil.Random(1, 8);
                    p9 = IntUtil.Random(1, 8);
                }
                if (pictureBox1 != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = Image.FromFile("img/" + p1.ToString() + ".png");

                if (pictureBox2 != null) pictureBox2.Image.Dispose();
                pictureBox2.Image = Image.FromFile("img/" + p2.ToString() + ".png");

                if (pictureBox3 != null) pictureBox3.Image.Dispose();
                pictureBox3.Image = Image.FromFile("img/" + p3.ToString() + ".png");

                if (pictureBox4 != null) pictureBox4.Image.Dispose();
                pictureBox4.Image = Image.FromFile("img/" + p4.ToString() + ".png");

                if (pictureBox5 != null) pictureBox5.Image.Dispose();
                pictureBox5.Image = Image.FromFile("img/" + p5.ToString() + ".png");

                if (pictureBox6 != null) pictureBox6.Image.Dispose();
                pictureBox6.Image = Image.FromFile("img/" + p6.ToString() + ".png");

                if (pictureBox6 != null) pictureBox6.Image.Dispose();
                pictureBox6.Image = Image.FromFile("img/" + p6.ToString() + ".png");

                if (pictureBox7 != null) pictureBox7.Image.Dispose();
                pictureBox7.Image = Image.FromFile("img/" + p7.ToString() + ".png");

                if (pictureBox8 != null) pictureBox8.Image.Dispose();
                pictureBox8.Image = Image.FromFile("img/" + p8.ToString() + ".png");

                if (pictureBox9 != null) pictureBox9.Image.Dispose();
                pictureBox9.Image = Image.FromFile("img/" + p9.ToString() + ".png");

                total = 0;

                if (p1 == p2 && p2 == p3)
                {
                    switch (p1)
                    {
                        case 1:
                            total += bet * 2;
                            break;
                        case 2:
                            total += bet * 4;
                            break;
                        case 3:
                            total += bet * 10;
                            break;
                        case 4:
                            total += bet * 20;
                            break;
                        case 5:
                            total += bet * 30;
                            break;
                        case 6:
                            total += bet * 40;
                            break;
                        case 7:
                            total += bet * 100;
                            break;
                        default:
                            break;
                    }
                }
                if (p4 == p5 && p5 == p6)
                {
                    switch (p4)
                    {
                        case 1:
                            total += bet * 2;
                            break;
                        case 2:
                            total += bet * 4;
                            break;
                        case 3:
                            total += bet * 10;
                            break;
                        case 4:
                            total += bet * 20;
                            break;
                        case 5:
                            total += bet * 30;
                            break;
                        case 6:
                            total += bet * 40;
                            break;
                        case 7:
                            total += bet * 100;
                            break;
                        default:
                            break;
                    }
                }
                if (p7 == p8 && p8 == p9)
                {
                    switch (p7)
                    {
                        case 1:
                            total += bet * 2;
                            break;
                        case 2:
                            total += bet * 4;
                            break;
                        case 3:
                            total += bet * 10;
                            break;
                        case 4:
                            total += bet * 20;
                            break;
                        case 5:
                            total += bet * 30;
                            break;
                        case 6:
                            total += bet * 40;
                            break;
                        case 7:
                            total += bet * 100;
                            break;
                        default:
                            break;
                    }
                }
                if (p1 == p5 && p5 == p9)
                {
                    switch (p9)
                    {
                        case 1:
                            total += bet * 2;
                            break;
                        case 2:
                            total += bet * 4;
                            break;
                        case 3:
                            total += bet * 10;
                            break;
                        case 4:
                            total += bet * 20;
                            break;
                        case 5:
                            total += bet * 30;
                            break;
                        case 6:
                            total += bet * 40;
                            break;
                        case 7:
                            total += bet * 100;
                            break;
                        default:
                            break;
                    }
                }
                if (p3 == p5 && p5 == p7)
                {
                    switch (p3)
                    {
                        case 1:
                            total += bet * 2;
                            break;
                        case 2:
                            total += bet * 4;
                            break;
                        case 3:
                            total += bet * 10;
                            break;
                        case 4:
                            total += bet * 20;
                            break;
                        case 5:
                            total += bet * 30;
                            break;
                        case 6:
                            total += bet * 40;
                            break;
                        case 7:
                            total += bet * 100;
                            break;
                        default:
                            break;
                    }
                }
                credits += total;
                label3.Text = "Win: " + total.ToString();
                label1.Text = "Credit: " + credits.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bet = int.Parse(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ne feledd, akár a pénzed 2000% is megnyerheted egy kör alatt, de csak a 100%-át veszítheted el!");
        }
    }
}
