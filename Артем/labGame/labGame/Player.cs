using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace labGame
{
    class Player
    {
        public float x, y;
        public Image VirusBitmap;
        public int size;
        public float gravityValue;
        public bool isLife;
        public int ochki;


        public Player(int x, int y)
        {
            VirusBitmap = Properties.Resources.virus;
            this.x = x;
            this.y = y;
            size = 50;
            gravityValue = 0.1f;
            isLife = true;
            ochki = 0;
        }
    }
}
