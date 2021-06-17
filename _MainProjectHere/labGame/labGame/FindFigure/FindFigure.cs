using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    public partial class FindFigure : Form
    {
        public FindFigure(bool win, int score, int time)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            if (score == -1)
            {
                laScore.Text = "Can you find figure for 60 sec?";
            }
            else if (win == true)
            {
                laScore.Text = $"You won\nYour score: {score}\nYour time: {time}";
            }
            else if (win == false)
            {
                laScore.Text = $"Game over\nYour score: {score}\nYour time: {time}";
            }

            // старт кнопок
            buStart.Click += BuStart_Click;
        }

        private void BuStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Field F = new Field();
            F.ShowDialog();
        }
    }
}
