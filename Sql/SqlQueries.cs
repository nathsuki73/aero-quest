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
            string query = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)";

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

                        cmd.ExecuteNonQuery();
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
    }
}
