using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Racing
{
    public partial class ChangeCar : Form
    {
        private BuyCar buyCar;
        private RacingMenu menu;

        private int coins;
        private object[,] cars;

        public ChangeCar(int coins, object[,] cars)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.coins = coins;
            this.cars = cars;

            if ((bool)cars[0, 1])
            {
                selectButton(buClassic);
                unselectButton(buGreen);
                unselectButton(buNeon);
            }
            if ((bool)cars[1, 1])
            {
                selectButton(buGreen);
                unselectButton(buClassic);
                unselectButton(buNeon);
            }
            if ((bool)cars[2, 1])
            {
                selectButton(buNeon);
                unselectButton(buClassic);
                unselectButton(buGreen);
            }

            /*buClassic.Image = labGame.Properties.Resources.car;
            buGreen.Image = labGame.Properties.Resources.carGreen;
            buNeon.Image = labGame.Properties.Resources.carNeon;*/
            
            // ---------------- это удалить
            buClassic.Image = labGame.Properties.Resources.virus;
            buGreen.Image = labGame.Properties.Resources.virus;
            buNeon.Image = labGame.Properties.Resources.virus;
            // ---------------- до сюда


            buClassic.Click += BuClassic_Click;
            buGreen.Click += BuGreen_Click;
            buNeon.Click += BuNeon_Click;
            buOk.Click += BuOk_Click;
        }

        private void BuOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu = new RacingMenu(0, coins, cars);
            menu.ShowDialog();
        }

        private void BuClassic_Click(object sender, EventArgs e) // нажатие на классик    
        {
            for (int i = 0; i < 3; i++)
            {
                cars[i, 1] = false;
            }
            cars[0, 1] = true;
            selectButton(buClassic);
            unselectButton(buNeon);
            unselectButton(buGreen);
        }

        private void BuGreen_Click(object sender, EventArgs e) // нажатие на зеленый    
        {
            if (!(bool)cars[1, 2])
            {
                this.Hide();
                buyCar = new BuyCar(1, cars, coins);
                buyCar.ShowDialog();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    cars[i, 1] = false;
                }
                cars[1, 1] = true;
                selectButton(buGreen); 
                unselectButton(buClassic);
                unselectButton(buNeon);
            }
        }

        private void BuNeon_Click(object sender, EventArgs e) // нажатие на неон    
        {
            if (!(bool)cars[2, 2])
            {
                this.Hide();
                buyCar = new BuyCar(2, cars, coins);
                buyCar.ShowDialog();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    cars[i, 1] = false;
                }
                cars[2, 1] = true;
                selectButton(buNeon);
                unselectButton(buClassic);
                unselectButton(buGreen);
            }
        }

        private void selectButton(Button button) // выделение кнопки    
        {
            button.Text = "SELECTED";
            button.ForeColor = Color.Red;
        }

        private void unselectButton(Button button) // снятие выделения    
        {
            button.Text = "";
            button.ForeColor = Color.Black;
        }
    }
}
