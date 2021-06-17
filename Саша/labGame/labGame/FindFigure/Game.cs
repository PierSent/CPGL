using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    class Game
    {
        private Game g;
        private Field form;
        private PictureBox[,] figure;
        private TableLayoutPanel table;
        private Label score;
        private Label tr;

        private int tryCount;
        private int length;
        private readonly int figCount = 4;
        private int winPic;

        public Game(Field form, TableLayoutPanel table, int length, Label score, Label tr)
        {
            this.form = form;
            this.table = table;
            this.length = length;
            this.score = score;
            this.tr = tr;

            if (this.length - 4 == 10)
            {
                this.isEnd();
            }

            score.Text = $"Ваш счёт: {length - 4}";

            Random rnd = new Random();
            this.winPic = rnd.Next(0, figCount); // выбор фигуры

            CreateFigures(table);
            ResizeTable(table);
        }

        public Game()
        {
        }

        // растягиваемость таблицы
        private void ResizeTable(TableLayoutPanel taGrid)
        {
            taGrid.ColumnCount = 0;
            taGrid.RowCount = 0;
            taGrid.ColumnCount = length;
            taGrid.RowCount = length;
            taGrid.ColumnStyles.Clear();
            taGrid.RowStyles.Clear();
            for (int i = 0; i < length; i++)
            {
                taGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / length));
            }
            for (int i = 0; i < length; i++)
            {
                taGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / length));
            }
        }

        private void CreateFigures(TableLayoutPanel taGrid)
        {
            Random rnd = new Random();
            int winPositionI = rnd.Next(0, length); // выбор позиции 
            int winPositionJ = rnd.Next(0, length); // выбор позиции 
            figure = new PictureBox[length, length];
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                {
                    figure[i, j] = new PictureBox();
                    if (winPositionI == i &&
                        winPositionJ == j)
                    {
                        figure[i, j].Image = WinFigure(winPic);
                        figure[i, j].Name = "win";
                        figure[i, j].MouseDown += FigWin_MouseDown;
                    }
                    else
                    {
                        figure[i, j].Image = RandomFigure(winPic);
                        figure[i, j].MouseDown += FigLose_MouseDown;

                    }
                    figure[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    figure[i, j].Dock = System.Windows.Forms.DockStyle.Fill;
                    taGrid.Controls.Add(figure[i, j]);
                }
        }

        // при выигрыше
        private void FigWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pic)
            {
                nextGame();
            }
        }

        // при проигрыше
        private void FigLose_MouseDown(object sender, MouseEventArgs e)
        {
            
            tryCount = form.tryCount--;
            if (tryCount < 0)
            {
                this.isEnd();
            }
            tr.Text = $"Кол-во попыток: {tryCount}";
        }


        // расставление фигур по таблице
        private Bitmap RandomFigure(int figNum)
        {
            Random rnd = new Random();
            int randFig = rnd.Next(0, figCount - 1);
            Bitmap ReturnImg = null;

            if (figNum == 0)
            {
                if (randFig == 0)
                {
                    ReturnImg = Properties.Resources.GreenTriangle;
                }
                if (randFig == 1)
                {
                    ReturnImg = Properties.Resources.YellowTriangle;
                }
                if (randFig == 2)
                {
                    ReturnImg = Properties.Resources.GreenSquare;
                }
            }
            else if (figNum == 1)
            {
                if (randFig == 0)
                {
                    ReturnImg = Properties.Resources.GreenTriangle;
                }
                if (randFig == 1)
                {
                    ReturnImg = Properties.Resources.YellowSquare;
                }
                if (randFig == 2)
                {
                    ReturnImg = Properties.Resources.GreenSquare;
                }
            }
            else if (figNum == 2)
            {
                if (randFig == 0)
                {
                    ReturnImg = Properties.Resources.GreenTriangle;
                }
                if (randFig == 1)
                {
                    ReturnImg = Properties.Resources.YellowTriangle;
                }
                if (randFig == 2)
                {
                    ReturnImg = Properties.Resources.YellowSquare;
                }
            }
            else if (figNum == 3)
            {
                if (randFig == 0)
                {
                    ReturnImg = Properties.Resources.YellowSquare;
                }
                if (randFig == 1)
                {
                    ReturnImg = Properties.Resources.YellowTriangle;
                }
                if (randFig == 2)
                {
                    ReturnImg = Properties.Resources.GreenSquare;
                }
            }

            return ReturnImg;
        }

        // выигрышная фигура
        private Bitmap WinFigure(int randPic)
        {
            Bitmap ReturnImg = null;
            if (randPic == 0)
            {
                ReturnImg = Properties.Resources.YellowSquare;
            }
            if (randPic == 1)
            {
                ReturnImg = Properties.Resources.YellowTriangle;
            }
            if (randPic == 2)
            {
                ReturnImg = Properties.Resources.GreenSquare;
            }
            if (randPic == 3)
            {
                ReturnImg = Properties.Resources.GreenTriangle;
            }
            return ReturnImg;
        }

        // очистка выигрышной фигуры
        private void ClearWinName()
        {
            for (int i = 0; i < this.length; i++)
            {
                for (int j = 0; j < this.length; j++)
                {
                    figure[i, j].Name = "";
                }
            }
        }

        // след игра
        private void nextGame()
        {
            ClearWinName();
            table.Controls.Clear();
            length++;
            g = new Game(form, table, length, score, tr);
        }

        // закончена ли игра?
        public void isEnd()
        {
            form.Hide();
            FindFigure F;
            if (length - 4 == 10)
            {
                F = new FindFigure(true, length - 4, 60 - form.gameTime);
            }
            else
            {
                F = new FindFigure(false, length - 4, 60 - form.gameTime);
            }
            F.ShowDialog();
        }

    }
}
