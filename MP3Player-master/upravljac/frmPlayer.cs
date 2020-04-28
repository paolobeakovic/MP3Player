using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljac
{
    public partial class frmPlayer : Form
    {
        private PlayerKontrola mp3Player = new PlayerKontrola();
        public frmPlayer()
        {
            InitializeComponent();
        }

        PlayerKontrola Muzika = new PlayerKontrola();



        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Muzika.Pokreni();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Muzika.Stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Muzika.Pauza();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            Muzika.Forward();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            Muzika.Backward();
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
