using aero_quest.Sql;
using Mysqlx.Resultset;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace aero_quest.Objects
{
    public class Aircraft
    {
        // Unique identifier for the aircraft
        public int id { get; set; }

        // Model of the aircraft
        public string Model { get; set; }

        // Manufacturer of the aircraft
        public string Manufacturer { get; set; }

        // Total number of seats in the aircraft (read-only)
        public int TotalSeats { get; private set; }

        // HashSet to store available seat IDs, ensuring uniqueness
        public HashSet<string> AvailableSeats { get; private set; }

        // Constructor to initialize the Aircraft object with total seats, auto-generating available seats
        public Aircraft(int id, string model, string manufacturer, int totalSeats)
        {
            this.id = id;
            Model = model;
            Manufacturer = manufacturer;
            TotalSeats = totalSeats;
            AvailableSeats = InitializeSeats(totalSeats);
        }

        // Overloaded constructor to initialize the Aircraft object with a predefined set of available seats
        public Aircraft(int id, string model, string manufacturer, int totalSeats, HashSet<string> seats)
        {
            this.id = id;
            Model = model;
            Manufacturer = manufacturer;
            TotalSeats = totalSeats;
            AvailableSeats = seats;
        }

        // Overrides the default ToString method to return the aircraft model
        public override string ToString()
        {
            return $"{Model}";
        }

        // Private method to generate a HashSet of seat IDs based on the total number of seats
        private HashSet<string> InitializeSeats(int totalSeats)
        {
            var seats = new HashSet<string>();

            char row = 'A'; // Represents the row letter
            for (int i = 1; i <= totalSeats; i++)
            {
                seats.Add($"{row}{i}"); // Combine row letter and seat number to form seat ID
                if (i % 12 == 0) // Move to the next row after 12 seats
                    row++;
            }

            return seats;
        }

        // Method to update the availability of a specific seat
        // Adds the seat to the available set if isAvailable is true, otherwise removes it
        public void UpdateSeatAvailability(string seatId, bool isAvailable)
        {
            if (isAvailable)
            {
                MessageBox.Show($"{seatId}: is now available");
                AvailableSeats.Add(seatId);
            }
            else
            {
                AvailableSeats.Remove(seatId);
            }
        }

        // Method to find the first available seat, mark it as unavailable, and return its ID
        // Returns null if no seats are available
        public string GetAndUpdateAvailableSeat()
        {
            if (AvailableSeats.Count > 0) // Check if there are any available seats
            {
                string seatId = AvailableSeats.First(); // Get the first available seat

                UpdateSeatAvailability(seatId, false); // Mark the seat as unavailable

                return seatId; // Return the seat ID
            }
            else
            {
                return null; // No available seats
            }
        }
    }
    public class Flight
    {
        // Static list of all aircrafts available
        public static LinkedList<Aircraft> aircrafts = new LinkedList<Aircraft>();

        // Static list to maintain flight schedules
        public static ArrayList flightSchedule = new ArrayList();

        // Unique identifier for the flight
        public int id { get; set; }

        // Origin location of the flight
        public string from { get; set; }

        // Destination location of the flight
        public string to { get; set; }

        // Departure time of the flight
        public string departureTime { get; set; }

        // Arrival time of the flight
        public string arrivalTime { get; set; }

        // Aircraft assigned to the flight
        public Aircraft aircraft { get; set; }

        // Number of passengers on the flight
        public int passengerCount { get; set; }

        // Date of the flight
        public DateTime date { get; set; }

        // Price of the flight ticket
        public decimal price { get; set; }

        // Constructor to initialize a flight object
        public Flight(int id, string from, string to, string departure, string arrival, Aircraft aircraft, int passengerCount, DateTime date, decimal price)
        {
            this.id = id;
            this.from = from;
            this.to = to;
            this.departureTime = departure;
            this.arrivalTime = arrival;
            this.aircraft = aircraft;
            this.passengerCount = passengerCount;
            this.date = date;
            this.price = price;
        }

        // Static method to initialize flight schedules by loading data from a database or other source
        public static void InitializeFlights()
        {
            SqlQueries.InitializeData();
        }

        // Static method to retrieve a flight based on specified criteria
        public static Flight GetFlight(string from, string to, string departure, string arrival, string date)
        {
            foreach (Flight flight in flightSchedule)
            {
                if (flight.from == from &&
                    flight.to == to &&
                    flight.departureTime == departure &&
                    flight.arrivalTime == arrival &&
                    flight.date.ToString() == date)
                {
                    return flight; // Flight found
                }
            }
            return null; // Flight not found
        }
    }
}
