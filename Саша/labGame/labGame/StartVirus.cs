using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    public partial class StartVirus : Form
    {
        public StartVirus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_VirusGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void start_VirusGame()
        {
            VirusGame VG = new VirusGame();
            VG.ShowDialog();
        }
    }
}
