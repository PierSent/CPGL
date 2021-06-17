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
using System.Media;
using System.IO;

namespace labGame
{
    public partial class Menu : Form
    {
        private Users users;
        private int userId;
        private SoundPlayer soundPlayer;
        static public bool isMuscPlaying = true;
        static public bool isThemeDark = false;
        static public Color Light = Color.FromArgb(153, 255, 204); // #99ffcc
        static public Color Dark = Color.FromArgb(0, 102, 102); // #006666

        public Menu(int userId, Users users)
        {
            InitializeComponent();

            if (isMuscPlaying)
            {
                soundPlayer = new SoundPlayer(Path.GetFullPath(@$"..\..\..\Resources\msc.wav"));
                soundPlayer.PlayLooping();
            }

            this.Activated += Menu_Activated;

            this.users = users;
            this.userId = userId;

            // кнопки 
            buTicTacToe.Click += BuTicTacToe_Click;
            buFindFigure.Click += BuFindFigure_Click;
            bu15.Click += Bu15_Click;
            buRacing.Click += BuRacing_Click;
            buSettings.Click += BuSettings_Click;
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            // проверка на тему
            makeDark(Menu.isThemeDark);
        
        }

        // кнопка настроек 
        private void BuSettings_Click(object sender, EventArgs e)
        {
            SettingsForm S = new SettingsForm(userId, users, soundPlayer);
            S.ShowDialog();
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

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        private void makeDark(bool isDark)
        {
            if (isDark == true)
            {
                this.BackColor = Menu.Dark;
                label1.ForeColor = Menu.Light;
                buSettings.ForeColor = Menu.Light;

                buRacing.BackColor = Menu.Dark;
                buTicTacToe.BackColor = Menu.Dark;
                buFindFigure.BackColor = Menu.Dark;
                bu15.BackColor = Menu.Dark;

                buRacing.ForeColor = Menu.Light;
                buTicTacToe.ForeColor = Menu.Light;
                buFindFigure.ForeColor = Menu.Light;
                bu15.ForeColor = Menu.Light;
            }
            else
            {
                this.BackColor = Menu.Light;
                label1.ForeColor = Menu.Dark;
                buSettings.ForeColor = Menu.Dark;

                buRacing.BackColor = Menu.Light;
                buTicTacToe.BackColor = Menu.Light;
                buFindFigure.BackColor = Menu.Light;
                bu15.BackColor = Menu.Light;

                buRacing.ForeColor = Menu.Dark;
                buTicTacToe.ForeColor = Menu.Dark;
                buFindFigure.ForeColor = Menu.Dark;
                bu15.ForeColor = Menu.Dark;
            }
        }
    }
}
