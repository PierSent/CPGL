using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGame
{
    public partial class Field : Form
    {
        private Game game;
        private int lenght;
        public int gameTime = 60;
        public int tryCount = 2;



        public Field()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            lenght = 4;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            game = new Game(this, taGrid, lenght, laScore, laTry);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(gameTime == 0)
            {
                timer.Stop();
                game.isEnd();
            }
            gameTime--;
            laTimer.Text = $"00:{gameTime}";
        }

    }
}
