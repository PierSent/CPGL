using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ticTacToe;
using lab15;
using Racing;


namespace labGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            buTicTacToe.Click += BuTicTacToe_Click;
            buFindFigure.Click += BuFindFigure_Click;
            bu15.Click += Bu15_Click;
            buRacing.Click += BuRacing_Click;
        }

        private void BuRacing_Click(object sender, EventArgs e)
        {
            object[,] cars = new object[3, 4]
            {   {"classic", true, true, 0},
                {"green", false, false, 50},
                {"neon", false, false, 100}   };
            // 0 - id машины, 1 - выбрана или нет, 2 - куплена или нет, 3 - цена
            RacingMenu R = new RacingMenu(0, 1000, cars);
            // 0 - рекорд по расстоянию, 1000 - кол-во денег, cars - массив машин
            R.ShowDialog();
        }

        private void Bu15_Click(object sender, EventArgs e)
        {
            Game15 G = new Game15();
            G.ShowDialog();
        }

        private void BuFindFigure_Click(object sender, EventArgs e)
        {
            FindFigure F = new FindFigure(true, -1, -1);
            // true - выиграна ли игра, -1 - счет, -1 - время
            F.ShowDialog();
        }

        private void BuTicTacToe_Click(object sender, EventArgs e)
        {
            TicTacToe T = new TicTacToe();
            T.ShowDialog();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            StartVirus SV = new StartVirus();
            SV.ShowDialog();
        }

        private void finish_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SudokuGame(object sender, EventArgs e)
        {
            Sudoku S = new Sudoku();
            S.ShowDialog();
        }

        /////////////////////////////////////////////////////////////////////////////// by Petrenko
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84: ////проверка клиентской области
                    base.WndProc(ref m);            //////////////////////часть кода, чтобы форма перемещалась при хватании окна
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        ////////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)
        {
            MatchGame SV = new MatchGame();
            SV.ShowDialog();
        }//открытие формы с игрой "угадай фигуры"
        
    }
}
