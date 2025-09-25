using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaPalace.classes
{
    class User
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Username;
        public string Password;
        public bool IsAdmin;
        public string Role;

        public override string ToString()
        {
            return $"{FirstName} {LastName} ------- {Username} - {Role}";
        }

        public static List<User> GetAll()
        {
            List<User> users = new List<User>();

            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users;", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = Convert.ToInt32(reader["user_id"]),
                    FirstName = Convert.ToString(reader["user_firstname"]),
                    LastName = Convert.ToString(reader["user_lastname"]),
                    Email = Convert.ToString(reader["user_email"]),
                    Username = Convert.ToString(reader["user_username"]),
                    Password = Convert.ToString(reader["user_password"]),
                    IsAdmin = Convert.ToBoolean(reader["user_admin"]),
                    Role = Convert.ToString(reader["user_role"])
                };
                users.Add(user);
            }

            con.Close();
            return users;
        }

        public static User GetLoginUser(string username, string password)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Users WHERE user_username = @username AND user_password = @password;", con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();
            User user = null;

            if (reader.Read())
            {
                user = new User
                {
                    Id = Convert.ToInt32(reader["user_id"]),
                    FirstName = Convert.ToString(reader["user_firstname"]),
                    LastName = Convert.ToString(reader["user_lastname"]),
                    Email = Convert.ToString(reader["user_email"]),
                    Username = Convert.ToString(reader["user_username"]),
                    Password = Convert.ToString(reader["user_password"]),
                    IsAdmin = Convert.ToBoolean(reader["user_admin"]),
                    Role = Convert.ToString(reader["user_role"])
                };
            }

            con.Close();
            return user;
        }

        public static int AddToDatabase(User user)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(@"
                INSERT INTO Users 
                (user_firstname, user_lastname, user_email, user_username, user_password, user_admin, user_role)
                VALUES (@firstName, @lastName, @email, @username, @password, @isAdmin, @role);", con);

            cmd.Parameters.AddWithValue("@firstName", user.FirstName);
            cmd.Parameters.AddWithValue("@lastName", user.LastName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
            cmd.Parameters.AddWithValue("@role", user.Role);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int UpdateDatabase(User user)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(@"
                UPDATE Users SET
                    user_firstname = @firstName,
                    user_lastname = @lastName,
                    user_email = @email,
                    user_username = @username,
                    user_password = @password,
                    user_admin = @isAdmin,
                    user_role = @role
                WHERE user_id = @id;", con);

            cmd.Parameters.AddWithValue("@firstName", user.FirstName);
            cmd.Parameters.AddWithValue("@lastName", user.LastName);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@isAdmin", user.IsAdmin);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@id", user.Id);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int DeleteFromDatabase(User user)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM Users WHERE user_id = @id;", con);
            cmd.Parameters.AddWithValue("@id", user.Id);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }


    }
}
