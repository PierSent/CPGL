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


            if (users.LoginUser(username, password) == true)
            {

                this.Hide();
                Menu M = new Menu();
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

    }
}
