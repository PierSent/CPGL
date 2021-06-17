using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Racing
{
    public class Road
    {
        public int X;
        public int Y;
        static public int Width;
        public int Height;

        public Image roadImg;

        public Road(int x, int y) //, int height
        {
            roadImg = labGame.Properties.Resources.road;
           

            Y = y;
            X = x;
            Height = roadImg.Height;
            Width = roadImg.Width;
        }
    }
}
