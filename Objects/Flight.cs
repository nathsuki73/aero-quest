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
        public int id {  get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; } 
        public int TotalSeats { get; private set; }
        public HashSet<string> AvailableSeats { get; private set; } 
        //for uniqquenes of id seats
        public Aircraft(int id, string model, string manufacturer, int totalSeats)
        {
            this.id = id;
            Model = model;
            Manufacturer = manufacturer;
            TotalSeats = totalSeats;
            AvailableSeats = InitializeSeats(totalSeats);
        }

        public Aircraft(int id, string model, string manufacturer,int totalSeats,  HashSet<string> seats)
        {
            this.id = id;
            Model = model;
            Manufacturer = manufacturer;
            TotalSeats = totalSeats;
            AvailableSeats = seats;
        }

        public override string ToString()
        {
            return $"{Model}";
        }
        private HashSet<string> InitializeSeats(int totalSeats)
        {
            var seats = new HashSet<string>();

            char row = 'A';
            for (int i = 1; i <= totalSeats; i++)
            {
                seats.Add($"{row}{i}");
                if (i % 12 == 0) 
                    row++;
            }

            return seats;
        }

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

        // Method to get an available seat and update its availability
        public string GetAndUpdateAvailableSeat()
        {
            // Find an available seat (if any)
            if (AvailableSeats.Count > 0)
            {
                string seatId = AvailableSeats.First();

                UpdateSeatAvailability(seatId, false);

                return seatId;
            }
            else
            {
                // No available seats
                return null;
            }
        }


    }
    public class Flight
    {
        public static LinkedList<Aircraft> aircrafts = new LinkedList<Aircraft>();
        public static ArrayList flightSchedule = new ArrayList();
        public int id {  get; set; }
        public string from {  get; set; }
        public string to { get; set; }
        public string departureTime { get; set; }
        public string arrivalTime { get; set; }
        public Aircraft aircraft {  get; set; }
        public int passengerCount { get; set; }
        public DateTime date { get; set; }

        public decimal price { get; set; }

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

        // must be run once to initialize the schedules
        public static void InitializeFlights()
        {
            /*// Create an aircraft object 
            Aircraft aircraft = new Aircraft(1, "Boeing 737", "Boeing", 180);

            // Flight 1
            Flight flight1 = new Flight
            {
                from = "New York",
                to = "Los Angeles",
                departureTime = "10:20 pm",
                arrivalTime = "11:20 pm",
                aircraft = aircraft,
                passengerCount = 150,
                date = new DateTime(2024, 12, 29),
                price = 6969
            };*/

            /* // Add flights to the schedule
             Flight.AddFlight(flight1);
             Flight.aircrafts.AddLast(aircraft);*/
            SqlQueries.InitializeData();


        }

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
                    return flight;
                }
            }
            return null; // Flight not found
        }
    }
}
