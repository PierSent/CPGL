using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace labGame
{
    class Obstruction
    {
        public int x, y;
        public Image ObstructionBitmap;
        public int sizeX, sizeY;

        //первоначальное положение препятствий на поле
        public Obstruction(int x, int y, bool isRotatedImage = false)
        {
            ObstructionBitmap = Properties.Resources.Obstruction;
            this.x = x;
            this.y = y;
            sizeX = 100;
            sizeY = 250;
            if (isRotatedImage)
                ObstructionBitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}
