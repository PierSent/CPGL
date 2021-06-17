using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Racing
{
    class Rock
    {
        public int X;
        public int Y;
        static public int Width;
        static public int Height;

        static public Image rockImg;

        public Rock(int x, int y)
        {
            rockImg = labGame.Properties.Resources.rock;


            Y = y;
            X = x;
            Height = 50;
            Width = 42;
        }
    }
}
