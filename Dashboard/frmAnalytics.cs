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
        SoundPlayer player1 = new SoundPlayer("Black_Sabbath_-_Sabotage_-_04_-_Megalomania[1].wav");
        SoundPlayer player2 = new SoundPlayer("Losing_My_Edge[1].wav");
        SoundPlayer player3 = new SoundPlayer("ABBA_-_Waterloo_-_05_-_My_Mama_Said[1].wav");
        SoundPlayer player4 = new SoundPlayer("Black_Sabbath_-_Paranoid_[Deluxe_Edition_2016]_-_CD1_-_06_-_Hand_of_Doom[1].wav");
        SoundPlayer player5 = new SoundPlayer("David_Bowie_-_Aladdin_Sane_-_10_-_Lady_Grinning_Soul[1].wav");
        SoundPlayer player6 = new SoundPlayer("David_Byrne_-_Grown_Backwards_-_03_-_Au_fond_du_temple_saint[1].wav");
        SoundPlayer player7 = new SoundPlayer("Janis_Joplin_-_Pearl_-_07_-_Me_And_Bobby_McGee[1].wav");
        SoundPlayer player8 = new SoundPlayer("Jethro_Tull_-_Aqualung_-_40th_Anniversary_Special_Edition_-_CD1_-_10_-_Locomotive_Breath[1].wav");
        SoundPlayer player9 = new SoundPlayer("Kebnekajse_-_Idioten_-_08_-_Senpolska[1].wav");
        SoundPlayer player10 = new SoundPlayer("Massive_Attack_-_Mezzanine_-_09_-_Mezzanine[1].wav");
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
