using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    //доделать кнопку restart - РАБОТАЕТ
    //сделать секундомер - РАБОТАЕТ
    //попробовать вывести результат: очки + время
    //две трубы + больше + расстояние
    //проигрыш по центру - РАБОТАЕТ
    //выбор кем играть и какие условия(режим настройки)

    public partial class VirusGame : Form
    {
        Player Virus;
        Obstruction Obs1, Obs2;
        float gravity; //изменение позиции
        float g = -0.120f;
        float gV = 0.1f;
        float vGV = 0.005f;
        int xP = 100;
        int yP = 200;
        int minY = 500;
        int constX = 550;
        int minY1 = -120;
        int maxY1 = -10;
        int minY2 = 380;
        int maxY2 = 480;


        public VirusGame()
        {
            InitializeComponent();
            Init();
            Invalidate();//вызов отрисовки

        }


        public void Init()
        { //рандомное появление игрока и препятствий на поле 
            Virus = new Player(xP, yP);
            Random r = new Random();
            Random k = new Random();
            int y1 = r.Next(minY1, maxY1);
            int y2 = k.Next(minY2, maxY2);
            Obs1 = new Obstruction(constX, y1, true);
            Obs2 = new Obstruction(constX, y1 + y2);
            this.label1.Text = "Score: 0";
            timer1.Interval = 4;
            timer1.Tick += new EventHandler(update);
            timer1.Start();

        }



        private void update(object sender, EventArgs e)
        {    //граничные условия для проигрыша
            if (Virus.y > minY) { 
                Virus.isLife = false;
                label3.Visible = true;
                this.label3.Text = "You lose";
                timer2.Stop();
            }

            if (controlObs(Virus, Obs1) || controlObs(Virus, Obs2))
            {
                Virus.isLife = false;
                label3.Visible = true;
                this.label3.Text = "You lose";
                timer2.Stop();
            }
            //константы
            if (Virus.gravityValue != gV)
                Virus.gravityValue += vGV;//возвращаем
            gravity += Virus.gravityValue;
            Virus.y += gravity;

            if (Virus.isLife)
            {
                MoveObstruction();
            }
            label2.Text = "Time: " + i + "s.";
            Invalidate();//вызов полета

        }

        private void MoveObstruction()
        {
            Obs1.x -= 2;
            Obs2.x -= 2;
            newObs();
        }

        private void newObs()
        {
          //рассчёт, если пролетает препятствие, то + очко
            if (Obs1.x < Virus.x - yP)
            {
                Random r = new Random();
                Random k = new Random();
                int y1 = r.Next(minY1, maxY1);
                int y2 = k.Next(minY2, maxY2);
                Obs1 = new Obstruction(constX, y1, true);
                Obs2 = new Obstruction(constX, y1 + y2);
                Virus.ochki++;
                this.label1.Text = "Score: " + Virus.ochki;
            }
        }

        private bool controlObs(Player Virus, Obstruction Obs1)
        {
        //контроль соприкосновения игрока с препятствием
            PointF delta = new PointF();
            delta.X = (Virus.x + Virus.size / 2) - (Obs1.x + Obs1.sizeX / 2);
            delta.Y = (Virus.y + Virus.size / 2) - (Obs1.y + Obs1.sizeY / 2);
            if (Math.Abs(delta.X) <= Virus.size / 2 + Obs1.sizeX / 2)
            {
                if (Math.Abs(delta.Y) <= Virus.size / 2 + Obs1.sizeY / 2)
                {
                    //MessageBox.Show("You Losser");
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Virus.isLife) {
                gravity = 0;
                Virus.gravityValue = g;
            }
        }

        //кнопка закрытия игры
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //кнопка "начать заново"
        private void restart(object sender, EventArgs e)
        {
            this.Close();
            VirusGame VG = new VirusGame();
            VG.ShowDialog();
        }
        
        
        //таймер игры
        int i = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
        }

        private void OnPaint(object sender, PaintEventArgs e)//отрисовка
        {
            Graphics graphics = e.Graphics;
            graphics.DrawImage(Virus.VirusBitmap, Virus.x, Virus.y, Virus.size, Virus.size);

            //Obs1.ObstructionBitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
            graphics.DrawImage(Obs1.ObstructionBitmap, Obs1.x, Obs1.y, Obs1.sizeX, Obs1.sizeY);

            // Obs2.ObstructionBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            graphics.DrawImage(Obs2.ObstructionBitmap, Obs2.x, Obs2.y, Obs2.sizeX, Obs2.sizeY);
        }


    }
}
