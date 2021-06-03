using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Racing
{
    public partial class RacingMenu : Form
    {
        private Game game;
        private ChangeCar changeCar;

        private int maxDist;
        private int coins;
        private object[,] cars;

        public RacingMenu(int maxDist, int coins, object[,] cars)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.cars = cars;
            this.maxDist = maxDist;
            this.coins = coins;
            InitializeComponent();

            laCoins.Text = $"Coins: {coins}";
            laScore.Text = $"Last score: {maxDist} m";

            buStart.Click += BuStart_Click;
            buCar.Click += BuCar_Click;
        }

        private void BuCar_Click(object sender, EventArgs e)
        {
            changeCar = new ChangeCar(coins, cars);
            this.Hide();
            changeCar.ShowDialog();
        }

        private void BuStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            game = new Game(maxDist, coins, cars);
            game.ShowDialog();
        }
    }
}
