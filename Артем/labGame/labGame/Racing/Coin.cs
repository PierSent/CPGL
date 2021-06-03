using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Racing
{
    class Coin
    {
        public int X;
        public int Y;
        static public int Width;
        static public int Height;

        static public Image rockImg;

        public Coin(int x, int y)
        {
            // rockImg = labGame.Properties.Resources.coin;
            rockImg = labGame.Properties.Resources.virus;
            // ---------------- это удалить


            Y = y;
            X = x;
            Height = 31;
            Width = 21;
        }
    }
}
