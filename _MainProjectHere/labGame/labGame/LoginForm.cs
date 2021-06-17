using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labGame
{
    public partial class LoginForm : Form
    {
        private string username;
        private string password;
        private Users users;
        public LoginForm(Users users)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            // проверка на тему
            makeDark(Menu.isThemeDark);
  

            this.users = users;

            // функции для кнопок
            buReg.Click += BuReg_Click;
            buLogin.Click += BuLogin_Click;
        }

        // кнопка авторизации
        private void BuLogin_Click(object sender, EventArgs e)
        {
            username = teUser.Text;
            password = tePass.Text;

            int userId = users.LoginUser(username, password);
            if (userId >= 0)
            {

                this.Hide();
                Menu M = new Menu(userId, users);
                M.ShowDialog();
            }
            else
            {
                MessageBox.Show($"{users.LoginUser(username, password)}");
            }
            
        }

        // кнопка открытия окна регистрации
        private void BuReg_Click(object sender, EventArgs e)
        {
            RegForm R = new RegForm(users);
            R.ShowDialog();
        }


        private void makeDark(bool isDark)
        {
            if (isDark == true)
            {
                this.BackColor = Menu.Dark;
                teUser.ForeColor = Menu.Light;
                tePass.ForeColor = Menu.Light;

                laPass.ForeColor = Menu.Light;
                laUser.ForeColor = Menu.Light;
                buReg.ForeColor = Menu.Light;
                buLogin.ForeColor = Menu.Light;

                tePass.BackColor = Menu.Dark;
                teUser.BackColor = Menu.Dark;
                buReg.BackColor = Menu.Dark;
                buLogin.BackColor = Menu.Dark;

            }
            else
            {
                this.BackColor = Menu.Light;
                teUser.ForeColor = Menu.Dark;
                tePass.ForeColor = Menu.Dark;

                laPass.ForeColor = Menu.Dark;
                laUser.ForeColor = Menu.Dark;
                buReg.ForeColor = Menu.Dark;
                buLogin.ForeColor = Menu.Dark;

                tePass.BackColor = Menu.Light;
                teUser.BackColor = Menu.Light;
                buReg.BackColor = Menu.Light;
                buLogin.BackColor = Menu.Light;
            }
        }
    }
}
