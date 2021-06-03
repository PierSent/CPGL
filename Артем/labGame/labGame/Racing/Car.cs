using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Racing
{
    class Car
    {
        public int X;
        public int Y;
        static public int Width;
        static public int Height;

        public Image carImg;

        public Car(int x, int y, Image carImg)
        {
            this.carImg = carImg;
            X = x;
            Y = y;
            Height = 101;
            Width = 59;
        }
    }
}
