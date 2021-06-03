using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class TicTacToe : Form
    {
        private bool player;
        public TicTacToe()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            player = true;
            laMove.Text = "'Х' Player move";


            button1.Click += Buttons_Click;
            button2.Click += Buttons_Click;
            button3.Click += Buttons_Click;
            button4.Click += Buttons_Click;
            button5.Click += Buttons_Click;
            button6.Click += Buttons_Click;
            button7.Click += Buttons_Click;
            button8.Click += Buttons_Click;
            button9.Click += Buttons_Click;
            buRestart.Click += BuRestart_Click;

        }

        private void BuRestart_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            if (player)
            {
                sender.GetType().GetProperty("Text").SetValue(sender, "x");
                player = false;
                laMove.Text = "'O' Player move";
            }
            else
            if (!player)
            {
                sender.GetType().GetProperty("Text").SetValue(sender, "о");
                player = true;
                laMove.Text = "'Х' Player move";
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }

        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("You won!");
            }
            else 
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show("You won!");
            }
            else
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show("You won!");
            }
            else
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("You won!");
            }
            else
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show("You won!");
            }
            else
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("You won!");
            }
            else
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("You won!");
            }
            else
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("You won!");
            }
        }
    }
}
