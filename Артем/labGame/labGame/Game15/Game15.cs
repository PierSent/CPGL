using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab15
{
    public partial class Game15 : Form
    {
        private int lvl;
        private int lenght;
        private Field field;


        public Game15()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            buStart.Click += BuStart_Click;
        }

        private void BuStart_Click(object sender, EventArgs e)
        {
            if ((isInt(teLvl.Text)) && (isInt(teLenght.Text)))
            {
                lvl = Convert.ToInt32(teLvl.Text);
                lenght = Convert.ToInt32(teLenght.Text);
                if (lvl < 1)
                {
                    MessageBox.Show("Уровень сложности должен быть больше 0");
                }
                else if (lenght < 2)
                {
                    MessageBox.Show("Сторона квадрата должна быть больше 1");
                }
                else if (lenght > 9)
                {
                    MessageBox.Show("Куда тебе столько?\nСторона квадрата должна быть меньше 10");
                }
                else
                {
                    createField(lenght, lvl);
                    if (lenght > 4)
                    {
                        field.Height = 772;
                        field.Width = 764;
                    }
                    field.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Если что сторона и уровень - это целые числа)");
            }
        }

        private void createField(int lenght, int lvl)
        {
            field = new Field(lenght, lvl);
        }

        public static bool isInt(string input)
        {
            if (String.IsNullOrEmpty(input))
                return false;
            else
            {
                int i;
                if (Int32.TryParse(input, out i))
                    return true;
                else
                    return false;
            }
        }
    }
}
