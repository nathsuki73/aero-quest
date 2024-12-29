using aero_quest.Objects;
using aero_quest.UserControls.Booking_Process;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls
{
    public partial class FlightSchedule : UserControl
    {
        private static ArrayList filteredFlights;

        public FlightSchedule()
        {
            InitializeComponent();
            LoadFLightSchedules();
        }
        public FlightSchedule(string from, string to, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            LoadFLightSchedules(from, to, startDate, endDate);
        }

        private void LoadFLightSchedules()
        {
            guna2DataGridView1.DataSource = Flight.flightSchedule;

            guna2DataGridView1.Columns["from"].HeaderText = "From";
            guna2DataGridView1.Columns["to"].HeaderText = "To";
            guna2DataGridView1.Columns["departureTime"].HeaderText = "Departure Time";
            guna2DataGridView1.Columns["arrivalTime"].HeaderText = "Arrival Time";
            guna2DataGridView1.Columns["aircraft"].HeaderText = "Aircraft"; 
            guna2DataGridView1.Columns["passengerCount"].HeaderText = "Passenger Count";
            guna2DataGridView1.Columns["date"].HeaderText = "Date";
            guna2DataGridView1.Columns["price"].HeaderText = "Price";
            FlightSchedule.filteredFlights = Flight.flightSchedule;
        }

        private void LoadFLightSchedules(string from, string to, DateTime startDate, DateTime endDate)
        {
            var filteredFlights = Flight.flightSchedule
            .Cast<Flight>()
            .Where(f => (f.from.Equals(from, StringComparison.OrdinalIgnoreCase)) &&
                        (f.to.Equals(to, StringComparison.OrdinalIgnoreCase)) &&
                        f.date.Date >= startDate.Date && f.date.Date <= endDate.Date)
            .ToList();  

            guna2DataGridView1.DataSource = filteredFlights;

            guna2DataGridView1.Columns["from"].HeaderText = "From";
            guna2DataGridView1.Columns["to"].HeaderText = "To";
            guna2DataGridView1.Columns["departureTime"].HeaderText = "Departure Time";
            guna2DataGridView1.Columns["arrivalTime"].HeaderText = "Arrival Time";
            guna2DataGridView1.Columns["aircraft"].HeaderText = "Aircraft";
            guna2DataGridView1.Columns["passengerCount"].HeaderText = "Passenger Count";
            guna2DataGridView1.Columns["date"].HeaderText = "Date";
            guna2DataGridView1.Columns["price"].HeaderText = "Price";

            FlightSchedule.filteredFlights = new ArrayList(filteredFlights);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("flightSchedule");

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && User.isLoggedIn)
            {
                Flight selectedFlight = (Flight)FlightSchedule.filteredFlights[e.RowIndex];

                // Create a List<string> to store the row values
                List<string> rowData = new List<string>();

                // Loop through each cell in the selected row
                foreach (DataGridViewCell cell in guna2DataGridView1.Rows[e.RowIndex].Cells)
                {
                    // Add the cell value to the list (convert to string)
                    rowData.Add(cell.Value?.ToString() ?? string.Empty);
                }
                
                UserControlManager.AddControl(new ConfirmSchedule(rowData, selectedFlight), "confirmSchedule");

            }
            else
            {
                MessageBox.Show("PLease login muna");
            }
        }
    }
}
