using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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
