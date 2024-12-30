using aero_quest.Objects;
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
                    guna2DataGridView1.Columns[8].Visible = false;
                    guna2DataGridView1.Columns[7].Visible = false;


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
            dataTable.Columns.Add("id", typeof(string));

            foreach (var schedule in schedules)
            {
                // Assume the schedule contains: [original_schedule, status, reference, seatId]

                DataRow row = dataTable.NewRow();
                row["From"] = schedule[1];
                row["To"] = schedule[2];
                row["Departure"] = schedule[3];
                row["Arrival"] = schedule[4];
                row["Date"] = schedule[7].ToString();
                row["Status"] = schedule[9];
                row["Reference"] = schedule[10];
                row["SeatId"] = schedule[11];
                row["id"] = schedule[12];

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to cancel this booking?",
                    "Cancel Booking",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    string from = selectedRow.Cells["from"].Value.ToString();
                    string  to = selectedRow.Cells["to"].Value.ToString();
                    string departure = selectedRow.Cells["departure"].Value.ToString();
                    string arrival = selectedRow.Cells["arrival"].Value.ToString();
                    string date = selectedRow.Cells["date"].Value.ToString();
                    string seatId = selectedRow.Cells["seatId"].Value.ToString();

                    Flight flight = Flight.GetFlight(from, to, departure, arrival, date);

                    flight.aircraft.UpdateSeatAvailability(seatId, true);

                    SqlQueries.DeleteSchedule(id);
                    LoadBookings();
                    MessageBox.Show("Booking canceled successfully.");
                }
                else
                {
                    MessageBox.Show("Cancellation aborted.");
                }
            }
        }
    }
}
