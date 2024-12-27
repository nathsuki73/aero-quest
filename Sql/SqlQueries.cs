using aero_quest.Objects;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace aero_quest.Sql
{
    internal class SqlQueries
    {

        public static string connStr { get; private set; }

        static SqlQueries()
        {
            connStr = "server=localhost;user id=root;password=;database=aero_quest;";
        }

        public static bool AddNewUser(User user)
        {
            string query = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password);  SELECT LAST_INSERT_ID();";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Name);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@password", user.Password);

                        object result = cmd.ExecuteScalar();
                        int newUserId = Convert.ToInt32(result);

                        CreateProfile(newUserId);

                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }

            }


            return true;
        }

        private static void CreateProfile(int userId)
        {
            string query = "INSERT INTO profiles (userId, name, birth, age, gender, email, phone, profile) VALUES (@userId, @name, @birth, @age, @gender, @email, @phone, @profile)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@name", null);
                        cmd.Parameters.AddWithValue("@birth", new DateTime(1753, 1, 1));
                        cmd.Parameters.AddWithValue("@age", null);
                        cmd.Parameters.AddWithValue("@gender", null);
                        cmd.Parameters.AddWithValue("@email", null);
                        cmd.Parameters.AddWithValue("@phone", null);
                        cmd.Parameters.AddWithValue("@profile", null);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        public static Profile GetProfile(int? userId)
        {
            string query = "SELECT id, name, birth, age, gender, email, phone, profile FROM profiles WHERE userId = @userId";
            Profile profile = null;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                
                
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                profile = new Profile
                                {
                                    Id = reader.GetInt32("id"),
                                    Name = reader["name"] != DBNull.Value ? reader["name"].ToString() : null,
                                    Birth = reader["birth"] != DBNull.Value ? Convert.ToDateTime(reader["birth"]) : new DateTime(1753, 1, 1),
                                    Age = reader["age"] != DBNull.Value ? Convert.ToInt32(reader["age"]) : 0,
                                    Gender = reader["gender"] != DBNull.Value ? reader["gender"].ToString() : null,
                                    Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : null,
                                    Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : null,
                                    ProfileImage = reader["profile"] != DBNull.Value ? (byte[])reader["profile"] : null

                                };
                            }
                        }
                    }
                
            }

            return profile;
        }

        public static bool UpdateProfile(Profile profile)
        {
            string query = @"
        UPDATE profiles 
        SET 
            name = @name, 
            birth = @birth, 
            age = @age, 
            gender = @gender, 
            email = @email, 
            phone = @phone, 
            profile = @profile 
        WHERE id = @id";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", profile.Id);
                        cmd.Parameters.AddWithValue("@name", profile.Name ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@birth", profile.Birth != DateTime.MinValue ? profile.Birth : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@age", profile.Age != 0 ? profile.Age : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@gender", profile.Gender ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", profile.Email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone", profile.Phone ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@profile", profile.ProfileImage ?? (object)DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if at least one row is updated
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }



        public static int? VerifyUser(User user)
        {
            string query = "SELECT id FROM users WHERE email = @email AND password = @password";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@password", user.Password);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result); // Return user ID if found
                        }
                        else
                        {
                            return null; // No user found
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }



    }
}
