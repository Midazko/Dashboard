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
        SoundPlayer player1 = new SoundPlayer("piano-g_G#_major.wav");
        SoundPlayer player2 = new SoundPlayer("piano-bb_A#_major.wav");
        SoundPlayer player3 = new SoundPlayer("piano-c_C#_major.wav");
        SoundPlayer player4 = new SoundPlayer("piano-eb_D#_major.wav");
        SoundPlayer player5 = new SoundPlayer("piano-f_F#_major.wav");
        SoundPlayer player6 = new SoundPlayer("piano-f_F_major.wav");
        SoundPlayer player7 = new SoundPlayer("piano-a_A_major.wav");
        SoundPlayer player8 = new SoundPlayer("piano-b_B_major.wav");
        SoundPlayer player9 = new SoundPlayer("piano-d_D_major.wav");
        SoundPlayer player10 = new SoundPlayer("piano-e_E_major.wav");
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
