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

namespace Dashboard
{
    public partial class frmGame : Form
    {
        SoundPlayer _player = new SoundPlayer(@"E:\git\Dashboard\Dashboard\audio\Gah!.wav");
        public frmGame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _player.Play();
        }
    }
}
