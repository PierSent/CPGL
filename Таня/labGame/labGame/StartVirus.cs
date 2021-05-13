using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
    
    //запуск стартовой формы игры VirusGame
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
        } //кнопка старта игры

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//кнопка закрытия формы
        
        private void start_VirusGame()
        {
            VirusGame VG = new VirusGame();
            VG.ShowDialog();
        }
    }
}
