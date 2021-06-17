using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(@"..\..\..\UsersDB.mdf")};Integrated Security=True";

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

        // добавление новой аватарки     ---------------- доделать
        public void UpdateAva(int userId, string ava)
        {
            SqlCommand command = new SqlCommand($"UPDATE [Users] SET Ava = @ava WHERE Id = @userId", sqlConnection);
            //SqlCommand command = new SqlCommand($"UPDATE [Users] SET Ava = {ava} WHERE UserId = {userId}", sqlConnection);

            command.Parameters.AddWithValue("userId", userId);
            command.Parameters.AddWithValue("ava", ava);

            command.ExecuteNonQuery();
        }

        // проверка есть ли пользователь в бд
        public int LoginUser(string username, string password)
        {
            int can = -1;
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
                        can = (int)sqlReader["Id"];
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

        // возвращает название аватарки
        public string getAva(int userId)
        {
            string ava = null;
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Users]", sqlConnection);

            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (Convert.ToInt32(sqlReader["Id"]) == userId )
                    {
                        if (sqlReader["Ava"] == null)
                        {
                            ava = null;
                        }
                        else
                        {
                            ava = Convert.ToString(sqlReader["Ava"]).Trim();
                        }
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
            return ava;
        }

        // возвращает никнейм
        public string getUsername(int userId)
        {
            string username = null;
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Users]", sqlConnection);

            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    if (Convert.ToInt32(sqlReader["Id"]) == userId)
                    {
                        username = Convert.ToString(sqlReader["Username"]).Trim();
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
            return username;
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
