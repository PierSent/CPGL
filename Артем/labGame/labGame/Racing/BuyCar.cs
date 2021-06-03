using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Racing
{
    public partial class BuyCar : Form
    {
        private ChangeCar changeCar;

        private int car;
        private int coins;
        private object[,] cars;

        public BuyCar(int car, object[,] cars, int coins)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            
            this.car = car;
            this.cars = cars;
            this.coins = coins;
            
            buBuy.Text = $"{(int)cars[car, 3]}$";


            buBuy.Click += BuBuy_Click;
            buNo.Click += BuNo_Click;
        }

        private void BuNo_Click(object sender, EventArgs e) // отмена   
        {
            this.Hide();
            changeCar = new ChangeCar(coins, cars);
            changeCar.ShowDialog();
        }

        private void BuBuy_Click(object sender, EventArgs e) // покупка    
        {
            if ((int)cars[car, 3] >= coins)
            {
                MessageBox.Show("You don't have enough coins");
            }
            else
            {
                coins -= (int)cars[car, 3];
                cars[car, 1] = true;
                cars[car, 2] = true;
                this.Hide();
                changeCar = new ChangeCar(coins, cars);
                changeCar.ShowDialog();
            }
        }
    }
}
