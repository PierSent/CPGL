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
    }
}
