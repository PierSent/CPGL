using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    public partial class RegForm : Form
    {
        private string username;
        private string password;
        private Users users;
        public RegForm(Users users)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            // проверка на тему
            makeDark(Menu.isThemeDark);
      

            this.users = users;

            buReg.Click += BuReg_Click;
        }

        private void BuReg_Click(object sender, EventArgs e)
        {
            if (teUser.Text != null || tePass.Text != null || teConPass.Text != null)
            {
                if (tePass.Text == teConPass.Text)
                {
                    username = teUser.Text;
                    password = tePass.Text;
                    users.AddUser(username, password);
                

                    this.Hide();
                    RegForm M = new RegForm(users);
                    M.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Fill all the fields");
            }
        }

        private void makeDark(bool isDark)
        {
            if (isDark == true)
            {
                this.BackColor = Menu.Dark;
                teUser.ForeColor = Menu.Light;
                tePass.ForeColor = Menu.Light;
                teConPass.ForeColor = Menu.Light;

                laConPass.ForeColor = Menu.Light;
                laPass.ForeColor = Menu.Light;
                laUser.ForeColor = Menu.Light;
                buReg.ForeColor = Menu.Light;

                teConPass.BackColor = Menu.Dark;
                tePass.BackColor = Menu.Dark;
                teUser.BackColor = Menu.Dark;
                buReg.BackColor = Menu.Dark;

            }
            else
            {
                this.BackColor = Menu.Light;
                teUser.ForeColor = Menu.Dark;
                tePass.ForeColor = Menu.Dark;
                teConPass.ForeColor = Menu.Dark;

                laConPass.ForeColor = Menu.Dark;
                laPass.ForeColor = Menu.Dark;
                laUser.ForeColor = Menu.Dark;
                buReg.ForeColor = Menu.Dark;

                teConPass.BackColor = Menu.Light;
                tePass.BackColor = Menu.Light;
                teUser.BackColor = Menu.Light;
                buReg.BackColor = Menu.Light;
            }
        }
    }
}
