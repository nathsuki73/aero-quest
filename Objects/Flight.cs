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
            // Create an aircraft object for use in all flights
            Aircraft aircraft = new Aircraft("Boeing 737", "Boeing", 180);

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
                terminal = "Terminal 1"
            };

            // Flight 2
            Flight flight2 = new Flight
            {
                from = "Los Angeles",
                to = "Chicago",
                departureTime = "12:00 pm",
                arrivalTime = "3:00 pm",
                aircraft = aircraft,
                passengerCount = 140,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 2"
            };

            // Flight 3
            Flight flight3 = new Flight
            {
                from = "Chicago",
                to = "Dallas",
                departureTime = "2:00 pm",
                arrivalTime = "4:00 pm",
                aircraft = aircraft,
                passengerCount = 160,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 3"
            };

            // Flight 4
            Flight flight4 = new Flight
            {
                from = "Dallas",
                to = "San Francisco",
                departureTime = "4:30 pm",
                arrivalTime = "6:30 pm",
                aircraft = aircraft,
                passengerCount = 170,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 4"
            };

            // Flight 5
            Flight flight5 = new Flight
            {
                from = "San Francisco",
                to = "Miami",
                departureTime = "6:00 pm",
                arrivalTime = "9:00 pm",
                aircraft = aircraft,
                passengerCount = 150,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 1"
            };

            // Flight 6
            Flight flight6 = new Flight
            {
                from = "Miami",
                to = "Seattle",
                departureTime = "9:30 pm",
                arrivalTime = "12:30 am",
                aircraft = aircraft,
                passengerCount = 180,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 2"
            };

            // Flight 7
            Flight flight7 = new Flight
            {
                from = "Seattle",
                to = "Boston",
                departureTime = "11:00 am",
                arrivalTime = "2:00 pm",
                aircraft = aircraft,
                passengerCount = 160,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 3"
            };

            // Flight 8
            Flight flight8 = new Flight
            {
                from = "Boston",
                to = "Washington DC",
                departureTime = "1:30 pm",
                arrivalTime = "3:30 pm",
                aircraft = aircraft,
                passengerCount = 140,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 4"
            };

            // Flight 9
            Flight flight9 = new Flight
            {
                from = "Washington DC",
                to = "Atlanta",
                departureTime = "5:00 pm",
                arrivalTime = "7:00 pm",
                aircraft = aircraft,
                passengerCount = 150,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 1"
            };

            // Flight 10
            Flight flight10 = new Flight
            {
                from = "Atlanta",
                to = "Orlando",
                departureTime = "8:00 pm",
                arrivalTime = "10:00 pm",
                aircraft = aircraft,
                passengerCount = 160,
                date = new DateTime(2024, 12, 29),
                terminal = "Terminal 2"
            };

            // Add flights to the schedule
            Flight.AddFlight(flight1);
            Flight.AddFlight(flight2);
            Flight.AddFlight(flight3);
            Flight.AddFlight(flight4);
            Flight.AddFlight(flight5);
            Flight.AddFlight(flight6);
            Flight.AddFlight(flight7);
            Flight.AddFlight(flight8);
            Flight.AddFlight(flight9);
            Flight.AddFlight(flight10);

        }
    }
}
