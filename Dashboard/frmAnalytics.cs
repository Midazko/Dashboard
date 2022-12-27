using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Numerics;

namespace Dashboard
{
    public partial class frmAnalytics : Form
    {
        SoundPlayer player1 = new SoundPlayer(@"E:\git\Dashboard\audio\Losing_My_Edge[1].wav");
        SoundPlayer player2 = new SoundPlayer(@"E:\git\Dashboard\audio\Black_Sabbath_-_Sabotage_-_04_-_Megalomania[1].wav");
        SoundPlayer player3 = new SoundPlayer(@"E:\git\Dashboard\audio\Jethro_Tull_-_Aqualung_-_40th_Anniversary_Special_Edition_-_CD1_-_10_-_Locomotive_Breath[1].wav");
        SoundPlayer player4 = new SoundPlayer(@"E:\git\Dashboard\audio\Jethro_Tull_-_Thick_As_A_Brick_-_01_-_Thick_As_A_Brick_(part_1)[1].wav");
        SoundPlayer player5 = new SoundPlayer(@"E:\git\Dashboard\audio\Jethro_Tull_-_Thick_As_A_Brick_-_02_-_Thick_As_A_Brick_(part_2)[1].wav");
        SoundPlayer player6 = new SoundPlayer(@"E:\git\Dashboard\audio\Yes_-_Close_To_The_Edge_(2013_Steven_Wilson_Remix)_-_01_-_Close_To_The_Edge[1].wav");
        SoundPlayer player7 = new SoundPlayer(@"E:\git\Dashboard\audio\Yes_-_Close_To_The_Edge_(2013_Steven_Wilson_Remix)_-_02_-_And_You_And_I[1].wav");
        SoundPlayer player8 = new SoundPlayer(@"E:\git\Dashboard\audio\Yes_-_Close_To_The_Edge_(2013_Steven_Wilson_Remix)_-_03_-_Siberian_Khatru[1].wav");
        SoundPlayer player9 = new SoundPlayer(@"E:\git\Dashboard\audio\Yes_-_Fragile_-_09_-_Heart_of_the_Sunrise[1].wav");
        SoundPlayer player10 = new SoundPlayer(@"E:\git\Dashboard\audio\Yes_-_Fragile_-_16_-_America_(Singel_1972)[1].wav");
        public frmAnalytics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            player1.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2.Play();        }

        private void button4_Click(object sender, EventArgs e)
        {

            player3.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            player4.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            player5.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            player6.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            player7.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            player8.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            player9.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            player10.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            player1.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player1.Stop();
            player2.Stop();
            player3.Stop();
            player4.Stop();
            player5.Stop();
            player6.Stop();
            player7.Stop();
            player8.Stop();
            player9.Stop();
            player10.Stop();
        }
    }
}
