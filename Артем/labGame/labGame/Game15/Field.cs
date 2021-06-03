using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab15
{
    public partial class Field : Form
    {
        private Game g;

        public Field(int _lenght, int _lvl)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            int length = _lenght;
            int lvl = _lvl;
            g = new Game(this, taGrid ,length, lvl);
        }
    }
}