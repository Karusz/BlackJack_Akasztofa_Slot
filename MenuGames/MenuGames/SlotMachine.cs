using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuGames
{
    public partial class SlotMachine : Form
    {
        public SlotMachine()
        {
            InitializeComponent();
            InitializeArray();
        }
        public static long credits = 100;
        public static long total = 0;
        public static int bet = 5;

        public string[,] pics = new string[7, 4];
        private void InitializeArray()
        {
            pics[0, 0] = "img//alma1.png";
            pics[0, 1] = "img//alma2.png";
            pics[0, 2] = "img//alma3.png";
            pics[0, 3] = "img//alma4.png";

            pics[1, 0] = "img//amogus1.png";
            pics[1, 1] = "img//amogus2.png";
            pics[1, 2] = "img//amogus3.png";
            pics[1, 3] = "img//amogus4.png";

            pics[2, 0] = "img//cherry1.png";
            pics[2, 1] = "img//cherry2.png";
            pics[2, 2] = "img//cherry3.png";
            pics[2, 3] = "img//cherry4.png";

            pics[3, 0] = "img//sor1.png";
            pics[3, 1] = "img//sor2.png";
            pics[3, 2] = "img//sor3.png";
            pics[3, 3] = "img//sor4.png";

            pics[4, 0] = "img//penz1.png";
            pics[4, 1] = "img//penz2.png";
            pics[4, 2] = "img//penz3.png";
            pics[4, 3] = "img//penz4.png";

            pics[5, 0] = "img//hetes1.png";
            pics[5, 1] = "img//hetes2.png";
            pics[5, 2] = "img//hetes3.png";
            pics[5, 3] = "img//hetes4.png";

            pics[6, 0] = "img//java1.png";
            pics[6, 1] = "img//java2.png";
            pics[6, 2] = "img//java3.png";
            pics[6, 3] = "img//java4.png";
        }
        public static class IntUtil
        {
            private static Random random;
            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min,int max)
            {
                Init();
                return random.Next(min,max);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SlotMachine_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("img//alma1.png");
            pictureBox2.Image = Image.FromFile("img//alma1.png");
            pictureBox3.Image = Image.FromFile("img//alma1.png");
            pictureBox4.Image = Image.FromFile("img//alma1.png");
            pictureBox5.Image = Image.FromFile("img//alma1.png");
            pictureBox6.Image = Image.FromFile("img//alma1.png");
            pictureBox7.Image = Image.FromFile("img//alma1.png");
            pictureBox8.Image = Image.FromFile("img//alma1.png");
            pictureBox9.Image = Image.FromFile("img//alma1.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (credits <=bet) 
            {
                credits = credits - bet;
                label1.Text = "Credits: " + credits.ToString();
                for (int i = 0; i < 10; i++)
                {
                    pictureBox1.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox2.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox3.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox4.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox5.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox6.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox7.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox8.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                    pictureBox9.Image = Image.FromFile(pics[IntUtil.Random(0, 7), IntUtil.Random(0, 4)]);
                }
                total = 0;
                
            }
        }
    }
}
