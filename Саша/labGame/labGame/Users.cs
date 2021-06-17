using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace labGame
{
    public class Users
    {
        SqlConnection sqlConnection;

        public Users()
        {
            TakeConnection();
        }
        // строка подключения
        private async void TakeConnection()
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanya\Desktop\CPGL-main\CPGL-main\Саша\labGame\labGame\UsersDB.mdf;Integrated Security=True";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Sasha\Documents\Studying\программная Инженерия\CPGL\Саша\labGame\labGame\UsersDB.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        // добавление пользователя в бд
        public void AddUser(string username, string password)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Users] (username, password)VALUES(@username, @password)", sqlConnection);
            
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);

            command.ExecuteNonQuery();
        }

        // проверка есть ли пользователь в бд
        public bool LoginUser(string username, string password)
        {
            bool can = false;
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Users]", sqlConnection);

            try
            {
                sqlReader = command.ExecuteReader();

                while ( sqlReader.Read())
                {
                    if (Convert.ToString( sqlReader["Username"] ).Trim() == username &&
                        Convert.ToString( sqlReader["Password"] ).Trim() == password)
                    {
                        can = true;
                    }
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
            return can;
        }

        //  потом добавить при закрытии меню
        public void CloseConnection()
        {
            if (sqlConnection != null && sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }
    }
}
