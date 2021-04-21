using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPetrenko
{
    internal class GameLogic
    {
        public int CounterCorrect { get; private set; }
        public int CountWrong { get; private set; }
        public string CodeText { get; private set; }

        private bool AnswerCorrect;

        public void DoReset()
        {
            CounterCorrect = 0;
            CountWrong = 0;
            //DoContinue();
        }

        private void DoContinue()//массив для определения кода квадратов
        {
            int[] array = new int[9];
            Random rand = new Random();
            for (int y = 0; y < 9; y++)
            {
                array[y] = rand.Next(0, 2);
            }

            
        }

    }
}
