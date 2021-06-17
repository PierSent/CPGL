using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab15
{
    internal class Game
    {
        private Button[,] bu;
        private int lvl;
        private int moveCounter = 0;


        private int holeI;
        private int holeJ;
        private int lenght;
        private Field field;


        public Game(Field _field, TableLayoutPanel taGrid , int _lenght, int _lvl)
        {
            this.field = _field;
            this.lenght = _lenght;
            this.lvl = _lvl;
            ResizeTable(taGrid);
            CreateButtons(taGrid);
            MixButtons();
            
        }


        //  конец игры 
        private void isEnd()
        {
            int right = 0;
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    if (bu[i, j].Text == $"{1 + j + i * lenght}")
                    {
                        right++;
                    }
                }
            if (right == lenght*lenght - 1)
            {
                field.Close();
                MessageBox.Show($"Ты выиграл!\nВсего за {moveCounter} шагов") ;
            }
        }

        // растягивание таблицы
        private void ResizeTable(TableLayoutPanel taGrid)
        {
            taGrid.ColumnCount = 0;
            taGrid.RowCount = 0;
            taGrid.ColumnCount = lenght;
            taGrid.RowCount = lenght;
            taGrid.ColumnStyles.Clear();
            taGrid.RowStyles.Clear();
            for (int i = 0; i < lenght; i++)
            {
                taGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / lenght));
            }
            for (int i = 0; i < lenght; i++)
            {
                taGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / lenght));
            }

        }

        // создание кнопок
        private void CreateButtons(TableLayoutPanel taGrid)
        {
            bu = new Button[lenght, lenght];
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    bu[i, j] = new Button();
                    if ((i+1)*(j+1) == lenght * lenght)
                    {
                        bu[i, j].Text = "";
                    }
                    else
                    {
                        bu[i, j].Text = $"{1 + j + i * lenght}";
                    }
                    // описание стилей кнопок
                    bu[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    bu[i, j].Font = new Font("Segoe UI Light", 30);
                    bu[i, j].ForeColor = Color.Purple;
                    bu[i, j].FlatStyle = FlatStyle.Flat;
                    bu[i, j].Dock = System.Windows.Forms.DockStyle.Fill;
                    bu[i, j].Click += Button_Click;
                    bu[i, j].KeyDown += G_KeyDown;
                    taGrid.Controls.Add(bu[i, j]);
                }
        }


        //  обработка клавиш
        private void G_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:  //  вверх
                    holeI = FindHoleI();
                    holeJ = FindHoleJ();


                    if (e.Shift)
                    {
                        if (holeI != lenght - 1)
                        {
                            while (holeI != lenght - 1)
                            {
                                ReplaceDown(holeI, holeJ);
                                holeI = FindHoleI();
                            }
                        }
                    }
                    else if (holeI != lenght - 1)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    break;
                case Keys.S: // вниз 
                    holeI = FindHoleI();
                    holeJ = FindHoleJ();


                    if (e.Shift)
                    {
                        if (holeI != 0)
                        {
                            while (holeI != 0)
                            {
                                ReplaceUp(holeI, holeJ);
                                holeI = FindHoleI();
                            }
                        }
                    }
                    else if (holeI != 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    break;
                case Keys.D: //  вправо
                    holeI = FindHoleI();
                    holeJ = FindHoleJ();


                    if (e.Shift)
                    {
                        if (holeJ != 0)
                        {
                            while (holeJ != 0)
                            {
                                ReplaceLeft(holeI, holeJ);
                                holeJ = FindHoleJ();
                            }
                        }
                    }
                    else if (holeJ != 0)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                    break;
                case Keys.A: //  влево
                    holeI = FindHoleI();
                    holeJ = FindHoleJ();


                    if (e.Shift)
                    {
                        if (holeJ != lenght - 1)
                        {
                            while (holeJ != lenght - 1)
                            {
                                ReplaceRight(holeI, holeJ);
                                holeJ = FindHoleJ();
                            }
                        }
                    }
                    else if (holeJ != lenght - 1)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                    break;
                default:
                    break;
            }
            
            
            field.Text = $"Кол-во шагов: {moveCounter}";
            isEnd();
        }


        //  обработка мыши 
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Control x)
            {
                holeI = FindHoleI();
                holeJ = FindHoleJ();


                if (holeI != lenght - 1)
                {
                    for (int i = 0; i < lenght; i++)
                    {
                        if (x.Text == bu[i, holeJ].Text)
                        {
                            if (i > holeI)
                            {
                                int count = i - holeI;
                                for (int n = 0; n < count; n++)
                                {
                                    ReplaceDown(holeI, holeJ);
                                    holeI = FindHoleI();
                                    holeJ = FindHoleJ();
                                }
                            }
                        }
                    }
                }
                if (holeI != 0)
                {
                    for (int i = 0; i < lenght; i++)
                    {
                        if (x.Text == bu[i, holeJ].Text)
                        {
                            if (i < holeI)
                            {
                                int count = holeI - i;
                                for (int n = 0; n < count; n++)
                                {
                                    ReplaceUp(holeI, holeJ);
                                    holeI = FindHoleI();
                                    holeJ = FindHoleJ();
                                }
                            }
                        }
                    }
                }
                if (holeJ != lenght - 1)
                {
                    for (int j = 0; j < lenght; j++)
                    {
                        if (x.Text == bu[holeI, j].Text)
                        {
                            if (j > holeJ)
                            {
                                int count = j - holeJ;
                                for (int n = 0; n < count; n++)
                                {
                                    ReplaceRight(holeI, holeJ);
                                    holeI = FindHoleI();
                                    holeJ = FindHoleJ();
                                }
                            }
                        }
                    }
                }
                if (holeJ != 0)
                {
                    for (int j = 0; j < lenght; j++)
                    {
                        if (x.Text == bu[holeI, j].Text)
                        {
                            if (j < holeJ)
                            {
                                int count = holeJ - j;
                                for (int n = 0; n < count; n++)
                                {
                                    ReplaceLeft(holeI, holeJ);
                                    holeI = FindHoleI();
                                    holeJ = FindHoleJ();
                                }
                            }
                        }
                    }
                }


                field.Text = $"Кол-во шагов: {moveCounter}";
                isEnd();
            }
        }
        

        //  перемешивание 
        private void MixButtons()
        {
            for (int n = 0; n < lvl; n++)
            {
                Random rnd = new Random();
                holeI = FindHoleI();
                holeJ = FindHoleJ();

                //  исключаем углы
                if (holeI == 0 && holeJ == 0)
                {
                    int rand = rnd.Next(2);
                    if (rand == 0)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                }
                else if (holeI == 0 && holeJ == lenght - 1)
                {
                    int rand = rnd.Next(2);
                    if (rand == 0)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                }
                else if (holeI == lenght - 1 && holeJ == 0)
                {
                    int rand = rnd.Next(2);
                    if (rand == 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                }
                else if (holeI == lenght - 1 && holeJ == lenght - 1)
                {
                    int rand = rnd.Next(2);
                    if (rand == 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                }
                
                //  исключаем стороны
                else if (holeI == 0)
                {
                    int rand = rnd.Next(3);
                    if (rand == 0)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                    else if (rand == 2)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                }
                else if (holeI == lenght - 1)
                {
                    int rand = rnd.Next(3);
                    if (rand == 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                    else if (rand == 2)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                }
                else if (holeJ == 0)
                {
                    int rand = rnd.Next(3);
                    if (rand == 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    else if (rand == 2)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                }
                else if (holeJ == lenght -1)
                {
                    int rand = rnd.Next(3);
                    if (rand == 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    else if (rand == 2)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                }
               
                //  остальное 
                else
                {
                    int rand = rnd.Next(4);
                    if (rand == 0)
                    {
                        ReplaceUp(holeI, holeJ);
                    }
                    else if (rand == 1)
                    {
                        ReplaceDown(holeI, holeJ);
                    }
                    else if (rand == 2)
                    {
                        ReplaceLeft(holeI, holeJ);
                    }
                    else if (rand == 3)
                    {
                        ReplaceRight(holeI, holeJ);
                    }
                }
            }

            moveCounter -= lvl;
        }
        

        //  перемещения плитки
        private void ReplaceLeft(int i, int j)
        {
            string text1 = bu[i, j].Text;
            string text2 = bu[i, j - 1].Text;
            bu[i, j].Text = text2;
            bu[i, j - 1].Text = text1;

            moveCounter++;
        }
        private void ReplaceRight(int i, int j)
        {
            string text1 = bu[i, j].Text;
            string text2 = bu[i, j + 1].Text;
            bu[i, j].Text = text2;
            bu[i, j + 1].Text = text1;

            moveCounter++;
        }
        private void ReplaceUp(int i, int j)
        {
            string text1 = bu[i, j].Text;
            string text2 = bu[i - 1, j].Text;
            bu[i, j].Text = text2;
            bu[i - 1, j].Text = text1;

            moveCounter++;
        }
        private void ReplaceDown(int i, int j)
        {
            string text1 = bu[i, j].Text;
            string text2 = bu[i + 1, j].Text;
            bu[i, j].Text = text2;
            bu[i + 1, j].Text = text1;

            moveCounter++;
        }


        //  найти координаты дырки
        private int FindHoleI()
        {
            int result = 0;
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    if (bu[i, j].Text == "")
                    {
                        result = i;
                    }
                }
            return result;
        }
        private int FindHoleJ()
        {
            int result = 0;
            for (int i = 0; i < lenght; i++)
                for (int j = 0; j < lenght; j++)
                {
                    if (bu[i, j].Text == "")
                    {
                        result = j;
                    }
                }
            return result;
        }
    }
}