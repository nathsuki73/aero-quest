using aero_quest.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aero_quest.UserControls.Manage
{
    public partial class ManageBookings : UserControl
    {
        public ManageBookings()
        {
            InitializeComponent();
            LoadBookings();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            UserControlManager.RemoveControlByName("manageBookings");
        }

        private void LoadBookings() {
            try
            {
                // Fetch booking data from the database
                DataTable allSchedBooked = ConvertSchedulesToDataTable(SqlQueries.GetAllBookingSchedules()); // Assuming this returns a DataTable

                // Check if data exists
                if (allSchedBooked != null && allSchedBooked.Rows.Count > 0)
                {
                    // Bind the data to the DataGridView
                    guna2DataGridView1.DataSource = allSchedBooked;

                }
                else
                {
                    // Clear the DataGridView if no data exists
                    guna2DataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                // Handle potential exceptions
                MessageBox.Show($"An error occurred while loading bookings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable ConvertSchedulesToDataTable(List<List<string>> schedules)
        {
            DataTable dataTable = new DataTable();

            // Define columns
            dataTable.Columns.Add("From", typeof(string));
            dataTable.Columns.Add("To", typeof(string));
            dataTable.Columns.Add("Departure", typeof(string));
            dataTable.Columns.Add("Arrival", typeof(string));
            dataTable.Columns.Add("Date", typeof(string));

            /*guna2DataGridView1.Columns["from"].HeaderText = "From";
            guna2DataGridView1.Columns["to"].HeaderText = "To";
            guna2DataGridView1.Columns["departureTime"].HeaderText = "Departure Time";
            guna2DataGridView1.Columns["arrivalTime"].HeaderText = "Arrival Time";
            guna2DataGridView1.Columns["aircraft"].HeaderText = "Aircraft";
            guna2DataGridView1.Columns["passengerCount"].HeaderText = "Passenger Count";
            guna2DataGridView1.Columns["date"].HeaderText = "Date";
            guna2DataGridView1.Columns["price"].HeaderText = "Price";*/
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Reference", typeof(string));
            dataTable.Columns.Add("SeatId", typeof(string));

            foreach (var schedule in schedules)
            {
                // Assume the schedule contains: [original_schedule, status, reference, seatId]

                DataRow row = dataTable.NewRow();

                row["From"] = schedule[0];
                row["To"] = schedule[1];
                row["Departure"] = schedule[2];
                row["Arrival"] = schedule[3];
                row["Date"] = schedule[6];
                row["Status"] = schedule[8];
                row["Reference"] = schedule[9];
                row["SeatId"] = schedule[10];

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
