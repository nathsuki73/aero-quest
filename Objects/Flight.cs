using Mysqlx.Resultset;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace aero_quest.Objects
{
    public class Aircraft
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; } 
        public int TotalSeats { get; private set; }
        public HashSet<string> AvailableSeats { get; private set; } 

        public Aircraft(string model, string manufacturer, int totalSeats)
        {
            Model = model;
            Manufacturer = manufacturer;
            TotalSeats = totalSeats;
            AvailableSeats = InitializeSeats(totalSeats);
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
                if (i % 6 == 0) 
                    row++;
            }

            return seats;
        }

        public void UpdateSeatAvailability(string seatId, bool isAvailable)
        {
            if (isAvailable)
            {
                AvailableSeats.Add(seatId);
            }
            else
            {
                AvailableSeats.Remove(seatId);
            }
        }


    }
    internal class Flight
    {
        public static ArrayList flightSchedule = new ArrayList();

        public string from {  get; set; }
        public string to { get; set; }
        public string departureTime { get; set; }
        public string arrivalTime { get; set; }
        public Aircraft aircraft {  get; set; }
        public int passengerCount { get; set; }
        public DateTime date { get; set; }
        public string terminal { get; set; }

        public static void AddFlight(Flight flight)
        {
            flightSchedule.Add(flight);
        }

        public static void InitializeFlights()
        {
            Aircraft aircraft = new Aircraft("Boeing 737", "Boeing", 180);

            // Create a flight object
            Flight flight = new Flight
            {
                from = "New York",
                to = "Los Angeles",
                departureTime = "10:20 pm",
                arrivalTime = "11:20 pm",
                aircraft = aircraft,
                passengerCount = 150,               
                date = new DateTime(2024, 12, 29), 
                terminal = "Terminal 1"
            };

            // Add the flight to the flight schedule
            Flight.AddFlight(flight);
        }
    }
}
