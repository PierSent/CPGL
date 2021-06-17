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
    public partial class MatchGame : Form
    {
        public MatchGame()
        {
            InitializeComponent();

        }

        public int boxSize = 50;
        int mapSize = 6;
        public void generateBoxes()
        {
            int y;

            int[] array = new int[9]; //массив для определения кода квадрата
            Random rand = new Random();
            for (y = 0; y < 9; y++)
            {
                array[y] = rand.Next(0, 2);
            }

            for (int x = 0; x < mapSize; x++)
                for (y = 0; y < mapSize; y++)
                {
                    if (array[y] == 1)
                    {
                        PictureBox box = new System.Windows.Forms.PictureBox();
                        box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        box.Location = new System.Drawing.Point(x * boxSize + 20, y * boxSize + 20);
                        box.BackColor = Color.Red;
                        box.Name = "pictureBox1";
                        box.Size = new System.Drawing.Size(boxSize, boxSize);
                        box.TabIndex = 3;
                        box.TabStop = false;
                        panel1.Controls.Add(box);
                        box.BringToFront();
                    }

                    else
                    {
                        PictureBox box = new System.Windows.Forms.PictureBox();
                        box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        box.Location = new System.Drawing.Point(x * boxSize + 20, y * boxSize + 20);
                        box.BackColor = Color.Blue;
                        box.Name = "pictureBox1";
                        box.Size = new System.Drawing.Size(boxSize, boxSize);
                        box.TabIndex = 3;
                        box.TabStop = false;
                        panel1.Controls.Add(box);
                        box.BringToFront();
                    }

                }
            ////////////////////////////
            for (y = 0; y < 9; y++)
            {
                array[y] = rand.Next(0, 2);
            }

            for (int x = 0; x < mapSize; x++)
                for (y = 0; y < mapSize; y++)
                {
                    if (array[y] == 1)
                    {
                        PictureBox box = new System.Windows.Forms.PictureBox();
                        box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        box.Location = new System.Drawing.Point(x * boxSize + 410, y * boxSize + 20);
                        box.BackColor = Color.Red;
                        box.Name = "pictureBox1";
                        box.Size = new System.Drawing.Size(boxSize, boxSize);
                        box.TabIndex = 3;
                        box.TabStop = false;
                        panel1.Controls.Add(box);
                        box.BringToFront();
                    }

                    else
                    {
                        PictureBox box = new System.Windows.Forms.PictureBox();
                        box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        box.Location = new System.Drawing.Point(x * boxSize + 410, y * boxSize + 20);
                        box.BackColor = Color.Blue;
                        box.Name = "pictureBox1";
                        box.Size = new System.Drawing.Size(boxSize, boxSize);
                        box.TabIndex = 3;
                        box.TabStop = false;
                        panel1.Controls.Add(box);
                        box.BringToFront();
                    }

                }

            /////////////

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //кнопка чтобы закрыть
        {
            this.Close();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84: ////проверка клиентской области
                    base.WndProc(ref m);            //////////////////////часть кода, чтобы форма перемещалась
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        int count1 = 1;
        int count2 = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = $"{count1++}";
            count1 = count1 + 1 - 1;
            generateBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = $"{count2++}";
            count2 = count2 + 1 - 1;
            generateBoxes();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            generateBoxes();
        }
    }
}
