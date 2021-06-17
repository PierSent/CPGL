using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    public partial class Sudoku : Form
    {
        public const int kolichKl = 3;
        const int sizeButton = 40;
        const int xM = 100, yM = 400;
        public int[,] map = new int[kolichKl * kolichKl, kolichKl * kolichKl];
        public Button[,] buttons = new Button[kolichKl * kolichKl, kolichKl * kolichKl];//двумерный массив кнопок

        public Sudoku()
        {
            InitializeComponent();
            generateMap();
        }

        public void generateMap() // обработка поля игры
        {
            for(int i=0;i< kolichKl * kolichKl; i++)
            {
                for(int j=0; j < kolichKl * kolichKl; j++)
                {
                    map[i, j] = (i * kolichKl + i / kolichKl + j) % (kolichKl * kolichKl) + 1; // определение положения цифр
                    buttons[i, j] = new Button();
                }
            }
            //transMatrix();
            //SwapRowsInBlock();
            // SwapColumnsInBlock();
            // SwapBlocksInRow();
            //SwapBlocksInColumn();
            //createMap();

            Random r = new Random(); //получение рандомной переменной для перемешивания
            for (int i = 0; i < 40; i++)
            {
                ShuffleMap(r.Next(0, 5));
            }

            createMap();
            HideCells();
        }



        public void HideCells()//скрываем часть ячеек для игры
        {
            int N = 40;
            Random r = new Random();
            while (N > 0)
            {
                for (int i = 0; i < kolichKl * kolichKl; i++)
                {
                    for (int j = 0; j < kolichKl * kolichKl; j++)
                    {
                        if (!string.IsNullOrEmpty(buttons[i, j].Text))
                        {
                            int a = r.Next(0, 100);
                            buttons[i, j].Text = a == 0 ? "" : buttons[i, j].Text;
                            buttons[i, j].Enabled = a == 0 ? true : false;

                            if (a == 0)
                                N--;
                            if (N <= 0)
                                break;
                        }
                    }
                    if (N <= 0)
                        break;
                }
            }
        }

        public void ShuffleMap(int i) //мешаем первоначальное состояние карты
        {
            switch (i)
            {
                case 0:
                    transMatrix();
                    break;
                case 1:
                    SwapRowsInBlock();
                    break;
                case 2:
                    SwapColumnsInBlock();
                    break;
                case 3:
                    SwapBlocksInRow();
                    break;
                case 4:
                    SwapBlocksInColumn();
                    break;
                default:
                    transMatrix();
                    break;
            }
        }

        public void SwapBlocksInColumn() // 7 8 9 и 4 5 6
        {
            Random r = new Random();
            var block1 = r.Next(0, kolichKl);
            var block2 = r.Next(0, kolichKl);
            while (block1 == block2)
                block2 = r.Next(0, kolichKl);
            block1 *= kolichKl;
            block2 *= kolichKl;
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                var k = block2;
                for (int j = block1; j < block1 + kolichKl; j++)
                {
                    var temp = map[i, j];
                    map[i, j] = map[i, k];
                    map[i, k] = temp;
                    k++;
                }
            }
        }

        public void SwapBlocksInRow()
        {
            Random r = new Random();
            var block1 = r.Next(0, kolichKl);
            var block2 = r.Next(0, kolichKl);
            while (block1 == block2)
                block2 = r.Next(0, kolichKl);
            block1 *= kolichKl;
            block2 *= kolichKl;
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                var k = block2;
                for (int j = block1; j < block1 + kolichKl; j++)
                {
                    var temp = map[j, i];
                    map[j, i] = map[k, i];
                    map[k, i] = temp;
                    k++;
                }
            }
        }

        public void SwapRowsInBlock() //смена строк в пределах блока
        {
            Random r = new Random();
            var block = r.Next(0, kolichKl);
            var row1 = r.Next(0, kolichKl);
            var line1 = block * kolichKl + row1;
            var row2 = r.Next(0, kolichKl);
            while (row1 == row2)
                row2 = r.Next(0, kolichKl);
            var line2 = block * kolichKl + row2;
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                var temp = map[line1, i];
                map[line1, i] = map[line2, i];
                map[line2, i] = temp;
            }
        }

        public void SwapColumnsInBlock() 
        {
            Random r = new Random();
            var block = r.Next(0, kolichKl);
            var row1 = r.Next(0, kolichKl);
            var line1 = block * kolichKl + row1;
            var row2 = r.Next(0, kolichKl);
            while (row1 == row2)
                row2 = r.Next(0, kolichKl);
            var line2 = block * kolichKl + row2;
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                var temp = map[i, line1];
                map[i, line1] = map[i, line2];
                map[i, line2] = temp;
            }
        }


        public void transMatrix()
        {
            int[,] tmap = new int[kolichKl * kolichKl, kolichKl * kolichKl];
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                for (int j = 0; j < kolichKl * kolichKl; j++)
                {
                    tmap[i, j] = map[j, i];
                }
            }
            map = tmap;
        }

        public void createMap()
        {
            for(int i=0;i< kolichKl * kolichKl; i++)
            {
                for(int j=0; j < kolichKl * kolichKl; j++)
                {
                    Button button = new Button();
                    buttons[i,j] = button;
                    button.Size = new Size(sizeButton, sizeButton);
                    button.Click += OnCellPressed;
                    button.Text = map[i, j].ToString();
                    button.Location = new Point(j * sizeButton + xM, i * sizeButton + yM);
                    this.Controls.Add(button);
                    
                }
            }
        }


        public void OnCellPressed(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string buttonText = pressedButton.Text;
            if (string.IsNullOrEmpty(buttonText))
            {
                pressedButton.Text = "1";
            }
            else
            {
                int num = int.Parse(buttonText);
                num++;
                if (num == 10)
                    num = 1;
                pressedButton.Text = num.ToString();
            }

        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restart(object sender, EventArgs e)
        {
            this.Close();
            Sudoku S = new Sudoku();
            S.ShowDialog();

            //for (int i = 0; i < kolichKl * kolichKl; i++)
            //{
            //    for (int j = 0; j < kolichKl * kolichKl; j++)
            //    {
            //        this.Controls.Remove(buttons[i, j]);
            //    }
            //}
            //generateMap();
        }

        private void check(object sender, EventArgs e)
        {
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                for (int j = 0; j < kolichKl * kolichKl; j++)
                {
                    var btnText = buttons[i, j].Text;
                    if (btnText != map[i, j].ToString())
                    {
                        MessageBox.Show("Неверно!");
                        return;
                    }
                }
            }

            MessageBox.Show("Верно!");
            for (int i = 0; i < kolichKl * kolichKl; i++)
            {
                for (int j = 0; j < kolichKl * kolichKl; j++)
                {
                    this.Controls.Remove(buttons[i, j]);
                }
            }
            generateMap();
        }
    }
}
