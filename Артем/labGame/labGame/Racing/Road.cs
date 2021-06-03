using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Racing
{
    class Road
    {
        public int X;
        public int Y;
        static public int Width;
        static public int Height;

        static public Image roadImg;

        public Road(int x, int y) //, int height
        {
            // roadImg = labGame.Properties.Resources.road;
            roadImg = labGame.Properties.Resources.fon1;
            // ---------------- это удалить

            Y = y;
            X = x;
            Height = roadImg.Height;
            Width = roadImg.Width;
        }
    }
}
