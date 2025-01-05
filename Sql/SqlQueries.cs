using aero_quest.Objects;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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


        // Adding New User
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


        // Creating new profile
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


        // Getting Profile of logged in user
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

        // Updating Profile
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


        // Verifying User
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



        // Adding Booking Schedule
        public static bool AddBookingSchedule(List<string> schedule, string bookingReference, string seatId)
        {

            try
            {
                // Convert the List<string> into a byte array (BLOB)
                byte[] scheduleBytes = ConvertScheduleToBytes(schedule);

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"INSERT INTO schedules (userId, schedule, status, reference, seatId) 
                             VALUES (@userId, @schedule, @status, @reference, @seatId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", User.currentLoggedInId);
                        cmd.Parameters.AddWithValue("@schedule", scheduleBytes);
                        cmd.Parameters.AddWithValue("@status", "Not Checked-In");
                        cmd.Parameters.AddWithValue("@reference", bookingReference); 
                        cmd.Parameters.AddWithValue("@seatId", seatId); 

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Converting Schedule
        private static byte[] ConvertScheduleToBytes(List<string> schedule)
        {
            // Convert List<string> to a single string and then to bytes (for BLOB storage)
            string scheduleString = string.Join(";", schedule); // You can choose any delimiter
            return Encoding.UTF8.GetBytes(scheduleString);
        }

        // Getting all Booking Schedules
        public static List<List<string>> GetAllBookingSchedules()
        {
            try
            {
                List<List<string>> allSchedules = new List<List<string>>();

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = "SELECT * FROM schedules WHERE userId = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", User.currentLoggedInId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Retrieve all columns
                                int id = reader.GetInt32(reader.GetOrdinal("id"));
                                byte[] scheduleBytes = (byte[])reader["schedule"];
                                string status = reader.GetString(reader.GetOrdinal("status"));
                                string reference = reader.GetString(reader.GetOrdinal("reference"));
                                string seatId = reader.GetString(reader.GetOrdinal("seatId"));

                                // Convert the byte array back to List<string>
                                List<string> schedule = ConvertBytesToSchedule(scheduleBytes);

                                // Add additional fields to the schedule
                                schedule.Add(status);
                                schedule.Add(reference);
                                schedule.Add(seatId);
                                schedule.Add(id.ToString());

                                // Add this schedule to the list of all schedules
                                allSchedules.Add(schedule);
                            }
                        }
                    }
                }

                return allSchedules; // Return all schedules
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }

        // Updating Schedule status
        public static bool UpdateScheduleStatus(int id, string newStatus)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Update query to modify the status for a specific ID
                    string query = "UPDATE schedules SET status = @newStatus WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@newStatus", newStatus);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the command and check if rows were affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Return true if at least one row was updated
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Deleting Schedule
        public static bool DeleteSchedule(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Delete query to remove the record with the specified ID
                    string query = "DELETE FROM schedules WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameter to avoid SQL injection
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the command and check if rows were affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Return true if at least one row was deleted
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        //Converting Bytes to Schedule
        private static List<string> ConvertBytesToSchedule(byte[] scheduleBytes)
        {
            // Convert bytes back to string
            string scheduleString = Encoding.UTF8.GetString(scheduleBytes);

            // Split the string back into a List<string> using the chosen delimiter
            return scheduleString.Split(';').ToList();
        }

        // Initializing flight datas
        public static void InitializeData()
        {
            LinkedList<Aircraft> aircrafts = Flight.aircrafts;
            ArrayList flightSchedule = Flight.flightSchedule;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Retrieve Aircraft data
                string aircraftQuery = "SELECT * FROM aircrafts";
                MySqlCommand aircraftCommand = new MySqlCommand(aircraftQuery, conn);
                MySqlDataReader aircraftReader = aircraftCommand.ExecuteReader();

                while (aircraftReader.Read())
                {
                    int aircraftId = aircraftReader.GetInt32("aircraft_id");
                    string model = aircraftReader.GetString("model");
                    string manufacturer = aircraftReader.GetString("manufacturer");
                    int totalSeat = aircraftReader.GetInt32("totalSeat");
                    HashSet<string> availableSeat = ConvertAvailableSeat(aircraftReader["availableSeat"] as byte[]);
                    


                    Aircraft aircraft = null;
                    if (availableSeat != null)
                    {
                        aircraft = new Aircraft(aircraftId, model, manufacturer, totalSeat, availableSeat);
                    }
                    else
                    {
                        aircraft = new Aircraft(aircraftId, model, manufacturer, totalSeat);

                    }
                    aircrafts.AddLast(aircraft);
                }
                aircraftReader.Close();

                // Retrieve Flight data
                string flightQuery = "SELECT * FROM flights";
                MySqlCommand flightCommand = new MySqlCommand(flightQuery, conn);
                MySqlDataReader flightReader = flightCommand.ExecuteReader();

                while (flightReader.Read())
                {
                    int flightId = flightReader.GetInt32("id");
                    string fromLocation = flightReader.GetString("fromX");
                    string toLocation = flightReader.GetString("toX");
                    string departureTime = flightReader.GetString("departure");
                    string arrivalTime = flightReader.GetString("arrival");
                    int aircraftId = flightReader.GetInt32("aircraft_id");
                    int passengerCount = flightReader.GetInt32("passengerCount");
                    DateTime flightDate = flightReader.GetDateTime("date");
                    decimal price = flightReader.GetDecimal("price");

                    // Find the corresponding Aircraft for this flight
                    Aircraft aircraft = null;
                    foreach (var a in aircrafts)
                    {
                        if (a.id == aircraftId)
                        {
                            aircraft = a;
                            break;
                        }
                    }

                    // Create a Flight object
                    Flight flight = new Flight(
                        flightId, 
                        fromLocation,
                        toLocation,
                        departureTime,
                        arrivalTime,
                        aircraft,
                        passengerCount,
                        flightDate,
                        price

                                                    );
                    flightSchedule.Add(flight);
                }
                flightReader.Close();
            }

        }

        // Converting Blob 
        public static HashSet<string> ConvertAvailableSeat(byte[] blob)
        {
            if (blob != null)
            {
                // Convert the byte array (BLOB) into a string (assumes UTF-8 encoding)
                string seatData = Encoding.UTF8.GetString(blob);

                // Split the string into seat IDs (assuming comma-separated values)
                string[] seatArray = seatData.Split(',');

                // Convert the array into a HashSet to ensure uniqueness
                HashSet<string> availableSeats = new HashSet<string>(seatArray);

                return availableSeats;
            } else { return null; }
            
        }

        // Uploading new data
        public static void UploadData()
        {
            LinkedList<Aircraft> aircrafts = Flight.aircrafts;
            ArrayList flightSchedule = Flight.flightSchedule;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Upload Aircraft data
                foreach (var aircraft in aircrafts)
                {
                    string aircraftQuery = @"INSERT INTO aircrafts (aircraft_id, model, manufacturer, totalSeat, availableSeat) 
                                      VALUES (@aircraftId, @model, @manufacturer, @totalSeat, @availableSeat)
                                      ON DUPLICATE KEY UPDATE
                                      model = @model, manufacturer = @manufacturer, totalSeat = @totalSeat, availableSeat = @availableSeat;";

                    MySqlCommand aircraftCommand = new MySqlCommand(aircraftQuery, conn);
                    aircraftCommand.Parameters.AddWithValue("@aircraftId", aircraft.id);
                    aircraftCommand.Parameters.AddWithValue("@model", aircraft.Model);
                    aircraftCommand.Parameters.AddWithValue("@manufacturer", aircraft.Manufacturer);
                    aircraftCommand.Parameters.AddWithValue("@totalSeat", aircraft.TotalSeats);
                    aircraftCommand.Parameters.AddWithValue("@availableSeat", ConvertAvailableSeatToBlob(aircraft.AvailableSeats));

                    aircraftCommand.ExecuteNonQuery();
                }

                // Upload Flight data
                foreach (Flight flight in flightSchedule)
                {
                    string flightQuery = @"INSERT INTO flights (id, fromX, toX, departure, arrival, aircraft_id, passengerCount, date, price) 
                                   VALUES (@flightId, @fromX, @toX, @departure, @arrival, @aircraftId, @passengerCount, @date, @price)
                                   ON DUPLICATE KEY UPDATE
                                   fromX = @fromX, toX = @toX, departure = @departure, arrival = @arrival, 
                                   aircraft_id = @aircraftId, passengerCount = @passengerCount, date = @date, price = @price;";

                    MySqlCommand flightCommand = new MySqlCommand(flightQuery, conn);
                    flightCommand.Parameters.AddWithValue("@flightId", flight.id);
                    flightCommand.Parameters.AddWithValue("@fromX", flight.from);
                    flightCommand.Parameters.AddWithValue("@toX", flight.to);
                    flightCommand.Parameters.AddWithValue("@departure", flight.departureTime);
                    flightCommand.Parameters.AddWithValue("@arrival", flight.arrivalTime);
                    flightCommand.Parameters.AddWithValue("@aircraftId", flight.aircraft.id);
                    flightCommand.Parameters.AddWithValue("@passengerCount", flight.passengerCount);
                    flightCommand.Parameters.AddWithValue("@date", flight.date);
                    flightCommand.Parameters.AddWithValue("@price", flight.price);

                    flightCommand.ExecuteNonQuery();
                }
            }
        }


        // Converting Seat to blob
        public static byte[] ConvertAvailableSeatToBlob(HashSet<string> availableSeats)
        {
            // Join the HashSet into a comma-separated string
            string seatData = string.Join(",", availableSeats);

            // Convert the string into a byte array (UTF-8 encoding)
            byte[] blob = Encoding.UTF8.GetBytes(seatData);

            return blob;
        }






        // Getting user's Mails
        public static HashSet<Mails> GetMails(int id)
        {
            HashSet<Mails> mails = new HashSet<Mails>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    string checkQuery = "SELECT mails FROM mail WHERE userId = @userId";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@userId", id);

                        connection.Open();
                        object result = checkCommand.ExecuteScalar();

                        if (result != null)
                        {
                            // userId exists; retrieve the mail blob and deserialize
                            byte[] mailBlob = (byte[])result;
                            HashSet<Mails> deserializedMails = DeserializeMails(mailBlob);
                            Console.WriteLine($"UserId already exists in the mail table with deserialized mails.");

                            return deserializedMails;
                        }
                        else
                        {
                            // userId doesn't exist, return the mails
                            return mails;
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                Console.WriteLine($"Database error: {sqlEx.Message}");
                // Handle MySQL-specific exceptions (e.g., connection issues, query errors)
                return mails; // Return an empty HashSet in case of failure
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Handle any other general exceptions (e.g., deserialization issues)
                return mails; // Return an empty HashSet in case of failure
            }
        }

        // Uploading user's Mails
        public static void UploadMails()
        {
            // To prevent Duplicate Emails
            HashSet<Mails> mails = User._userMails;
            int? id = User.currentLoggedInId;

            if (id == null)
            {
                Console.WriteLine("No user logged in.");
                return;
            }

            // Serialize the mails to a byte array
            byte[] mailBlob = SerializeMails(mails);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    // Check if the userId exists in the mail table
                    string checkQuery = "SELECT COUNT(*) FROM mail WHERE userId = @userId";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@userId", id);

                        connection.Open();
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count > 0)
                        {
                            // userId exists; update the existing mail record
                            string updateQuery = "UPDATE mail SET mails = @mailBlob WHERE userId = @userId";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@mailBlob", mailBlob);
                                updateCommand.Parameters.AddWithValue("@userId", id);

                                updateCommand.ExecuteNonQuery();
                                Console.WriteLine("Mails updated successfully.");
                            }
                        }
                        else
                        {
                            // userId doesn't exist; insert a new record
                            string insertQuery = "INSERT INTO mail (userId, mails) VALUES (@userId, @mailBlob)";
                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@userId", id);
                                insertCommand.Parameters.AddWithValue("@mailBlob", mailBlob);

                                insertCommand.ExecuteNonQuery();
                                Console.WriteLine("Mails uploaded successfully.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                Console.WriteLine($"Database error: {sqlEx.Message}");
                // Handle MySQL-specific exceptions (e.g., connection issues, query errors)
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                // Handle any other general exceptions
            }
        }



        // Serialize mails from a UTF-8 byte array
        private static byte[] SerializeMails(HashSet<Mails> mails)
        {
            // Serialize HashSet<Mails> to JSON string
            string json = JsonConvert.SerializeObject(mails);

            // Convert the JSON string to a byte array using UTF-8 encoding
            return Encoding.UTF8.GetBytes(json);
        }

        // Deserialize mails from a UTF-8 byte array
        private static HashSet<Mails> DeserializeMails(byte[] mailBlob)
        {
            if (mailBlob == null || mailBlob.Length == 0)
            {
                return new HashSet<Mails>(); // Return empty set if there's no data
            }

            // Convert the byte array back to a JSON string using UTF-8 encoding
            string json = Encoding.UTF8.GetString(mailBlob);

            // Deserialize the JSON string to HashSet<Mails>
            return JsonConvert.DeserializeObject<HashSet<Mails>>(json);
        }

    }
}
